#pragma checksum "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b2709022f01eb3662403ddbaf8f9bd24a292de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Partial2), @"mvc.1.0.view", @"/Views/Home/_Partial2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b2709022f01eb3662403ddbaf8f9bd24a292de", @"/Views/Home/_Partial2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4002dd5f0308a86c1c2ea0c865d330f682eea768", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Partial2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<productSingleImage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  


<section class=""trending_items"" >
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section_tittle text-center"">
                    <h2>محصولات test</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 18 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
             for (int j = 0; j < 2; j++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                 for (int i = 0; i < 3; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-sm-6\">\r\n                        <div class=\"single_product_item\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b2709022f01eb3662403ddbaf8f9bd24a292de5404", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=", 795, "", 821, 1);
#nullable restore
#line 26 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
WriteAttributeValue("", 800, Model[@i].mainImages, 800, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"#\" class=\"img-fluid\">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                                                                                         WriteLiteral(Model[@i].ProductID);

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
            WriteLiteral("\r\n\r\n\r\n                            \r\n                            <h3> <a href=\"single-product.html\">");
#nullable restore
#line 31 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                                                          Write(Model[@i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h3>\r\n                            <h3> <a href=\"single-product.html\">");
#nullable restore
#line 32 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                                                          Write(Model[@i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h3>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 35 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Git myproject\STOREv3\Store\ENDPOINT.WEBUI\Views\Home\_Partial2.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"


    <!-- Latest compiled and minified CSS -->
    <!-- https://xstore.8theme.com/demos/hosting/-->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">

    <!-- Optional theme -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"" integrity=""sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <!-- Latest compiled and minified JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
    <link href=""https://fonts.googleapis.com/css?family=Josefin+Sans:300,400,700&subset=latin-ext"" ");
                WriteLiteral("rel=\"stylesheet\">\r\n    <script src=\"//code.jquery.com/jquery-1.10.2.js\"></script>\r\n    <script src=\"//code.jquery.com/ui/1.11.4/jquery-ui.js\"></script>\r\n\r\n\r\n    <script>\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"


<style>



    .social-link {
        width: 30px;
        height: 30px;
        border: 1px solid #ddd;
        display: flex;
        align-items: center;
        justify-content: center;
        color: #666;
        border-radius: 50%;
        transition: all 0.3s;
        font-size: 0.9rem;
    }

        .social-link:hover, .social-link:focus {
            background: #ddd;
            text-decoration: none;
            color: #555;
        }

    .progress {
        height: 10px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<productSingleImage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
