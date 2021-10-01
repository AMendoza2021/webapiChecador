namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOMICILIO.PAIS")]
    public partial class PAIS
    {
        [Key]
        public int IDPAIS { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(10)]
        public string CLAVECORTA { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
