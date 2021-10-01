namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.SUCURSALESLARISSA")]
    public partial class SUCURSALESLARISSA
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDSUCURSAL { get; set; }

        public Guid? IDSUCURSALLARISSA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
