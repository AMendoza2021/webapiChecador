namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.COMPRADETALLE")]
    public partial class COMPRADETALLE1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRADETALLE1()
        {
            COMPRADETALLEPROVEEDOR = new HashSet<COMPRADETALLEPROVEEDOR>();
        }

        [Key]
        public int IDREG { get; set; }

        public int? IDREQUISICION { get; set; }

        public int? IDPRODUCTO { get; set; }

        public decimal? CANTIDAD { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public decimal? PRODUCTOPROCESADO { get; set; }

        public decimal? PRODUCTOFALTANTE { get; set; }

        public int? IDUSUARIOACTUALIZA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZA { get; set; }

        public int? IDPRODUCTOCOMPRA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual COMPRA1 COMPRA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLEPROVEEDOR> COMPRADETALLEPROVEEDOR { get; set; }
    }
}
