#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\Principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3326a240f0057d5eb738da5837d5123576df03ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ofertalaboral_Principal), @"mvc.1.0.view", @"/Views/Ofertalaboral/Principal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3326a240f0057d5eb738da5837d5123576df03ad", @"/Views/Ofertalaboral/Principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Ofertalaboral_Principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ofertalaboral>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control border-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Presencial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Semipresencial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Virtual", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<div class=""alert alert-warning"" role=""alert"">

    <div class="" row"">
        <div class=""col-md-7"">
            <h3>
                Registro de  Oferta Laboral
            </h3>

        </div>
        <div class=""col-md-5"">
            <button id=""btnRegistrarOferta""
                    class="" btn btn-secondary"">

                Registrar
            </button>

        </div>
    </div>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""modalRegistrOfertaLaboral"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"" role=""document"">

        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel""></h5>
                <div class=""col"">
                    <p class=""text-center font-weight-bold"">T??tulo</p>
                    <input type=""text"" class="" form-control border-primary"" id=""txtTitulo"" />
                </div>


                <b");
            WriteLiteral(@"utton type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <div class="" container-fluid"">

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Descripci??n del puesto</p>

                                <textarea class=""form-control border-primary"" id=""txtDescripcionpuesto"" rows=""3""></textarea>
                            </div>

                        </div>

                        <div class=""col-md-3"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Inicio de postulaci??n</p>
                                <input type=""date"" id=""txtFechaIn"" name=""trip-start""
                                       value");
            WriteLiteral(@"=""2021-07-10""
                                       min=""2021-07-10"" max=""2021-12-31"">
                            </div>

                        </div>

                        <div class=""col-md-3"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Fin de postulaci??n</p>
                                <input type=""date"" id=""txtFechaF"" name=""trip-start""
                                       value=""2021-07-10""
                                       min=""2021-01-01"" max=""2021-12-31"">
                            </div>

                        </div>

                    </div>




                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Detalle de la oferta</p>
                                <textarea class=""form-control border-primary"" id=""txtDetalle"" rows=""3""></textarea>
    ");
            WriteLiteral(@"                        </div>

                        </div>
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Lugar</p>
                                <input type=""text"" class="" form-control border-primary"" id=""txtLugar"" />
                            </div>

                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Perfil del candidato</p>
                                <textarea class=""form-control border-primary"" id=""txtPerfil"" rows=""3""></textarea>
                            </div>

                        </div>


                        <div class="" col-md-3"">

                            <p class=""input-group-text font-weight-bold"" for=""inputGroupSelect01"">Jornada</p");
            WriteLiteral(">\r\n                        </div>\r\n\r\n                        <div class=\"col-md-3\">\r\n");
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3326a240f0057d5eb738da5837d5123576df03ad9185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 128 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\Principal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JornadaId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 128 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Ofertalaboral\Principal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.EstadocivilIdestciv;

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

                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Requisitos</p>
                                <textarea class=""form-control border-primary"" id=""txtRequisitos"" rows=""3""></textarea>
                            </div>

                        </div>
                        <div class=""col-md-6"">
                            <p class=""font-weight-bold"">Salario</p>
                            <div class=""input-group"">

                                <input type=""text"" class=""form-control border-primary"" id=""txtSalario"" aria-label="" Sol amount (with dot and two decimal places)"">
                                <span class=""input-group-text"">S/.</span>
                            </div>
                        </div>

                    </div>


                    <div cla");
            WriteLiteral(@"ss=""row"">
                        <div class=""col-md-6"">
                            <div class="" form-group"">
                                <p class=""font-weight-bold"">Beneficios</p>
                                <textarea class=""form-control border-primary"" id=""txtBeneficios"" rows=""3""></textarea>

                            </div>

                        </div>


                        <div class="" col-md-3"">

                            <p class=""font-weight-bold"">Modalidad</p>
                        </div>

                        <div class=""col-md-3"">
                            <select class=""form-select border-primary"" id=""txtModalidad"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3326a240f0057d5eb738da5837d5123576df03ad13046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3326a240f0057d5eb738da5837d5123576df03ad14307", async() => {
                WriteLiteral("Presencial");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3326a240f0057d5eb738da5837d5123576df03ad15503", async() => {
                WriteLiteral("Semipresencial");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3326a240f0057d5eb738da5837d5123576df03ad16703", async() => {
                WriteLiteral("Virtual");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>




                    </div>




                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""d-grid gap-9 col-3 mx-auto"">

                    <button type=""button"" class=""btn btn-success"" id=""btnCrearOferta"">Crear Oferta</button>


                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" aria-label=""Cancelar""> Cancelar</button>


                </div>
            </div>
        </div>
    </div>
</div>





<input type=""hidden"" id="" = hidIDRegistro"" value="" -1"" />


<hr />

<div id=""divListadoRegistroOferta"">

    <!---la lista de ofertas del admi logueado-->
</div>


<script>

    CargarListaIOfertas();

    function CargarListaIOfertas() {
        $.ajax({
            type: ""GET"",
            url: ""MisOfertas"",
            cache: false,
            success: function (dataHtml) {
                $(""#divLis");
            WriteLiteral(@"tadoRegistroOferta"").html(dataHtml);
            }

        });

    }














    $(""#btnCrearOferta"").click(function () {

        let vIDRegistro = $(""#hidIDRegistro"").val();
        let vTitulo = $(""#txtTitulo"").val();
        let vDescripcionpuesto = $(""#txtDescripcionpuesto"").val();
        let vDetalle = $(""#txtDetalle"").val();
        let vPerfil = $(""#txtPerfil"").val();
        let vRequisitos = $(""#txtRequisitos"").val();
        let vBeneficios = $(""#txtBeneficios"").val();
        let vLugar = $(""#txtLugar"").val();

        let vSalario = $(""#txtSalario"").val();
        let vModalidad = $(""#txtModalidad"").val();
        let vFechIni = $(""#txtFechaIn"").val();
        let vFechFin = $(""#txtFechaF"").val();
        let vIdJornada = $(""#JornadaId"").val();



        $.ajax({

            type: ""POST"",
            url: ""Crear"",
            cache: false,
            data: {
                idRegistro: vIDRegistro,
                Titulo: vTitulo,
       ");
            WriteLiteral(@"         Descripcionpuesto: vDescripcionpuesto,
                Detalle: vDetalle,
                Perfil: vPerfil,
                Requisitos: vRequisitos,
                Beneficios: vBeneficios,
                Lugar: vLugar,
                Jornada: vIdJornada,
                Salario: vSalario,
                Modalidad: vModalidad,
                FechaInicio: vFechIni,
                FechaFin: vFechFin,


            },

            success: function (exito) {
                if (exito) {

                    swal(""Se registr?? correctamente!"")

                    CargarListaIOfertas()

                    $(""#modalRegistrOfertaLaboral"").modal(""toggle"");
                } else {

                    alert("" Error al registrar oferta laboral"")
                }

            }


        });

    });

    $(""#btnRegistrarOferta"").click(function () {

        $(""#modalRegistrOfertaLaboral"").modal();
    });

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ofertalaboral> Html { get; private set; }
    }
}
#pragma warning restore 1591
