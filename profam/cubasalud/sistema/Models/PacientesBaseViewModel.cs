using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using Database.Shared.Data;

namespace sistema.Models
{
    public class PacientesBaseViewModel
    {
        public Paciente Paciente {get;set;} = new Paciente();
        public SelectList SexoSelectListItems {get;set;}
        public void Init(IPacientes pacientesRepository)
        {
            SexoSelectListItems = new SelectList(pacientesRepository.GetSexosList(), "Id", "DescripcionSexo");
        }

        public int Id {
            get {return Paciente.Id;}
            set {Paciente.Id = value;}
        }
    }
}