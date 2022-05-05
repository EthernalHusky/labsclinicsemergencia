using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class CajaClinica
    {
        public CajaClinica()
        {
            DetalleCajaClinicas = new List<DetalleCajaClinica>();
        }

        public int Id { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal MontoApertura {get;set;}
        public DateTime FechaApertura {get;set;}
        public DateTime? FechaCierre {get;set;}
        public bool EstadoCaja {get;set;}
        public ICollection<DetalleCajaClinica> DetalleCajaClinicas {get;set;}
    }
}