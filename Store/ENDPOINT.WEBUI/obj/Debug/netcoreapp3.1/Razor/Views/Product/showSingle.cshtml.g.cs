#pragma checksum "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13e26b712f1f1e37a5b923997920c23d21856ed"
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
#line 1 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using ENDPOINT.WEBUI.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using ENDPOINT.WEBUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\_ViewImports.cshtml"
using CORE.DOMAIN;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4452049b306c9553bc082e4faffbe4bfad874e", @"/Views/Product/showSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e247071f7f4ac46aca1b1065e3ee2aaf92b4f6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_showSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<productMultiImage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AboutUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showBySeach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
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
#line 25 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                     foreach (var item in Model.AllImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            <img");
            BeginWriteAttribute("src", " src=", 864, "", 880, 1);
#nullable restore
#line 28 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
WriteAttributeValue("", 869, item.image, 869, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" style=\"width:55%;height:88%;margin:0 auto\">\r\n        </div>");
#nullable restore
#line 29 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"single_product_text text-center\">\r\n                    <h3>");
#nullable restore
#line 36 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>\r\n                        ");
#nullable restore
#line 38 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <div class=\"card_area\">\n                        <div class=\"product_count_area\">\n\n                            <div class=\"product_count d-inline-block\">\n");
            WriteLiteral("                            </div>\n\n\n                            <h4>قیمت : جهت اطلاع تماس بگیرید</h4>\n\n\n                        </div>\n                        <div class=\"add_to_cart\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4452049b306c9553bc082e4faffbe4bfad874e8431", async() => {
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
#line 66 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-pill badge-dark\" style=\"font-size:large\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34313734cb4edb9fd0eabe0005c6d6f7d825ef6210655", async() => {
                WriteLiteral(" ");
#nullable restore
#line 71 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
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
#line 71 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                                            WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Input"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Input", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Input"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </span>\n");
#nullable restore
#line 73 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
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
<!--================End Single Product Area =================-->


<section class=""client_review "" style=""direction: ltr"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""client_review_slider owl-carousel "">



");
#nullable restore
#line 95 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                     foreach (var item in Model.RelatedProduct)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single_client_review\" dir=\"rtl\">\n            <div class=\"mx-auto d-block\">\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa4452049b306c9553bc082e4faffbe4bfad874e11903", async() => {
                WriteLiteral("\n                    <img");
                BeginWriteAttribute("src", " src=", 3210, "", 3231, 1);
#nullable restore
#line 96 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
WriteAttributeValue("", 3215, item.mainImages, 3215, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-rounded\" style=\"height:33%;width:33%\" alt=\"#\">\r\n                ");
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
#line 100 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
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
            WriteLiteral("\r\n\r\n            </div>\r\n            <h5>");
#nullable restore
#line 105 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 106 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>");
#nullable restore
#line 108 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
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
