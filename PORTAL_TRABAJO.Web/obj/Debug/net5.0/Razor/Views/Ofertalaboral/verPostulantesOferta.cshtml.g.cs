#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4ad566a05a3f6ec20dd20e73ebffa7881509dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ofertalaboral_verPostulantesOferta), @"mvc.1.0.view", @"/Views/Ofertalaboral/verPostulantesOferta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ad566a05a3f6ec20dd20e73ebffa7881509dcf", @"/Views/Ofertalaboral/verPostulantesOferta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Ofertalaboral_verPostulantesOferta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Detpostuof>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "verPostulantesOferta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-overlay rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imagenCandidato"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Postulaciones</h1>\r\n\r\n\r\n<h2 id=\"txtNropostulaciones\">Hay ");
#nullable restore
#line 17 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                            Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" postulaciones </h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4ad566a05a3f6ec20dd20e73ebffa7881509dcf5433", async() => {
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Filtro:<input type=\"text\"  name=\"searchString\"");
                BeginWriteAttribute("value", " value=\"", 325, "\"", 359, 1);
#nullable restore
#line 22 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
WriteAttributeValue("", 333, ViewData["CurrentFilter"], 333, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            <input type=\"submit\" value=\"Buscar\" class=\"btn btn-default\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4ad566a05a3f6ec20dd20e73ebffa7881509dcf6331", async() => {
                    WriteLiteral("Todos los registros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<!--<-->");
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
 foreach (var item in Model)
{


    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 62 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                           Write(item.CandidatoIdcandidatNavigation.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                                                                       Write(item.CandidatoIdcandidatNavigation.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h5>\r\n\r\n\r\n        <div class=\"card-body\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4ad566a05a3f6ec20dd20e73ebffa7881509dcf10113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 67 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                                                                                                  WriteLiteral("~/Images/"+ item.CandidatoIdcandidatNavigation.Foto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"align-content-sm-center\" id=\"txtDestele\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 69 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                                  Write(item.CandidatoIdcandidatNavigation.Descrpperfil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 70 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"
                                Write(item.CandidatoIdcandidatNavigation.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n\r\n            <a href=\"#\" class=\"btn btn-primary\" ");
            WriteLiteral(" id=\"irPerfil\">Ir a  perfil</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\verPostulantesOferta.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Detpostuof>> Html { get; private set; }
    }
}
#pragma warning restore 1591
