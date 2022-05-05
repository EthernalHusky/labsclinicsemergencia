using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Caja
    {
        public Caja()
        {
            DetalleCajas = new List<DetalleCaja>();
        }

        public int Id { get; set; }
        public int? EmpleadoId {get;set;}
        
        [Column(TypeName="decimal(18,2)")]
        public decimal MontoApertura {get;set;}
        public DateTime FechaApertura {get;set;}
        public DateTime? FechaCierre {get;set;}
        public bool EstadoCaja {get;set;}
        public User ResponsableApertura {get;set;} 
        public User ResponsableCierre {get;set;} 
        public ICollection<DetalleCaja> DetalleCajas {get;set;}

        public string ResponsableAperturaText{
            get{return (ResponsableApertura.Persona == null || ResponsableApertura == null) 
                ? "" : ResponsableApertura.Persona.Nombre.ToString();}
        }

        public string ResponsableCierreText{
            get{return (ResponsableCierre.Persona == null || ResponsableCierre == null) 
                ? "" : ResponsableCierre.Persona.Nombre.ToString();}
        }
    }
}