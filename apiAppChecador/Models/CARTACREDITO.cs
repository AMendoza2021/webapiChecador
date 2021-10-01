namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPP.CARTACREDITO")]
    public partial class CARTACREDITO
    {
        [Key]
        public int IDCARTACREDITO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDBANCO { get; set; }

        public int? IDPROVEEDOR { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        public DateTime? FECHAVENCIMIENTO { get; set; }

        public decimal? IMPORTE { get; set; }

        [StringLength(5)]
        public string TIPOMONEDA { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public bool? PAGADA { get; set; }

        public DateTime? FECHAPAGO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }
    }
}
