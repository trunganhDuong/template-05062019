#pragma checksum "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\BackEnd\Views\Shared\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11fcb02bf9986f17248636104b23f8a85a72b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BackEnd_Views_Shared__Menu), @"mvc.1.0.view", @"/Areas/BackEnd/Views/Shared/_Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BackEnd/Views/Shared/_Menu.cshtml", typeof(AspNetCore.Areas_BackEnd_Views_Shared__Menu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11fcb02bf9986f17248636104b23f8a85a72b8c", @"/Areas/BackEnd/Views/Shared/_Menu.cshtml")]
    public class Areas_BackEnd_Views_Shared__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1088, true);
            WriteLiteral(@"<!-- Left side column. contains the sidebar -->
<aside class=""main-sidebar"">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class=""sidebar"">
        <!-- search form -->
        <form action=""#"" method=""get"" class=""sidebar-form"">
            <div class=""input-group"">
                <input type=""text"" name=""q"" class=""form-control"" placeholder=""Search..."">
                <span class=""input-group-btn"">
                    <button type=""submit"" name=""search"" id=""search-btn"" class=""btn btn-flat"">
                        <i class=""fa fa-search""></i>
                    </button>
                </span>
            </div>
        </form>
        <!-- /.search form -->
        <!-- sidebar menu: : style can be found in sidebar.less -->
        <ul class=""sidebar-menu"" data-widget=""tree"">
            <li class=""header"">MAIN NAVIGATION</li>
            <li>
                <a href=""/"">
                    <i class=""fa fa-dashboard""></i> <span>Dashboard</span>
             ");
            WriteLiteral("   </a>\r\n            </li>\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1149, 1);
#line 26 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\BackEnd\Views\Shared\_Menu.cshtml"
WriteAttributeValue("", 1095, Url.Action("Index", "Article", new { Area="Backend"}), 1095, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1150, 175, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-newspaper-o\" aria-hidden=\"true\"></i> <span>Tin tức</span>\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1325, "\"", 1385, 1);
#line 31 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\BackEnd\Views\Shared\_Menu.cshtml"
WriteAttributeValue("", 1332, Url.Action("Index", "Policy", new { Area="Backend"}), 1332, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1386, 157, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-file-text\"></i> <span>Chính sách</span>\r\n                </a>\r\n            </li>\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1543, "\"", 1604, 1);
#line 36 "D:\Projects\Template_RealEstate_050602019\Template_RealEstate_20052019\Areas\BackEnd\Views\Shared\_Menu.cshtml"
WriteAttributeValue("", 1550, Url.Action("Index", "Contact", new { Area="Backend"}), 1550, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1605, 155, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-id-card\"></i> <span>Liên hệ</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </section>\r\n</aside>");
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
