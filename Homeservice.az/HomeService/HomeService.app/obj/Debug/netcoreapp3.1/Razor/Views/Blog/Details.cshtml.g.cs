#pragma checksum "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50e4587bed2ab24331de1c9d300d2b2d78a85400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.service.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.app.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
using HomeService.service.Dtos.BlogDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50e4587bed2ab24331de1c9d300d2b2d78a85400", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599a3c90f551cd2f9cac3a20c8f3092dfccf49d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogGetDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/Blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("watch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50e4587bed2ab24331de1c9d300d2b2d78a854004961", async() => {
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
            }
            );
            WriteLiteral("\r\n<div class=\"main-wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"product-div\">\r\n            <div class=\"product-div-left\">\r\n                <div class=\"img-container\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50e4587bed2ab24331de1c9d300d2b2d78a854006418", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 481, "~/assets/images/blog/", 481, 21, true);
#nullable restore
#line 16 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 502, Model.ImageFile, 502, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"product-div-right\">\r\n                <span class=\"product-name\">\r\n");
#nullable restore
#line 22 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                     if ((localizaer["Language"] == "Az"))
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.TitleAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                
                    }
                    else if ((localizaer["Language"] == "En"))
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.TitleEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                
                    }
                    else
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.TitleRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n\r\n\r\n                <p class=\"product-description\">\r\n");
#nullable restore
#line 41 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                     if ((localizaer["Language"] == "Az"))
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.DescriptionAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                      
                    }
                    else if ((localizaer["Language"] == "En"))
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.DescriptionEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                      

                    }
                    else
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                   Write(Html.Raw(Model.DescriptionRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\HP\Desktop\New folder (6)\Homeservice.az\HomeService\HomeService.app\Views\Blog\Details.cshtml"
                                                      

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Localization.IStringLocalizer<SharedResource> localizaer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogGetDto> Html { get; private set; }
    }
}
#pragma warning restore 1591