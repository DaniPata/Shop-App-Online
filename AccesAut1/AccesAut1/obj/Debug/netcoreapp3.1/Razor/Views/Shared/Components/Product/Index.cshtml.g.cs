#pragma checksum "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d9934dcfa03eeed1317d3587b66126344e3729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Product_Index), @"mvc.1.0.view", @"/Views/Shared/Components/Product/Index.cshtml")]
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
#line 1 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\_ViewImports.cshtml"
using AccesAut1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\_ViewImports.cshtml"
using AccesAut1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d9934dcfa03eeed1317d3587b66126344e3729", @"/Views/Shared/Components/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd80902d94b4e2e26aa844398dda22e5e1b6016f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"w3ls_mobiles_grid_right_grid3\">\r\n\r\n");
#nullable restore
#line 8 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
      int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
      string id = "idModal";

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
     foreach (var product in Model)
    {
         i++;
        id = id + i.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 agileinfo_new_products_grid agileinfo_new_products_grid_mobiles\">\r\n            <div class=\"agile_ecommerce_tab_left mobiles_grid\">\r\n\r\n                <div class=\"hs-wrapper hs-wrapper2\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11d9934dcfa03eeed1317d3587b66126344e37295137", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 483, "~/products/", 483, 11, true);
#nullable restore
#line 19 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
AddHtmlAttributeValue("", 494, product.Photo, 494, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <div class=\"w3_hs_bottom w3_hs_bottom_sub1\">\r\n                        <ul>\r\n                            <li>\r\n                                <a href=\"#\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 24 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
                                                                         Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""><span class=""glyphicon glyphicon-eye-open"" aria-hidden=""true""></span></a>
                            </li>
                        </ul>
                    </div>
                </div>


                <div class=""mobiles_grid_pos"">
                    <h6>New</h6>
                </div>
            </div>
        </div>
");
            WriteLiteral("        <div class=\"clearfix\"> </div>\r\n");
#nullable restore
#line 39 "E:\Anul4\Copy\AccesAut1\AccesAut1\Views\Shared\Components\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
