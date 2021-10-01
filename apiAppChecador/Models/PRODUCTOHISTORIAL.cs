namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.PRODUCTOHISTORIAL")]
    public partial class PRODUCTOHISTORIAL
    {
        [Key]
        public int IDHISTORIAL { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int? IDPRODUCTO { get; set; }

        [StringLength(75)]
        public string ACCION { get; set; }

        [StringLength(75)]
        public string EVENTO { get; set; }

        [StringLength(750)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
