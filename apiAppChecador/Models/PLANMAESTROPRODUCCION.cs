namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.PLANMAESTROPRODUCCION")]
    public partial class PLANMAESTROPRODUCCION
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
