using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Prescripcion
    {
        public Prescripcion()
        {
            Consultas = new List<Consulta>();
        }
        public int Id { get; set; }
        public int ProductoId {get;set;}
        public int Cantidad {get;set;}
        public string Indicaciones {get;set;}


        public Producto Producto {get;set;}
        public ICollection<Consulta> Consultas {get;set;}
    }
}