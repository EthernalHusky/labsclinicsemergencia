using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class Cotizacion
    {

        public Cotizacion()
        {
            DetalleCotizacion = new List<DetalleCotizacion>();
        }   

        public int Id { get; set; }
        // public int? EmpleadoId {get;set;}
        public string Nit {get; set;}
        public string Nombres {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get;set;}

        public int? EnvioId {get;set;}
        public DateTime? FechaCotizacion {get;set;}
        public DateTime? FechaValida {get;set;}
        public bool Eliminado {get; set;}
        public bool Confirmado {get; set;}
        public string TipoVenta {get;set;}

        // public Empleado Empleado {get;set;}

        public ICollection<DetalleCotizacion> DetalleCotizacion {get;set;}

    }
}