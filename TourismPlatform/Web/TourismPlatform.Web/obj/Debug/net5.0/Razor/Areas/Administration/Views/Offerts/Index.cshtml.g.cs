#pragma checksum "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b423ca6a58b49b708100b653eabf06b149566a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Offerts_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/Offerts/Index.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TourismPlatform.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\_ViewImports.cshtml"
using TourismPlatform.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b423ca6a58b49b708100b653eabf06b149566a4", @"/Areas/Administration/Views/Offerts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"139f71cdf6b999ccf0e47f2ec241a607bf18962b", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Offerts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TourismPlatform.Data.Models.Offert>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b423ca6a58b49b708100b653eabf06b149566a45097", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Transport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerPerson));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PriceIncludes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PriceDoesNotInclude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Transport.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerPerson));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriceIncludes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriceDoesNotInclude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b423ca6a58b49b708100b653eabf06b149566a416778", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b423ca6a58b49b708100b653eabf06b149566a419041", async() => {
                WriteLiteral("Details");
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
#nullable restore
#line 95 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b423ca6a58b49b708100b653eabf06b149566a421310", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\Alex\Desktop\TourismPlatform_project\Tourism Platform 2\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Areas\Administration\Views\Offerts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TourismPlatform.Data.Models.Offert>> Html { get; private set; }
    }
}
#pragma warning restore 1591
