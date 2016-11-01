﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using V5_DataCollection._Class.Gather;
using V5_DataCollection._Class.PythonExt;
using V5_Model;
using V5_WinLibs.Core;

namespace V5_DataCollection._Class {
    public class TestHelper {
        public void Test1() {
            var regexHref = @"<a href=""service-sid-12832.html"" target=""_blank""><img src=""[图片]"" onerror='(*)' title=""unity《疯狂伐木工2》源码""></a>";
            regexHref = regexHref.Replace("[", "(?<");
            regexHref = regexHref.Replace("]", ">.*?)");
            regexHref = regexHref.Replace("(*)", ".+?");
            var cc = @"
            <div class=""box case_box clearfix"">
                                  <div class=""case_con clearfix"">
                                      <a href=""service-sid-12832.html"" target=""_blank""><img src=""data/uploads/2016/09/05/210_749657ccd48b94ad5.jpg"" onerror='$(this).attr(""src"",""tpl/default/img/shop/shop_default.gif"")' title=""unity《疯狂伐木工2》源码""></a>

                                      <div class=""mt_5 clearfix pl_5 h70"" >
                                                                                    <span ><a href=""service-sid-12832.html"" target=""_blank"" class=""font14b list_small_title c333"" title=""unity《疯狂伐木工2》源码"">unity《疯狂伐木工2》源码</a></span>
                                              
                                          <div class=""clear""></div>
                                          <span class=""fl_l c999 mt_5"">素材分类：                                          游戏源码 / Unity3D</span>   
                                      </div>
                                      <div class="" img_title clearfix pl_5"">
                                          <a href=""service-sid-12832.html"" class=""case_name"" title=""""><span class=""font_jifen "">10金币 <span class=""c333"">或</span> 100积分</span></a>
                                      </div>
<div class=""img_title clearfix pl_5"">
                                          </div>
                                  </div>
                              </div>
            ";
            Regex regex = new Regex(HtmlHelper.Instance.ParseCollectionStrings(regexHref), RegexOptions.Compiled | RegexOptions.IgnoreCase);

            for (Match match = regex.Match(HtmlHelper.Instance.ParseCollectionStrings(cc)); match.Success; match = match.NextMatch()) {
                var aaa = match.Groups["图片"].ToString();
            }
        }
    }
}
