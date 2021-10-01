namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.ORDENCOSTEO")]
    public partial class ORDENCOSTEO
    {
        [Key]
        public int IDOrden { get; set; }

        public int IDEmpresa { get; set; }

        public int IDSucursal { get; set; }

        public int IDTipo { get; set; }

        public int IDSubtipo { get; set; }

        public int? IDGrupo { get; set; }

        public int IDProducto { get; set; }

        public int IDSituacion { get; set; }

        public int? IDExistencia { get; set; }

        public int? IDOrdenProduccion { get; set; }

        public int? IDOrdenAcondicionamiento { get; set; }

        [Required]
        [StringLength(25)]
        public string Folio { get; set; }

        [StringLength(25)]
        public string NoLote { get; set; }

        public decimal? CantidadTeorica { get; set; }

        public decimal? CantidadObtenida { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [StringLength(500)]
        public string Comentarios { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }
    }
}
