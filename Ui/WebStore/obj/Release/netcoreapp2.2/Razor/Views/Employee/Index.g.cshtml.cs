#pragma checksum "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b2e55232eee6632fddc9e58671ee812e5e1175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b2e55232eee6632fddc9e58671ee812e5e1175", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad124de73790005e28177e9f5fcb3f3258d9eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.DomainNew.ViewModels.EmployeeView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Список сотрудников";
    var isAdmin = User.IsInRole("Admin");

#line default
#line hidden
            BeginContext(156, 24, true);
            WriteLiteral("<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(180, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b2e55232eee6632fddc9e58671ee812e5e11754405", async() => {
                BeginContext(186, 26, true);
                WriteLiteral("\n    <title>title</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(219, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(220, 851, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b2e55232eee6632fddc9e58671ee812e5e11755609", async() => {
                BeginContext(226, 12, true);
                WriteLiteral("\n    <hr />\n");
                EndContext();
#line 14 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
     if (isAdmin)
    {

#line default
#line hidden
                BeginContext(262, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(270, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b2e55232eee6632fddc9e58671ee812e5e11756257", async() => {
                    BeginContext(315, 8, true);
                    WriteLiteral("Добавить");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(327, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 17 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(334, 37, true);
                WriteLiteral("    <hr />\n    <table class=\"table\">\n");
                EndContext();
#line 20 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(418, 58, true);
                WriteLiteral("            <tr>\n                <td>\n                    ");
                EndContext();
                BeginContext(477, 64, false);
#line 24 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
               Write(Html.ActionLink(item.FirstName, "Details", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(541, 23, true);
                WriteLiteral("\n                </td>\n");
                EndContext();
#line 26 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                 if (isAdmin)
                {

#line default
#line hidden
                BeginContext(612, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(636, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b2e55232eee6632fddc9e58671ee812e5e11759119", async() => {
                    BeginContext(681, 26, true);
                    WriteLiteral("<i class=\"fa fa-edit\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(711, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 29 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(735, 20, true);
                WriteLiteral("                <td>");
                EndContext();
                BeginContext(756, 12, false);
#line 30 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
               Write(item.SurName);

#line default
#line hidden
                EndContext();
                BeginContext(768, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(795, 15, false);
#line 31 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
               Write(item.Patronymic);

#line default
#line hidden
                EndContext();
                BeginContext(810, 26, true);
                WriteLiteral("</td>\n                <td>");
                EndContext();
                BeginContext(837, 8, false);
#line 32 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
               Write(item.Age);

#line default
#line hidden
                EndContext();
                BeginContext(845, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 33 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                 if (isAdmin)
                {

#line default
#line hidden
                BeginContext(899, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(923, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b2e55232eee6632fddc9e58671ee812e5e117513226", async() => {
                    BeginContext(970, 25, true);
                    WriteLiteral("<i class=\"fa fa-cut\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 35 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(999, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 36 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1023, 18, true);
                WriteLiteral("            </tr>\n");
                EndContext();
#line 38 "G:\ASP2\урок6\ASP2--5\ASP2--5\Ui\WebStore\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1051, 13, true);
                WriteLiteral("    </table>\n");
                EndContext();
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
            EndContext();
            BeginContext(1071, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.DomainNew.ViewModels.EmployeeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
