namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPRAS.COMPRADETALLE")]
    public partial class COMPRADETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRADETALLE()
        {
            ACTIVOSFIJOS = new HashSet<ACTIVOSFIJOS>();
        }

        [Key]
        public int IDREG { get; set; }

        public int? IDCOMPRA { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDPRODUCTOREQUISICION { get; set; }

        public decimal? CANTIDAD { get; set; }

        public decimal? PRECIO { get; set; }

        public double? DESCUENTO { get; set; }

        public decimal? TOTAL { get; set; }

        public int? PRODUCTOPROVEEDOR { get; set; }

        public decimal? PRODUCTORECIBIDO { get; set; }

        public decimal? PRODUCTOFALTANTE { get; set; }

        public int? IDUSUARIOACTUALIZA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZA { get; set; }

        public bool? APLICAIVA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual PRODUCTO PRODUCTO1 { get; set; }

        public virtual COMPRA COMPRA { get; set; }

        public virtual COMPRA COMPRA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }
    }
}
