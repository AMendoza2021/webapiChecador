namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.CFDI")]
    public partial class CFDI1
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDCFDI { get; set; }

        [StringLength(500)]
        public string IDEMAIL { get; set; }

        [StringLength(200)]
        public string EMAIL_REMITENTE { get; set; }

        public DateTime? FECHAEMAIL { get; set; }
    }
}
