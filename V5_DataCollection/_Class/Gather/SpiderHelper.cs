using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.DAL;
using V5_DataCollection._Class.Publish;
using V5_Model;
using V5_Utility.Utility;
using V5_WinLibs;
using V5_WinLibs.Core;
using V5_WinLibs.DBHelper;
using V5_WinLibs.Utility;

namespace V5_DataCollection._Class.Gather {
    /// <summary>
    /// 采集管理
    /// </summary>
    public class SpiderHelper {

        #region 访问器变量
        /// <summary>
        /// 是否停止
        /// </summary>
        public bool Stopped { get; set; }
        /// <summary>
        /// 任务索引
        /// </summary>
        public int TaskIndex { get; set; }
        private ModelTask _modelTask = new ModelTask();
        /// <summary>
        /// 任务模型
        /// </summary>
        public ModelTask modelTask {
            get { return _modelTask; }
            set { _modelTask = value; }
        }
        #endregion

        #region 委托变量
        /// <summary>
        /// 采集过程中
        /// </summary>
        public GatherEventHandler.GatherWorkHandler GatherWorkDelegate;
        /// <summary>
        /// 采集完成
        /// </summary>
        public GatherEventHandler.GatherComplateHandler GatherComplateDelegate;
        /// <summary>
        /// 采集进度条
        /// </summary>
        public MainEventHandler.OutPutTaskProgressBarHandler OutPutTaskProgressBarDelegate;
        #endregion

        #region 私有变量
        private GatherEvents.GatherLinkEvents gatherEv = new GatherEvents.GatherLinkEvents();

        private Queue<ModelLinkUrl> _listLinkUrl = new Queue<ModelLinkUrl>();
        private cGatherFunction _gatherWork = new cGatherFunction();
        #endregion


        /// <summary>
        /// 消息输出
        /// </summary>
        private void MessageOut(string strMsg) {
            if (GatherWorkDelegate != null) {
                gatherEv.Message = strMsg;
                GatherWorkDelegate(this, gatherEv);
            }
        }

        public void Stop() {
            this.Stopped = true;
            modelTask = null;
        }
        /// <summary>
        /// 开始采集网址列表
        /// </summary>
        public void Start() {
            if (this.Stopped || modelTask == null) {
                return;
            }

            _listLinkUrl.Clear();

            MessageOut("开始采集数据！请稍候...");

            #region 采集列表
            var task = new TaskFactory().StartNew(() => {
                var spiderList = new SpiderListHelper();
                spiderList.Model = modelTask;
                spiderList.OutTreeNodeHandler += (string url, string title, int nodeIndex) => {
                    var m = new ModelLinkUrl() {
                        Url = url,
                        Title = title
                    };
                    bool addFlag = true;
                    foreach (var item in _listLinkUrl.ToArray()) {
                        if (item.Url == url) {
                            addFlag = false;
                            break;
                        }
                    }
                    if (addFlag) {
                        string msg = url + "==" + HtmlHelper.Instance.ParseTags(title);
                        _listLinkUrl.Enqueue(m);
                        MessageOut(msg);
                    }
                };
                spiderList.OutMessageHandler += (string msg) => {
                    MessageOut(msg);
                };
                spiderList.AnalyzeAllList();

                this.Stopped = true;
            });
            #endregion

            #region 采集内容
            task.ContinueWith(x => {

                MessageOut("分析获取网页个数为" + _listLinkUrl.Count + "个！");
                MessageOut("采集网站列表完成!");
                if (modelTask.IsSpiderContent == 1 && _listLinkUrl.Count > 0) {

                    MessageOut("开始采集列表地址详细内容!");

                    var spiderViewHelper = new SpiderViewHelper();
                    spiderViewHelper.Model = modelTask;
                    spiderViewHelper.OutViewUrlContentHandler += (string content) => {
                        MessageOut(content);
                    };
                    while (true) {
                        if (_listLinkUrl.Count == 0) {
                            break;
                        }
                        var mlink = _listLinkUrl.Dequeue();
                        spiderViewHelper.SpiderContent(mlink.Url, modelTask.ListTaskLabel);
                    }

                }
                else {
                    MessageOut("采集网站内容选项关闭!或者采集列表的地址为0!不需要采集!");
                }
            });
            #endregion

            #region 发布数据
            task.ContinueWith(x => {
                MessageOut("采集网站Url内容完成！");
                //开始发布内容
                if (modelTask.IsPublishContent == 1) {
                    PublishHelper publich = new PublishHelper();
                    publich.ModelTask = modelTask;
                    publich.PublishCompalteDelegate = GatherWorkDelegate;

                    MessageOut("正在开始发布数据!");
                    publich.PublishCompalteDelegate = (object sender, GatherEvents.GatherLinkEvents e) => {
                        MessageOut(e.Message);
                        if (GatherComplateDelegate != null)
                            GatherComplateDelegate(modelTask);
                        this.Stop();
                    };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(publich.Start));
                }
                else {
                    GatherComplateDelegate(modelTask);
                    MessageOut("发布数据没有开启!不需要发布数据!");
                    this.Stop();
                }
            });
            #endregion

            task.ContinueWith(x => {
                this.Stopped = true;
            });
        }
    }
}
