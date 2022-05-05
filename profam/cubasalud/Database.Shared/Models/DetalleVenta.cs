using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class DetalleVenta
    {
        public int Id {get;set;}
        public int VentaId {get;set;}
        public int? ProductoId {get;set;}
        public int? ServicioId {get;set;}
        public int Cantidad {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Descuento {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Subtotal{get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Total {get;set;}
        public string BienOServicio {get;set;}

        public Producto Producto {get;set;}
        public Servicio Servicio {get;set;}
        public Venta Venta {get;set;}
       
    }
}