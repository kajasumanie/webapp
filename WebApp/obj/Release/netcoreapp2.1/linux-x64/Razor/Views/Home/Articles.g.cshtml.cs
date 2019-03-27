#pragma checksum "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0461c8139c57c70e76e0a6fb1c3d1e8d309c39f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Articles), @"mvc.1.0.view", @"/Views/Home/Articles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Articles.cshtml", typeof(AspNetCore.Views_Home_Articles))]
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
#line 1 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0461c8139c57c70e76e0a6fb1c3d1e8d309c39f9", @"/Views/Home/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticlesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
  
    ViewData["Title"] = "Articles";

#line default
#line hidden
            BeginContext(70, 278, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""jumbotron"">
        <h2 class=""display-4"">Latest posts published on the WebApp!</h2>
        <hr class=""my-4"">
    </div>

    <div class=""row"">
        <div class=""col-12"">
            <ul class=""list-group list-group-flush"">
");
            EndContext();
#line 15 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
                 foreach (var article in Model.Articles)
                {

#line default
#line hidden
            BeginContext(425, 166, true);
            WriteLiteral("                    <br>\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <h3 class=\"card-title\">");
            EndContext();
            BeginContext(592, 13, false);
#line 20 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
                                              Write(article.Title);

#line default
#line hidden
            EndContext();
            BeginContext(605, 83, true);
            WriteLiteral("</h3>\r\n                            <em class=\"card-footer text-muted\">Published on ");
            EndContext();
            BeginContext(689, 38, false);
#line 21 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
                                                                       Write(article.PublishedOn.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(727, 56, true);
            WriteLiteral("</em>\r\n                            <p class=\"card-text\">");
            EndContext();
            BeginContext(784, 15, false);
#line 22 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
                                            Write(article.Content);

#line default
#line hidden
            EndContext();
            BeginContext(799, 145, true);
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-primary\">Read more</a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 26 "D:\Others\Workspace\AspNetCore\WebApp\WebApp\Views\Home\Articles.cshtml"
                }

#line default
#line hidden
            BeginContext(963, 55, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticlesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
