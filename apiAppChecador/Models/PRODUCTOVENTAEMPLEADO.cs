namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.PRODUCTOVENTAEMPLEADO")]
    public partial class PRODUCTOVENTAEMPLEADO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDSUCURSAL { get; set; }

        public Guid? IDSUCURSALLARISSA { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        public int? IDPRODUCTO { get; set; }

        public Guid? IDPRODUCTOLARISSA { get; set; }

        public bool? RECETA { get; set; }

        public bool? AUTORIZACION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
