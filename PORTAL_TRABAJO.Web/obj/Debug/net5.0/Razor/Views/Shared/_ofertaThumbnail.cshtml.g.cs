#pragma checksum "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaca94940d3b970ccd48f3ac5065fd2740cea515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ofertaThumbnail), @"mvc.1.0.view", @"/Views/Shared/_ofertaThumbnail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaca94940d3b970ccd48f3ac5065fd2740cea515", @"/Views/Shared/_ofertaThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da76d5650e6113913b2209febfc5ae11f2b8128", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ofertaThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ofertalaboral>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "ofertaDetailsRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mb-4 shadow-sm\">\r\n");
            WriteLiteral("    <div class=\"card-body\">\r\n        <h4 class=\"card-title\"style=\"color:blue\">");
#nullable restore
#line 9 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                             Write(string.IsNullOrEmpty(Model.Titulooferta) ? "Name is not available" : Model.Titulooferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                         Write(string.IsNullOrEmpty(Model.Detalleoferta) ? "Description is not availabe": Model.Detalleoferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"d-flex justify-content-between align-items-center\">\r\n            <div class=\"btn-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaca94940d3b970ccd48f3ac5065fd2740cea5154924", async() => {
                WriteLiteral("View details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <small class=\"text-muted\">Publicado el ");
#nullable restore
#line 16 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                               Write(string.IsNullOrEmpty(Model.Fechapublicacion.ToString()) ? "NA" : Model.Fechapublicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\r\n            <small class=\"text-muted\" >Publicado el ");
#nullable restore
#line 18 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                               Write(Html.ValueFor(modelItem => Model.Fechapublicacion, "{0:dd/MM/yyyy}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
              
                int jornada = Model.Jornada.Id;


            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
             if (jornada == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <small class=\"text-primary\" id=\"txtJornada\"  >");
#nullable restore
#line 26 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                                         Write(Model.Jornada.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 27 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <small class=\"text-danger\" id=\"txtJornada\" >");
#nullable restore
#line 30 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
                                               Write(Model.Jornada.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n");
#nullable restore
#line 31 "C:\Users\User\source\repos\PORTAL_TRABAJO\PORTAL_TRABAJO.Web\Views\Shared\_ofertaThumbnail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
