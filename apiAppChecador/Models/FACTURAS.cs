namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.FACTURAS")]
    public partial class FACTURAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURAS()
        {
            NOTASCREDITO = new HashSet<NOTASCREDITO>();
            NOTASDEVOLUCION = new HashSet<NOTASDEVOLUCION>();
            ABONOS = new HashSet<ABONOS>();
            FACTURALICITACION = new HashSet<FACTURALICITACION>();
            FACTURASCFDI = new HashSet<FACTURASCFDI>();
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
        }

        [Key]
        public int IDFACTURA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDAGENTE { get; set; }

        public int IDREGIMENFISCAL { get; set; }

        public int IDUSOCFDI { get; set; }

        public int IDSITUACION { get; set; }

        public int IDDOMICILIOSUCURSAL { get; set; }

        public int IDDOMICILIOMATRIZ { get; set; }

        public int IDDOMICILIOFISCAL { get; set; }

        public int? IDDOMICILIOENVIOS { get; set; }

        [StringLength(255)]
        public string ORDENCLIENTE { get; set; }

        [Required]
        [StringLength(10)]
        public string SERIE { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        public int IDMONEDA { get; set; }

        public decimal? TIPOCAMBIO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string IMPORTELETRA { get; set; }

        public bool ESPAGOCREDITO { get; set; }

        public int IDMETODOPAGO { get; set; }

        public int? IDFORMAPAGO { get; set; }

        public int? IDREFERENCIABANCARIA { get; set; }

        public int? CONDICIONES { get; set; }

        public DateTime? FECHAVENCIMIENTO { get; set; }

        [StringLength(1024)]
        public string COMENTARIOS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(50)]
        public string CODIGOPOSTAL { get; set; }

        [StringLength(250)]
        public string LUGAREXPEDICION { get; set; }

        public virtual METODOSPAGO METODOSPAGO { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual REGIMENFISCAL REGIMENFISCAL { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual USOCFDI USOCFDI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASCREDITO> NOTASCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASDEVOLUCION> NOTASDEVOLUCION { get; set; }

        public virtual DOMICILIO DOMICILIO { get; set; }

        public virtual DOMICILIO DOMICILIO1 { get; set; }

        public virtual DOMICILIO DOMICILIO2 { get; set; }

        public virtual DOMICILIOENTREGA DOMICILIOENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ABONOS> ABONOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURALICITACION> FACTURALICITACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASCFDI> FACTURASCFDI { get; set; }

        public virtual AGENTES AGENTES { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual REFERENCIASBANCARIAS REFERENCIASBANCARIAS { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }
    }
}
