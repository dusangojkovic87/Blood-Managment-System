#pragma checksum "C:\Users\Dule\Desktop\Donate Blood\DonateBlood\Donate Blood\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9004702221e75bbf87363beb6151f52b0492f9d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9004702221e75bbf87363beb6151f52b0492f9d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4695ddb175d0f3ccbd985505ebf9f71b48b72b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid p-0 bg-black"">
    <div class=""row no-gutters"">
        <div class=""col-12 d-flex flex-column align-items-center justify-content-center height-500px"">
            <h1 class=""text-center home__heading font-permanent-marker font-size-4rem"">Donate Blood</h1>
            <img class=""image-fluid home__bg__img"" src=""/images/home/bloodDrop.svg"" alt=""bloodDrop.svg"">
            <img class=""wave__img"" src=""images/home/wave1.svg"" alt=""wave1.svg"">
        </div>
    </div>
</div>
<div
    class=""container-fluid d-flex flex-column flex-lg-row flex-md-row align-items-center  align-items-md-center justify-content-md-center"">
    <div class=""col-8 col-sm-6 col-md-3 bg-primary m-4 d-flex flex-column align-items-center  home-card-item"">
        <img class=""home__card__img"" src=""/icons/home/donorHand.svg"" alt=""donorHand.svg"">
        <p class=""home__card__text font-monserrat text-center"">Over 3456 donors</p>
    </div>
    <div class=""col-8 col-sm-6 col-md-3 bg-primary m-4 d-flex flex");
            WriteLiteral(@"-column align-items-center  home-card-item"">
        <img class=""home__card__img"" src=""/icons/home/user.svg"" alt=""donorHand.svg"">
        <p class=""home__card__text font-monserrat text-center"">Over 2567 active users</p>
    </div>
    <div class=""col-8 col-sm-6 col-md-3 bg-primary m-4 d-flex flex-column align-items-center  home-card-item"">
        <img class=""home__card__img"" src=""/icons/home/map.svg"" alt=""donorHand.svg"">
        <p class=""home__card__text font-monserrat text-center"">Over 500 locations</p>
    </div>
</div>
<div class=""container-fluid p-0"">
    <div class=""row no-gutters"">
        <div class=""col-12 bg-primary height-50px d-flex justify-content-center align-items-center"">
            <h6 class=""font-monserrat text-white font-weight-bold font-size-2rem mb-0"">About us</h6>
        </div>
    </div>
</div>
<div class=""container-fluid p-0"">
    <div class=""row no-gutters"">
        <div class=""col-12 d-flex flex-column justify-content-center align-items-center"">
            <img");
            WriteLiteral(@" class=""img-fluid home__img"" src=""/images/home/home1.jpg"" alt=""home1.jpg"">
            <div class=""home-img-overlay""></div>
            <p class=""font-monserrat font-weight-bold text-justify text-grey p-4"">Lorem ipsum dolor sit amet consectetur
                adipisicing
                elit. Ad, dicta quis porro exercitationem veniam facilis doloribus quos modi odit excepturi sed expedita
                dolor! Nesciunt velit ratione voluptas unde nulla cum neque ipsum exercitationem asperiores eaque beatae
                minima omnis autem cumque distinctio eos delectus, reiciendis doloremque, ducimus alias expedita optio
                similique. Exercitationem earum eaque odit, quas sunt, fuga vitae doloribus laborum dicta porro rem
                excepturi in nobis sed harum. Labore suscipit consectetur nam eligendi quasi eos odio. Dolores, magnam
                corporis, at asperiores qui recusandae libero tempora accusamus nulla mollitia maiores expedita eos
                eaque? Quidem");
            WriteLiteral(" consequuntur vitae nostrum? Dignissimos aliquid tempore repudiandae!</p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9004702221e75bbf87363beb6151f52b0492f9d97123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
