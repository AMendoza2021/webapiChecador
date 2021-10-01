namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.COMPRAARCHIVOADJUNTO")]
    public partial class COMPRAARCHIVOADJUNTO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDREQUISICION { get; set; }

        [StringLength(100)]
        public string NOMBREARCHIVO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public byte[] ARCHIVO { get; set; }

        public DateTime? FECHA { get; set; }
    }
}
