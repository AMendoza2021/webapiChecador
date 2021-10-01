namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.DOCUMENTOS")]
    public partial class DOCUMENTOS
    {
        [Key]
        public int IDDOCUMENTO { get; set; }

        public int? IDEMPRESA { get; set; }

        [Required]
        [StringLength(5)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRIPCION { get; set; }

        [StringLength(10)]
        public string PREFIJOGLOBAL { get; set; }

        [StringLength(10)]
        public string PREFIJO { get; set; }

        [StringLength(10)]
        public string SUFIJO { get; set; }

        [StringLength(5)]
        public string SEPARADORGLOBAL { get; set; }

        [StringLength(5)]
        public string SEPARADORPREFIJO { get; set; }

        [StringLength(5)]
        public string SEPARADORSUFIJO { get; set; }

        [StringLength(50)]
        public string REGEX { get; set; }

        [Required]
        [StringLength(1)]
        public string VISTAPREDET { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
