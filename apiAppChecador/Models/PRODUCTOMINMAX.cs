namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.PRODUCTOMINMAX")]
    public partial class PRODUCTOMINMAX
    {
        [Key]
        public int IDMINMAX { get; set; }

        public int IDPRODUCTO { get; set; }

        public decimal? MINTIJ { get; set; }

        public decimal? MAXTIJ { get; set; }

        public decimal? MINMTY { get; set; }

        public decimal? MAXMTY { get; set; }

        public decimal? MINHER { get; set; }

        public decimal? MAXHER { get; set; }

        public decimal? MINPUB { get; set; }

        public decimal? MAXPUB { get; set; }

        public decimal? MINMEX { get; set; }

        public decimal? MAXMEX { get; set; }

        public decimal? MINGUA { get; set; }

        public decimal? MAXGUA { get; set; }

        public decimal? MINMER { get; set; }

        public decimal? MAXMER { get; set; }

        public decimal? MINGLO { get; set; }

        public decimal? MAXGLO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
