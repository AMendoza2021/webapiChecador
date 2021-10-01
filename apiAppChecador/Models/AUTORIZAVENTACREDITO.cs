namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.AUTORIZAVENTACREDITO")]
    public partial class AUTORIZAVENTACREDITO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDESTATUS { get; set; }

        public Guid? IDREGISTRODEVENTA { get; set; }

        public decimal? CREDITOAUTORIZADO { get; set; }

        public decimal? DEUDAACTUAL { get; set; }

        public decimal? EXTENSIONDECREDITO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? AUTORIZADO { get; set; }

        public int? IDUSUARIOAUTORIZO { get; set; }

        public DateTime? FECHAAUTORIZO { get; set; }

        public Guid? IDUSUARIOSOLICITO { get; set; }

        public Guid? IDUSUARIOCANCELO { get; set; }
    }
}
