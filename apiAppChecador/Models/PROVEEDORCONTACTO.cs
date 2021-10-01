namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.PROVEEDORCONTACTO")]
    public partial class PROVEEDORCONTACTO
    {
        [Key]
        public int IDCONTACTO { get; set; }

        public int? IDPROVEEDOR { get; set; }

        [StringLength(1000)]
        public string CONTACTO { get; set; }

        [StringLength(100)]
        public string TELEFONO { get; set; }

        [StringLength(10)]
        public string EXT { get; set; }

        [StringLength(100)]
        public string CELULAR { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string FAX { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
