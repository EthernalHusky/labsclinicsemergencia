using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using System;
using System.Linq;
using Database.Shared.DataBindings;

namespace Database.Shared.IRepository
{
    public interface ICitas
    {
        IList<Citas> GetList();
        void Add(Citas cita, bool saveChanges = true);
        Citas GetCita(int id);
        void Update(Citas model, bool saveChanges = true);
        PaginacionList<Citas> PaginacionCitas(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<Citas> PaginacionCitasFinalizadas(string sortOrder, string searchString, int? pageNumber, int pageSize);
        PaginacionList<Citas> PaginacionCitasNoAsistidas(string sortOrder, string searchString, int? pageNumber, int pageSize);
        IList<Especialidad> GetEspecialidadesList();
        IList<Citas> CitasNormales(string searchString);
        IList<Citas> CitasPorFecha(DateTime fecha);
        IList<EstadoPagoConsulta> EstadoPagosConsultasLista();
    }
}