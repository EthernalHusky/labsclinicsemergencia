using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class DetalleCompra
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public int CompraId { get; set; }
        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName="decimal(18,3)")]
        public decimal Precio { get; set; }

        [Column(TypeName="decimal(18,3)")]
        public decimal BaseImponible { get; set; }
        [Column(TypeName="decimal(18,3)")]
        public decimal PrecioTotal { get; set; }
        [Column(TypeName="decimal(18,3)")]
        public decimal Impuesto { get; set; }
        public Producto Producto { get; set; }
        public Compra Compra { get; set; }


    }
}