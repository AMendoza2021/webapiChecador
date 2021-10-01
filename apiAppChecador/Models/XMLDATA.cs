namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.XMLDATA")]
    public partial class XMLDATA
    {
        [Key]
        public int IDDOCUMENTO { get; set; }

        [StringLength(255)]
        public string XMLNOMBRE { get; set; }

        [Column("XMLDATA", TypeName = "xml")]
        public string XMLDATA1 { get; set; }

        public DateTime? FECHA { get; set; }
    }
}
