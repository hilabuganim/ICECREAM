#pragma checksum "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84601857aed4b17f22410db6fa548141f3f46b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Icecreams_Index), @"mvc.1.0.view", @"/Views/Icecreams/Index.cshtml")]
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
#line 1 "C:\Users\hilab\source\repos\icecream\icecream\Views\_ViewImports.cshtml"
using icecream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hilab\source\repos\icecream\icecream\Views\_ViewImports.cshtml"
using icecream.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84601857aed4b17f22410db6fa548141f3f46b7c", @"/Views/Icecreams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c923f4c765050f4b1cfab4a4d05da639f2fb2586", @"/Views/_ViewImports.cshtml")]
    public class Views_Icecreams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<icecream.Models.Icecream>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-new-gr-c-s-check-loaded", new global::Microsoft.AspNetCore.Html.HtmlString("14.1034.0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gr-ext-installed", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<html data-wf-domain=""template-stone.webflow.io"" data-wf-page=""5e457cdd6bf0d0c1d6420d3d""
      data-wf-site=""5e457cdd6bf0d06897420d3a"" data-wf-status=""1""
      class=""w-mod-js wf-robotocondensed-n3-active wf-robotocondensed-n4-active wf-robotocondensed-n7-active wf-roboto-n4-active wf-roboto-n3-active wf-roboto-n5-active wf-vollkorn-n4-active wf-vollkorn-n7-active wf-vollkorn-i7-active wf-vollkorn-i4-active wf-active"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84601857aed4b17f22410db6fa548141f3f46b7c6512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c7627", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Stone Responsive Website Template | Webflow Templates</title>
    <meta content=""Stone Template is an awesome dark and beige muted theme for an agency or any other professional service.""
          name=""description"">
    <meta content=""width=device-width, initial-scale=1"" name=""viewport"">
    <meta content=""Webflow"" name=""generator"">
    <!--    <link href=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/css/template-stone.webflow.ca1296b83.css""-->
    <!--          rel=""stylesheet"" type=""text/css"">-->
    <script src=""https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js"" type=""text/javascript""></script>
    <link rel=""stylesheet""
          href=""http://fonts.googleapis.com/css?family=Vollkorn:400,400italic,700,700italic%7CRoboto+Condensed:300,regular,700%7CRoboto:300,regular,500""
          media=""all"">
    <script type=""text/javascript"">WebFont.load({google: {families: [""Vollkorn:400,400italic,700,700italic"", ""Roboto Condensed:300,regul");
                WriteLiteral(@"ar,700"", ""Roboto:300,regular,500""]}});</script>
    <!--[if lt IE 9]>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/html5shiv/3.7.3/html5shiv.min.js""
            type=""text/javascript""></script><![endif]-->
    <script type=""text/javascript"">
!function (o, c) {
        var n = c.documentElement, t = "" w-mod-"";
        n.className += t + ""js"", (""ontouchstart"" in o || o.DocumentTouch && c instanceof DocumentTouch) && (n.className += t + ""touch"")
    }(window, document);</script>
    <link href=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d0c4f0420d3f_favicon.ico""
          rel=""shortcut icon"" type=""image/x-icon"">
    <link href=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d01600420d4d_stone-webclip.png""
          rel=""apple-touch-icon"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c10628", async() => {
                WriteLiteral(@"
    <div data-collapse=""medium"" data-animation=""default"" data-duration=""400"" role=""banner"" class=""navbar w-nav"">
        <div class=""w-container"">
            <a href=""/"" aria-current=""page"" class=""brand w-clearfix w-nav-brand w--current""
               aria-label=""home"">
                <img src=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d070d8420d48_stone-logo-beige.svg""
                     width=""20""");
                BeginWriteAttribute("alt", " alt=\"", 3022, "\"", 3028, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"stone-logo\">\r\n                <div class=\"logo-text\">STONE</div>\r\n            </a>\r\n            <nav role=\"navigation\" class=\"nav-menu w-nav-menu\">\r\n                <a href=\"/\" aria-current=\"page\" class=\"nav-link w-nav-link w--current\"");
                BeginWriteAttribute("style", " style=\"", 3272, "\"", 3280, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a>\r\n                <a href=\"/work\" class=\"nav-link w-nav-link\"");
                BeginWriteAttribute("style", " style=\"", 3351, "\"", 3359, 0);
                EndWriteAttribute();
                WriteLiteral(">Work</a>\r\n                <a href=\"/contact\" class=\"nav-link w-nav-link\"");
                BeginWriteAttribute("style", " style=\"", 3433, "\"", 3441, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact</a>\r\n                <a href=\"#\" class=\"nav-link w-hidden-main w-hidden-medium w-hidden-small w-hidden-tiny w-nav-link\"");
                BeginWriteAttribute("style", " style=\"", 3570, "\"", 3578, 0);
                EndWriteAttribute();
                WriteLiteral(">Facebook</a>\r\n                <a href=\"#\" class=\"nav-link w-hidden-main w-hidden-medium w-hidden-small w-hidden-tiny w-nav-link\"");
                BeginWriteAttribute("style", " style=\"", 3708, "\"", 3716, 0);
                EndWriteAttribute();
                WriteLiteral(@">Twitter</a>
            </nav>
            <a href=""http://www.twitter.com/webflowapp""
               class=""nav-link social-icons last w-hidden-medium w-hidden-small w-hidden-tiny w-inline-block"">
                <img src=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d0642f420d49_twitter-icon.svg""
                     width=""16""");
                BeginWriteAttribute("alt", " alt=\"", 4079, "\"", 4085, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </a>
            <a href=""http://www.facebook.com/webflow""
               class=""nav-link social-icons w-hidden-medium w-hidden-small w-hidden-tiny w-inline-block"">
                <img src=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d0781c420d40_facebook-icon2.svg""
                     width=""15""");
                BeginWriteAttribute("alt", " alt=\"", 4430, "\"", 4436, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </a>
            <div class=""menu-button w-nav-button"" style=""-webkit-user-select: text;"" aria-label=""menu"" role=""button""
                 tabindex=""0"" aria-controls=""w-nav-overlay-0"" aria-haspopup=""menu"" aria-expanded=""false"">
                <div class=""menu-icon w-icon-nav-menu""></div>
            </div>
        </div>
        <div class=""w-nav-overlay"" data-wf-ignore="""" id=""w-nav-overlay-0""></div>
    </div>

    <div class=""section beige"" style=""background-color: palevioletred"">
        <div class=""w-container"">
            <div class=""w-container"">
                <h1 style=""color: black"">Order one of our wonderful flavors.</h1>
                <div style=""background-color: black"" class=""horizontal-bar beige""></div>
            </div>
        </div>
    </div>
    <div class=""section lightgrey"">
        <div class=""w-container"">
            <html>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c14939", async() => {
                    WriteLiteral("\r\n                <link href=\'https://fonts.googleapis.com/css?family=Courgette\' rel=\'stylesheet\'>\r\n                <meta name=\"viewport\" content=\"width=device-width\" />\r\n                <title>Index</title>\r\n            ");
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
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c16207", async() => {
                    WriteLiteral("\r\n\r\n                <p>\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c16521", async() => {
                        WriteLiteral("Create New");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </p>\r\n\r\n                <div class=\"icecreams\">\r\n\r\n\r\n                    <div class=\"container\">\r\n");
#nullable restore
#line 99 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <div class=\"item\">\r\n                                <img");
                    BeginWriteAttribute("src", " src=\"", 5967, "\"", 5984, 1);
#nullable restore
#line 102 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
WriteAttributeValue("", 5973, item.image, 5973, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                <h1 class=\"flavor\"><strong>");
#nullable restore
#line 103 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                                                      Write(item.icecreamName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</strong></h1>\r\n                                <p>");
#nullable restore
#line 104 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                              Write(item.icecreamDescription);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                <p>");
#nullable restore
#line 105 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                              Write(item.price);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" $</p>\r\n");
#nullable restore
#line 106 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                                 if (RouteConfig.user != null)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <div class=\"crud\">\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c20027", async() => {
                        WriteLiteral("Edit");
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
#line 109 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                                                           WriteLiteral(item.id);

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
                    WriteLiteral(" |\r\n");
                    WriteLiteral("                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84601857aed4b17f22410db6fa548141f3f46b7c22460", async() => {
                        WriteLiteral("Delete");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                                                             WriteLiteral(item.id);

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
                    WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 113 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 116 "C:\Users\hilab\source\repos\icecream\icecream\Views\Icecreams\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </div>\r\n\r\n\r\n                </div>\r\n\r\n\r\n            ");
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
                WriteLiteral(@"

            <style>

                .icecreams {
                    display: inline-block;
                }

                .container {
                    font-family: Courgette, serif;
                    margin: 10px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    gap: 50px;
                    float: left;
                    flex-wrap: wrap;
                }

                .item {
                    padding: 15px;
                    display: flex;
                    justify-content: center;
                    flex-direction: column;
                    width: 230px;
                    align-self: self-start;
                }

                p {
                    margin: 0;
                    text-align: center;
                }

                .item img {
                    width: 200px;
                    height: 200px;
                    border-radiu");
                WriteLiteral(@"s: 100px;
                    box-shadow: rgba(50, 50, 93, 0.25) 0 13px 27px -5px, rgba(0, 0, 0, 0.3) 0 8px 16px -8px;
                    transition: ease-in-out 0.5s;
                }

                    .item img:hover {
                        box-shadow: rgba(255, 0, 231, 0.5) 0 50px 100px -20px, rgba(217, 32, 32, 0.6) 0 30px 60px -30px;
                    }

                .flavor {
                    text-align: center;
                    color: white;
                    font-size: 50px;
                    font-style: italic;
                    margin-top: -40px;
                    margin-bottom: 20px;
                    line-height: 80%;
                    text-shadow: 0 1px 0 #ccc, 0 2px 0 #c9c9c9, 0 3px 0 #bbb, 0 4px 0 #b9b9b9, 0 5px 0 #aaa, 0 6px 1px rgba(0, 0, 0, .1), 0 0 5px rgba(0, 0, 0, .1), 0 1px 3px rgba(0, 0, 0, .3), 0 3px 5px rgba(0, 0, 0, .2), 0 5px 10px rgba(0, 0, 0, .25), 0 10px 10px rgba(0, 0, 0, .2), 0 20px 20px rgba(0, 0, 0, .15);
                }

   ");
                WriteLiteral(@"             * {
                    box-sizing: border-box;
                }

                .crud {
                    display: flex;
                    justify-content: center;
                    gap: 10px;
                    margin-top: 10px;
                    color: gray;
                }
            </style>
</div>
    </div>
    <div class=""section footer"">
        <div class=""w-container"">
            <div class=""w-row"">
                <div class=""w-col w-col-4"">
                    <img src=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/5e457cdd6bf0d067ea420d45_stone-logo.svg""
                         width=""20""");
                BeginWriteAttribute("alt", " alt=\"", 9581, "\"", 9587, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""stone-logo footer"">
                    <div class=""footer-text w-hidden-small w-hidden-tiny"">2014 Stone Creative Agency</div>
                </div>
                <div class=""w-col w-col-4""><a href=""/contact"" class=""button beige footer"">get in touch with us</a></div>
                <div class=""w-col w-col-4"">
                    <div class=""footer-text address"">1423 Elk St, Brooklyn NY, 82328</div>
                </div>
            </div>
        </div>
    </div>
    <script src=""https://d3e54v103j8qbb.cloudfront.net/js/jquery-3.5.1.min.dc5e7f18c8.js?site=5e457cdd6bf0d06897420d3a""
            type=""text/javascript"" integrity=""sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=""
            crossorigin=""anonymous""></script>
    <script src=""https://assets.website-files.com/5e457cdd6bf0d06897420d3a/js/webflow.6e1279216.js""
            type=""text/javascript""></script>
    <!--[if lte IE 9]>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js""></s");
                WriteLiteral("cript><![endif]-->\r\n    <a class=\"w-webflow-badge\" href=\"https://webflow.com?utm_campaign=brandjs\">\r\n        <img src=\"https://d3e54v103j8qbb.cloudfront.net/img/webflow-badge-icon.f67cd735e3.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 10807, "\"", 10813, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n             style=\"margin-right: 8px; width: 16px;\"><img src=\"https://d1otoma47x30pg.cloudfront.net/img/webflow-badge-text.6faa6a38cd.svg\" alt=\"Made in Webflow\">\r\n    </a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<icecream.Models.Icecream>> Html { get; private set; }
    }
}
#pragma warning restore 1591
