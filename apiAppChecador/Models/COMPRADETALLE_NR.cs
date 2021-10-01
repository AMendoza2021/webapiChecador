namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.COMPRADETALLE_NR")]
    public partial class COMPRADETALLE_NR
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDREQUISICION { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(1000)]
        public string NOMBRE { get; set; }

        public decimal? CANTIDAD { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        public int? IDPROVEEDOR { get; set; }

        [StringLength(1000)]
        public string MOTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDPRODUCTO { get; set; }
    }
}
