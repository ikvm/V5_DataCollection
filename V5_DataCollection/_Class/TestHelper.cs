using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using V5_DataCollection._Class.Gather;
using V5_DataCollection._Class.PythonExt;
using V5_Model;

namespace V5_DataCollection._Class {
    public class TestHelper {
        public void Test1() {
            var aa = @"a(?<Keyword>.*?)2";
            var cc = "a=1,b=2";
            Regex regex = new Regex(aa, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            for (Match match = regex.Match(cc); match.Success; match = match.NextMatch()) {
                var aaa = match.Groups["Keyword"].ToString();
            }
        }
    }
}
