#pragma checksum "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Profile\Partial\_ProfileLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e43beabe81ade3a739d49600211bc312db864bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Partial__ProfileLayout), @"mvc.1.0.view", @"/Views/Profile/Partial/_ProfileLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Partial/_ProfileLayout.cshtml", typeof(AspNetCore.Views_Profile_Partial__ProfileLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e43beabe81ade3a739d49600211bc312db864bd", @"/Views/Profile/Partial/_ProfileLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad124de73790005e28177e9f5fcb3f3258d9eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Partial__ProfileLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Profile\Partial\_ProfileLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 44, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-3\">");
            EndContext();
            BeginContext(74, 47, false);
#line 5 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Profile\Partial\_ProfileLayout.cshtml"
                     Write(await Html.PartialAsync("Partial/_ProfileMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(121, 33, true);
            WriteLiteral("</div>\n    <div class=\"col-md-9\">");
            EndContext();
            BeginContext(155, 12, false);
#line 6 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Profile\Partial\_ProfileLayout.cshtml"
                     Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(167, 15, true);
            WriteLiteral("</div>\n</div>\n\n");
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
