#pragma checksum "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d383bf0c6184b9c4352e7da1405f7b420288ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CajaClinica_Aperturar), @"mvc.1.0.view", @"/Views/CajaClinica/Aperturar.cshtml")]
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
#line 1 "/root/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d383bf0c6184b9c4352e7da1405f7b420288ad", @"/Views/CajaClinica/Aperturar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CajaClinica_Aperturar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaClinicaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CajaClinica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aperturar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tempusdominus-bootstrap-4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/daterangepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    <div class=\"form-row\">\n           \n                <div class=\"col-md-6\">\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d383bf0c6184b9c4352e7da1405f7b420288ad7339", async() => {
                WriteLiteral(@"
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">

                            <div class=""text-center"">
                                <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 617, "\"", 625, 0);
                EndWriteAttribute();
                WriteLiteral(">Monto Apertura</label>\n                                    ");
#nullable restore
#line 18 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                               Write(Html.TextBoxFor(a => a.CajaClinica.MontoApertura, new {@class="form-control", @placeholder="Monto a Aperturar"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
#nullable restore
#line 19 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                               Write(Html.ValidationMessageFor(a => a.CajaClinica.MontoApertura, "", new { @class = "text-danger"}));

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
            WriteLiteral("\n                </div>\n\n           \n\n          \n                <div class=\"col-md-6\">\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d383bf0c6184b9c4352e7da1405f7b420288ad10681", async() => {
                WriteLiteral(@"
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">

                            <div class=""text-center"">
                                <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 1618, "\"", 1626, 0);
                EndWriteAttribute();
                WriteLiteral(@">Rango de fechas</label>
                                   <div class=""input-group"">
                            <input type=""text"" class=""form-control float-right"" id=""reservationtime"" name=""fecha"">
                           </div>
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-primary text-center"">Generar Pdf</button>

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("               <th>Acciones</th>\n\n                                                    </tr>\n                                                    </thead>\n                                                    <tbody>\n");
#nullable restore
#line 79 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                         foreach(var item in Model.ListaCajas)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                             if(item.EstadoCaja == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr class=\"bg-success\">\n                                                                     <td>");
#nullable restore
#line 84 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                    Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 85 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 86 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaClinicas.Sum(x=>x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 87 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaClinicas.Sum(x=>x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 89 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajaClinicas.Sum(x=>x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;

                                                                        decimal res= suma1 + montoap;


                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 98 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4925, "\"", 4992, 1);
#nullable restore
#line 100 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
WriteAttributeValue("", 4932, Url.Action("VerDetalle","CajaClinica", new {id = @item.Id}), 4932, 60, false);

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
#line 106 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                            }
                                                            else 
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\n                                                                    <td>");
#nullable restore
#line 110 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 111 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 112 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaClinicas.Sum(x=>x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 113 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(item.DetalleCajaClinicas.Sum(x=>x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    \n");
#nullable restore
#line 115 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajaClinicas.Sum(x => x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;

                                                                        decimal res= suma1 + montoap;
                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 122 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 6900, "\"", 6967, 1);
#nullable restore
#line 124 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
WriteAttributeValue("", 6907, Url.Action("VerDetalle","CajaClinica", new {id = @item.Id}), 6907, 60, false);

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
#line 130 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "/root/profam/cubasalud/sistema/Views/CajaClinica/Aperturar.cshtml"
                                                             
                                                   
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d383bf0c6184b9c4352e7da1405f7b420288ad23721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d383bf0c6184b9c4352e7da1405f7b420288ad24887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d383bf0c6184b9c4352e7da1405f7b420288ad26053", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d383bf0c6184b9c4352e7da1405f7b420288ad27837", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CajaClinicaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
