using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;

namespace Database.Shared.IRepository
{
    public interface ITraslados
    {
        void Add(TrasladosProductos traslados, bool saveChanges = true);
        void Add(DetalleTrasladoProductos detalleTrasladoProductos, bool saveChanges = true);
        PaginacionList<TrasladosProductos> PaginacionTrasladosBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionAceptadosBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionEnTransitoBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionFaltantesBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionConProblemaBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionCanceladosBodegaAClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        

        PaginacionList<TrasladosProductos> PaginacionTrasladosBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionAceptadosBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionEnTransitoBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionFaltantesBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionConProblemaBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<TrasladosProductos> PaginacionCanceladosBodegaAFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);


        TrasladosProductos GetTraslados(int id, bool includeRelatedEntities = true);
        void SaveChanges();
        IList<DetalleTrasladoProductos> GetListDetalleTrasladoProductos(int id);
        void DeleteDetalleTraslado(int id, bool savechanges = true);
        DetalleTrasladoProductos GetDetalleTrasladoProductos(int id, bool includeRelatedEntities = true);
        void UpdateDetalleTrasladoProductos(DetalleTrasladoProductos model, bool saveChanges = true);
        void UpdateTraslado(TrasladosProductos model, bool saveChanges = true);
    }
}