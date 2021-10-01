namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.NOTASCREDITOCFDI")]
    public partial class NOTASCREDITOCFDI
    {
        [Key]
        public int IDNOTACREDITOCFDI { get; set; }

        public int IDNOTACREDITO { get; set; }

        [Required]
        [StringLength(50)]
        public string UUID { get; set; }

        public DateTime FECHATIMBRADO { get; set; }

        [Required]
        [StringLength(50)]
        public string CERTIFICADOEMISOR { get; set; }

        [Required]
        [StringLength(50)]
        public string CERTIFICADOSAT { get; set; }

        public string SELLOEMISOR { get; set; }

        public string SELLOSAT { get; set; }

        public bool? CANCELADA { get; set; }

        public byte[] CBB { get; set; }

        [Required]
        public string CADENAORIGINAL { get; set; }

        [Required]
        [StringLength(1024)]
        public string RUTAXML { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        [Column(TypeName = "xml")]
        public string XML { get; set; }

        public virtual NOTASCREDITO NOTASCREDITO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
