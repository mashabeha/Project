#pragma checksum "D:\Shop\Views\Shoes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7635526d2c78d2389c22c59dee8c00772c41ef08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoes_List), @"mvc.1.0.view", @"/Views/Shoes/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shoes/List.cshtml", typeof(AspNetCore.Views_Shoes_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7635526d2c78d2389c22c59dee8c00772c41ef08", @"/Views/Shoes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6ba1d69c48c17f3954fb28edf10427469cf487", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoes_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 28, true);
            WriteLiteral("\r\n<h1> Усі бренди</h1>\r\n<h2>");
            EndContext();
            BeginContext(29, 20, false);
#line 3 "D:\Shop\Views\Shoes\List.cshtml"
Write(Model.shoessCategory);

#line default
#line hidden
            EndContext();
            BeginContext(49, 37, true);
            WriteLiteral("</h2>\r\n<div class=\"row mt -5 mb-2\">\r\n");
            EndContext();
#line 5 "D:\Shop\Views\Shoes\List.cshtml"
      
        foreach (Product product in Model.allShoes)
        {
            

#line default
#line hidden
            BeginContext(171, 33, false);
#line 8 "D:\Shop\Views\Shoes\List.cshtml"
       Write(Html.Partial("AllShoes", product));

#line default
#line hidden
            EndContext();
#line 8 "D:\Shop\Views\Shoes\List.cshtml"
                                              
        }
    

#line default
#line hidden
            BeginContext(224, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
