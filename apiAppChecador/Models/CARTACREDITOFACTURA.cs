namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPP.CARTACREDITOFACTURA")]
    public partial class CARTACREDITOFACTURA
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDCARTACREDITO { get; set; }

        public int? IDFACTURA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
