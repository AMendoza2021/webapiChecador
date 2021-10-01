namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.SUCURSALPROVEEDOR")]
    public partial class SUCURSALPROVEEDOR
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDPROVEEDOR { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
