using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;

namespace Database.Shared.IRepository
{
    public interface IEmpleado
    {
        public void Add(Empleado empleado, bool saveChanges = true);
        public List<Empleado> GetList();
        public void Update(Empleado model, bool saveChanges = true);

        public Empleado Get(int id, bool includeRelatedEntities = true);
        Medicos GetMedicoById(int id, bool includeRelatedEntities = true);
        Medicos GetMedicoByName(string name, bool includeRelatedEntities = true);

        List<Medicos> GetListMedicos();

        void Add(Medicos medico, bool saveChanges = true);

        public PaginacionList<Empleado> PaginacionEmpleados(string sortOrder, string searchString, int? pageNumber, int pageSize);
    }
}