using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.PythonExt;
using V5_Model;
using V5_WinLibs.Core;
using V5_WinLibs.DBHelper;

namespace V5_DataCollection._Class.Gather {
    public class SpiderViewHelper {
        /// <summary>
        /// 任务模型
        /// </summary>
        public ModelTask Model { get; set; } = new ModelTask();

        public delegate void OutViewUrlContent(string content);
        public event OutViewUrlContent OutViewUrlContentHandler;

        #region 测试内容详细地址

        public void Test(string Test_ViewUrl, List<ModelTaskLabel> Test_LabelList, int minTime = 1000, int maxTime = 2000) {
            try {

                #region  采集测试
                string sContent = string.Empty;
                string pageContent = CommonHelper.getPageContent(Test_ViewUrl, Model.PageEncode);
                if (pageContent.Equals("本次请求并未返回任何数据")) {
                    OutViewUrlContentHandler?.Invoke("采集地址不正确!或者采集内容失败!");
                    return;
                }

                StringBuilder sbTest = new StringBuilder();
                string tempContent = pageContent;

                foreach (var itemLabel in Test_LabelList) {
                    sContent = string.Empty;
                    sContent += "【" + itemLabel.LabelName + "】： ";
                    string regContent = HtmlHelper.Instance.ParseCollectionStrings(itemLabel.LabelNameCutRegex);
                    regContent = CommonHelper.ReplaceSystemRegexTag(regContent);
                    string CutContent = CollectionHelper.Instance.CutStr(pageContent, regContent)[0];
                    #region 标签是循环
                    if (itemLabel.IsLoop == 1) {
                        string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);
                        foreach (string s in LabelString) {
                            CutContent += s + "$$$$";
                        }
                        int n = CutContent.LastIndexOf("$$$$");
                        CutContent = CutContent.Remove(n, 4);
                    }
                    #endregion
                    #region 标签是链接
                    if (itemLabel.IsLinkUrl == 1) {
                        CutContent = CollectionHelper.Instance.DefiniteUrl(CutContent, Test_ViewUrl);
                        CutContent = CollectionHelper.Instance.GetHttpPage(CutContent, 1000, Encoding.GetEncoding(Model.PageEncode));
                        regContent = HtmlHelper.Instance.ParseCollectionStrings(itemLabel.LabelValueLinkUrlRegex);
                        //
                        regContent = regContent.Replace("\\(\\*)", ".+?");
                        regContent = regContent.Replace("\\[参数]", "([\\S\\s].*?)");
                        CutContent = CollectionHelper.Instance.CutStr(CutContent, regContent)[0];
                        //
                    }
                    #endregion
                    #region 标签是分页
                    if (itemLabel.IsPager == 1) {
                        regContent = HtmlHelper.Instance.ParseCollectionStrings(itemLabel.LabelValuePagerRegex);
                        regContent = regContent.Replace("\\(\\*)", ".+?");
                        regContent = regContent.Replace("\\[参数]", "([\\S\\s].*?)");
                        string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);

                        foreach (string pageUrl in LabelString) {
                            string url = CollectionHelper.Instance.DefiniteUrl(pageUrl, Test_ViewUrl);
                            string pageContentPager = CollectionHelper.Instance.GetHttpPage(url, 100000);
                            if (pageContent.Equals("$UrlIsFalse$") || pageContent.Equals("$GetFalse$")) {

                                CutContent += "=====分页内容=======================================================\r\n";
                                CutContent += "远程链接内容失败!";
                            }
                            else {
                                //重新截取标签
                                string regContent1 = HtmlHelper.Instance.ParseCollectionStrings(itemLabel.LabelNameCutRegex);
                                regContent1 = CommonHelper.ReplaceSystemRegexTag(regContent1);
                                string CutContent1 = CollectionHelper.Instance.CutStr(pageContentPager, regContent1)[0];

                                CutContent += "=====分页内容=======================================================\r\n";
                                CutContent += CutContent1;
                            }
                        }
                    }
                    #endregion
                    #region 过滤标签Html
                    if (itemLabel.LblHtmlRemove != null) {
                        //
                        string[] arr = itemLabel.LblHtmlRemove.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                        CutContent = CollectionHelper.ScriptHtml(CutContent, arr);
                    }
                    #endregion
                    #region 过滤Html
                    if (itemLabel.LabelHtmlRemove != null) {
                        //
                        string[] arr = itemLabel.LabelHtmlRemove.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string str in arr) {
                            if (str == "all") {
                                //替换标准标签包含 图片 视频  文档 压缩文件 什么的
                                CutContent = HtmlHelper.ReplaceNormalHtml(CutContent, Test_ViewUrl, false);
                                CutContent = CollectionHelper.Instance.NoHtml(CutContent);
                                break;
                            }
                            else if (str == "table") {
                                CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "table", 2);
                            }
                            else if (str == "font<span>") {
                                CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "font", 3);
                                CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "span", 3);
                            }
                            else if (str == "script") {
                                CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "script", 3);
                            }
                            else if (str == "a") {
                                CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "a", 3);
                            }
                        }
                    }
                    #endregion
                    #region 排除字符
                    if (itemLabel.LabelRemove != null) {
                        foreach (string str in itemLabel.LabelRemove.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries)) {
                            string[] ListStr = str.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                            if (ListStr[1] == "1") {
                                CutContent = CollectionHelper.RemoveHtml(CutContent, ListStr[0]);
                            }
                            else {
                                CutContent = CutContent.Replace(str, "");
                            }
                        }
                    }
                    #endregion
                    #region 替换字符
                    if (itemLabel.LabelReplace != null) {
                        foreach (string str in itemLabel.LabelReplace.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries)) {
                            string[] ListStr = str.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                            CutContent = CutContent.Replace(ListStr[0], ListStr[1]);
                        }
                    }
                    #endregion
                    CutContent = CutContent.Replace("\t", "");
                    string SpiderLabelPlugin = itemLabel.SpiderLabelPlugin;
                    if (SpiderLabelPlugin != "不使用插件" && !string.IsNullOrEmpty(SpiderLabelPlugin)) {
                        CutContent = PythonExtHelper.RunPython(SpiderLabelPlugin, Test_ViewUrl, CutContent);
                    }
                    sContent += CutContent;
                    sbTest.AppendLine(sContent);
                }

                OutViewUrlContentHandler?.Invoke(sbTest.ToString());
                #endregion
            }
            catch (Exception ex) {
                OutViewUrlContentHandler?.Invoke("测试网页采集失败!" + ex.Message);
            }
        }

        #endregion

        public void SpiderContent(string Test_ViewUrl, List<ModelTaskLabel> Test_LabelList) {

            string url = Test_ViewUrl;
            string SQL = string.Empty, cutContent = string.Empty;

            string pageContent = CommonHelper.getPageContent(Test_ViewUrl, Model.PageEncode);
            string title = CollectionHelper.Instance.CutStr(pageContent, "<title>([\\S\\s]*?)</title>")[0];

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder strSql = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();

            string tempContent = pageContent;

            foreach (ModelTaskLabel m in Model.ListTaskLabel) {
                string regContent = HtmlHelper.Instance.ParseCollectionStrings(m.LabelNameCutRegex);
                regContent = CommonHelper.ReplaceSystemRegexTag(regContent);
                string CutContent = CollectionHelper.Instance.CutStr(pageContent, regContent)[0];

                #region 替换内容中的链接为远程链接
                string[] TagImgList = CollectionHelper.Instance.GetImgTag(CutContent);
                foreach (string tagimg in TagImgList) {
                    if (string.IsNullOrEmpty(tagimg)) {
                        break;
                    }
                    //远程连接
                    string newTagImg = CollectionHelper.Instance.FormatUrl(Model.TestViewUrl, tagimg);
                    //替换连接
                    CutContent = CutContent.Replace(tagimg, newTagImg);
                    #region 保存远程图片
                    if (m.IsDownResource == 1) {
                        //替换时间格式连接
                        string downImgPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\" + Model.TaskName + "\\Images\\";
                        string newImgName = ImageDownHelper.DownUrlPics(newTagImg, downImgPath);
                        //FileInfo fImg = new FileInfo(newTagImg);
                        if (newImgName.IndexOf("/") > 0) {
                            FileInfo fImg = new FileInfo(newImgName);
                            string ext = fImg.Extension;
                            ext = string.IsNullOrEmpty(ext) ? ".jpg" : ext;
                            //string newTimeImg = "images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
                            string newTimeImg = newImgName;

                            lock (QueueHelper.lockObj) {
                                var d = new Dictionary<string, string>();
                                d.Add(newTagImg, newTimeImg);
                                QueueHelper.Q_DownImgResource.Enqueue(d);
                            }
                        }
                    }
                    #endregion
                }
                #endregion

                #region 结果为循环
                if (m.IsLoop == 1) {
                    string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);
                    foreach (string s in LabelString) {
                        CutContent += s + "$$$$";
                    }
                    int n = CutContent.LastIndexOf("$$$$");
                    CutContent = CutContent.Remove(n, 4);
                }
                #endregion

                #region 结果为连接
                if (m.IsLinkUrl == 1) {
                    string[] CutContentArr = CutContent.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string sUrl in CutContentArr) {
                        CutContent = CollectionHelper.Instance.DefiniteUrl(sUrl, Model.TestViewUrl);//地址
                        CutContent = CollectionHelper.Instance.GetHttpPage(CutContent, 1000, Encoding.GetEncoding(Model.PageEncode));
                        regContent = HtmlHelper.Instance.ParseCollectionStrings(m.LabelValueLinkUrlRegex);
                        regContent = regContent.Replace("\\(\\*)", ".+?");
                        regContent = regContent.Replace("\\[参数]", "([\\S\\s].*?)");
                        CutContent = CollectionHelper.Instance.CutStr(CutContent, regContent)[0];
                    }
                }
                #endregion

                #region 过滤标签Html
                if (m.LblHtmlRemove != null) {
                    //
                    string[] arr = m.LblHtmlRemove.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                    CutContent = CollectionHelper.ScriptHtml(CutContent, arr);
                }
                #endregion

                #region 标签是分页
                if (m.IsPager == 1) {
                    regContent = HtmlHelper.Instance.ParseCollectionStrings(m.LabelValuePagerRegex);
                    regContent = regContent.Replace("\\(\\*)", ".+?");
                    regContent = regContent.Replace("\\[参数]", "([\\S\\s].*?)");
                    string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);

                    foreach (string pageUrl in LabelString) {
                        string url1 = CollectionHelper.Instance.DefiniteUrl(pageUrl, url);
                        string pageContentPager = CollectionHelper.Instance.GetHttpPage(url1, 100000);
                        if (pageContent.Equals("$UrlIsFalse$") || pageContent.Equals("$GetFalse$")) {

                            CutContent += "=====分页内容=======================================================\r\n";
                            CutContent += "远程链接内容失败!";
                        }
                        else {
                            //重新截取标签
                            string regContent1 = HtmlHelper.Instance.ParseCollectionStrings(m.LabelNameCutRegex);
                            regContent1 = CommonHelper.ReplaceSystemRegexTag(regContent1);
                            string CutContent1 = CollectionHelper.Instance.CutStr(pageContentPager, regContent1)[0];

                            CutContent += "=====分页内容=======================================================\r\n";
                            CutContent += CutContent1;
                        }
                    }
                }
                #endregion

                #region 过滤Html
                if (!string.IsNullOrEmpty(m.LabelHtmlRemove)) {
                    string[] arr = m.LabelHtmlRemove.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string str in arr) {
                        if (str == "all") {
                            CutContent = CollectionHelper.Instance.NoHtml(CutContent);
                            break;
                        }
                        else if (str == "table") {
                            CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "table", 2);
                        }
                        else if (str == "font<span>") {
                            CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "font", 3);
                            CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "span", 3);
                        }
                        else if (str == "a") {
                            CutContent = CollectionHelper.Instance.ScriptHtml(CutContent, "a", 3);
                        }
                    }
                }
                #endregion

                #region 排除字符
                if (!string.IsNullOrEmpty(m.LabelRemove)) {
                    foreach (string str in m.LabelRemove.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries)) {
                        string[] ListStr = str.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                        if (ListStr[1] == "1") {
                            CutContent = CollectionHelper.RemoveHtml(CutContent, ListStr[0]);
                        }
                        else {
                            CutContent = CutContent.Replace(str, "");
                        }
                    }
                }
                #endregion

                #region 替换字符
                if (!string.IsNullOrEmpty(m.LabelReplace)) {
                    foreach (string str in m.LabelReplace.Split(new string[] { "$$$$" }, StringSplitOptions.RemoveEmptyEntries)) {
                        string[] ListStr = str.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                        CutContent = CutContent.Replace(ListStr[0], ListStr[1]);
                    }
                }
                #endregion

                sb1.Append("" + m.LabelName.Replace("'", "''") + ",");
                sb2.Append("'" + CutContent.Replace("'", "''") + "',");
                if (CutContent.Replace("'", "''").Length < 100) {
                    sb3.Append(" " + m.LabelName.Replace("'", "''") + "='" + CutContent.Replace("'", "''") + "' and");
                }

                #region 下载资源
                //添加文件下载功能  开关打开的时候
                if (m.IsDownResource == 1) {
                    string[] imgExtArr = m.DownResourceExts.Split(new string[] { ";" }, StringSplitOptions.None);
                    foreach (string s in imgExtArr) {

                    }
                    string downImgPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\" + Model.TaskName + "\\Images\\";
                    CutContent = ImageDownHelper.SaveUrlPics(CutContent, downImgPath);
                }
                #endregion
            }

            try {
                #region 保存数据库
                string LocalSQLiteName = "Data\\Collection\\" + Model.TaskName + "\\SpiderResult.db";
                string sql = " Select Count(1) From Content Where HrefSource='" + url + "' ";
                object o = SQLiteHelper.ExecuteScalar(LocalSQLiteName, sql);
                if (Convert.ToInt32("0" + o) == 0) {

                    strSql.Append("insert into Content(HrefSource,");
                    strSql.Append(sb1.ToString().Remove(sb1.Length - 1));
                    strSql.Append(")");
                    strSql.Append(" values ('" + url + "',");
                    strSql.Append(sb2.ToString().Remove(sb2.Length - 1));
                    strSql.Append(")");

                    SQLiteHelper.Execute(LocalSQLiteName, strSql.ToString());
                }
                title = title.Replace('\\', ' ').Replace('/', ' ').Split(new char[] { '_' })[0].Split(new char[] { '-' })[0];
                #endregion

                OutViewUrlContentHandler?.Invoke(Test_ViewUrl + "=" + title);
            }
            catch (Exception ex) {
                OutViewUrlContentHandler?.Invoke(Test_ViewUrl + "=" + title + "=" + ex.Message);
            }
        }
    }
}
