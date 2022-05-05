using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class DetalleTrasladoProductos
    {
        public DetalleTrasladoProductos()
        {

        }
        public int Id { get; set; }
        public int ProductoId {get;set;}
        public int TrasladosProductosId {get;set;}
        public int Cantidad {get;set;}
        public TrasladosProductos TrasladosProductos {get;set;}
        public Producto Producto{get;set;}

        
    }
}