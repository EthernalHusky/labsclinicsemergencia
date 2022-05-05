using Database.Shared.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Database.Shared.IRepository;
using System;
using Database.Shared.Paginacion;

namespace sistema.Models
{
    public class ConsultasViewModel
    {
        public Consulta Consulta {get;set;}
        public int CitaId {get;set;}
        public string Nombres {get;set;}
        public string Servicio {get;set;}
        public int EstadoPagoId {get;set;} = 2;
        public string MedicoAsignado {get;set;}
        public decimal CostoConsulta {get;set;}
        public string FechaYHoraInicio {get;set;}

        // para paginacion
        public string buscar {get;set;}
        public string currentFilter {get; set;}
        public int? pageNumber {get;set;}
        public PaginacionList<Consulta> Consultas {get;set;}

        public SelectList EstadosPagosLista {get;set;}

        public void Init(ICitas citaRepository)
        {
            EstadosPagosLista = new SelectList(citaRepository.EstadoPagosConsultasLista(), "Id", "Estado", 2);
        }
    }
}