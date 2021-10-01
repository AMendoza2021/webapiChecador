namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.CANCELACIONCDFI")]
    public partial class CANCELACIONCDFI
    {
        [Key]
        public int IDCANCELACIONCDFI { get; set; }

        public int IDFACTURAELECTRONICA { get; set; }

        public int IDSITUACION { get; set; }

        [Required]
        [StringLength(50)]
        public string CHRTIPOCOMPROBANTE { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string CHRRESPUESTAXML { get; set; }

        public int INTESTATUSCANCELACION { get; set; }

        [StringLength(300)]
        public string STRACK { get; set; }

        [StringLength(300)]
        public string STRTEXTOCANCELACION { get; set; }

        [StringLength(50)]
        public string CHRUUIDDCANCELACION { get; set; }

        [StringLength(1024)]
        public string CHRRUTAXML { get; set; }

        [Required]
        [StringLength(500)]
        public string STRMOTIVO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
