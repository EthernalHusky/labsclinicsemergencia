using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.IRepository
{
    public interface ICompra
    {
       // public void Add(Compra Compra, bool saveChanges = true);

        public void Add(DetalleCompra detalle, bool saveChanges = true);

            public void saveChanges();

            public List<Compra> GetList();
            public List<Compra> GetListadoFecha(DateTime inicio, DateTime final);

            public List<Compra> GetListadoFechaEmpleado(DateTime inicio, DateTime final, int? id);

            public Compra Get(int id, bool includeRelatedEntities = true);

            public List<DetalleCompra> GetDetalle(int id, bool includeRelatedEntities = true);
            public void Delete(int id, bool savechanges = true);

            public void Update(Compra model, bool saveChanges = true);
            public void Update(DetalleCompra model, bool saveChanges = true);
            public void Add(Recepcion recepcion, bool saveChanges = true);
            public void Update(Recepcion recepcion, bool saveChanges = true);
            public List<Recepcion> GetRecepciones();
            public Recepcion GetRecepcion (int id, bool includeRelatedEntities = true);
            public PaginacionList<Compra> PaginacionCompras(string sortOrder, string searchString, int? pageNumber, int pageSize);

            public PaginacionList<Compra> PaginacionComprasPeticion(string sortOrder, string searchString, int? pageNumber, int pageSize);

            public PaginacionList<Compra> PaginacionComprasComprados(string sortOrder, string searchString, int? pageNumber, int pageSize);

            public PaginacionList<Recepcion> PaginacionRecepciones(string sortOrder, string searchString, int? pageNumber, int pageSize);

            IList<TipoCompra> TipoCompraLista();
            
            DetalleCompra GetDetalleC(int id, bool includeRelatedEntities = true);
         //  public void Delete(DetalleCompra detalle);
        // public List<Venta> GetList();
        // public void Update(Venta model, bool saveChanges = true);

        //  public Venta Get(int id, bool includeRelatedEntities = true);

    }
}