namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.MOVIMIENTO")]
    public partial class MOVIMIENTO
    {
        [Key]
        public int IDMOVIMIENTO { get; set; }

        [StringLength(2)]
        public string NUMMOVIMIENTO { get; set; }

        [StringLength(50)]
        public string NOMMOVIMIENTO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
