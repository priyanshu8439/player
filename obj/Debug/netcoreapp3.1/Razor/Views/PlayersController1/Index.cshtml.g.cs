#pragma checksum "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c791a1f11f80f86eed8add37a902121fafafe792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlayersController1_Index), @"mvc.1.0.view", @"/Views/PlayersController1/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Day47\WebAppMVC\WebAppMVC\Views\_ViewImports.cshtml"
using WebAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Day47\WebAppMVC\WebAppMVC\Views\_ViewImports.cshtml"
using WebAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c791a1f11f80f86eed8add37a902121fafafe792", @"/Views/PlayersController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d71c890daac151288336527d688967613a7d246", @"/Views/_ViewImports.cshtml")]
    public class Views_PlayersController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppMVC.Models.Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Players List</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n          \r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\Day47\WebAppMVC\WebAppMVC\Views\PlayersController1\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppMVC.Models.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
