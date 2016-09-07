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
using V5_WinLibs.DBUtility;

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

                    #region 结果为循环
                    if (itemLabel.IsLoop == 1) {
                        string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);
                        foreach (string s in LabelString) {
                            CutContent += s + "$$$$";
                        }
                        int n = CutContent.LastIndexOf("$$$$");
                        CutContent = CutContent.Remove(n, 4);
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
                                CutContent = CutContent.Replace(ListStr[0], "");
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

                    #region 使用插件
                    string SpiderLabelPlugin = itemLabel.SpiderLabelPlugin;
                    if (SpiderLabelPlugin != "不使用插件" && !string.IsNullOrEmpty(SpiderLabelPlugin)) {
                        CutContent = PythonExtHelper.RunPython(SpiderLabelPlugin, new object[] { Test_ViewUrl, CutContent });
                    }
                    #endregion

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

        #region 测试标签

        public string TestLabel(ModelTaskLabel itemLabel, string pageContent) {
            var sContent = string.Empty;
            //var pageContent = CommonHelper.getPageContent(itemLabel.TestViewUrl, Model.PageEncode);
            sContent += "【" + itemLabel.LabelName + "】： ";
            string regContent = HtmlHelper.Instance.ParseCollectionStrings(itemLabel.LabelNameCutRegex);
            regContent = CommonHelper.ReplaceSystemRegexTag(regContent);
            string CutContent = CollectionHelper.Instance.CutStr(pageContent, regContent)[0];

            #region 结果为循环
            if (itemLabel.IsLoop == 1) {
                string[] LabelString = CollectionHelper.Instance.CutStr(pageContent, regContent);
                foreach (string s in LabelString) {
                    CutContent += s + "$$$$";
                }
                int n = CutContent.LastIndexOf("$$$$");
                CutContent = CutContent.Remove(n, 4);
            }
            #endregion

            #region 过滤Html
            if (itemLabel.LabelHtmlRemove != null) {
                string[] arr = itemLabel.LabelHtmlRemove.Split(new string[] { "||||" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in arr) {
                    if (str == "all") {
                        CutContent = HtmlHelper.ReplaceNormalHtml(CutContent, itemLabel.TestViewUrl, false);
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
                        CutContent = CutContent.Replace(ListStr[0], "");
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

            #region 使用插件
            string SpiderLabelPlugin = itemLabel.SpiderLabelPlugin;
            if (SpiderLabelPlugin != "不使用插件" && !string.IsNullOrEmpty(SpiderLabelPlugin)) {
                CutContent = PythonExtHelper.RunPython(SpiderLabelPlugin, new object[] { Model.TestViewUrl, CutContent });
            }
            #endregion

            sContent += CutContent;

            return sContent;
        }
        #endregion


        #region 采集详细
        public void SpiderContent(string viewUrl, List<ModelTaskLabel> Test_LabelList) {

            string SQL = string.Empty, cutContent = string.Empty;

            string pageContent = CommonHelper.getPageContent(viewUrl, Model.PageEncode);
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

                #region 下载资源
                var imgTag = ImageDownHelper.GetImgTag(CutContent);
                if (m.IsDownResource == 1) {
                    string[] imgExtArr = m.DownResourceExts.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    var downImgPath = AppDomain.CurrentDomain.BaseDirectory + "Data\\Collection\\" + Model.TaskName + "\\Images\\";
                    int ii = 1;
                    foreach (var img in imgTag) {
                        var remoteImg = CollectionHelper.Instance.FormatUrl(Model.TestViewUrl, img);
                        var newImg = DateTime.Now.ToString("yyyyMMddHHmmssffffff") + "_" + ii + ".jpg";
                        if (!string.IsNullOrEmpty(m.DownResourceExts)) {
                            var imgExt = remoteImg.Substring(remoteImg.LastIndexOf("."));
                            if (imgExtArr.SingleOrDefault(x => x.ToLower() == imgExt.ToLower()) != imgExt.ToLower()) {
                                continue;
                            }
                        }
                        CutContent = CutContent.Replace(img, downImgPath + newImg);
                        //
                        QueueImgHelper.AddImg(Model.ID, downImgPath + newImg, remoteImg, Model.CollectionContentStepTime.Value);
                        ii++;
                    }
                }
                else {
                    //替换内容中的链接为远程链接
                    foreach (var img in imgTag) {
                        var remoteImg = CollectionHelper.Instance.FormatUrl(Model.TestViewUrl, img);
                        CutContent = CutContent.Replace(img, remoteImg);
                    }
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
                            CutContent = CutContent.Replace(ListStr[0], "");
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

                #region 加载插件
                string SpiderLabelPlugin = m.SpiderLabelPlugin;
                if (SpiderLabelPlugin != "不使用插件" && !string.IsNullOrEmpty(SpiderLabelPlugin)) {
                    CutContent = PythonExtHelper.RunPython(SpiderLabelPlugin, new object[] { viewUrl, CutContent });
                }
                #endregion

                #region 替换特殊
                sb1.Append("" + m.LabelName.Replace("'", "''") + ",");
                sb2.Append("'" + CutContent.Replace("'", "''") + "',");
                if (CutContent.Replace("'", "''").Length < 100) {
                    sb3.Append(" " + m.LabelName.Replace("'", "''") + "='" + CutContent.Replace("'", "''") + "' and");
                }
                #endregion
            }

            try {
                #region 保存数据库
                string LocalSQLiteName = "Data\\Collection\\" + Model.TaskName + "\\SpiderResult.db";
                string sql = " Select Count(1) From Content Where HrefSource='" + viewUrl + "' ";
                object o = DbHelper.ExecuteScalar(LocalSQLiteName, sql);
                if (Convert.ToInt32("0" + o) == 0) {

                    strSql.Append("insert into Content(HrefSource,");
                    strSql.Append(sb1.ToString().Remove(sb1.Length - 1));
                    strSql.Append(")");
                    strSql.Append(" values ('" + viewUrl + "',");
                    strSql.Append(sb2.ToString().Remove(sb2.Length - 1));
                    strSql.Append(")");

                    DbHelper.Execute(LocalSQLiteName, strSql.ToString());
                }
                title = title.Replace('\\', ' ').Replace('/', ' ').Split(new char[] { '_' })[0].Split(new char[] { '-' })[0];
                #endregion

                OutViewUrlContentHandler?.Invoke(viewUrl + "=" + title);
            }
            catch (Exception ex) {
                OutViewUrlContentHandler?.Invoke(viewUrl + "=" + title + "=" + ex.Message);
            }
        }
        #endregion
    }
}
