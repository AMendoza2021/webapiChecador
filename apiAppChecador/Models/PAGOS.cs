namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.PAGOS")]
    public partial class PAGOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAGOS()
        {
            ABONOS = new HashSet<ABONOS>();
            PAGOSCFDI = new HashSet<PAGOSCFDI>();
            PAGOSCFDI1 = new HashSet<PAGOSCFDI>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
        }

        [Key]
        public int IDPAGO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDTIPOPAGO { get; set; }

        [Required]
        [StringLength(50)]
        public string FOLIO { get; set; }

        public decimal IMPORTE { get; set; }

        public int IDMONEDA { get; set; }

        public decimal TIPOCAMBIO { get; set; }

        [StringLength(50)]
        public string REFERENCIA { get; set; }

        public DateTime? FECHADEPOSITO { get; set; }

        public bool GENERADO { get; set; }

        public int? IDFORMAPAGO { get; set; }

        public int? IDBANCOORIGEN { get; set; }

        [StringLength(50)]
        public string CUENTAORDENANTE { get; set; }

        public int? IDBANCODESTINO { get; set; }

        [StringLength(50)]
        public string CUENTADESTINO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDSITUACION { get; set; }

        public int? IDAGENTE { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDREFERENCIA { get; set; }

        public int? IDREFERENCIANEGOCIO { get; set; }

        public bool? SPEI { get; set; }

        [Column(TypeName = "xml")]
        public string SPEIXML { get; set; }

        [StringLength(50)]
        public string SERIE { get; set; }

        public bool IMPRIRRS { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual BANCO BANCO1 { get; set; }

        public virtual FORMASPAGO FORMASPAGO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ABONOS> ABONOS { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual TIPOPAGO TIPOPAGO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSCFDI> PAGOSCFDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSCFDI> PAGOSCFDI1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }
    }
}
