#pragma checksum "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351e4cbdb55d3b6f57a31bfaf06ddc4e582a960e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogPosts_ById), @"mvc.1.0.view", @"/Views/BlogPosts/ById.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\_ViewImports.cshtml"
using TourismPlatform.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\_ViewImports.cshtml"
using TourismPlatform.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351e4cbdb55d3b6f57a31bfaf06ddc4e582a960e", @"/Views/BlogPosts/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"139f71cdf6b999ccf0e47f2ec241a607bf18962b", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogPosts_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourismPlatform.Web.ViewModels.BlogPosts.SingleBlogPostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
  
    this.ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
   Write(this.Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n\r\n    <div class=\"item-figure\">\r\n        <img class=\"img-fluid w-95\"");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 261, 1);
#nullable restore
#line 11 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
WriteAttributeValue("", 246, Model.ImageUrl, 246, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 262, "\"", 280, 1);
#nullable restore
#line 11 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
WriteAttributeValue("", 268, Model.Title, 268, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"ctg-name\">\r\n        <h5>Автор: ");
#nullable restore
#line 14 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
              Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"row\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 412, "\"", 420, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <p class=\"item-description\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Alex\Desktop\TourismPlatform_project\Project_TourismPlatform\TourismPlatform\Web\TourismPlatform.Web\Views\BlogPosts\ById.cshtml"
               Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n        </div>\r\n    </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourismPlatform.Web.ViewModels.BlogPosts.SingleBlogPostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
