using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Pagos
    {
        public int Id { get; set; }

        public int? VentaId {get; set;}
        public int? VentaLabId {get;set;}
        public int FormaPagoId { get; set; }
        
        [Column(TypeName="decimal(18,2)")]
        public decimal Monto { get; set; }
        public FormaPago FormaPago {get; set;}

        public Venta Venta {get; set;}
        public VentasLab VentaLab {get; set;}



    }
}