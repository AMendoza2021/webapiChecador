namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.PERMISOENEMAILCPP")]
    public partial class PERMISOENEMAILCPP
    {
        [Key]
        public int IDPERMISO { get; set; }

        public int IDUSUARIO { get; set; }

        public int IDCONFIGURACION { get; set; }

        public bool ACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
