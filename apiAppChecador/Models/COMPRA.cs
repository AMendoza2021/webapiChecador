namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPRAS.COMPRA")]
    public partial class COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA()
        {
            ACTIVOSFIJOS = new HashSet<ACTIVOSFIJOS>();
            COMPRADETALLE = new HashSet<COMPRADETALLE>();
            COMPRADETALLE1 = new HashSet<COMPRADETALLE>();
            COMPRADETALLEADICIONAL = new HashSet<COMPRADETALLEADICIONAL>();
            COMPRAHISTORICO = new HashSet<COMPRAHISTORICO>();
            COMPRAREQUISICION = new HashSet<COMPRAREQUISICION>();
        }

        [Key]
        public int IDCOMPRA { get; set; }

        [Required]
        [StringLength(50)]
        public string FOLIO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDTIPOORDEN { get; set; }

        [StringLength(1500)]
        public string COMENTARIOS { get; set; }

        [StringLength(1000)]
        public string CONTACTOENTREGA { get; set; }

        [StringLength(1000)]
        public string DOMICILIOENTREGA { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public DateTime? FECHAPAGO { get; set; }

        public DateTime? FECHAENTREGA { get; set; }

        public DateTime? FECHACIERRE { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOSOLICITA { get; set; }

        public int? IDUSUARIOPREAUTORIZA { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public int? IDFIRMAREALIZO { get; set; }

        public int? IDFIRMAPREAUTORIZO { get; set; }

        public int? IDFIRMAAUTORIZO { get; set; }

        [StringLength(50)]
        public string FACTURA { get; set; }

        [StringLength(50)]
        public string COTIZACION { get; set; }

        public int? IDPROVEEDOR { get; set; }

        [StringLength(1)]
        public string FORMAENTREGA { get; set; }

        [StringLength(3)]
        public string TIPOMONEDA { get; set; }

        public double? TIPOCAMBIO { get; set; }

        public bool? CREDITO { get; set; }

        public int? PLAZOPAGO { get; set; }

        public double? IVA { get; set; }

        public decimal? IMPUESTO { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public decimal? TOTAL { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public double? ANTICIPO { get; set; }

        [StringLength(1)]
        public string MEDIDAPARCIALIDAD { get; set; }

        public int? PARCIALIDADES { get; set; }

        public int? RECIBIDO { get; set; }

        [StringLength(10)]
        public string CONDICIONES { get; set; }

        public Guid? IDADJUNTOS { get; set; }

        public Guid? IDCOMENTARIO { get; set; }

        public decimal? IMPUESTORETENIDO { get; set; }

        public decimal? ISR { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal? ISH { get; set; }

        public decimal? ULTIMODESCUENTO { get; set; }

        public bool? DEPARTAMENTOSUCURSAL { get; set; }

        public virtual ESTATUS ESTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVOSFIJOS> ACTIVOSFIJOS { get; set; }

        public virtual DEPARTAMENTOSUCURSAL DEPARTAMENTOSUCURSAL1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual TIPOCOMPRA TIPOCOMPRA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }

        public virtual USUARIO USUARIO4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE> COMPRADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE> COMPRADETALLE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLEADICIONAL> COMPRADETALLEADICIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO> COMPRAHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAREQUISICION> COMPRAREQUISICION { get; set; }
    }
}
