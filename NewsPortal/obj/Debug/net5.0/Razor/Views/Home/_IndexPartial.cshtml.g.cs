#pragma checksum "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "304028f30358d01d7732eaac15e53407e176be79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__IndexPartial), @"mvc.1.0.view", @"/Views/Home/_IndexPartial.cshtml")]
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
#line 1 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
using NewsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
using NewsAPI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
using NewsAPI.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304028f30358d01d7732eaac15e53407e176be79", @"/Views/Home/_IndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84dd967efc590f56e4d91bb198e0d4b947b97b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__IndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/picture.missing.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"col-md-10 col-lg-8 col-xl-7\" id=\"newsBlog\">\r\n    <!-- Post preview-->\r\n");
#nullable restore
#line 8 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
     if (Model.ArticleResult.Articles.Count == 0)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"post-preview\">\r\n            <h2 class=\"alert post-title\">Sorry, there are no news for your request </h2>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
     }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
         foreach (var article in Model.ArticleResult.Articles)
         {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
             if (article.UrlToImage == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-preview\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "304028f30358d01d7732eaac15e53407e176be796193", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2 class=\"post-title\">");
#nullable restore
#line 22 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                      Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3 class=\"post-subtitle\">");
#nullable restore
#line 23 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                         Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"post-meta\">\r\n                        Posted by\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 910, "\"", 929, 1);
#nullable restore
#line 26 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
WriteAttributeValue("", 917, article.Url, 917, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                          Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                   Write(article.PublishedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-preview\">\r\n                    <input type=\"image\" class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 1196, "\"", 1221, 1);
#nullable restore
#line 34 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
WriteAttributeValue("", 1202, article.UrlToImage, 1202, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h2 class=\"post-title\">");
#nullable restore
#line 35 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                      Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3 class=\"post-subtitle\">");
#nullable restore
#line 36 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                         Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"post-meta\">\r\n                        Posted by\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1463, "\"", 1482, 1);
#nullable restore
#line 39 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
WriteAttributeValue("", 1470, article.Url, 1470, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                                          Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
                   Write(article.PublishedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
             
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Артем\source\repos\NewsPortal\NewsPortal\Views\Home\_IndexPartial.cshtml"
          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr class=\"my-4\" />\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591