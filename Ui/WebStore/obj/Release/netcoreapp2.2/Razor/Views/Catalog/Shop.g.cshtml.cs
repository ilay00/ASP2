#pragma checksum "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Catalog\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e369eab9ff0a1fcc381390b7cbc9afd9e615e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Shop), @"mvc.1.0.view", @"/Views/Catalog/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Shop.cshtml", typeof(AspNetCore.Views_Catalog_Shop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e369eab9ff0a1fcc381390b7cbc9afd9e615e0", @"/Views/Catalog/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad124de73790005e28177e9f5fcb3f3258d9eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.DomainNew.ViewModels.CatalogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Catalog\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
            BeginContext(91, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(93, 49, false);
#line 6 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Catalog\Shop.cshtml"
Write(await Html.PartialAsync("Partial/_Advertisement"));

#line default
#line hidden
            EndContext();
            BeginContext(142, 77, true);
            WriteLiteral("\n\n<section>\n    <div class=\"row\">\n        <div class=\"col-sm-3\">\n            ");
            EndContext();
            BeginContext(220, 47, false);
#line 11 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Catalog\Shop.cshtml"
       Write(await Html.PartialAsync("Partial/_LeftSideBar"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 73, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-sm-9 padding-right\">\n            ");
            EndContext();
            BeginContext(341, 65, false);
#line 14 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Catalog\Shop.cshtml"
       Write(await Html.PartialAsync("Partial/_FeaturedItems", Model.Products));

#line default
#line hidden
            EndContext();
            BeginContext(406, 280, true);
            WriteLiteral(@"
            <ul class=""pagination"">
                <li class=""active""><a href="""">1</a></li>
                <li><a href="""">2</a></li>
                <li><a href="""">3</a></li>
                <li><a href="""">&raquo;</a></li>
            </ul>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.DomainNew.ViewModels.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
