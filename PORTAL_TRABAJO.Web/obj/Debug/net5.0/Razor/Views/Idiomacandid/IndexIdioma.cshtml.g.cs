#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea7230a0995371dc1e6aa6f5de43c1e7e9110cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idiomacandid_IndexIdioma), @"mvc.1.0.view", @"/Views/Idiomacandid/IndexIdioma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea7230a0995371dc1e6aa6f5de43c1e7e9110cc", @"/Views/Idiomacandid/IndexIdioma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Idiomacandid_IndexIdioma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PORTAL_TRABAJO.Web.Models.Idiomacandid>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
  
    ViewData["Title"] = "IndexIdioma";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""modalIdioma"">
    <button type=""button"" class=""btn btn-outline-primary"" id=""btnAddCandidatoExp"" data-toggle=""modal"" data-target=""#ModelIdioma"">
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""23"" height=""23"" fill=""currentColor"" class=""bi bi-plus-circle"" viewBox=""0 0 16 16"">
            <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
            <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"" />
        </svg>
    </button>
    <div class=""modal fade"" id=""ModelIdioma"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Registro</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;");
            WriteLiteral("</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>IDIOMA</label>\r\n");
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea7230a0995371dc1e6aa6f5de43c1e7e9110cc5211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 28 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdiomaId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 28 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdiomaId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label>NIVEL ORAL</label>\r\n");
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea7230a0995371dc1e6aa6f5de43c1e7e9110cc7445", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 34 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NiveloralidiId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.NiveloralidiId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <label>NIVEL ESCRITO</label>\r\n");
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea7230a0995371dc1e6aa6f5de43c1e7e9110cc9797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 43 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NivescridId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 43 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Idiomacandid\IndexIdioma.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.NivescridId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                    </div>
                    <br />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                    <button type=""button"" id=""btnGuardarIdioma"" class=""btn btn-primary"">Guardar </button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""containerIdioma"" style=""border:1px solid #1582d1"">
    <div class=""row justify-content-center"">
        <h3>IDIOMAS</h3>
    </div>
    <hr style=""border:1px solid #1582d1"" />
    <div id=""divIdioma"" class="" justify-content-center"">

    </div>

</div>


<input type=""hidden"" id=""hidIDIdioma"" value=""-1"" />

<script>

    //$(""#divIdioma"").on('click', '.btnUpdateIdioma', function () {
    //    let vIDIdiomaC = $(this).attr('data-id');
    //    $(""#hidIDIdioma"").val(vIDIdiomaC);
    //    let modalRegistro = $(""#ModelIdioma"");

    /");
            WriteLiteral(@"/    $.ajax({
    //        type: ""GET"",
    //        url: ""Obtener"",
    //        cache: false,
    //        data: { id: vIDIdiomaC },
    //        success: function (objIdioma) {

    //            $(""#IdiomaId"").val(objIdioma.idioma);
    //            $(""#NiveloralidiId"").val(objIdioma.NivOral);
    //            $(""#NivescridId"").val(objIdioma.NivEscr);

    //            modalRegistro.modal();
    //            /*modalRegistro.find(""#modalIdioma"".html(""Editar""));*/
    //        }
    //    });
    //});
    CargarListaIdiomaCandid();
    function CargarListaIdiomaCandid() {
        $.ajax({
            type: ""GET"",
            url: ""ListadoIdioma"",
            cache: false,
            success: function (dataHtml) {
                $(""#divIdioma"").html(dataHtml);
            }

        });

    }

    $(""#divIdioma"").on('click', '.btnRemoveIdioma', function () {
        let vIDIdiomaC = $(this).attr('data-id');

        if (confirm(""??Est?? seguro de eliminar este idi");
            WriteLiteral(@"oma?"")) {

            $.ajax({
                type: ""POST"",
                url: ""Eliminar"",
                cache: false,
                data: { id: vIDIdiomaC },
                success: function (exito) {
                    if (exito) {
                        CargarListaIdiomaCandid();
                    } else {
                        alert(""Ocurri?? un error al eliminar el cliente...."");
                    }
                }
            });
        }

    });

    $(""#btnGuardarIdioma"").click(function () {

        let vIDIdiomaC = $(""#hidIDIdioma"").val();

        let vIdioma = $(""#IdiomaId"").val();
        let vNivOral = $(""#NiveloralidiId"").val();
        let vNivEscr = $(""#NivescridId"").val();




        $.ajax({
            type: ""POST"",
            url: ""IndexIdioma"",
            cache: false,
            data: {
                id: vIDIdiomaC,

                idioma: vIdioma,
                NivOral: vNivOral,
                NivEscr: vNivEscr,

");
            WriteLiteral(@"

            },
            success: function (exito) {
                if (exito) {
                    alert(""Se registr?? correctamente"")
                    CargarListaIdiomaCandid();
                    $(""#ModelIdioma"").modal(""toggle"");

                } else {
                    alert(""Ocurri?? un error en la transacci??n"")
                }
            }
        });

    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PORTAL_TRABAJO.Web.Models.Idiomacandid> Html { get; private set; }
    }
}
#pragma warning restore 1591
