namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.CACTUAL")]
    public partial class CACTUAL
    {
        [Key]
        public int IDACTUAL { get; set; }

        public int? IDTACTIVIDAD { get; set; }

        public int? IDUSUARIO { get; set; }

        public int? IDAREA { get; set; }

        [StringLength(150)]
        public string CONCEPTO { get; set; }

        [StringLength(50)]
        public string NUMORDEN { get; set; }

        public DateTime? FECHACAPTURA { get; set; }

        public DateTime? FECHAREGISTRO { get; set; }

        public DateTime? INICIO { get; set; }

        public DateTime? FIN { get; set; }

        [StringLength(150)]
        public string EMPLEADOS { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
