namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.EMAILCPP")]
    public partial class EMAILCPP
    {
        [Key]
        public int IDCONFIGURACION { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        [StringLength(100)]
        public string CATEGORIA { get; set; }

        [StringLength(3)]
        public string CATEGORIACLAVE { get; set; }

        [StringLength(20)]
        public string RFCEMPRESA { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string CONTRASENA { get; set; }

        public int? IDEMRPESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public bool ACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
