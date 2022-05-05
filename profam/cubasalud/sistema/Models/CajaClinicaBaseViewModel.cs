using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;

namespace sistema.Models
{
    public class CajaClinicaBaseViewModel 
    {
        public CajaClinica CajaClinica {get;set;} = new CajaClinica();
        public IList<CajaClinica> ListaCajas {get;set;}
        // public List<Categoria> ListaCategorias = new List<Categoria>();
    

        public void Init(ICajaClinica _cajaRepository)
        {
            ListaCajas = _cajaRepository.ListarCajas();
        }

        public int Id
        {
            get { return CajaClinica.Id; }
            set { CajaClinica.Id = value; }
        }
    }
} 