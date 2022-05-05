using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;

namespace sistema.Models
{
    public class CajaLaboratorioBaseViewModel 
    {
        public CajaLab CajaLab {get;set;} = new CajaLab();
        public IList<CajaLab> ListaCajas {get;set;}
        // public List<Categoria> ListaCategorias = new List<Categoria>();
    

        public void Init(ILaboratorioClinico _labClinico)
        {
            ListaCajas = _labClinico.ListarCajas();
        }

        public int Id
        {
            get { return CajaLab.Id; }
            set { CajaLab.Id = value; }
        }
    }
} 