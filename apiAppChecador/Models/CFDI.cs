namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DESCARGASCFDI.CFDI")]
    public partial class CFDI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CFDI()
        {
            PAGO = new HashSet<PAGO>();
            PDF = new HashSet<PDF>();
        }

        [Key]
        public int ID_CFDI { get; set; }

        public int? ID_ESTATUS { get; set; }

        [StringLength(3)]
        public string VERSION { get; set; }

        [StringLength(10)]
        public string SERIE { get; set; }

        [StringLength(10)]
        public string FOLIO { get; set; }

        [StringLength(20)]
        public string TIPO_COMPROBANTE { get; set; }

        [StringLength(30)]
        public string CERTIFICADO_SAT { get; set; }

        [StringLength(30)]
        public string CERTIFICADO_EMISOR { get; set; }

        public DateTime? FECHA_EMISION { get; set; }

        public DateTime? FECHA_TIMBRADO { get; set; }

        [StringLength(40)]
        public string UUID { get; set; }

        [Column(TypeName = "money")]
        public decimal? IMPORTE_TOTAL { get; set; }

        [StringLength(14)]
        public string RFC_EMISOR { get; set; }

        [StringLength(14)]
        public string RFC_RECEPTOR { get; set; }

        [Column(TypeName = "xml")]
        public string CONTENIDO_XML { get; set; }

        [StringLength(500)]
        public string RUTA_XML { get; set; }

        public DateTime? FECHA_LECTURA { get; set; }

        [StringLength(300)]
        public string NOMBRE_ORIGINAL { get; set; }

        [StringLength(200)]
        public string EMAIL_ORIGEN { get; set; }

        [StringLength(600)]
        public string PROVEEDOR { get; set; }

        public int? DESCARGADA { get; set; }

        public bool? FINANZAS { get; set; }

        [StringLength(200)]
        public string EMAIL_REMITENTE { get; set; }

        [StringLength(500)]
        public string IDEMAIL { get; set; }

        public DateTime? FECHAEMAIL { get; set; }

        public Guid? IDCOMENTARIO { get; set; }

        public bool? CONTRARECIBO { get; set; }

        [StringLength(5000)]
        public string MSGCONTRARECIBO { get; set; }

        public DateTime? FECHAESTIMADAPAGO { get; set; }

        public DateTime? FECHAPAGADA { get; set; }

        [StringLength(1000)]
        public string DESTINATARIOSCONTRARECIBO { get; set; }

        [StringLength(1000)]
        public string ASUNTOCONTRARECIBO { get; set; }

        public DateTime? FECHACONTRARECIBO { get; set; }

        [StringLength(1000)]
        public string CONDICIONES { get; set; }

        [StringLength(5)]
        public string TIPOMONEDA { get; set; }

        public int? RECIBIDA { get; set; }

        public int? PAGADA { get; set; }

        public int? PROCESADA { get; set; }

        [StringLength(100)]
        public string TIPOFACTURA { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDPROVEEDOR { get; set; }

        public Guid? IDARCHIVOSADJUNTOS { get; set; }

        [StringLength(1000)]
        public string MOTIVOCANCELACION { get; set; }

        public int? IDCONFIGURACION { get; set; }

        public int? IDUSUARIODESCARGO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGO> PAGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PDF> PDF { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual PROVEEDOR PROVEEDOR1 { get; set; }
    }
}
