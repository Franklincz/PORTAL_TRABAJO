#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4605578c1fc4390619a3680c4186ec37118e254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idiomacandid_ListadoIdioma), @"mvc.1.0.view", @"/Views/Idiomacandid/ListadoIdioma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4605578c1fc4390619a3680c4186ec37118e254", @"/Views/Idiomacandid/ListadoIdioma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Idiomacandid_ListadoIdioma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Idiomacandid>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
  
    ViewData["Title"] = "IndexIdioma";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"divIdioma\">\r\n");
#nullable restore
#line 7 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-white bg-warning mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Idioma.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>NIVEL ORAL:</p>   <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Niveloralidi.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>NIVEL ESCRITO:</p> <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Nivescrid.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
            WriteLiteral("                <button type=\"button\" class=\"btn btn-outline-primary  btnRemoveIdioma\" data-id=\"");
#nullable restore
#line 21 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
                                                                                           Write(item.Ididioma);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    ELIMINAR
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-trash-fill"" viewBox=""0 0 16 16"">
                        <path d=""M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"" />
                    </svg>
                </button>

            </div>
        </div>
");
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\ListadoIdioma.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Idiomacandid>> Html { get; private set; }
    }
}
#pragma warning restore 1591
