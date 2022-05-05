using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;

namespace Database.Shared.IRepository
{
    public interface IPacientes
    {
        public void Add(Paciente Paciente, bool saveChanges = true);
        public List<Paciente> GetList();
        List<EstadoExamen> GetListEstadosExamen();
        public PaginacionList<Paciente> PaginacionClientes(string sortOrder, string searchString, int? pageNumber, int pageSize);
        public void Update(Paciente model, bool saveChanges = true);
        public Paciente Get(int id, bool includeRelatedEntities = true);
        public Paciente GetPacientePorNombre(string nombre); 
        public Paciente GetPacientePorId(int id);
        public IList<Sexo> GetSexosList();
    }
}