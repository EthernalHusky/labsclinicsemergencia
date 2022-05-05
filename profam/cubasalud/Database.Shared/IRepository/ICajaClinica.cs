using System.Collections.Generic;
using Database.Shared.Models;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.IRepository
{
    public interface ICajaClinica
    {
        public List<CajaClinica> ListarCajas();

        public void Add(CajaClinica caja, bool saveChanges = true);
        public void Add(DetalleCajaClinica caja, bool saveChanges = true);
        public CajaClinica GetCajaAbierta();
        public List<CajaClinica> GetListadoFecha(DateTime inicio, DateTime final);
        public void Update(CajaClinica caja, bool saveChanges = true);
        public PaginacionList<CajaClinica> PaginacionCategoria(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public CajaClinica GetCaja(int id, bool includeRelatedEntities = true);
        public void GetDetalleCajaPorVentaId(int id, bool savechanges = true);
        public DetalleCajaClinica GetDetalleCaja(int id);
        public DetalleCajaClinica GetDetalleCajaVentaServicio(int id);
        public void GetDetalleCajaPorVentaIdC(int id, bool savechanges = true);

    }
}
