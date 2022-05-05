using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class DetalleCajaClinica
    {

        public int Id { get; set; }
        public int? VentaId {get;set;}
        public int? CompraId {get;set;}
        public int? VentaServicioId {get;set;}
        public int CajaClinicaId {get;set;}
        public string Descripcion {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Gasto {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Ingreso {get;set;}
        public DateTime Fecha {get;set;}

        public Venta Venta {get;set;}
        public Compra Compra{get;set;}
        public VentaServicio VentaServicio {get;set;}
        public CajaClinica CajaClinica {get;set;}

    }
}