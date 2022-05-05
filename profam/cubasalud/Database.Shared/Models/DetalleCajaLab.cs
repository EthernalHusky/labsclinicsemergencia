using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class DetalleCajaLab
    {

        public int Id { get; set; }
        public int? VentasLabId {get;set;}
        public int? CajaLabId {get;set;}
        public string Descripcion {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Gasto {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Ingreso {get;set;}
        public DateTime Fecha {get;set;}

        public VentasLab VentasLab {get;set;}
        public CajaLab CajaLab {get;set;}

    }
}