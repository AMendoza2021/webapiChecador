namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.ABONOSHISTORIAL")]
    public partial class ABONOSHISTORIAL
    {
        [Key]
        public int IDREG { get; set; }

        public int IDABONO { get; set; }

        public int IDPAGO { get; set; }

        public int IDFACTURA { get; set; }

        [Required]
        [StringLength(50)]
        public string FOLIO { get; set; }

        public decimal SALDOINICIAL { get; set; }

        public decimal ABONO { get; set; }

        public decimal SALDOFINAL { get; set; }

        public bool GENERADO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCION { get; set; }

        [StringLength(1000)]
        public string MOTIVO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
