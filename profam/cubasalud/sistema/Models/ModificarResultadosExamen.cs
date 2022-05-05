using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using Database.Shared.Data;

namespace sistema.Models
{
    public class ModificarResultadosExamen
    {
        public DetalleExamen DetalleExamen {get;set;}
        public int? ExamenId {get;set;}


        public int Id
        {
            get { return DetalleExamen.Id; }
            set { DetalleExamen.Id = value; }
        }

    }
}