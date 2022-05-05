using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Database.Shared.Paginacion;
using Database.Shared.Models;

namespace sistema.Models
{
    public class InsumosFarmaciaViewModel
    { 
        public SelectList CategoriasSelectList {get;set;}
        public PaginacionList<Producto> Productos {get;set;}
        public string buscar {get;set;}
        public string currentFilter {get;set;}
        public int? pageNumber {get;set;}
        public int? categoriaId {get;set;}
        public int TotalInsumos {get;set;}

        public void Init(IDespegablesProducto _categoriaRepository)
        {
            CategoriasSelectList = new SelectList(_categoriaRepository.ListaCategorias(), "Id", "NombreCategoria");
        }
    }
}