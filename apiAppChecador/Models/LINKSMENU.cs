namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.LINKSMENU")]
    public partial class LINKSMENU
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDMENU { get; set; }

        public int? IDLINK { get; set; }

        public int? IDROL { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? USUARIOACTUALIZO { get; set; }

        public virtual LINK LINK { get; set; }

        public virtual MENU MENU { get; set; }

        public virtual ROL1 ROL1 { get; set; }
    }
}
