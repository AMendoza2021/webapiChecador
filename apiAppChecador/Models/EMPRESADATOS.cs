namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.EMPRESADATOS")]
    public partial class EMPRESADATOS
    {
        [Key]
        public int IDDATOS { get; set; }

        public int? IDEMPRESA { get; set; }

        [StringLength(1000)]
        public string CONTACTO { get; set; }

        [StringLength(20)]
        public string TELEFONO { get; set; }

        [StringLength(10)]
        public string EXT { get; set; }

        [StringLength(100)]
        public string CELULAR { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string SITIOWEB { get; set; }

        [StringLength(1024)]
        public string LOGOURL { get; set; }

        public byte[] LOGO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }
    }
}
