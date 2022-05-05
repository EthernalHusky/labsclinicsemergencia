using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using System;

namespace sistema.Models
{
    public class ExamenLabClinicoViewModel
    {

        public ExamenLabClinicoViewModel()
        {
        }

        public ExamenLabClinico ExamenLabClinico {get;set;} = new ExamenLabClinico();
        public SelectList ListCategorias {get;set;}
        public List<DatosExamenesLabClinico> DatosExamenes {get;set;}

        public string Campos {get;set;}
        public string Resultado {get;set;}
        public string ValorReferencia {get;set;}
        public string Indicaciones {get;set;} 


        public void Init(ILaboratorioClinico categoriaRepository)
        {
            ListCategorias = new SelectList(categoriaRepository.GetListCategoriasLab(), "Id", "Nombre");
        }
        
        public int Id
        {
            get { return ExamenLabClinico.Id; }
            set { ExamenLabClinico.Id = value; }
        }
    }
} 