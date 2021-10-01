namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOTIFICACIONES.NOTIFICACION")]
    public partial class NOTIFICACION
    {
        [Key]
        public int IDNOTIFICACION { get; set; }

        [StringLength(500)]
        public string TOKENID { get; set; }

        [StringLength(100)]
        public string TIPODISPOSITIVO { get; set; }

        [StringLength(100)]
        public string MACADD { get; set; }

        public int? IDUSUARIO { get; set; }

        [StringLength(100)]
        public string CATEGORIA { get; set; }

        [StringLength(300)]
        public string EMAIL { get; set; }

        public bool? ACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
