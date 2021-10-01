namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.NOTASDEVOLUCIONCFDI")]
    public partial class NOTASDEVOLUCIONCFDI
    {
        [Key]
        public int IDNOTADEVOLUCIONCFDI { get; set; }

        public int IDNOTADEVOLUCION { get; set; }

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

        public bool? CANCELADA { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string XML { get; set; }

        public byte[] CBB { get; set; }

        [Required]
        public string CADENAORIGINAL { get; set; }

        [Required]
        [StringLength(1024)]
        public string RUTAXML { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual NOTASDEVOLUCION NOTASDEVOLUCION { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
