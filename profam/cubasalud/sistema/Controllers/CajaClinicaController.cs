using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Shared.IRepository;
using sistema.Models;
using Database.Shared.Paginacion;
using System.Linq;
using Database.Shared.Models;
using Microsoft.AspNetCore.Authorization;

namespace sisrest.Controllers
{
    [Authorize(Roles = "Administrador, Cajero, Supervisor, Vendedor")]
public class CajaClinicaController : Controller
    {
        private readonly ICajaClinica _cajaClinicaRepository = null;

        public CajaClinicaController(ICajaClinica cajaClinicaRepository)
        {

            _cajaClinicaRepository = cajaClinicaRepository;

        }

        public IActionResult Aperturar()
        {

            var model = new CajaClinicaBaseViewModel()
            {
            };
            
            model.Init(_cajaClinicaRepository);


            return View(model);
        }

        [HttpPost]
        public IActionResult Aperturar(CajaClinicaBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                // var cajaAbierta = _cajaRepository.GetCajaAbierta();
                var cajita = _cajaClinicaRepository.ListarCajas();

                //verificar si no hay cajas abiertas

                if (cajita.Any(a => a.EstadoCaja == true))
                {
                    TempData["Message"] = "¡Error. Ya hay una caja abierta.!";
                    model.Init(_cajaClinicaRepository);
                    return RedirectToAction("Aperturar");
                }
                else
                {
                    var nuevaCaja = new CajaClinica()
                    {
                        MontoApertura = model.CajaClinica.MontoApertura,
                        FechaApertura = DateTime.Now,
                        EstadoCaja = true
                    };

                    _cajaClinicaRepository.Add(nuevaCaja);

                    model.Init(_cajaClinicaRepository);
                    return RedirectToAction("Aperturar");
                }
            }

            model.Init(_cajaClinicaRepository);
            return View(model);


        }

        public IActionResult Cerrar(CajaClinicaBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var caja = _cajaClinicaRepository.GetCaja(model.CajaClinica.Id);
                caja.EstadoCaja = false;
                caja.FechaCierre = DateTime.Now;

                _cajaClinicaRepository.Update(caja);

                model.Init(_cajaClinicaRepository);
                return RedirectToAction("Aperturar");

            }

            model.Init(_cajaClinicaRepository);
            return View(model);


        }

        public IActionResult VerDetalle(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var caja = _cajaClinicaRepository.GetCaja((int)id);

            if (caja == null)
            {
                return StatusCode(404);
            }

            var model = new CajaClinicaBaseViewModel()
            {
                CajaClinica = caja
            };

            return View(model);
        }

        public JsonResult GuardarIngreso(string monto, string descripcion)
        {

            if (monto != null && descripcion != null)
            {

                var cajaAbierta = _cajaClinicaRepository.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCajaClinica()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Ingreso = Convert.ToInt32(monto),
                    CajaClinica = cajaAbierta,
                };

                _cajaClinicaRepository.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El ingreso se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.CajaClinica.Id);


            }

            return Json("Ha ocurrido un error");

        }


        public JsonResult GuardarEgreso(string monto, string descripcion)
        {


            if (monto != null && descripcion != null)
            {
                var cajaAbierta = _cajaClinicaRepository.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCajaClinica()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Gasto = Convert.ToInt32(monto),
                    CajaClinica = cajaAbierta,
                };

                _cajaClinicaRepository.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El gasto se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.CajaClinica.Id);
            }

            return Json("Ha ocurrido un error");
        }



    }


}