namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[CATALOGO.TEST]")]
    public partial class CATALOGO_TEST
    {
        [Key]
        [Column(Order = 0)]
        public int IDTEST { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NOMBRE { get; set; }
    }
}
