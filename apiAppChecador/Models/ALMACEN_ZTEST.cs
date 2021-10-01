namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("[ALMACEN.ZTEST]")]
    public partial class ALMACEN_ZTEST
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }
    }
}
