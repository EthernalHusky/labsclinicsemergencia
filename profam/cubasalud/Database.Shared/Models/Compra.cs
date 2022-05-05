using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Database.Shared.Models
{
    public class Compra
    {

        public Compra()
        {
            DetalleCompras = new List<DetalleCompra>();
            Recepciones = new List<Recepcion>();
        }
        
        public int Id { get; set; }
        public int TipoCompraId {get;set;}
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public int EmpleadoId { get; set; }
        public string NoComprobante {get; set;}
        public string NombreVendedor {get; set;}
        public DateTime FechaLimite {get; set;}
        public DateTime FechaRecepcion {get; set;}
        public DateTime FechaCompra {get; set;}
        public bool Estado {get; set;}
        public bool Eliminado {get; set;}
        public Proveedor Proveedor {get;set;}
        public Empleado Empleado {get;set;}
        public string Observaciones {get;set;}
        public TipoCompra TipoCompra {get;set;} 

        public ICollection<DetalleCompra> DetalleCompras {get;set;}
        public ICollection<Recepcion> Recepciones {get;set;}

        public string verEstado(){

            if(Estado==false)
            {
                return "Peticion"; 
            }

                return "Comprado";

        }


    }
}