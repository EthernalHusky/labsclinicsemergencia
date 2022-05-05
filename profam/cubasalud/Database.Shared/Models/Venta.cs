using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Shared.Models
{
    public class Venta
    {

        public Venta()
        {
            DetalleVenta = new List<DetalleVenta>();
            Pagos = new List<Pagos>();
            DetalleCajas = new List<DetalleCaja>();
            DetalleCajaClinicas = new List<DetalleCajaClinica>();
        }
        public int Id { get; set; }
        public int? PacienteId { get; set; }
        public int? ClientesId {get;set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public int EmpleadoId { get; set; }
        public string NoComprobante {get; set;}
        public string Nit {get; set;}
        public string Nombres {get; set;}
        public string Direccion {get; set;}
        public int? EnvioId {get;set;}
        public DateTime FechaVenta {get;set;}
        public bool Eliminado {get; set;}
        public string TipoVenta {get;set;} 
        public Paciente Paciente {get;set;}
        public Empleado Empleado {get;set;}
        public Clientes Clientes {get;set;}
        public Envio Envio {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal MontoPago {get;set;}
        [Column(TypeName="decimal(18,2)")]
        public decimal Vuelto {get;set;}

        public ICollection<DetalleVenta> DetalleVenta {get;set;}
        public ICollection<Pagos> Pagos {get;set;}
        public ICollection<DetalleCaja> DetalleCajas {get;set;}
        public ICollection<DetalleCajaClinica> DetalleCajaClinicas {get;set;}

    }
}