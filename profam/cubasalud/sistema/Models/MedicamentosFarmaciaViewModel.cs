using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;
using Database.Shared.Models;

namespace sistema.Models
{
    public class MedicamentosFarmaciaViewModel
    { 
        public SelectList GrupoTerapeuticoSelectList {get;set;}
        public PaginacionList<Producto> Productos {get;set;}
        public string buscar {get;set;}
        public string currentFilter {get;set;}
        public int? pageNumber {get;set;}
        public int? terapeuticoId {get;set;}

        public int TotalMedicamentos {get;set;}

        public void Init(IDespegablesProducto _categoriaRepository)
        {
            GrupoTerapeuticoSelectList = new SelectList(_categoriaRepository.ListarGrupoT(), "Id", "NombreGrupoT");
        }
    }
}