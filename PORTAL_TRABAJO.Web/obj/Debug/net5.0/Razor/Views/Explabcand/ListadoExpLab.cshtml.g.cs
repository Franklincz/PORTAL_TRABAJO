#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7829e181643ee5b90d48b49af8f58b5adb9047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Explabcand_ListadoExpLab), @"mvc.1.0.view", @"/Views/Explabcand/ListadoExpLab.cshtml")]
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
#line 1 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\_ViewImports.cshtml"
using PORTAL_TRABAJO.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\_ViewImports.cshtml"
using PORTAL_TRABAJO.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7829e181643ee5b90d48b49af8f58b5adb9047", @"/Views/Explabcand/ListadoExpLab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Explabcand_ListadoExpLab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Explabcand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"divFormAcad\">\r\n");
#nullable restore
#line 7 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card w-75  \">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\"> ");
#nullable restore
#line 12 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Empresaexp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">    ");
#nullable restore
#line 13 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Giroempresa.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">  ");
#nullable restore
#line 14 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Empresaexp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">  ");
#nullable restore
#line 15 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Areatrabajo.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <p class=\"card-text\">   ");
#nullable restore
#line 17 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">   ");
#nullable restore
#line 18 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n                <button type=\"button\" class=\"btn btn-outline-primary btnUpdateExpL\" data-id=\"");
#nullable restore
#line 22 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                                                                        Write(item.Idexplabcand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-pencil-fill"" viewBox=""0 0 16 16"">
                        <path d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"" />
                    </svg>
                </button>
                <button type=""button"" class=""btn btn-outline-primary  btnRemoveExpL"" data-id=""");
#nullable restore
#line 27 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
                                                                                         Write(item.Idexplabcand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-trash-fill"" viewBox=""0 0 16 16"">
                        <path d=""M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"" />
                    </svg>
                </button>

            </div>
        </div>
");
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 37 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Explabcand\ListadoExpLab.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Explabcand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
