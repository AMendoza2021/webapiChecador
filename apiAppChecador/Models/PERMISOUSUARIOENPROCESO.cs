namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.PERMISOUSUARIOENPROCESO")]
    public partial class PERMISOUSUARIOENPROCESO
    {
        [Key]
        public int IDPERMISO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(25)]
        public string PROCESO { get; set; }

        public int? IDUSUARIO { get; set; }

        [StringLength(50)]
        public string PERMISO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
