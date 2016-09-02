using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V5_DataCollection._Class.Gather;
using V5_DataCollection._Class.PythonExt;
using V5_Model;

namespace V5_DataCollection._Class {
    public class TestHelper {
        public void Test1() {
            //测试列表
            var spiderList = new SpiderListHelper();
            spiderList.ResolveList("http://www.6m5m.com/shop_list-path-S149A335-page-1.html", 1);
        }

        public void Test2() {
            var Test_LabelList = new List<ModelTaskLabel>();
            Test_LabelList.Add(new ModelTaskLabel() {
                LabelName = "标题",
                LabelNameCutRegex = "<title>[参数]</title>"
            });

            var Model = new ModelTask() {
                ListTaskLabel = Test_LabelList
            };

            var spiderView = new SpiderViewHelper();
            spiderView.Model = Model;
            spiderView.OutViewUrlContentHandler += (string content) => {
                throw new NotImplementedException();
            };
            spiderView.SpiderContent("http://www.68design.net/Web-Guide/Xhtml-CSS/63761-1.html", Test_LabelList);
        }

        public void Test3() {
            var s = PythonExtHelper.RunPython(@"Plugins\SpiderUrl\test.py", new object[] { });
        }
    }
}
