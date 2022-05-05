using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Paciente
    {
    public  Paciente()
    {
        Venta = new List<Venta>();
        Citas = new List<Citas>();
        Examens  = new List<Examen>();
    }


        public int Id {get;set;}
        public int? SexoId {get;set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string Nombre {get;set;}
        public string Telefono {get;set;}
        public string Celular {get;set;}
        public string Nit {get;set;}
        public string Direccion {get;set;}
        public string Alias {get;set;}
        public string no_IGGS {get;set;}
        public bool esta_Afiliado {get;set;} = false;
        public DateTime? FechaNacimiento {get;set;}
        public bool Eliminado {get; set;}
        public Sexo Sexo {get;set;}
        public ICollection<Venta> Venta {get;set;}
        public ICollection<VentaServicio> VentaServicio {get;set;} // no lo estoy usando, ver si es necesario quitar
        public ICollection<Citas> Citas {get;set;}
        public ICollection<Examen> Examens {get;set;}


        public string sexoText {
            get {return Sexo == null ? "" : Sexo.DescripcionSexo.ToString();}
        }

        public string PacienteConIGSS {
            get {return string.IsNullOrEmpty(no_IGGS) ? $"{Nombre} -  afil.: / sin registro" : $"{Nombre} -  afil.: {no_IGGS}";}
        }
    }
}