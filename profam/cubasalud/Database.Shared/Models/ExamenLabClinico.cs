using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Database.Shared.Models
{
    public class ExamenLabClinico
    {
      
      public ExamenLabClinico()
      {
        DetalleExamens = new List<DetalleExamen>();
        DatosExamenesLabClinicos = new List<DatosExamenesLabClinico>();
      }
        public int Id { get; set; }
        public int CategoriaLabClinicoId {get;set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string NombreExamen { get; set; }
        public string CodigoInterno {get;set;}
        public decimal Precio {get;set;}
        public decimal PrecioB {get;set;}
        public decimal PrecioC {get;set;}
        public string Indicaciones {get;set;}
        public DateTime FechaCreacion {get;set;}
        public String UltimaModificacion {get;set;}
        public bool Eliminado {get;set;}
        public decimal PrecioCosto {get;set;}
        public string TipoDeExamen {get;set;}
        public bool Activo {get;set;} = true;


        public CategoriaLabClinico CategoriaLabClinico {get;set;}
        public ICollection<DetalleExamen> DetalleExamens {get;set;}
        public ICollection<DatosExamenesLabClinico> DatosExamenesLabClinicos {get;set;}



    }
}