namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.ABONOS")]
    public partial class ABONOS
    {
        [Key]
        public int IDABONO { get; set; }

        public int IDPAGO { get; set; }

        public int IDFACTURA { get; set; }

        public int? IDSITUACION { get; set; }

        public decimal IMPORTE { get; set; }

        public decimal ABONO { get; set; }

        public decimal SALDO { get; set; }

        public decimal TIPOCAMBIO { get; set; }

        public bool? GENERADO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual FACTURAS FACTURAS { get; set; }

        public virtual PAGOS PAGOS { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
