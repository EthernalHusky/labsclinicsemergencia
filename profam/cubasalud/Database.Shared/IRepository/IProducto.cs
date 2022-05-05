using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using Database.Shared.DataBindings;
using Database.Shared.Data;

namespace Database.Shared.IRepository
{
    public interface IProducto
    {
        public void Add(Producto producto, bool saveChanges = true);
        public List<Producto> GetList();
        public IList<Producto> GetListado();
        public IList<Producto> GetListadoFaltantesFarmacia(string searchString);
        public IList<Producto> GetListadoFaltantesClinica(string searchString);
        public Producto Get(int id, bool includeRelatedEntities = true);
        public Producto GetPorNumeroDeReferencia(string id, bool includeRelatedEntities = true);
        public IList<Producto> GetPorNumeroDeReferenciaList(string id, bool includeRelatedEntities = true);

        public Producto GetPorNumeroDeReferenciayNombre(string id, bool includeRelatedEntities = true);
        public IList<RetornoProductoPOS> BuscarPorNombreYReferenciaBusquedaAjax(string searchString);
        public void Update(Producto producto, bool saveChanges = true);
        public void SaveChanges();
        public PaginacionList<Producto> PaginacionProductosFarmaciaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public PaginacionList<Producto> PaginacionProductosFarmaciaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);
        public PaginacionList<Producto> PaginacionProductosClinicaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public PaginacionList<Producto> PaginacionProductosClinicaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);
        PaginacionList<Producto> PaginacionBodegaMedicamentos(string searchString, int? pageNumber, int pageSize, int? terapeuticoId);
        public PaginacionList<Producto> PaginacionProductosFaltantes(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProductosVencimiento(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public IList<ProductoYCodigo> GetListParaCotizacion();
        public Producto GetProdutoById(int id);
        public Producto GetProductoByTipoBodegaAndNombre(int tipoBodega, string nombre);
        public Producto GetPorNumeroDeReferenciaClinica(string id, bool includeRelatedEntities = true);
        public IList<RetornoProductoPOSClinica> BuscarPorNombreYReferenciaBusquedaAjaxClinica(string searchString);
        public IList<Producto> GetListadoProductos();
        IList<Producto> GetListadoProductosBodega();
        public IList<Producto> FiltrarPorBusquedaYTerapeutico(string searchString, int? terapeuticoId, int tipoBodega);
        public IList<Producto> FiltrarPorBusquedaYCategoria(string searchString, int? categoriaId, int tipoBodega);
        public PaginacionList<Producto> PaginacionProductosFaltantesClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionVencidosFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProximosAVencerFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionVencidosClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public PaginacionList<Producto> PaginacionProximosAVencerClinica(string sortOrder, string searchString, int? pageNumber, int pageSize);
        Producto GetByName(string producto, bool includeRelatedEntities = true);
        int GetTotalMedicamentosFarmacia();
        int GetTotalInsumosFarmacia();

        int GetTotalMedicamentosClinica();
        int GetTotalInsumosClinica();
        
        int GetTotalMedicamentosBodega();
        int GetTotalInsumosBodega();
        IList<ProductosByLab> GetProductosByLaboratorioId(int laboratorioId);
        IList<ProductosByLab> GetProductosLaboratorio();
        
        PaginacionList<Producto> PaginacionProductosBodegaInsumosMedicos(string searchString, int? pageNumber, int pageSize, int? categoriaId);

        IList<Producto> GetMedicamentosFarmaciaList();
    }
}