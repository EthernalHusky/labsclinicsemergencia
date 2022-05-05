using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class CajaLab
    {
        public CajaLab()
        {
            DetalleCajaLabs = new List<DetalleCajaLab>();
        }

        public int Id { get; set; }
        public int? EmpleadoId {get;set;}

        [Column(TypeName="decimal(18,2)")]
        public decimal MontoApertura {get;set;}
        public DateTime FechaApertura {get;set;}
        public DateTime? FechaCierre {get;set;}
        public bool EstadoCaja {get;set;}
        public User ResponsableAperturaLab {get;set;} 
        public User ResponsableCierreLab {get;set;} 
        public ICollection<DetalleCajaLab> DetalleCajaLabs {get;set;}

        // public string ResponsableAperturaText{
        //     get{return (ResponsableAperturaLab.Persona == null || ResponsableAperturaLab == null) 
        //         ? "" : ResponsableAperturaLab.Persona.Nombre.ToString();}
        // }

        // public string ResponsableCierreText{
        //     get{return (ResponsableCierreLab.Persona == null || ResponsableCierreLab == null) 
        //         ? "" : ResponsableCierreLab.Persona.Nombre.ToString();}
        // }
    }
}