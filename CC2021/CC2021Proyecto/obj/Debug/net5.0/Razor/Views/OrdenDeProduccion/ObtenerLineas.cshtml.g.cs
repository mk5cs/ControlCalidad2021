#pragma checksum "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d36368204a971ee27ca6120491d85d49e57087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdenDeProduccion_ObtenerLineas), @"mvc.1.0.view", @"/Views/OrdenDeProduccion/ObtenerLineas.cshtml")]
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
#line 1 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\_ViewImports.cshtml"
using CC2021Proyecto.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d36368204a971ee27ca6120491d85d49e57087", @"/Views/OrdenDeProduccion/ObtenerLineas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6148a241c22896970c27e9263b5fd9370e164ade", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdenDeProduccion_ObtenerLineas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IReadOnlyList<Dominio.Entities.LineaDeTrabajo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrdenDeProduccion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IniciarNuevaOrden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""d-flex"">
    <div class='bg-primary' style='height: 91.3vh'>
        <nav>
            <div class=""container border-bottom border-light py-2"">
                <h5><a href=""./calidadHermanado.html"" class='nav-item text-decoration-none text-light'>Hermanado</a></h5>
            </div>
            <div class=""container border-bottom border-light py-2"">
                <h5><a href=""./calidadInspeccion.html"" class='nav-item text-decoration-none text-light'>Inspeccion</a></h5>
            </div>
        </nav>
    </div>

    <!--App-->
    <div class=""container text-center"">
        <h2 class='my-4'>Administrar ordenes de produccion</h2>
        <div class=""d-flex flex-column my-2"">
            <div class=""d-flex justify-content-start mb-2"">
                <button class=""btn btn-primary mr-3"">Visualizar Datos</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d36368204a971ee27ca6120491d85d49e570874551", async() => {
                WriteLiteral("<button class=\"btn btn-primary\">Iniciar orden de produccion</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""container border border-primary overflow-auto"" style=""height: 60vh"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col"">Numero</th>
                            <th scope=""col"">Modelo</th>
                            <th scope=""col"">Color</th>
                            <th scope=""col"">Estado</th>
                            <th scope=""col"">Supervisor Linea</th>
                            <th scope=""col"">Supervisor calidad </th>
                            <th scope=""col"">Reanudar</th>
                            <th scope=""col"">Pausar</th>
                            <th scope=""col"">Finalizar</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                     foreach (var linea in Model)
                    {
                        if (linea.OrdenesDeProduccion.Count > 0)
                        {
                            foreach (var orden in linea.OrdenesDeProduccion)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 46 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                               Write(linea.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                   Write(orden.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                   Write(orden.Modelo.Denominacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                   Write(orden.Color.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                   Write(orden.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                     if (orden.EmpleadoOrden == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td></td>\r\n");
#nullable restore
#line 54 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\"");
#nullable restore
#line 57 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                        Write(orden.EmpleadoOrden);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</td>");
#nullable restore
#line 57 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <td></td>
                                    <td></td>
                                    <td><button class=""btn btn-success btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-play-btn"" viewBox=""0 0 16 16"">
                                        <path d=""M6.79 5.093A.5.5 0 0 0 6 5.5v5a.5.5 0 0 0 .79.407l3.5-2.5a.5.5 0 0 0 0-.814l-3.5-2.5z""/>
                                        <path d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm15 0a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4z""/>
                                    </svg></button></td>
                                    <td><button class=""btn btn-warning btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-pause-btn"" viewBox=""0 0 16 16"">
                                        <path d=""M6.25 5C5.56 5 5 5.56 5 6.25v3.5a1.25 1.25 0 1 0 2.5 0v-3.5C7.5 5.56 6.94 ");
            WriteLiteral(@"5 6.25 5zm3.5 0c-.69 0-1.25.56-1.25 1.25v3.5a1.25 1.25 0 1 0 2.5 0v-3.5C11 5.56 10.44 5 9.75 5z""/>
                                        <path d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm15 0a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4z""/>
                                    </svg></button></td>
                                    <td><button class=""btn btn-danger btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-stop-circle"" viewBox=""0 0 16 16"">
                                        <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""/>
                                        <path d=""M5 6.5A1.5 1.5 0 0 1 6.5 5h3A1.5 1.5 0 0 1 11 6.5v3A1.5 1.5 0 0 1 9.5 11h-3A1.5 1.5 0 0 1 5 9.5v-3z""/>
                                    </svg></button></td>
                                </tr>
");
#nullable restore
#line 73 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 78 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                           Write(linea.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td></td>\r\n                                <td></td>\r\n                                <td></td>\r\n                                <td></td>\r\n");
#nullable restore
#line 83 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                 if (linea.Empleado == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td></td>\r\n");
#nullable restore
#line 86 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 89 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                   Write(linea.Empleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 90 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <td><button class=""btn btn-success btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-play-btn"" viewBox=""0 0 16 16"">
                                    <path d=""M6.79 5.093A.5.5 0 0 0 6 5.5v5a.5.5 0 0 0 .79.407l3.5-2.5a.5.5 0 0 0 0-.814l-3.5-2.5z""/>
                                    <path d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm15 0a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4z""/>
                                </svg></button></td>
                                <td><button class=""btn btn-warning btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-pause-btn"" viewBox=""0 0 16 16"">
                                    <path d=""M6.25 5C5.56 5 5 5.56 5 6.25v3.5a1.25 1.25 0 1 0 2.5 0v-3.5C7.5 5.56 6.94 5 6.25 5zm3.5 0c-.69 0-1.25.56-1.25 1.25v3.5a1.25 1.25 0 1 0 2.5 0v-3.5C11 5.56 10.44 5 9.75 5z""/>
                  ");
            WriteLiteral(@"                  <path d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm15 0a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v8a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4z""/>
                                </svg></button></td>
                                <td><button class=""btn btn-danger btn-sm""><svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""currentColor"" class=""bi bi-stop-circle"" viewBox=""0 0 16 16"">
                                    <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""/>
                                    <path d=""M5 6.5A1.5 1.5 0 0 1 6.5 5h3A1.5 1.5 0 0 1 11 6.5v3A1.5 1.5 0 0 1 9.5 11h-3A1.5 1.5 0 0 1 5 9.5v-3z""/>
                                </svg></button></td>
                            </tr>");
#nullable restore
#line 104 "C:\Users\USUARIO\source\repos\CC\CC2021\CC2021Proyecto\Views\OrdenDeProduccion\ObtenerLineas.cshtml"
                                 }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IReadOnlyList<Dominio.Entities.LineaDeTrabajo>> Html { get; private set; }
    }
}
#pragma warning restore 1591