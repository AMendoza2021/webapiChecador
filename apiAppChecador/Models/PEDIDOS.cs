namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.PEDIDOS")]
    public partial class PEDIDOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEDIDOS()
        {
            REGISTROVENTA = new HashSet<REGISTROVENTA>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
        }

        [Key]
        public int IDPEDIDO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDAGENTE { get; set; }

        public int IDSITUACION { get; set; }

        [Required]
        [StringLength(10)]
        public string FOLIO { get; set; }

        [StringLength(25)]
        public string ORDENCLIENTE { get; set; }

        public int? IDSOLICITANTE { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        public int? IDMETODOPAGO { get; set; }

        public int? IDFORMAPAGO { get; set; }

        public int? IDREFERENCIABANCARIA { get; set; }

        public DateTime FECHAENTREGA { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }
    }
}
