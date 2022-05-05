using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Shared.IRepository;
using sistema.Models;
using Database.Shared.Paginacion;
using System.Linq;
using Database.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace sisrest.Controllers
{
    [Authorize(Roles = "Administrador, Cajero, Supervisor, Vendedor")]
    public class CajaController : Controller
    {
        private readonly ICaja _cajaRepository = null;
        private readonly UserManager<User> _userManager = null;
        private readonly IGeneratePdf _generatePdf;

        public CajaController(ICaja cajaRepository, UserManager<User> userManager, IGeneratePdf generatePdf)
        {

            _cajaRepository = cajaRepository;
            _userManager = userManager;
            _generatePdf = generatePdf;

        }

        public IActionResult Aperturar()
        {
            var model = new CajaBaseViewModel();
            model.Init(_cajaRepository);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Aperturar(CajaBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                // var cajaAbierta = _cajaRepository.GetCajaAbierta();
                var cajita = _cajaRepository.ListarCajas();

                //verificar si no hay cajas abiertas

                if (cajita.Any(a => a.EstadoCaja == true))
                {
                    TempData["Message"] = "¡Error. Ya hay una caja abierta.!";
                    model.Init(_cajaRepository);
                    return RedirectToAction("Aperturar");
                }
                else
                {
                    var user = await _userManager.GetUserAsync(HttpContext.User);

                    var nuevaCaja = new Caja()
                    {
                        MontoApertura = model.Caja.MontoApertura,
                        FechaApertura = DateTime.Now,
                        EstadoCaja = true,
                        ResponsableApertura = user,
                    };

                    _cajaRepository.Add(nuevaCaja);

                    model.Init(_cajaRepository);
                    return RedirectToAction("Aperturar");
                }
            }

            model.Init(_cajaRepository);
            return View(model);


        }

        public async Task<IActionResult> Cerrar(CajaBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                var caja = _cajaRepository.GetCaja(model.Caja.Id);
                caja.EstadoCaja = false;
                caja.FechaCierre = DateTime.Now;
                caja.ResponsableCierre = user;

                _cajaRepository.Update(caja);

                model.Init(_cajaRepository);
                return RedirectToAction("Aperturar");

            }

            model.Init(_cajaRepository);
            return View(model);


        }

        public IActionResult VerDetalle(int? id)
        {

            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var caja = _cajaRepository.GetCaja((int)id);

            if (caja == null)
            {
                return StatusCode(404);
            }

            var model = new CajaBaseViewModel()
            {
                Caja = caja
            };

            return View(model);
        }

        public JsonResult GuardarIngreso(string monto, string descripcion)
        {

            if (monto != null && descripcion != null)
            {

                var cajaAbierta = _cajaRepository.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCaja()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Ingreso = Convert.ToInt32(monto),
                    Caja = cajaAbierta,
                };

                _cajaRepository.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El ingreso se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.Caja.Id);


            }

            return Json("Ha ocurrido un error");

        }


        public JsonResult GuardarEgreso(string monto, string descripcion)
        {


            if (monto != null && descripcion != null)
            {
                var cajaAbierta = _cajaRepository.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCaja()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Gasto = Convert.ToInt32(monto),
                    Caja = cajaAbierta,
                };

                _cajaRepository.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El gasto se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.Caja.Id);
            }

            return Json("Ha ocurrido un error");
        }


        public async Task<IActionResult> Reporte(string fecha)
         {
            var fechas = fecha.Split('-');
            var  cajas = _cajaRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));

            var model = new ReporteCajaFarmaciaViewModel()
            {
                Cajas = cajas,
                Desde = fechas[0],
                Hasta = fechas[1],
            };
            
            return await _generatePdf.GetPdf("Views/Caja/Reporte.cshtml", model);
        }

        public async Task<IActionResult> ReporteDetalle(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var caja = _cajaRepository.GetCaja((int)id);

            if (caja == null)
            {
                return StatusCode(404);
            }

            var model = new CajaBaseViewModel()
            {
                Caja = caja
            };
            
            return await _generatePdf.GetPdf("Views/Caja/ReporteDetalle.cshtml", model);
        }


        public JsonResult EliminarDetalle(int detalleId)
        {
            _cajaRepository.DeleteDetalleCaja(detalleId);
            TempData["Message"] = "¡El registro se ha eliminado con éxito.!";

            return Json(new object());
        }
    }


}