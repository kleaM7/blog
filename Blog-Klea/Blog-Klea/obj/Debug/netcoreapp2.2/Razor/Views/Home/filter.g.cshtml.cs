#pragma checksum "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9e71dc0482f36b58683df39f2a849a1cfac982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_filter), @"mvc.1.0.view", @"/Views/Home/filter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/filter.cshtml", typeof(AspNetCore.Views_Home_filter))]
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
#line 1 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\_ViewImports.cshtml"
using Blog_Klea;

#line default
#line hidden
#line 2 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\_ViewImports.cshtml"
using Blog_Klea.Models;

#line default
#line hidden
#line 8 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#line 10 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9e71dc0482f36b58683df39f2a849a1cfac982", @"/Views/Home/filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5dabde65702f578b3e52eb70898d22f600820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog_Klea.Models.BlogPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
  
    ViewData["Title"] = "Home Page";

    var uid = User.FindFirstValue(ClaimTypes.NameIdentifier);

    var usern = await UserManager.FindByIdAsync(uid);

#line default
#line hidden
            BeginContext(294, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(443, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
 if (SignInManager.IsSignedIn(User))

{


#line default
#line hidden
            BeginContext(490, 69, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome ");
            EndContext();
            BeginContext(560, 5, false);
#line 22 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                                 Write(usern);

#line default
#line hidden
            EndContext();
            BeginContext(565, 50, true);
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"text-center\">\r\n");
            EndContext();
#line 25 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
         foreach (BlogPost item in ViewData["posts"] as IEnumerable<BlogPost>)

        {

#line default
#line hidden
            BeginContext(708, 85, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h3 style=\"color:indigo\">");
            EndContext();
            BeginContext(794, 10, false);
#line 30 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                                        Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(804, 27, true);
            WriteLiteral("</h3>\r\n                    ");
            EndContext();
            BeginContext(831, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d9e71dc0482f36b58683df39f2a849a1cfac9825925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 841, "~/content/blog/", 841, 15, true);
#line 31 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
AddHtmlAttributeValue("", 856, item.Image, 856, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(892, 28, true);
            WriteLiteral("\r\n                    <h6>\r\n");
            EndContext();
#line 33 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                         if (item.Content.ToString().Length > 200)
                        {
                            item.Content = item.Content.Substring(0, 199) + "...";
                        }

#line default
#line hidden
            BeginContext(1126, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1151, 12, false);
#line 37 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                   Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 117, true);
            WriteLiteral(";\r\n                    </h6>\r\n                    <p style=\"font-size:12px; color:dimgray\">\r\n                        ");
            EndContext();
            BeginContext(1281, 12, false);
#line 40 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                   Write(item.PubDate);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 80, true);
            WriteLiteral(";\r\n                    </p>\r\n                    <p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1430, 2);
            WriteAttributeValue("", 1380, "https://localhost:44302/BlogPost/Details/", 1380, 41, true);
#line 43 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
WriteAttributeValue(" ", 1421, item.ID, 1422, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1431, 71, true);
            WriteLiteral("> View more </a>\r\n                    </p>\r\n\r\n                </td>\r\n\r\n");
            EndContext();
            BeginContext(1790, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
        }

#line default
#line hidden
            BeginContext(1820, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 57 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"

}
else
{


#line default
#line hidden
            BeginContext(1850, 118, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n    </div>\r\n    <div class=\"text-center\">\r\n");
            EndContext();
#line 66 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
         foreach (BlogPost item in ViewData["posts"] as IEnumerable<BlogPost>)

        {

#line default
#line hidden
            BeginContext(2061, 85, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h3 style=\"color:indigo\">");
            EndContext();
            BeginContext(2147, 10, false);
#line 71 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                                        Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 27, true);
            WriteLiteral("</h3>\r\n                    ");
            EndContext();
            BeginContext(2184, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d9e71dc0482f36b58683df39f2a849a1cfac98211012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2194, "~/content/blog/", 2194, 15, true);
#line 72 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
AddHtmlAttributeValue("", 2209, item.Image, 2209, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2245, 28, true);
            WriteLiteral("\r\n                    <h6>\r\n");
            EndContext();
#line 74 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                         if (item.Content.ToString().Length > 200)
                        {
                            item.Content = item.Content.Substring(0, 199) + "...";
                        }

#line default
#line hidden
            BeginContext(2479, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2504, 12, false);
#line 78 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                   Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 117, true);
            WriteLiteral(";\r\n                    </h6>\r\n                    <p style=\"font-size:12px; color:dimgray\">\r\n                        ");
            EndContext();
            BeginContext(2634, 12, false);
#line 81 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
                   Write(item.PubDate);

#line default
#line hidden
            EndContext();
            BeginContext(2646, 80, true);
            WriteLiteral(";\r\n                    </p>\r\n                    <p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2726, "\"", 2783, 2);
            WriteAttributeValue("", 2733, "https://localhost:44302/BlogPost/Details/", 2733, 41, true);
#line 84 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
WriteAttributeValue(" ", 2774, item.ID, 2775, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2784, 71, true);
            WriteLiteral("> View more </a>\r\n                    </p>\r\n\r\n                </td>\r\n\r\n");
            EndContext();
            BeginContext(3143, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 95 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
        }

#line default
#line hidden
            BeginContext(3173, 16, true);
            WriteLiteral("\r\n\r\n    </div>\r\n");
            EndContext();
#line 99 "C:\Users\Xhers\source\repos\Blog-Klea\Blog-Klea\Views\Home\filter.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog_Klea.Models.BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
