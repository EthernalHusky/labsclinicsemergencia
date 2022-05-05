using Database.Shared.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using System;
using Database.Shared.Paginacion;

namespace sistema.Models
{
    public class InfoConsultaViewModel
    {
        public Consulta Consulta {get;set;}

    }
}