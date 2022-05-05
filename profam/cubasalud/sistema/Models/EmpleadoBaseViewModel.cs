using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;

namespace sistema.Models
{
    public class EmpleadoBaseViewModel
    {
        public Empleado Empleado {get;set;} = new Empleado();

         public IFormFile imagen {get; set;}

        public bool Modificar {get;set;}

        public int Id
        {
            get { return Empleado.Id; }
            set { Empleado.Id = value; }
        }
    }
} 