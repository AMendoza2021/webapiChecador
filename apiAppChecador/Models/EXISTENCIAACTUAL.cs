namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.EXISTENCIAACTUAL")]
    public partial class EXISTENCIAACTUAL
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        public int? IDEXISTENCIA { get; set; }

        [StringLength(20)]
        public string NOLOTE { get; set; }

        public decimal? TOTAL { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
