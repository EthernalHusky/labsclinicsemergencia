using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Database.Shared.Models
{
    public class Especialidad
    {
        public Especialidad()
        {
            Citas = new List<Citas>();
        }
        public int Id { get; set; }
        public string NombreEspecialidad {get;set;}

        public ICollection<Citas> Citas {get;set;}
    }
}