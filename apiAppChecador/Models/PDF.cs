namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DESCARGASCFDI.PDF")]
    public partial class PDF
    {
        [Key]
        public int IDPDF { get; set; }

        public int? IDCFDI { get; set; }

        [StringLength(1000)]
        public string RUTA { get; set; }

        [StringLength(500)]
        public string NOMBREARCHIVO { get; set; }

        public bool? EXISTE { get; set; }

        public virtual CFDI CFDI { get; set; }
    }
}
