namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.COMPRADETALLEPROVEEDOR")]
    public partial class COMPRADETALLEPROVEEDOR
    {
        [Key]
        public int IDREG { get; set; }

        public bool? FAVORITO { get; set; }

        public int? IDREQPRODUCTO { get; set; }

        public int? IDPROVEEDOR { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }

        public virtual COMPRADETALLE1 COMPRADETALLE1 { get; set; }
    }
}
