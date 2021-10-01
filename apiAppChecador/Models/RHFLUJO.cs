namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.RHFLUJO")]
    public partial class RHFLUJO
    {
        [Key]
        public int IDFLUJO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? ESTADOACTUAL { get; set; }

        public int? ESTADONUEVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? REQFIRMA { get; set; }

        [StringLength(50)]
        public string COLUMNAFIRMA { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }
    }
}
