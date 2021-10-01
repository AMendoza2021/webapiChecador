namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.TEST")]
    public partial class TEST
    {
        [Key]
        public int PK_ALMACEN { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }
    }
}
