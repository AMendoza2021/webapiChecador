namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.ROLUSUARIO")]
    public partial class ROLUSUARIO
    {
        [Key]
        public int IDROLUSUARIO { get; set; }

        public int IDUSUARIO { get; set; }

        public int IDROL { get; set; }

        public DateTime FECHA { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual ROL ROL { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
