namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.PRODUCTOLICITACION")]
    public partial class PRODUCTOLICITACION
    {
        [Key]
        public int IDPRODUCTOLICITACION { get; set; }

        [Required]
        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(255)]
        public string CHRCAMPO1 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO2 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO3 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO4 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO5 { get; set; }

        [StringLength(1000)]
        public string CHRDESCRIPCION { get; set; }

        [StringLength(1000)]
        public string CHRCLAVE { get; set; }

        [StringLength(1000)]
        public string CHRPRESENTACION { get; set; }

        [StringLength(255)]
        public string CHRCAMPO6 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO7 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO8 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO9 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO10 { get; set; }

        public int? INTCANTIDAD { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
