namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTARIO.LOGSINVENTARIO")]
    public partial class LOGSINVENTARIO
    {
        [Key]
        public long IDLOG { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(1000)]
        public string MENSAJE { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDINVENTARIO { get; set; }
    }
}
