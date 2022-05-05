using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class FormaPago
    {
      
      public FormaPago(){
         Pagos = new List<Pagos>();

      }
        public int Id { get; set; }


        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string NombreFormaPago { get; set; }

         public ICollection<Pagos> Pagos {get;set;}

    }
}