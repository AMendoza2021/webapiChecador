namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.RESPONSABLE")]
    public partial class RESPONSABLE
    {
        [Key]
        public int IDRESPONSABLE { get; set; }

        public int? CODRESPONSABLE { get; set; }

        [StringLength(70)]
        public string NOMRESPONSABLE { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
