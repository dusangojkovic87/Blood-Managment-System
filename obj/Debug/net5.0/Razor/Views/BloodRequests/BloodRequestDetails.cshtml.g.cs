#pragma checksum "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b944f2ddd162802765960f39ce85508dabf88a4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BloodRequests_BloodRequestDetails), @"mvc.1.0.view", @"/Views/BloodRequests/BloodRequestDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b944f2ddd162802765960f39ce85508dabf88a4e", @"/Views/BloodRequests/BloodRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4695ddb175d0f3ccbd985505ebf9f71b48b72b", @"/Views/_ViewImports.cshtml")]
    public class Views_BloodRequests_BloodRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonateBlood.Models.BloodRequestShowModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bloodrequest.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row mt-4 d-flex justify-content-center\">\r\n        <div class=\"col-6 col-md-4  height-250px mb-4\">\r\n            <img class=\"position-absolute w-100 h-100 request__sender__img\"");
            BeginWriteAttribute("src", " src=\"", 270, "\"", 294, 2);
            WriteAttributeValue("", 276, "\\", 276, 1, true);
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
WriteAttributeValue("", 277, Model.ProfileImg, 277, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 295, "\"", 319, 2);
            WriteAttributeValue("", 301, "\\", 301, 1, true);
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
WriteAttributeValue("", 302, Model.ProfileImg, 302, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
    </div>
        <div class=""col-12 height-400px"">
            <div class=""bg-primary height-40px d-flex justify-content-center align-items-center"">
                <h6 class=""text-white font-monserrat font-size-1rem font-weight-bold"">Required ");
#nullable restore
#line 10 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
                                                                                          Write(Model.BloodType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" blood\r\n                    type</h6>\r\n            </div>\r\n            <p class=\"font-size-0-5rem tex-dark font-monserrat font-weight-bold mt-2 ml-2\">");
#nullable restore
#line 13 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
                                                                                      Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-dark font-monserrat font-size-1rem ml-2\">Location: ");
#nullable restore
#line 14 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
                                                                         Write(Model.DonateLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-dark font-monserrat font-size-1rem ml-2\">");
#nullable restore
#line 15 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
                                                               Write(Model.BloodReqDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 16 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
          Write(Model.AplicationUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"w-100 d-flex justify-content-center\">\r\n        <button class=\"contact__req__sender__btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1122, "\"", 1178, 3);
            WriteAttributeValue("", 1132, "redirectToReqSender(\'", 1132, 21, true);
#nullable restore
#line 18 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\BloodRequests\BloodRequestDetails.cshtml"
WriteAttributeValue("", 1153, Model.AplicationUserId, 1153, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1176, "\')", 1176, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Contact sender</button>\r\n    </div>\r\n        </div>  \r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b944f2ddd162802765960f39ce85508dabf88a4e7965", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DonateBlood.Models.BloodRequestShowModel> Html { get; private set; }
    }
}
#pragma warning restore 1591