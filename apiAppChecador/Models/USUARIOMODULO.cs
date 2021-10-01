namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.USUARIOMODULO")]
    public partial class USUARIOMODULO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDUSUARIO { get; set; }

        public int? IDMODULO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDROL { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual MODULO MODULO { get; set; }

        public virtual ROL1 ROL1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
