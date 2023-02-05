#pragma checksum "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc344545420c45d71fc4d676e46d92a38466ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "C:\Users\brsyr\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc344545420c45d71fc4d676e46d92a38466ab8", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415ce9953bd46be8f2c4fe4cc22e26d003bfb282", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count>2? "popular":"";
    var products = Model.Products;
    var categoryName = Model.Category.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc344545420c45d71fc4d676e46d92a38466ab83818", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Product</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <style>
        .popular {
            color:green;
            font-weight: 700;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc344545420c45d71fc4d676e46d92a38466ab85324", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 26 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8cc344545420c45d71fc4d676e46d92a38466ab85852", async() => {
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
                WriteLiteral("\r\n    <main>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h1");
                BeginWriteAttribute("class", " class=\"", 1022, "\"", 1043, 1);
#nullable restore
#line 33 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
WriteAttributeValue("", 1030, popularClass, 1030, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                         Write(categoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                </div>\r\n            </div>         \r\n\r\n");
#nullable restore
#line 37 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                 if(products.Count ==0 )
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
               Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                                                          
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">                  \r\n");
#nullable restore
#line 44 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                         foreach (var product in products)
                        {    

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3\">\r\n                                ");
#nullable restore
#line 47 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                           Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                           </div>       \r\n");
#nullable restore
#line 49 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                        }   

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 51 "C:\Users\brsyr\shopapp\shopapp.webui\Views\Product\List.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    </main>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
