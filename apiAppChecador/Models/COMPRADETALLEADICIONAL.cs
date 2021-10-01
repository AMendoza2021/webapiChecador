namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPRAS.COMPRADETALLEADICIONAL")]
    public partial class COMPRADETALLEADICIONAL
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDCOMPRA { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDPRODUCTOREQUISICION { get; set; }

        public int? IDORDENCOMPRADETALLE { get; set; }

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

        public virtual COMPRA COMPRA { get; set; }
    }
}
