#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0037992b15612178cb78241bc4ec43d082f8eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LaboratorioClinico_Aperturar), @"mvc.1.0.view", @"/Views/LaboratorioClinico/Aperturar.cshtml")]
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
#line 1 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0037992b15612178cb78241bc4ec43d082f8eb8", @"/Views/LaboratorioClinico/Aperturar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_LaboratorioClinico_Aperturar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaLaboratorioBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LaboratorioClinico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aperturar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Caja", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reporte", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tempusdominus-bootstrap-4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/daterangepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n ");
#nullable restore
#line 6 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <div class=\"form-row\">\n                <div class=\"col-md-6\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0037992b15612178cb78241bc4ec43d082f8eb87859", async() => {
                WriteLiteral(@"
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">

                            <div class=""text-center"">
                                <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 611, "\"", 619, 0);
                EndWriteAttribute();
                WriteLiteral(">Monto Apertura</label>\n                                    ");
#nullable restore
#line 17 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                               Write(Html.TextBoxFor(a => a.CajaLab.MontoApertura, new {@class="form-control", @placeholder="Monto a Aperturar"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
#nullable restore
#line 18 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                               Write(Html.ValidationMessageFor(a => a.CajaLab.MontoApertura, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-primary text-center"">Abrir caja</button>
                        </div>
                    </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n\n\n            \n                <div class=\"col-md-6\">\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0037992b15612178cb78241bc4ec43d082f8eb811285", async() => {
                WriteLiteral(@"
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">

                            <div class=""text-center"">
                                <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 1603, "\"", 1611, 0);
                EndWriteAttribute();
                WriteLiteral(@">Rango de fechas</label>
                                   <div class=""input-group"">
                            <input type=""text"" class=""form-control float-right"" id=""reservationtime"" name=""fecha"">
                           </div>
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-primary text-center"" >Generar PDF</button>
                        </div>
                    </div>
                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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



<div class=""form-row"">
 <div class=""col-md-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        
                        <div class=""form-row"">
                            <div class=""col-md-12"">
                                            <div class=""table-responsive"">
                                                <table class=""mb-0 table table-hover "">
                                                    <thead>
                                                    <tr>
                                                        <th>Fecha Apertura</th>
                                                        <th>Monto Apertura</th>
                                                        <th>Gastos</th>
                                                        <th>Ingresos</th>
                                                        <th>Total Cierre</th>
                                         ");
            WriteLiteral(@"               <th>Resp. Apertura</th>
                                                        <th>Resp. Cierre</th>
                                                    <th>Acciones</th>

                                                    </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 77 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                         foreach(var item in Model.ListaCajas)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                             if(item.EstadoCaja == true)
                                                            {
                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                                                                                                              
                                                                
                                                                var personaApertura = "";
                                                                var personaCierre = "";

                                                                if(item.ResponsableAperturaLab != null)
                                                                {
                                                                    if(item.ResponsableAperturaLab.Persona != null)
                                                                    {
                                                                        personaApertura = item.ResponsableAperturaLab.Persona.Nombre;
                                                                    }
                                                                }

                                                                if(item.ResponsableCierreLab != null)
                                                                {
                                                                    if(item.ResponsableCierreLab.Persona != null)
                                                                    {
                                                                        personaApertura = item.ResponsableCierreLab.Persona.Nombre;
                                                                    }
                                                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr class=\"bg-success\">\n                                                                    <td>");
#nullable restore
#line 104 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 105 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 106 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaLabs.Sum(x => x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 107 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaLabs.Sum(x => x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 109 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajaLabs.Sum(x=>x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;

                                                                        decimal res= suma1 + montoap;
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 116 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 117 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(personaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 118 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(personaCierre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7055, "\"", 7129, 1);
#nullable restore
#line 120 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
WriteAttributeValue("", 7062, Url.Action("VerDetalle","LaboratorioClinico", new {id = @item.Id}), 7062, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning btn-sm"">
                                                                            Ver Detalle
                                                                        </a>
                                                                    </td>
                                                                </tr>
");
#nullable restore
#line 125 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                            }
                                                            else 
                                                            {
                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                                                                                                           

                                                                var personaApertura = "";
                                                                var personaCierre = "";

                                                                if(item.ResponsableAperturaLab != null)
                                                                {
                                                                    if(item.ResponsableAperturaLab.Persona != null)
                                                                    {
                                                                        personaApertura = item.ResponsableAperturaLab.Persona.Nombre;
                                                                    }
                                                                }

                                                                if(item.ResponsableCierreLab != null)
                                                                {
                                                                    if(item.ResponsableCierreLab.Persona != null)
                                                                    {
                                                                        personaApertura = item.ResponsableCierreLab.Persona.Nombre;
                                                                    }
                                                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\n                                                                    <td>");
#nullable restore
#line 151 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 152 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 153 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaLabs.Sum(x=>x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 154 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaLabs.Sum(x=>x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 155 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajaLabs.Sum(x=>x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;
                                                                        decimal res= suma1 + montoap;
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 161 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 162 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(personaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 163 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                                   Write(personaCierre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 10812, "\"", 10880, 1);
#nullable restore
#line 165 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
WriteAttributeValue("", 10819, Url.Action("LaboratorioClinico","Caja", new {id = @item.Id}), 10819, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning btn-sm"">
                                                                            Ver Detalle
                                                                        </a>
                                                                        
                                                                    </td>
                                                                </tr>
");
#nullable restore
#line 171 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/Aperturar.cshtml"
                                                             
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
            </div>
                               
                            </div>
                        </div>
                        
                    </div>

                </div>
            </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0037992b15612178cb78241bc4ec43d082f8eb830583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0037992b15612178cb78241bc4ec43d082f8eb831749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0037992b15612178cb78241bc4ec43d082f8eb832915", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script>
   $(function(){
        $('.select2').select2({
            tags: true
        });
        
    $('.select2bs4').select2({
      theme: 'bootstrap4',
      tags: true,
    });

          $('#reservationtime').daterangepicker({
                    timePicker: true,
                    timePickerIncrement: 30,
                    locale: {
                        format: 'MM/DD/YYYY hh:mm A'
                    }
                });
             
    });


    
</script>
");
            }
            );
            WriteLiteral("\n");
            DefineSection("css", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0037992b15612178cb78241bc4ec43d082f8eb834713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CajaLaboratorioBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
