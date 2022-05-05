using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class ExamenFisico
    {
        public ExamenFisico()
        {
            Consultas = new List<Consulta>();
        }

        public int Id {get;set;}
        public string Temperatura {get;set;}
        public string FrecuenciaRespiratoria {get;set;}
        public string FrecuenciaCardiaca {get;set;}
        public string SaturacionDeOxigeno {get;set;}
        public string PresionArterialBrazoDerecho {get;set;}
        public string PresionArterialBrazoIzquierdo {get;set;}
        public string Observaciones {get;set;}

        public ICollection<Consulta> Consultas {get;set;}

    }
}