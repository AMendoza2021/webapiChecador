namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.INFORMATICAASIGNACION")]
    public partial class INFORMATICAASIGNACION
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDREQUISICION { get; set; }

        public int? IDEMPLEADO { get; set; }

        [StringLength(1000)]
        public string COMENTARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual INFORMATICA INFORMATICA { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}
