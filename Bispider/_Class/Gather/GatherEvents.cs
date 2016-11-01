﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V5_DataCollection._Class.Gather {
    public class GatherEvents {
        /// <summary>
        /// 采集链接
        /// </summary>
        public class GatherLinkEvents : EventArgs {
            public string ID { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }
            public string Message { get; set; }
            public bool IsSuccess { get; set; }
        }
    }
}
