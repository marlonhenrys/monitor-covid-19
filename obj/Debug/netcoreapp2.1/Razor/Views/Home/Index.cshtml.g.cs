#pragma checksum "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48f65fc91d448576133d5bf2b0b690ae4fd1f2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\_ViewImports.cshtml"
using monitor_covid19;

#line default
#line hidden
#line 2 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\_ViewImports.cshtml"
using monitor_covid19.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48f65fc91d448576133d5bf2b0b690ae4fd1f2d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3d067954813544677e17a4d07f651361aa0fe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<monitor_covid19.Models.Statistic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 199, true);
            WriteLiteral("\r\n<h3>Dashboard</h3>\r\n\r\n<table class=\"table table-striped table-bordered\">\r\n    <thead style=\"color:white\">\r\n        <tr>\r\n            <th style=\"background-color:#333\" scope=\"col\">\r\n                ");
            EndContext();
            BeginContext(297, 43, false);
#line 13 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(340, 103, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"background-color:darkorange\" scope=\"col\">\r\n                ");
            EndContext();
            BeginContext(444, 50, false);
#line 16 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConfirmedCases));

#line default
#line hidden
            EndContext();
            BeginContext(494, 96, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"background-color:red\" scope=\"col\">\r\n                ");
            EndContext();
            BeginContext(591, 42, false);
#line 19 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Deaths));

#line default
#line hidden
            EndContext();
            BeginContext(633, 103, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"background-color:dodgerblue\" scope=\"col\">\r\n                ");
            EndContext();
            BeginContext(737, 46, false);
#line 22 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Recovereds));

#line default
#line hidden
            EndContext();
            BeginContext(783, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(895, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(956, 47, false);
#line 31 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1071, 49, false);
#line 34 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConfirmedCases));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1188, 41, false);
#line 37 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Deaths));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1297, 45, false);
#line 40 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Recovereds));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "C:\Users\marlo\MyApps\monitor_covid19\monitor_covid19\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1397, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<monitor_covid19.Models.Statistic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
