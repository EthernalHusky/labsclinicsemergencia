using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class TipoBodega
    {
        public TipoBodega()
        {
            Productos = new List<Producto>();
        }
        public int Id { get; set; }
        public string DescripcionBodega {get;set;}
        public ICollection<Producto> Productos {get;set;}


    }
}