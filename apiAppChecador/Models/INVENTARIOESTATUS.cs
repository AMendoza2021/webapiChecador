namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.INVENTARIOESTATUS")]
    public partial class INVENTARIOESTATUS
    {
        [Key]
        public int IDESTATUS { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(15)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
