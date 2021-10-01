namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.TIPODOCUMENTO")]
    public partial class TIPODOCUMENTO1
    {
        [Key]
        public int IDTIPODOCUMENTO { get; set; }

        public int IDEMPRESA { get; set; }

        [Required]
        [StringLength(5)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRIPCION { get; set; }

        [StringLength(5)]
        public string PREFIJO { get; set; }

        [StringLength(5)]
        public string SUFIJO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
