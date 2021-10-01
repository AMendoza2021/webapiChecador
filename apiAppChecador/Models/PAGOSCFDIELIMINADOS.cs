namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.PAGOSCFDIELIMINADOS")]
    public partial class PAGOSCFDIELIMINADOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPAGOCFDI { get; set; }

        public int IDPAGO { get; set; }

        [Required]
        [StringLength(50)]
        public string UUID { get; set; }

        public DateTime FECHATIMBRADO { get; set; }

        [StringLength(25)]
        public string CERTIFICADOEMISOR { get; set; }

        [StringLength(25)]
        public string CERTIFICADOSAT { get; set; }

        public string SELLOEMISOR { get; set; }

        public string SELLOSAT { get; set; }

        public bool? CANCELADO { get; set; }

        [Column(TypeName = "xml")]
        public string XML { get; set; }

        public byte[] CBB { get; set; }

        public string CADENAORIGINAL { get; set; }

        [StringLength(1024)]
        public string RUTAXML { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }
    }
}
