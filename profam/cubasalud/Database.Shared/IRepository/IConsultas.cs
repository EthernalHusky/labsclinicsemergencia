using Database.Shared.Models;
using System.Collections.Generic;
using Database.Shared.Paginacion;
using System;
using System.Linq;
using Database.Shared.DataBindings;

namespace Database.Shared.IRepository
{
    public interface IConsultas
    {
        void Add(Consulta consulta, bool saveChanges = true);
        IList<Consulta> ListaConsultas();
        PaginacionList<Consulta> PaginacionConsultas(string searchString, int? pageNumber, int pageSize);
        Consulta GetConsulta(int id, bool relatedEntities = true);
        void Update(Consulta consulta, bool saveChanges = true);
    }
}