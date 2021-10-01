namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOMICILIO.DOMICILIO")]
    public partial class DOMICILIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOMICILIO()
        {
            CLIENTES2 = new HashSet<CLIENTES2>();
            EMPRESA1 = new HashSet<EMPRESA1>();
            FACTURAS = new HashSet<FACTURAS>();
            FACTURAS1 = new HashSet<FACTURAS>();
            FACTURAS2 = new HashSet<FACTURAS>();
            PROVEEDOR = new HashSet<PROVEEDOR>();
            SUCURSAL = new HashSet<SUCURSAL>();
            SUCURSAL1 = new HashSet<SUCURSAL>();
        }

        [Key]
        public int IDDOMICILIO { get; set; }

        [StringLength(10)]
        public string TIPODOMICILIO { get; set; }

        public int? IDPAIS { get; set; }

        public int? IDESTADO { get; set; }

        public int? IDMUNICIPIO { get; set; }

        public int? IDCOLONIA { get; set; }

        [StringLength(100)]
        public string COLONIA { get; set; }

        [StringLength(1000)]
        public string CALLE { get; set; }

        [StringLength(50)]
        public string NOEXT { get; set; }

        [StringLength(50)]
        public string NOINT { get; set; }

        [StringLength(1000)]
        public string COMPLEMENTO { get; set; }

        [StringLength(50)]
        public string CODIGOPOSTAL { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA1> EMPRESA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCURSAL> SUCURSAL1 { get; set; }
    }
}
