namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ORDENPRODUCCION")]
    public partial class ORDENPRODUCCION
    {
        [Key]
        public int IDOrden { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        public int? IDPrograma { get; set; }

        public int? IDProgramaDetalle { get; set; }

        public int IDSituacion { get; set; }

        public int IDFormula { get; set; }

        public int IDProductoFabricacion { get; set; }

        public int IDProductoSalida { get; set; }

        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string ClaveFormula { get; set; }

        [Required]
        [StringLength(50)]
        public string NoFormula { get; set; }

        [Required]
        [StringLength(50)]
        public string PNO { get; set; }

        [Required]
        [StringLength(50)]
        public string Analisis { get; set; }

        [Required]
        [StringLength(255)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(75)]
        public string PeriodoCaducidad { get; set; }

        public int NoOrden { get; set; }

        [Required]
        [StringLength(50)]
        public string NoLote { get; set; }

        public DateTime FechaCaducidadLote { get; set; }

        public decimal TamanoEstandar { get; set; }

        public decimal TamanoFabricar { get; set; }

        public decimal? TamanoFabricado { get; set; }

        public int IDUMTamanoLote { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int? IDUsuarioEmitio { get; set; }

        public DateTime? FechaEmision { get; set; }

        public int? IDUsuarioProduccion { get; set; }

        public DateTime? FechaUsuarioProduccion { get; set; }

        public int? IDUsuarioCalidad { get; set; }

        public DateTime? FechaUsuarioCalidad { get; set; }

        public int? IDUsuarioRespSanitario { get; set; }

        public DateTime? FechaUsuarioRespSanitario { get; set; }

        public int? RendimientoMaximo { get; set; }

        public int? RendimientoMinimo { get; set; }

        public decimal? RendimientoObtenido { get; set; }

        public int? IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int? IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }
    }
}
