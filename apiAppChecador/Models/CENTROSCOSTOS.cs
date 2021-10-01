namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.CENTROSCOSTOS")]
    public partial class CENTROSCOSTOS
    {
        [Key]
        public int IDCENTROCOSTOS { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string CLAVE { get; set; }

        [StringLength(150)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
