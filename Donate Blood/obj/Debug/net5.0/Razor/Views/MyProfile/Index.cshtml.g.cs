#pragma checksum "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db6000765f5c571881fc10af80971fef6e1cb70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyProfile_Index), @"mvc.1.0.view", @"/Views/MyProfile/Index.cshtml")]
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
#line 1 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\_ViewImports.cshtml"
using DonateBlood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\_ViewImports.cshtml"
using DonateBlood.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db6000765f5c571881fc10af80971fef6e1cb70", @"/Views/MyProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4695ddb175d0f3ccbd985505ebf9f71b48b72b", @"/Views/_ViewImports.cshtml")]
    public class Views_MyProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonateBlood.Models.AplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item profile__link d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyPosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeleteAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid mt-4"">
    <div class=""row d-flex flex-column flex-sm-row align-items-center align-items-sm-start align-items-md-start"">
        <div class=""col-6 col-md-4 col-lg-4 p-0 m-2 mb-4"">
            <img class=""donor__profile__img img-fluid w-100 """);
            BeginWriteAttribute("src", " src=\"", 314, "\"", 341, 2);
            WriteAttributeValue("", 320, "/", 320, 1, true);
            WriteAttributeValue("", 321, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                      
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                 Write(Model.ProfileImg);

#line default
#line hidden
#nullable disable
                                                                                                       
                PopWriter();
            }
            ), 321, 20, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 342, "\"", 369, 2);
            WriteAttributeValue("", 348, "/", 348, 1, true);
            WriteAttributeValue("", 349, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                                                  
#nullable restore
#line 5 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                                             Write(Model.ProfileImg);

#line default
#line hidden
#nullable disable
                                                                                                                                   
                PopWriter();
            }
            ), 349, 20, false);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""dropdown position-absolute w-100"">
                <button class=""btn bg-primary dropdown-toggle"" type=""button"" id=""profileDropdownBtn""
                    data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    options
                </button>
                <div class=""dropdown-menu bg-grey"" aria-labelledby=""profileDropdownBtn"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db6000765f5c571881fc10af80971fef6e1cb708354", async() => {
                WriteLiteral(" <span\r\n                            class=\"edit__icon\"></span>edit profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db6000765f5c571881fc10af80971fef6e1cb709890", async() => {
                WriteLiteral(" <span\r\n                            class=\"image__icon\"></span>change image");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db6000765f5c571881fc10af80971fef6e1cb7011427", async() => {
                WriteLiteral("<span\r\n                            class=\"post__icon\"></span>show my posts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db6000765f5c571881fc10af80971fef6e1cb7012964", async() => {
                WriteLiteral("<span\r\n                            class=\"delete__icon\"></span>delete account");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-10 col-sm-5 mt-4 d-flex flex-column align-items-center align-items-md-start"">
            <ul class=""p-0 w-100"">
                <li class="" my__profile__list__item text-uppercase""><span class=""mr-2"">");
#nullable restore
#line 25 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                       <span>");
#nullable restore
#line 26 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                          Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\" my__profile__list__item\">Blood Type: <span\r\n                        class=\"text-red-primary font-size-1-2rem\">");
#nullable restore
#line 28 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                               Write(Model.BloodType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\" my__profile__list__item\">Location: <span class=\"text-grey\">");
#nullable restore
#line 29 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                                    Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\" my__profile__list__item\">Email: <span class=\"text-grey\">");
#nullable restore
#line 30 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                                 Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li class=\" my__profile__list__item\">Phone: <span class=\"text-grey\">");
#nullable restore
#line 31 "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\MyProfile\Index.cshtml"
                                                                                 Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
