using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Database.Shared.Models
{
    public class Historia
    {
        public Historia()
        {
            Consultas = new List<Consulta>();
        }

        public int Id { get; set; }
        public string HistoriaProblema {get;set;}
        public string Sintomas {get;set;}
        public string Diagnostico {get;set;}
        public ICollection<Consulta> Consultas {get;set;}

    }
}