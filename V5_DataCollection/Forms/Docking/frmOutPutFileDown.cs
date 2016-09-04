using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using V5_DataCollection._Class.Common;
using V5_DataCollection._Class.Model;
using V5_WinLibs.Utility;
using WeifenLuo.WinFormsUI.Docking;

namespace V5_DataCollection.Forms.Docking {
    public partial class frmOutPutFileDown : BaseContent {

        public frmOutPutFileDown() {
            InitializeComponent();
        }

        private void frmOutPutFileDown_Load(object sender, EventArgs e) {
            var th = new ThreadMultiHelper(1, 1);
            th.WorkMethod += th_WorkMethod;
            th.CompleteEvent += th_CompleteEvent;
            th.Start();
        }

        void th_CompleteEvent() {

        }

        void th_WorkMethod(int taskindex, int threadindex) {
            while (true) {
                ModelDownLoadImg d = null;
                lock (QueueHelper.lockObj) {
                    if (QueueHelper.Q_DownImgResource.Count > 0) {
                        d = QueueHelper.Q_DownImgResource.Dequeue();
                    }
                }
                if (d != null) {
                    OutDownload(d);
                }
                Thread.Sleep(100);
            }
        }


        private void OutDownload(ModelDownLoadImg d) {
            this.Invoke(new MethodInvoker(() => {
                try {
                    WebClient wc = new WebClient();
                    wc.DownloadFile($"{d.RemoteImg}", $"{d.LocalImg}");
                    this.txtLogView.AppendText($"远程图片:{d.RemoteImg}本地图片:{d.LocalImg}任务:{d.TaskId}下载完成!");
                    this.txtLogView.AppendText("\r\n");
                }
                catch (Exception ex) {
                    this.txtLogView.AppendText($"远程图片:{d.RemoteImg}本地图片:{d.LocalImg}任务:{d.TaskId}失败!{ex.Message}");
                    this.txtLogView.AppendText("\r\n");
                }
            }));
        }
    }
}
