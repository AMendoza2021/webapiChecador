namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.PROGRAMAFABRICACION")]
    public partial class PROGRAMAFABRICACION
    {
        [Key]
        public int IDPROGRAMA { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDSITUACION { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        public int? PRIORIDAD { get; set; }

        public DateTime? FECHAEMISION { get; set; }

        public DateTime? FECHACOMPROMISO { get; set; }

        public DateTime? FECHAPLANEADAINICIO { get; set; }

        public DateTime? FECHAPLANEADAFIN { get; set; }

        public DateTime? FECHAINACTIVO { get; set; }

        [StringLength(500)]
        public string COMENTARIOS { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
