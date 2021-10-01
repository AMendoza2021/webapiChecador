namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.TIPOAREA")]
    public partial class TIPOAREA
    {
        [Key]
        public int IDTIPOAREA { get; set; }

        [StringLength(2)]
        public string NUMTIPOAREA { get; set; }

        [StringLength(50)]
        public string NOMTIPOAREA { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
