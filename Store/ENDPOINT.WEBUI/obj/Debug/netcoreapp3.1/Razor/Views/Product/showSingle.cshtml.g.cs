#pragma checksum "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26488129f46346ab59271a5ebec46437c8801519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_showSingle), @"mvc.1.0.view", @"/Views/Product/showSingle.cshtml")]
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
#line 1 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using ENDPOINT.WEBUI.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using ENDPOINT.WEBUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using CORE.DOMAIN;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26488129f46346ab59271a5ebec46437c8801519", @"/Views/Product/showSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f9886b3988667da271d279d1d523a114672cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_showSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<productMultiImage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AboutUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Seachq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "shows", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- breadcrumb part start-->
<section class=""breadcrumb_part single_product_breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb_iner"">
                    <h2></h2>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- breadcrumb part end-->
<!--================Single Product Area =================-->
<div class=""product_image_area"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""img-responsive center-block product_img_slide owl-carousel"" style=""margin:0 auto"" dir=""ltr"">
");
#nullable restore
#line 25 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                     foreach (var item in Model.AllImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <img");
            BeginWriteAttribute("src", " src=", 923, "", 933, 1);
#nullable restore
#line 28 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
WriteAttributeValue("", 928, item, 928, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" style=\"width:55%;height:88%;margin:0 auto\">\r\n                        </div>");
#nullable restore
#line 29 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"single_product_text text-center\">\r\n                    <h3>");
#nullable restore
#line 36 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <br>\r\n                    <br>\r\n                    <br>\r\n                    ");
#nullable restore
#line 40 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
               Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                    <div class=""card_area"">
                        <div class=""product_count_area"">




                            <h4>قیمت : جهت اطلاع تماس بگیرید</h4>


                        </div>
                        <div class=""add_to_cart"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26488129f46346ab59271a5ebec46437c88015198600", async() => {
                WriteLiteral("09120170473 شماره تماس ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                        <div>\r\n\r\n");
#nullable restore
#line 65 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"btn btn-outline-dark\" style=\"font-size:large\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26488129f46346ab59271a5ebec46437c880151910720", async() => {
                WriteLiteral(" ");
#nullable restore
#line 70 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                                                           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Input", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                                            WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Input"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Input", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Input"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </span>\r\n");
#nullable restore
#line 72 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""client_review "" style=""direction: ltr"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""client_review_slider owl-carousel "">



");
#nullable restore
#line 92 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                     foreach (var item in Model.RelatedProduct)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single_client_review\" dir=\"rtl\">\r\n                            <div class=\"mx-auto d-block\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26488129f46346ab59271a5ebec46437c880151914475", async() => {
                WriteLiteral(@"

                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4""></div>
                                            <div class=""col-4"">
                                                <img");
                BeginWriteAttribute("src", " src=", 3513, "", 3534, 1);
#nullable restore
#line 103 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
WriteAttributeValue("", 3518, item.mainImages, 3518, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-rounded"" alt=""#"">
                                            </div>
                                            <div class=""col-4""></div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                                                                                        WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <h5>");
#nullable restore
#line 111 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> \r\n                        </div>\r\n");
#nullable restore
#line 113 "D:\Git myproject\MedStore\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n<style>\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<productMultiImage> Html { get; private set; }
    }
}
#pragma warning restore 1591
