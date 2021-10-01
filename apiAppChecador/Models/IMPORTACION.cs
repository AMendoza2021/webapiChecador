namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UTILERIAS.IMPORTACION")]
    public partial class IMPORTACION
    {
        [Key]
        public int IDPROCESO { get; set; }

        public int IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        [Required]
        [StringLength(1)]
        public string TIPO { get; set; }

        public int IDTIPODOCUMENTO { get; set; }

        public int IDSITUACION { get; set; }

        public int REGISTROS { get; set; }

        public int REGISTROSAFECTADOS { get; set; }

        [StringLength(500)]
        public string RUTAARCHIVO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
