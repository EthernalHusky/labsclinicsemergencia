#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a77420833bd3f4d34bb089f29bd38c853737070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_VentasPorMesesFarmacia), @"mvc.1.0.view", @"/Views/Dashboard/VentasPorMesesFarmacia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a77420833bd3f4d34bb089f29bd38c853737070", @"/Views/Dashboard/VentasPorMesesFarmacia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_VentasPorMesesFarmacia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ChartsBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
  
    ViewData["Title"] = "Ventas por meses";
    var meses = String.Join(",", Model.Meses).ToUpperInvariant();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<br />

<br />

<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">
            <canvas id=""myChart"" width=""400"" height=""100""></canvas>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.min.js"" integrity=""sha512-d9xgZrVZpmmQlfonhQUvTR7lMPtO7NkZMkA0ABN3PHCbKA5nqylQ/yWlFAyY6hYgdF1Qh6nYiuADWwKB4C2WSw=="" crossorigin=""anonymous""></script>

    <script>
var ctx = document.getElementById('myChart').getContext('2d');

var meses = new Array();
var ingresos = new Array();

");
#nullable restore
#line 31 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
 foreach(var item in @Model.Meses)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                WriteLiteral("meses.push(\"");
#nullable restore
#line 33 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
             Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n");
#nullable restore
#line 34 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 36 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
 foreach(var item in @Model.IngresoPorMes)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                WriteLiteral("ingresos.push(\"");
#nullable restore
#line 38 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
                Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n");
#nullable restore
#line 39 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Dashboard/VentasPorMesesFarmacia.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
var myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: meses,
        datasets: [{
            label: 'Ventas por mes',
            data: ingresos,
            backgroundColor: [
                'rgba(245, 90, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(78, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(78, 159, 64, 0.2)',
                'rgba(78, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(78, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(78, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)',
                'rgba(");
                WriteLiteral(@"255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ChartsBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
