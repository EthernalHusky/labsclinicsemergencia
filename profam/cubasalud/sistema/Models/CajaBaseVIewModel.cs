using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;

namespace sistema.Models
{
    public class CajaBaseViewModel 
    {
        public CajaBaseViewModel()
        {
            Caja.ResponsableApertura = new User();
            Caja.ResponsableCierre = new User();
        }
        public Caja Caja {get;set;} = new Caja();
        public IList<Caja> ListaCajas {get;set;}
        // public List<Categoria> ListaCategorias = new List<Categoria>();
    

        public void Init(ICaja _cajaRepository)
        {
            ListaCajas = _cajaRepository.ListarCajas();
        }

        public int Id
        {
            get { return Caja.Id; }
            set { Caja.Id = value; }
        }
    }
} 