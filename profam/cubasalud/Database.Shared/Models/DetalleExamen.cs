using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Database.Shared.Models
{
    public class DetalleExamen
    {
        public int Id {get;set;}
        public int ExamenLabClinicoId {get;set;}
        public int? ExamenId {get;set;}
        public int Cantidad {get;set;}
        public decimal Precio {get;set;}
        public decimal Descuento {get;set;}
        public decimal Subtotal {get;set;}
        public decimal Total {get;set;}
        public string Resultado {get;set;} 


        public ExamenLabClinico ExamenLabClinico {get;set;}
        public Examen Examen {get;set;}
       
    }
}