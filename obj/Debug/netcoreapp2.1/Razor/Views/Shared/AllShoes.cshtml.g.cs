#pragma checksum "D:\Shop\Views\Shared\AllShoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965dfed12f6d9de6e8ee6623b42ce2810d9aba8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllShoes), @"mvc.1.0.view", @"/Views/Shared/AllShoes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllShoes.cshtml", typeof(AspNetCore.Views_Shared_AllShoes))]
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
#line 1 "D:\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "D:\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Shoes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965dfed12f6d9de6e8ee6623b42ce2810d9aba8f", @"/Views/Shared/AllShoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6ba1d69c48c17f3954fb28edf10427469cf487", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllShoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Data.Shoes.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 56, true);
            WriteLiteral("\r\n<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 88, "\"", 105, 1);
#line 4 "D:\Shop\Views\Shared\AllShoes.cshtml"
WriteAttributeValue("", 94, Model.name, 94, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(106, 14, true);
            WriteLiteral(" />\r\n    <h2> ");
            EndContext();
            BeginContext(121, 10, false);
#line 5 "D:\Shop\Views\Shared\AllShoes.cshtml"
    Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(131, 16, true);
            WriteLiteral("</h2>\r\n    <h2> ");
            EndContext();
            BeginContext(148, 15, false);
#line 6 "D:\Shop\Views\Shared\AllShoes.cshtml"
    Write(Model.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(163, 20, true);
            WriteLiteral("</h2>\r\n    <p>Ціна: ");
            EndContext();
            BeginContext(184, 25, false);
#line 7 "D:\Shop\Views\Shared\AllShoes.cshtml"
        Write(Model.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(209, 137, true);
            WriteLiteral(" </p>\r\n    <p><a class=\"btn btn-warning\" asp-controller=\"ShopCart\" asp-action=\"addToCart\" asp-route-id=\"5\">Додати в кошик</a></p>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Data.Shoes.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591