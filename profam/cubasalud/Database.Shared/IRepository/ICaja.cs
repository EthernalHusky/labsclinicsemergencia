using System.Collections.Generic;
using Database.Shared.Models;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.IRepository
{
    public interface ICaja
    {
        public IList<Caja> ListarCajas();
        public void Add(Caja caja, bool saveChanges = true);
        public void Add(DetalleCaja caja, bool saveChanges = true);
        public Caja GetCajaAbierta();
        public List<Caja> GetListadoFecha(DateTime inicio, DateTime final);
        public void Update(Caja caja, bool saveChanges = true);
        public PaginacionList<Caja> PaginacionCategoria(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public Caja GetCaja(int id, bool includeRelatedEntities = true);
        public void GetDetalleCajaPorVentaId(int id, bool savechanges = true);
        public DetalleCaja GetDetalleCaja(int id);
        public DetalleCaja GetDetalleCajaVentaServicio(int id);
        
        void DeleteDetalleCaja(int id, bool saveChanges = true);

    }
}
