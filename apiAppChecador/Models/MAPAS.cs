namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.MAPAS")]
    public partial class MAPAS
    {
        [Key]
        public int IDMAPA { get; set; }

        [StringLength(1)]
        public string NUMMAPA { get; set; }

        [StringLength(40)]
        public string NOMMAPA { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
