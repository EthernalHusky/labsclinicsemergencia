using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int? CitasId {get;set;}
        public int? PrescripcionId {get;set;}
        public int? HistoriaId {get;set;}
        public int? ExamenFisicoId {get;set;}
        public int EstadoPagoConsultaId {get;set;}
        public string ObservacionesAdicionales {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal CostoConsulta {get;set;}
        public DateTime FechaYHoraInicioConsulta {get;set;}
        public bool Archivado {get;set;}
        public EstadoPagoConsulta EstadoPagoConsulta {get;set;}
        public Prescripcion Prescripcion {get;set;}
        // public Historia Historia {get;set;}
        public Citas Citas {get;set;}
        public Historia Historia {get;set;}
        public ExamenFisico ExamenFisico {get;set;}
    }
}