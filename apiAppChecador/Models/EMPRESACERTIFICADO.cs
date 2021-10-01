namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.EMPRESACERTIFICADO")]
    public partial class EMPRESACERTIFICADO
    {
        [Key]
        public int IDCERTIFICADO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDEMPRESA { get; set; }

        [StringLength(100)]
        public string PATHCER { get; set; }

        [StringLength(100)]
        public string PATHKEY { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public DateTime? IDUSUARIOACTUALIZO { get; set; }
    }
}
