namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.XMLFACTURADETALLE")]
    public partial class XMLFACTURADETALLE
    {
        [Key]
        public int IDXMLDATADETALLE { get; set; }

        public int? IDXMLDATA { get; set; }

        public int? IDPRODUCTO { get; set; }

        public Guid? IDPRODUCTOLARISSA { get; set; }

        [StringLength(25)]
        public string PRODUCTOCLAVE { get; set; }

        [StringLength(50)]
        public string CLAVESAT { get; set; }

        [StringLength(1024)]
        public string PRODUCTO { get; set; }

        public decimal? CANTIDAD { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        [StringLength(50)]
        public string UNIDADMEDIDA { get; set; }

        [StringLength(25)]
        public string UNIDADMEDIDASAT { get; set; }

        public int? IDPRECIO { get; set; }

        public decimal? PRECIO { get; set; }

        public int? IDIMPUESTO { get; set; }

        public decimal? IMPUESTOCLAVE { get; set; }

        [StringLength(25)]
        public string FACTOR { get; set; }

        public decimal? TASA { get; set; }

        public decimal? IMPUESTOBASE { get; set; }

        public decimal? IMPUESTOIMPORTE { get; set; }

        public decimal? IMPORTE { get; set; }

        [StringLength(25)]
        public string LOTE { get; set; }

        public DateTime? CADUCIDAD { get; set; }
    }
}
