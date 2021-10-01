namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.FOLIOSUCURSAL")]
    public partial class FOLIOSUCURSAL
    {
        [Key]
        public int IDCONFIGURACION { get; set; }

        [StringLength(30)]
        public string CLAVE { get; set; }

        public int? IDSUCURSAL { get; set; }

        [StringLength(10)]
        public string PREFIJO { get; set; }

        [StringLength(10)]
        public string SUFIJO { get; set; }

        public int? CONSECUTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDDOCUMENTO { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
