namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOMICILIO.DOMICILIOENTREGA")]
    public partial class DOMICILIOENTREGA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOMICILIOENTREGA()
        {
            CLIENTES2 = new HashSet<CLIENTES2>();
            FACTURAS = new HashSet<FACTURAS>();
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

        [StringLength(10)]
        public string NOEXT { get; set; }

        [StringLength(10)]
        public string NOINT { get; set; }

        [StringLength(1000)]
        public string COMPLEMENTO { get; set; }

        [StringLength(10)]
        public string CODIGOPOSTAL { get; set; }

        [StringLength(100)]
        public string ALIAS { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES2> CLIENTES2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
    }
}
