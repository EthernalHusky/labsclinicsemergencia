using Database.Shared.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using Microsoft.AspNetCore.Http;
using Database.Shared.Data;
using System;

namespace sistema.Models
{
    public class CompraBaseViewModel
    {
        public Compra Compra { get; set; } = new Compra();
        // public Proveedor Proveedor { get; set; } = new Proveedor();
        // public List<DetalleCompra> ListaDetalle = new List<DetalleCompra>();
        public SelectList ListaProveedores { get; set; }
        public SelectList ListaTipoCompra {get;set;}
        public SelectList ListaEmpleados { get; set; }
        // public bool Modificar { get; set; }
        // public Producto Producto { get; set; } = new Producto();
        public Recepcion Recepcion { get; set; } = new Recepcion();
        // public List<Producto> ListaProductos { get; set; }
        public SelectList ListaProductosEInsumos {get;set;} 
        public SelectList ListaCasaMedica {get;set;}
        public DateTime FechaLimite {get;set;}


        public void Init(IProducto productoRepository, IProveedor proveedorRepository, ICompra compraRepository, IDespegablesProducto categoriaRepository)
        {
            ListaProductosEInsumos = new SelectList(productoRepository.GetListadoProductos(), "Id", "ProductoYPresentacion");
            ListaProveedores = new SelectList(proveedorRepository.GetList(), "Id", "Nombre");
            ListaTipoCompra = new SelectList(compraRepository.TipoCompraLista(), "Id", "Tipo");
            ListaCasaMedica = new SelectList(categoriaRepository.ListaLaboratorioProducto(), "Id", "NombreLaboratorioProducto");
        }

        // public int Id
        // {
        //     get { return Compra.Id; }
        //     set { Compra.Id = value; }
        // }
    }
}