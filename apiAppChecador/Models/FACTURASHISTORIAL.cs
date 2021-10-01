namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.FACTURASHISTORIAL")]
    public partial class FACTURASHISTORIAL
    {
        [Key]
        public int IDHISTORIAL { get; set; }

        public int? IDFLUJO { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCION { get; set; }

        [Required]
        [StringLength(500)]
        public string COMENTARIOS { get; set; }

        public int IDFACTURA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int? IDCLIENTE { get; set; }

        public int IDAGENTE { get; set; }

        public int IDUSOCFDI { get; set; }

        public int? IDSITUACION { get; set; }

        public int IDDOMICILIOMATRIZ { get; set; }

        public int IDDOMICILIOSUCURSAL { get; set; }

        public int IDDOMICILIOFISCAL { get; set; }

        public int? IDDOMICILIOENVIOS { get; set; }

        [StringLength(25)]
        public string ORDENCLIENTE { get; set; }

        [StringLength(25)]
        public string SERIE { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public decimal SUBTOTAL { get; set; }

        public decimal DESCUENTO { get; set; }

        public decimal IMPUESTOSTRASLADO { get; set; }

        public decimal TOTAL { get; set; }

        public int IDMONEDA { get; set; }

        public bool ESPAGOCREDITO { get; set; }

        public int? IDREFERENCIABANCARIA { get; set; }

        public int IDMETODOPAGO { get; set; }

        public int? CONDICIONES { get; set; }

        public DateTime? FECHAVENCIMIENTO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }
    }
}
