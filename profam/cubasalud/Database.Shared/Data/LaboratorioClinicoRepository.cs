using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;

namespace Database.Shared.Data
{
    public class LaboratorioClinico : ILaboratorioClinico
    {

        private readonly Context _context = null;

        public LaboratorioClinico(Context context)
        {
            _context = context;
        }

        public PaginacionList<CategoriaLabClinico> PaginacionCategoriasLab(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var categorias = _context.CategoriaLabClinicos.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                categorias = categorias
                .Where(s => s.Nombre.Contains(searchString));
            }

            return PaginacionList<CategoriaLabClinico>.CreateAsyncc(categorias
            .Where(x => x.Eliminado == false)
            .OrderBy(a => a.Nombre), 
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<VentasLab> PaginacionVentasLab(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var ventas = _context.VentasLabs.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                ventas = ventas
                .Where(s => s.Nombres.Contains(searchString));
            }

            return PaginacionList<VentasLab>.CreateAsyncc(ventas
            .Where(x => x.Eliminado == false)
            .OrderBy(a => a.Id), 
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<ExamenLabClinico> PaginacionExamenClinicoLab(string sortOrder, string searchString, int? pageNumber, int pageSize, int? catexamenid)
        {
            var examen = _context.ExamenLabClinicos
            .Include(a => a.CategoriaLabClinico)
            .AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                examen = examen
                .Where(s => s.NombreExamen.Contains(searchString));
            }

            if(catexamenid != null) examen = 
                examen.Where(a => a.CategoriaLabClinicoId == catexamenid);


            return PaginacionList<ExamenLabClinico>.CreateAsyncc(examen
            .Where(x => x.Eliminado == false)
            .OrderBy(a => a.NombreExamen), 
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Examen> PaginacionExamenesRealizados(string sortOrder, string searchString, int? pageNumber, int pageSize, int? estado)
        {
            var examen = _context.Examenes
            // .Include(a => a.Empleado).ThenInclude(a => a.Users)
            .Include(a => a.DetalleExamenes).ThenInclude(a => a.ExamenLabClinico) .ThenInclude(a => a.CategoriaLabClinico)
            .Include(a => a.Paciente)
            .Include(a => a.EstadoExamen)
            .AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                examen = examen
                .Where(s => s.Paciente.Nombre.Contains(searchString));
            }

            if(estado != null)
            {
                examen = examen.Where(a => a.EstadoExamenId == estado);
            }

            return PaginacionList<Examen>.CreateAsyncc(examen
            .Where(x => x.Eliminado == false)
            .OrderByDescending(a => a.Id), 
            pageNumber ?? 1, pageSize);
        }


        public IList<CategoriaLabClinico> GetListCategoriasLab()
        {
            return _context.CategoriaLabClinicos
            .Where(x => x.Eliminado == false).ToList();
        }

        public IList<ExamenLabClinico> GetListExamenesLaboratorio()
        {
            return _context.ExamenLabClinicos
            .Where(x => x.Eliminado == false).ToList();
        }

         public IList<Examen> GetListExamenesRealizado()
        {
            return _context.Examenes
            // .Include(a => a.Empleado).ThenInclude(a => a.Users)
            .Include(a => a.Paciente)
            .Include(a => a.DetalleExamenes).ThenInclude(a => a.ExamenLabClinico)
            .Where(x => x.Eliminado == false).ToList();
        }

      

        public void Add(CategoriaLabClinico categoriaLabClinico, bool saveChanges = true)
        {
            _context.CategoriaLabClinicos.Add(categoriaLabClinico);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Add(Examen examen, bool saveChanges = true)
        {
            _context.Examenes.Add(examen);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Add(ExamenLabClinico examenLabClinico, bool saveChanges = true)
        {
            _context.ExamenLabClinicos.Add(examenLabClinico);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

         public void Add(DatosExamenesLabClinico datos, bool saveChanges = true)
        {
            _context.DatosExamenesLabClinicos.Add(datos);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        // public IList<Sexo> GetSexosList()
        // {
        //     return _context.Sexo.ToList();
        // }

        public CategoriaLabClinico GetCategoriaLab(int id, bool includeRelatedEntities = true)
        {
            return _context.CategoriaLabClinicos.Where(a => a.Id == id).FirstOrDefault();
        }

        public DatosExamenesLabClinico GetDatosExamenLab(int id, bool includeRelatedEntities = true)
        {
            return _context.DatosExamenesLabClinicos.Where(a => a.Id == id).FirstOrDefault();
        }


        public List<ExamenLabClinico> ExamenesLabList(int idCategoria, bool includeRelatedEntities = true)
        {
            return _context.ExamenLabClinicos
                .Where(a => a.CategoriaLabClinicoId == idCategoria && a.Eliminado == false)
                    .ToList();
        }

        public List<ExamenLabClinico> ExamenesLabListTodos(bool includeRelatedEntities = true)
        {
            return _context.ExamenLabClinicos
            .Include(a => a.CategoriaLabClinico)
                .Where(a => a.Eliminado == false)
                    .ToList();
        }

        public List<DatosExamenesLabClinico> DatosLabList(int idExamenLab, bool includeRelatedEntities = true)
        {
            return _context.DatosExamenesLabClinicos
                .Where(a => a.ExamenLabClinicoId == idExamenLab 
                        && a.Eliminado == false)
                    .ToList();
        }

        public ExamenLabClinico GetExamenLab(int id, bool includeRelatedEntities = true)
        {
            return _context.ExamenLabClinicos.Where(a => a.Id == id).FirstOrDefault();
        }

        public DetalleExamen GetDetalleExamenLab(int id, bool includeRelatedEntities = true)
        {
            return _context.DetalleExamenes.AsNoTracking()
            .Where(a => a.Id == id)
            .FirstOrDefault();
        }

        public Examen GetExamenRealizado(int id, bool includeRelatedEntities = true)
        {
            return _context.Examenes
            // .Include(a => a.Empleado).ThenInclude(a => a.Users)
            .Include(a => a.Paciente)
            .Include(a => a.VentasLabs)
            .Include(a => a.DetalleExamenes).ThenInclude(a => a.ExamenLabClinico).ThenInclude(a => a.DatosExamenesLabClinicos)
            .Where(a => a.Id == id).FirstOrDefault();
        }

        public VentasLab GetVentaLab(int id, bool includeRelatedEntities = true)
        {
            return _context.VentasLabs
            // .Include(a => a.Empleado).ThenInclude(a => a.Users)
            .Where(a => a.Id == id).FirstOrDefault();
        }

        // public List<Paciente> GetList() 
        // {
        //     return _context.Pacientes.Where(x=>x.Eliminado==false).ToList();
        // } 

        // // usar para paginacion
        // public PaginacionList<Paciente> PaginacionClientes(string sortOrder, string searchString, int? pageNumber, int pageSize)
        // {
        //     var cliente = _context.Pacientes.AsQueryable();


        //     // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
        //     if(!string.IsNullOrEmpty(searchString))
        //     {
        //         cliente = cliente
        //         .Where(s => s.Nombre.Contains(searchString));
        //     }

        //     switch(sortOrder)
        //     {
        //         case "Nombre_desc":
        //         cliente = cliente.OrderByDescending(s => s.Nombre);
        //         break;

        //         default:
        //         cliente = cliente.OrderBy(s => s.Nombre);
        //         break;
        //     }

        //     return PaginacionList<Paciente>.CreateAsyncc(cliente
        //     .Include(a => a.Sexo)
        //     .Where(x => x.Eliminado==false)
        //     .OrderBy(a => a.Nombre), 
        //     pageNumber ?? 1, pageSize);
        // }


        public void Update(CategoriaLabClinico categoriaLabClinico, bool saveChanges = true)
        {
            _context.Entry(categoriaLabClinico).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public void Update(DatosExamenesLabClinico datos, bool saveChanges = true)
        {
            _context.Entry(datos).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public void Update(ExamenLabClinico examen, bool saveChanges = true)
        {
            _context.Entry(examen).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public void Update(Examen examen, bool saveChanges = true)
        {
            _context.Entry(examen).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public void Update(DetalleExamen examen, bool saveChanges = true)
        {
            _context.Entry(examen).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public void Update(VentasLab examen, bool saveChanges = true)
        {
            _context.Entry(examen).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }


        public void Update(CajaLab caja, bool saveChanges = true)
        {
            _context.Entry(caja).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        // public Paciente GetPacientePorNombre(string nombre)
        // {
        //     return _context.Pacientes.Where(a => a.Nombre == nombre && a.Eliminado == false).SingleOrDefault();
        // }

        // public Paciente GetPacientePorId(int id)
        // {
        //     return _context.Pacientes.Where(a => a.Id == id && a.Eliminado == false).SingleOrDefault();
        // }

        // para ventas

        public void Add(DetalleExamen detalle, bool saveChanges = true)
        {
            _context.DetalleExamenes.Add(detalle);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        } 

        public void Add(DetalleCajaLab detalle, bool saveChanges = true)
        {
            _context.DetalleCajaLab.Add(detalle);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        } 


        public void Add(CajaLab detalle, bool saveChanges = true)
        {
            _context.CajaLab.Add(detalle);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        } 

        public void saveChanges()
        {
            _context.SaveChanges();
        }


        public List<CajaLab> ListarCajas()
        {
            return _context.CajaLab
                .Include(x => x.DetalleCajaLabs)
                .Include(a => a.ResponsableAperturaLab).ThenInclude(a => a.Persona)
                .Include(a => a.ResponsableCierreLab).ThenInclude(a => a.Persona)
                .OrderByDescending(a => a.FechaApertura).ToList();
        }


        public CajaLab GetCajaAbierta()
        {
            return _context.CajaLab.Where(a => a.EstadoCaja == true).FirstOrDefault();
        }

        public CajaLab GetCaja(int id, bool includeRelatedEntities = true)
        {
            var caja = _context.CajaLab.AsQueryable();

            if (includeRelatedEntities)
            {
                caja = caja
                .Include(a => a.DetalleCajaLabs).ThenInclude(a => a.VentasLab).ThenInclude(a => a.Examen).ThenInclude(a => a.Paciente)
                // .Include(a => a.DetalleCajas).ThenInclude(a => a.Venta).ThenInclude(a => a.Empleado)
                // .Include(a => a.DetalleCajas).ThenInclude(a => a.Compra).ThenInclude(a => a.Proveedor)
                // .Include(a => a.DetalleCajas).ThenInclude(a => a.Compra).ThenInclude(a => a.Empleado)
                // .Include(a => a.DetalleCajas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Paciente)
                // .Include(a => a.DetalleCajas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Empleado)
                .Include(a => a.ResponsableAperturaLab).ThenInclude(a => a.Persona)
                .Include(a => a.ResponsableCierreLab).ThenInclude(a => a.Persona);
            }

            return caja.Where(a => a.Id == id).SingleOrDefault();
        }
        
    }
}