#pragma checksum "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866aa0a078d631b37273f9a54ffb65d48e0532af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\_ViewImports.cshtml"
using DonateBlood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\_ViewImports.cshtml"
using DonateBlood.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866aa0a078d631b37273f9a54ffb65d48e0532af", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4695ddb175d0f3ccbd985505ebf9f71b48b72b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Path</h5>\r\n    <hr>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Message</h5>\r\n    <hr>\r\n    <p>");
#nullable restore
#line 14 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Trace</h5>\r\n    <hr>\r\n    <p>");
#nullable restore
#line 19 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\Shared\Error.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
