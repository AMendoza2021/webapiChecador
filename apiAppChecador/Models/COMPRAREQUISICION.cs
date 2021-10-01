namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPRAS.COMPRAREQUISICION")]
    public partial class COMPRAREQUISICION
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDCOMPRA { get; set; }

        public int? IDREQUISICION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual COMPRA COMPRA { get; set; }

        public virtual COMPRA1 COMPRA1 { get; set; }
    }
}
