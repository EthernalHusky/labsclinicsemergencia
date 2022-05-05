using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Database.Shared.Models
{
    public class Empleado
    {
        public Empleado()
        {
            Users = new List<User>();
            Ventas = new List<Venta>();
            VentasServicios = new List<VentaServicio>();
            Compras = new List<Compra>();
            Citas = new List<Citas>();
            Examens = new List<Examen>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Telefono { get; set; }

        public string Telefono_2 { get; set; }

        public string Telefono_3 { get; set; }

        public string Direccion { get; set; }

        public string Edad { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Dpi { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Nit { get; set; }

        public string EstadoCivil { get; set; }

        public string TipoContrato { get; set; }

        public string Salario { get; set; }

        public string Observaciones { get; set; }

        public string Imagen {get;set;}

         public bool Eliminado {get; set;}

        public ICollection<User> Users{get;set;}
        public ICollection<Venta> Ventas{get;set;}
        public ICollection<VentaServicio> VentasServicios{get;set;}
        public ICollection<Compra> Compras {get;set;}
        public ICollection<Citas> Citas {get;set;}

        public ICollection<Examen> Examens {get;set;}


        public string NombreYApellidos {
            get {return $"{Nombre} - {Apellido}"; }
        }

    }
}