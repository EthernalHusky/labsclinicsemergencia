using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;

namespace sistema.Models
{
    public class ServicioBaseViewModel
    {
        public Servicio Servicio {get;set;} = new Servicio();

        public VentaServicio ventaServicio {get;set;} = new VentaServicio();
        public IList<DetalleServicio> DetalleServicios {get;set;}
        public bool Modificar {get;set;}

        public int Id
        {
            get { return Servicio.Id; }
            set { Servicio.Id = value; }
        }
    }
} 