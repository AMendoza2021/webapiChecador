namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.USUARIOCHECAEMPLEADO")]
    public partial class USUARIOCHECAEMPLEADO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDUSUARIO { get; set; }

        public int? IDEMPLEADO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
