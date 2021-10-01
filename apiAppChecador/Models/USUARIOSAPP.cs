namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.USUARIOSAPP")]
    public partial class USUARIOSAPP
    {
        public int ID { get; set; }

        public int? NOEMPLEADO { get; set; }

        public int? IDEMPLEADO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APELLIDO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? USUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }

    }
}
