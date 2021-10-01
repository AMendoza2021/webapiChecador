namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.REGISTROVENTA")]
    public partial class REGISTROVENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISTROVENTA()
        {
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
            REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
        }

        [Key]
        public int IDREGISTROVENTA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDSITUACION { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDAGENTE { get; set; }

        public int IDPEDIDO { get; set; }

        public bool ESCREDITO { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public DateTime? FECHAENTREGATENTATIVA { get; set; }

        public DateTime? FECHAENTREGA { get; set; }

        public decimal SUBTOTAL { get; set; }

        public int DESCUENTOPORCIENTO { get; set; }

        public decimal DESCUENTO { get; set; }

        public decimal IMPUESTOSTRASLADO { get; set; }

        public decimal TOTAL { get; set; }

        public int IDMONEDA { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDREFERENCIABANCARIA { get; set; }

        public int? IDMETODOPAGO { get; set; }

        public int? IDFORMAPAGO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual PEDIDOS PEDIDOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }
    }
}
