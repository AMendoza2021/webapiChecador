namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.PROVEEDOR")]
    public partial class PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDOR()
        {
            COMPRA = new HashSet<COMPRA>();
            CFDI = new HashSet<CFDI>();
            COMPRADETALLEPROVEEDOR = new HashSet<COMPRADETALLEPROVEEDOR>();
            PROVEEDORCONTACTO = new HashSet<PROVEEDORCONTACTO>();
            PROVEEDORPRODUCTO = new HashSet<PROVEEDORPRODUCTO>();
            SUCURSALPROVEEDOR = new HashSet<SUCURSALPROVEEDOR>();
        }

        [Key]
        public int IDPROVEEDOR { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string RAZONSOCIAL { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        public int? IDDIRECCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [StringLength(1000)]
        public string COMENTARIO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDBANCO { get; set; }

        [StringLength(50)]
        public string NUMSUCURSAL { get; set; }

        [Column(TypeName = "text")]
        public string DOMSUCURSAL { get; set; }

        public int? IDESTADO { get; set; }

        public int? IDMONEDA { get; set; }

        [StringLength(100)]
        public string CUENTA { get; set; }

        [StringLength(100)]
        public string CLABE { get; set; }

        [StringLength(100)]
        public string SCODE { get; set; }

        [StringLength(3)]
        public string TERMINOPAGO { get; set; }

        public int? IDCLASE { get; set; }

        [StringLength(50)]
        public string BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CFDI> CFDI { get; set; }

        public virtual DOMICILIO DOMICILIO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRADETALLEPROVEEDOR> COMPRADETALLEPROVEEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDORCONTACTO> PROVEEDORCONTACTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDORPRODUCTO> PROVEEDORPRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCURSALPROVEEDOR> SUCURSALPROVEEDOR { get; set; }
    }
}
