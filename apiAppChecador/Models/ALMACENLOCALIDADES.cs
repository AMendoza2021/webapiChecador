namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.ALMACENLOCALIDADES")]
    public partial class ALMACENLOCALIDADES
    {
        [Key]
        public Guid IDLocalidadLarissa { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int? IDAlmacen { get; set; }

        public int? IDLocalidad { get; set; }
    }
}
