namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.PRODUCTO")]
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            EXISTENCIA = new HashSet<EXISTENCIA>();
            PRODUCTOMINMAX = new HashSet<PRODUCTOMINMAX>();
            COMPRADETALLE = new HashSet<COMPRADETALLE>();
            COMPRADETALLE1 = new HashSet<COMPRADETALLE1>();
            COMPRADETALLE2 = new HashSet<COMPRADETALLE>();
            COMPRADETALLEADICIONAL = new HashSet<COMPRADETALLEADICIONAL>();
            HOJACOSTOSPRODUCCION = new HashSet<HOJACOSTOSPRODUCCION>();
            EXISTENCIAACTUAL = new HashSet<EXISTENCIAACTUAL>();
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
            FORMULAMAESTRADETALLE = new HashSet<FORMULAMAESTRADETALLE>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
            PRECIOVENTA = new HashSet<PRECIOVENTA>();
            PRODUCTOSUCURSAL = new HashSet<PRODUCTOSUCURSAL>();
            REGISTROVENTADETALLE = new HashSet<REGISTROVENTADETALLE>();
        }

        [Key]
        public int IDPRODUCTO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDPAISORIGEN { get; set; }

        public int? IDPAISVENDEDOR { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(1000)]
        public string NOMBRE { get; set; }

        [StringLength(1000)]
        public string NOMBREUS { get; set; }

        [StringLength(1000)]
        public string DESCRIPCION { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        [StringLength(10)]
        public string PREFIJOLOTE { get; set; }

        [StringLength(7)]
        public string CLASE { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public bool? SUJETOINSPECCION { get; set; }

        public bool? APLICAIVA { get; set; }

        public int? IDIMPUESTO { get; set; }

        public decimal? MINIMO { get; set; }

        public decimal? MAXIMOS { get; set; }

        public int? IDUNIDADMEDIDALOTE { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string CODIGOBARRAS { get; set; }

        public bool? PUEDEVENDERSE { get; set; }

        public bool? PUEDECOMPRARSE { get; set; }

        public decimal? PESO { get; set; }

        public int? IDUNIDADMEDIDAVOLUMEN { get; set; }

        public decimal? PUNTOREORDEN { get; set; }

        public bool? OPERACIONBAJOPEDIDO { get; set; }

        public bool? OPERACIONBAJOFABRICACION { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        public bool? APLICAANALISIS { get; set; }

        public int? IDMEDIDACOMPRA { get; set; }

        public decimal? MINIMOCOMPRA { get; set; }

        public int? PLAZOENTREGA { get; set; }

        public int? IDUNIDADMEDIDAPESO { get; set; }

        public decimal? VOLUMEN { get; set; }

        public bool licitacion { get; set; }

        public bool NOTIFICACIONMINIMO { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIA> EXISTENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOMINMAX> PRODUCTOMINMAX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE> COMPRADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE1> COMPRADETALLE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLE> COMPRADETALLE2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLEADICIONAL> COMPRADETALLEADICIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOJACOSTOSPRODUCCION> HOJACOSTOSPRODUCCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXISTENCIAACTUAL> EXISTENCIAACTUAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOVENTA> PRECIOVENTA { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual IMPUESTOS IMPUESTOS { get; set; }

        public virtual SUBCATEGORIA SUBCATEGORIA { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA1 { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA2 { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA3 { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA4 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOSUCURSAL> PRODUCTOSUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTADETALLE> REGISTROVENTADETALLE { get; set; }
    }
}
