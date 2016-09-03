using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataCollection._Class.Common {
    /// <summary>
    /// 队列列表
    /// </summary>
    public class QueueHelper {
        public readonly static object lockObj = new object();
        /// <summary>
        /// 下载图片资源
        /// </summary>
        public static Queue<Dictionary<string, string>> Q_DownImgResource = new Queue<Dictionary<string, string>>();


        public static void AddImg(string localPic, string remotePic) {
            var d = new Dictionary<string, string>();
            d.Add(localPic, remotePic);
            lock (lockObj) {
                Q_DownImgResource.Enqueue(d);
            }
        }

        public static Dictionary<string, string> DequeueImg() {
            Dictionary<string, string> d = null ;
            lock (lockObj) {
                d = Q_DownImgResource.Dequeue();
            }
            if (d != null) {
                return d;
            }
            return null;
        }

        public void SaveImgQueue() {

        }

        public void LoadImgQueue() {

        }
    }
}
