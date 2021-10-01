namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.PROVEEDORPRODUCTO")]
    public partial class PROVEEDORPRODUCTO
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDPROVEEDOR { get; set; }

        public int? IDPRODUCTOINTERNO { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        [StringLength(500)]
        public string NOMBRE { get; set; }

        [StringLength(500)]
        public string NOMBREUS { get; set; }

        [StringLength(1000)]
        public string DESCRIPCION { get; set; }

        [StringLength(5000)]
        public string COMENTARIOS { get; set; }

        public decimal? COSTOMXN { get; set; }

        public decimal? COSTOUSD { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
