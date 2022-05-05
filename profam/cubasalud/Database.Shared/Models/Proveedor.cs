using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Database.Shared.Models
{
    public class Proveedor
    {
       

        public int Id {get;set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Nombre {get;set;}

        public string Direccion {get;set;}

        public string Correo {get; set;}

        public string Giro {get; set;}

        public string Telefono_1 {get; set;}

        public string Telefono_2 {get; set;}

        public string Celular_1 {get; set;}

        public string Celular_2 {get; set;}

        public string Nit {get; set;}

        public string CuentaBancaria {get; set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public int BancoId {get; set;}

        public string Observaciones {get;set;}

        public string TipoProveedor {get;set;}

        public string FrecuenciaEntrega {get;set;}

        public string DiasEntrega{get;set;}

        public bool Eliminado {get; set;}


        public Banco Banco {get; set;}

       

      
    }
}
