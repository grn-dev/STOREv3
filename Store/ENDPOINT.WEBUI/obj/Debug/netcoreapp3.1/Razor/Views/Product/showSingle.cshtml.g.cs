#pragma checksum "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463e9a7985c56643927a745c6bf4cafbbed19b33"
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
using ENDPOINT.WEBUI;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463e9a7985c56643927a745c6bf4cafbbed19b33", @"/Views/Product/showSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4002dd5f0308a86c1c2ea0c865d330f682eea768", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_showSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<productMultiImage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
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
                <div class=""product_img_slide owl-carousel"" dir=""ltr"">
");
#nullable restore
#line 25 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                     foreach (var item in Model.AllImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single_product_img\">\n            <img");
            BeginWriteAttribute("src", " src=", 841, "", 857, 1);
#nullable restore
#line 28 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
WriteAttributeValue("", 846, item.image, 846, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" class=\"img-responsive center-block\" style=\"width:44%;height:64%\">\n        </div>");
#nullable restore
#line 29 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div>\n            </div>\n            <div class=\"col-lg-8\">\n                <div class=\"single_product_text text-center\">\n                    <h3>");
#nullable restore
#line 36 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p>\n                        ");
#nullable restore
#line 38 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <div class=\"card_area\">\n                        <div class=\"product_count_area\">\n\n                            <div class=\"product_count d-inline-block\">\n");
            WriteLiteral(@"                            </div>


                            <h4>قیمت : جهت اطلاع از تماس بگیرید</h4>


                        </div>
                        <div class=""add_to_cart"">
                            <a href=""#"" class=""btn_3"">09121112233 شماره تماس </a>
                        
                        </div>

                        <br>
                        <br>
                        <br>
                        <br>
                        <br>
                        <div>

");
#nullable restore
#line 66 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4> <span class=\"badge badge-pill badge-dark\"> ");
#nullable restore
#line 68 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                                                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n");
#nullable restore
#line 69 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Product\showSingle.cshtml"
                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        </div>\n\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!--================End Single Product Area =================-->\n\n\n\n<style>\n</style>\n\n");
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
