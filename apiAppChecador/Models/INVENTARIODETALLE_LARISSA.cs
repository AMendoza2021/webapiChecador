namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIODETALLE_LARISSA")]
    public partial class INVENTARIODETALLE_LARISSA
    {
        [Key]
        public long IDREG { get; set; }

        public int? IDINVENTARIO { get; set; }

        public Guid? IDEXISTENCIA { get; set; }

        public Guid? IDSUBTIPO { get; set; }

        public Guid? IDPRODUCTO { get; set; }

        public int? ITEM { get; set; }

        [StringLength(50)]
        public string NOLOTE { get; set; }

        [StringLength(50)]
        public string NOPRODUCTO { get; set; }

        [StringLength(500)]
        public string PRODUCTODESC { get; set; }

        public decimal? EXISTENCIA { get; set; }

        public decimal? CONTADO { get; set; }

        public decimal? DIFERENCIA { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public decimal? IMPORTEEXISTENCIA { get; set; }

        public decimal? IMPORTECONTADO { get; set; }

        public decimal? IMPORTEDIFERENCIA { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOCAPTURO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHACAPTURO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [StringLength(5000)]
        public string OBSERVACIONES { get; set; }
    }
}
