using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class VentasLab
    {

        public VentasLab()
        {
            Pagos = new List<Pagos>();
        }
        public int Id { get; set; }
        public int? ExamenId {get;set;}
        public string Nit { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaVenta { get; set; }
        public string EmpleadoResponsable {get;set;}
        public decimal Vuelto {get;set;}
        public string FormaPago { get; set; }
        public bool Eliminado { get; set; }
        public decimal Total {get;set;}
        public decimal MontoPagado {get;set;}

        public Examen Examen {get;set;}
        public ICollection<Pagos> Pagos {get;set;}
        public ICollection<DetalleCajaLab> DetalleCajaLabs {get;set;}

    }
}