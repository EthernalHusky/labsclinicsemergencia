using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Servicio
    {
        public Servicio()
        {
            DetalleServicio = new List<DetalleServicio>();
            DetalleCotizaciones = new List<DetalleCotizacion>();
            Citas = new List<Citas>();
            DetalleVentas = new List<DetalleVenta>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string NombreServicio { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
         [Column(TypeName="decimal(18,2)")]
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public bool Eliminado { get; set; }
        public ICollection<DetalleServicio> DetalleServicio { get; set; }
        public ICollection<DetalleCotizacion> DetalleCotizaciones { get; set; }
        public ICollection<Citas> Citas{get;set;}
        public ICollection<DetalleVenta> DetalleVentas{get;set;}

    }
}