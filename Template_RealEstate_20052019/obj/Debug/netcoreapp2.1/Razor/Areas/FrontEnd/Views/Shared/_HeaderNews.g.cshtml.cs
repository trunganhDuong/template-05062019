#pragma checksum "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\_HeaderNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "690a95f7124927f14c1810aeb061ddb7fe0a4425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared__HeaderNews), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/_HeaderNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/_HeaderNews.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared__HeaderNews))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"690a95f7124927f14c1810aeb061ddb7fe0a4425", @"/Areas/FrontEnd/Views/Shared/_HeaderNews.cshtml")]
    public class Areas_FrontEnd_Views_Shared__HeaderNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 849, true);
            WriteLiteral(@"<div id=""preloader""></div>

<header>
    <div id=""sticker"" class=""header-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12"">
                    <nav class=""navbar navbar-default"">
                        <div class=""navbar-header"">
                            <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target="".bs-example-navbar-collapse-1"" aria-expanded=""false"">
                                <span class=""sr-only"">Toggle navigation</span>
                                <span class=""icon-bar""></span>
                                <span class=""icon-bar""></span>
                                <span class=""icon-bar""></span>
                            </button>
                        </div>
                        ");
            EndContext();
            BeginContext(850, 41, false);
#line 17 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\_HeaderNews.cshtml"
                   Write(await Component.InvokeAsync("Menu", true));

#line default
#line hidden
            EndContext();
            BeginContext(891, 111, true);
            WriteLiteral("\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>");
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