#pragma checksum "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833c6847081cb7c0eeefe92af8e827830f56cb90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Design_Default), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Design_Default))]
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
#line 1 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833c6847081cb7c0eeefe92af8e827830f56cb90", @"/Areas/FrontEnd/Views/Shared/Components/Design/Default.cshtml")]
    public class Areas_FrontEnd_Views_Shared_Components_Design_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DesignDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
 if (Model != null && Model.Any())
{

#line default
#line hidden
            BeginContext(127, 492, true);
            WriteLiteral(@"    <!-- Start portfolio Area -->
    <div id=""design"" class=""section-padding wow fadeIn delay-05s grey-background"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"">
                    <h2 class=""service-title pad-bt15"">Thiết kế mặt bằng</h2>
                    <p class=""sub-title pad-bt15""></p>
                    <hr class=""bottom-line"">
                </div>
            </div>
            <div class=""row"">
");
            EndContext();
#line 17 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(684, 191, true);
            WriteLiteral("                    <div class=\"col-md-10 col-md-offset-1 col-sm-12 col-xs-12 portfolio-item padding-right-zero mr-btn-15\">\r\n                        <figure>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 875, "\"", 893, 1);
#line 21 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
WriteAttributeValue("", 881, item.Images, 881, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(894, 104, true);
            WriteLiteral(" class=\"img-responsive\">\r\n                            <figcaption>\r\n                                <h2>");
            EndContext();
            BeginContext(999, 11, false);
#line 23 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                               Write(item.Header);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 42, true);
            WriteLiteral("</h2>\r\n                                <p>");
            EndContext();
            BeginContext(1053, 16, false);
#line 24 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 112, true);
            WriteLiteral("</p>\r\n                            </figcaption>\r\n                        </figure>\r\n                    </div>\r\n");
            EndContext();
#line 28 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1200, 48, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Design\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DesignDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
