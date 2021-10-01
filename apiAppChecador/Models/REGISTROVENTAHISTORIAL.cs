namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.REGISTROVENTAHISTORIAL")]
    public partial class REGISTROVENTAHISTORIAL
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

        public int IDREGISTROVENTA { get; set; }

        public int IDPEDIDO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDSITUACION { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDAGENTE { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public DateTime? FECHAENTREGATENTATIVA { get; set; }

        public DateTime? FECHAENTREGA { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public int? DESCUENTOPORCIENTO { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal? IMPUESTOSTRASLADO { get; set; }

        public decimal? TOTAL { get; set; }

        public int IDMONEDA { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual PEDIDOS PEDIDOS { get; set; }

        public virtual REGISTROVENTA REGISTROVENTA { get; set; }
    }
}
