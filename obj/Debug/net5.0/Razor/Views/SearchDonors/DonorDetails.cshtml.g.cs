#pragma checksum "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8e2b97a39d87fca174741d350a7add8847a0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchDonors_DonorDetails), @"mvc.1.0.view", @"/Views/SearchDonors/DonorDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8e2b97a39d87fca174741d350a7add8847a0be", @"/Views/SearchDonors/DonorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4695ddb175d0f3ccbd985505ebf9f71b48b72b", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchDonors_DonorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonateBlood.Models.AplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message__donor__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/searchdonors.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""modal fade"" id=""messageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Message to Donor</h5>
      </div>
      <div class=""modal-body"">
            <p class=""modal__status__text font-monserrat text-center""></p>
      </div>
      <div class=""modal-footer"">
        <button id=""closeMsgModal"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
      </div>
    </div>
  </div>
</div>
<div class=""container-fluid"">
    <div class=""row flex-column flex-sm-row align-items-center align-items-sm-start"">
        <div class=""col-5 col-lg-4 mt-4"">
            <img class=""img-fluid rounded""");
            BeginWriteAttribute("src", " src=\"", 890, "\"", 917, 2);
            WriteAttributeValue("", 896, "/", 896, 1, true);
            WriteAttributeValue("", 897, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                   
#nullable restore
#line 20 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                              Write(Model.ProfileImg);

#line default
#line hidden
#nullable disable
                                                                                    
                PopWriter();
            }
            ), 897, 20, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 918, "\"", 945, 2);
            WriteAttributeValue("", 924, "/", 924, 1, true);
            WriteAttributeValue("", 925, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                               
#nullable restore
#line 20 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                          Write(Model.ProfileImg);

#line default
#line hidden
#nullable disable
                                                                                                                
                PopWriter();
            }
            ), 925, 20, false);
            EndWriteAttribute();
            WriteLiteral(@">
            <p class=""font-monserrat font-weight-bold font-size-1-2rem text-center pt-2"">Dusan Gojkovic</p>
        </div>
        <div class=""col-12 col-sm-6 mt-4"">
            <p class=""font-monserrat text-grey""><span class=""font-size-1rem font-weight-bold mr-2"">Blood Type:</span>
                <span class=""font-size-1-4rem text-red-primary font-weight-bold""> ");
#nullable restore
#line 25 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                               Write(Model.BloodType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n            </p>\r\n            <p class=\"font-monserrat text-grey\"><span class=\"font-size-1rem font-weight-bold mr-2\">Email:</span>\r\n");
#nullable restore
#line 28 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"font-monserrat text-grey\"><span\r\n                    class=\"font-size-1rem font-weight-bold mr-2\">Location:</span>");
#nullable restore
#line 30 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                              Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"font-monserrat text-grey\"><span\r\n                    class=\"font-size-1rem font-weight-bold mr-2\">Phone:</span>");
#nullable restore
#line 32 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                           Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row d-flex justify-content-center\">\r\n        <div class=\"col-12 mt-4\">\r\n            <h6 class=\"font-monserrat text-center font-weight-bold w-100\">Send message to donor</h6>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b8e2b97a39d87fca174741d350a7add8847a0be9493", async() => {
                WriteLiteral("\r\n                <input id=\"donorId\" name=\"id\" type=\"text\" hidden");
                BeginWriteAttribute("value", " value=\"", 2162, "\"", 2182, 1);
                WriteAttributeValue("", 2170, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                                              
#nullable restore
#line 39 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
                                                                                                       
                    PopWriter();
                }
                ), 2170, 12, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input id=\"senderName\" name=\"id\" type=\"text\" hidden");
                BeginWriteAttribute("value", " value=\"", 2253, "\"", 2283, 1);
                WriteAttributeValue("", 2261, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                                                 
#nullable restore
#line 40 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
                                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                                                                                                                    
                    PopWriter();
                }
                ), 2261, 22, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <textarea name=\"Message\" id=\"MessageToDonor\" cols=\"100\" rows=\"7\"></textarea>\r\n                <button class=\"send__msg__btn mt-4\">Send</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b8e2b97a39d87fca174741d350a7add8847a0be13122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 48 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Views\SearchDonors\DonorDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DonateBlood.Models.AplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
