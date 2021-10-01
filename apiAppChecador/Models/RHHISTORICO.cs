namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.RHHISTORICO")]
    public partial class RHHISTORICO
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int? IDREQUISICION { get; set; }

        public int? IDFLUJO { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }

        public int? IDESTATUSACTUAL { get; set; }

        public int? IDESTATUSNUEVO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public int? IDUSUARIOACTUALIZA { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual RH RH { get; set; }

        public virtual RHESTATUS RHESTATUS { get; set; }

        public virtual RHESTATUS RHESTATUS1 { get; set; }
    }
}
