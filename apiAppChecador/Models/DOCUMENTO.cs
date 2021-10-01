namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUMENTOS.DOCUMENTO")]
    public partial class DOCUMENTO
    {
        [Key]
        [Column(Order = 0)]
        public int IDDOCUMENTO { get; set; }

        public string TITULO { get; set; }

        public int? PROPIETARIO { get; set; }

        [StringLength(500)]
        public string ENLACE { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool ACTIVO { get; set; }
    }
}
