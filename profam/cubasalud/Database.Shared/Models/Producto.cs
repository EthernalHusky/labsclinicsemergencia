using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Shared.Models
{
    [Index(nameof(NombreProducto), nameof(TipoBodegaId), nameof(Eliminado), IsUnique = true)]
    public class Producto
    {
        public Producto()
        {
            DetalleVentas = new List<DetalleVenta>();
            DetalleCotizaciones = new List<DetalleCotizacion>();
            DetalleEnvios = new List<DetalleEnvio>();
            DetalleTrasladoProductos = new List<DetalleTrasladoProductos>();
            Prescripciones = new List<Prescripcion>();
        }

        public int Id { get; set; }
        
        // public int? ViaAdministracionsId {get;set;}
        public int? TipoBodegaId {get;set;}
        public int? ViadminId {get;set;}
        public int? TipoProductoId {get;set;}
        public int? GrupoTProductoId {get;set;}
        public int? PresentacionProductoId {get;set;}
        public int? LaboratorioProductoId {get;set;}
        public int? MarcaId {get;set;}
        public int? CategoriaId { get; set; }
        public int? GrupoId {get;set;}

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio { get; set; }
         [Column(TypeName="decimal(18,2)")]
        public decimal Precio_2 { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio_3 { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio_4 { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio_5 { get; set; } // este es el que se usa, el normal
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio_6 { get; set; } // precio familiar
        [Column(TypeName="decimal(18,2)")]
        public decimal Precio_7 {get; set;}
        [Column(TypeName="decimal(18,3)")]
        public decimal PrecioCosto { get; set; }
        public int Stock { get; set; }
        public int StockInical { get; set; }

        [Required(ErrorMessage = "* Este campo es obligatorio.")]
        public string CodigoReferencia { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string ActivoYConcentracion {get;set;}
        public string Dosis {get;set;}
        public DateTime? FechaVencimiento {get;set;}
        public bool Eliminado { get; set; }
        public TipoProducto TipoProducto {get;set; }
        public TipoBodega TipoBodega {get;set;}

        // despegables para farmacia
        public Viadmin Viadmin {get;set; }
        public PresentacionProducto PresentacionProducto {get;set;}
        public GrupoTProducto GrupoTProducto {get;set;}
        public LaboratorioProducto LaboratorioProducto {get;set;}


        // despegables para insumos 

        public Categoria Categoria { get; set; }
        public Marca Marca {get;set;}
        public Grupo Grupo {get;set;}



        public ICollection<DetalleVenta> DetalleVentas { get; set; }
        public ICollection<DetalleCotizacion> DetalleCotizaciones { get; set; }
        public ICollection<DetalleEnvio> DetalleEnvios { get; set; }
        public ICollection<DetalleTrasladoProductos> DetalleTrasladoProductos {get;set;}
        public ICollection<Prescripcion> Prescripciones {get;set;}



        public string GetProductosYCodigoDeBarras
        {
            get {
                return $"{NombreProducto} - {CodigoReferencia}";
            }
        }

        public string ProductoYPresentacion{
            get
            {
                // return (PresentacionProducto == null || Categoria == null) ? $"{NombreProducto} - // Sin asignar" 
                // : ($"{NombreProducto} - {PresentacionProducto.PresentProducto}");

                return $"{NombreProducto} - {(PresentacionProducto == null ? (Categoria == null ? "" : Categoria.NombreCategoria) : PresentacionProducto.PresentProducto)} - STOCK: {Stock}";
            }
        }
    }
}