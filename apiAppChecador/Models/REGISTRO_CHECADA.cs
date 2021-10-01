namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.REGISTRO_CHECADA")]
    public partial class REGISTRO_CHECADA
    {
        public int ID { get; set; }

        public int? NOEMPLEADO { get; set; }

        public int? IDACCION { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? USUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
