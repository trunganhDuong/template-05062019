#pragma checksum "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab5ff82a17fe52a9de85d86753b2d25657f97e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Location_Default), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/Components/Location/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/Components/Location/Default.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Location_Default))]
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
#line 1 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5ff82a17fe52a9de85d86753b2d25657f97e6f", @"/Areas/FrontEnd/Views/Shared/Components/Location/Default.cshtml")]
    public class Areas_FrontEnd_Views_Shared_Components_Location_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Location>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(102, 671, true);
            WriteLiteral(@"    <!-- Start About area -->
    <div id=""location"" class=""section-padding wow fadeIn delay-05s grey-background"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"">
                    <h2 class=""service-title pad-bt15"">Vị trí</h2>
                    <p class=""sub-title pad-bt15""></p>
                    <hr class=""bottom-line"">
                </div>
            </div>
            <div class=""row"">
                <!-- single-well start-->
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <div class=""well-left"">
                        <h4 class=""sec-head"">");
            EndContext();
            BeginContext(774, 12, false);
#line 20 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
                                        Write(Model.Header);

#line default
#line hidden
            EndContext();
            BeginContext(786, 64, true);
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(851, 27, false);
#line 22 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(878, 276, true);
            WriteLiteral(@"
                        </p>
                    </div>
                </div>
                <!-- single-well end-->
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <div class=""blog-sec"">
                        <div class=""blog-img"">
");
            EndContext();
#line 30 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
                             if (!string.IsNullOrEmpty(Model.MapImage))
                            {

#line default
#line hidden
            BeginContext(1258, 85, true);
            WriteLiteral("                                <a href=\"\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1343, "\"", 1364, 1);
#line 33 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
WriteAttributeValue("", 1349, Model.MapImage, 1349, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1365, 48, true);
            WriteLiteral(" alt=\"\">\r\n                                </a>\r\n");
            EndContext();
#line 35 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1444, 139, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- End col-->\r\n            </div>\r\n\r\n");
            EndContext();
#line 42 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
             if (!string.IsNullOrEmpty(Model.NearbyImage))
            {

#line default
#line hidden
            BeginContext(1658, 176, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-10 col-lg-offset-1\">\r\n                        <div class=\"blog-img\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1834, "\"", 1858, 1);
#line 47 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
WriteAttributeValue("", 1840, Model.NearbyImage, 1840, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1859, 96, true);
            WriteLiteral(" alt=\"\" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 51 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1970, 57, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- End About area -->\r\n");
            EndContext();
#line 55 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Location\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Location> Html { get; private set; }
    }
}
#pragma warning restore 1591
