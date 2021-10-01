namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.MONEDAS")]
    public partial class MONEDAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONEDAS()
        {
            TRASLADOS = new HashSet<TRASLADOS>();
            FACTURAS = new HashSet<FACTURAS>();
            NOTASCREDITO = new HashSet<NOTASCREDITO>();
            PAGOS = new HashSet<PAGOS>();
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
            PERFILCREDITO = new HashSet<PERFILCREDITO>();
            PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
            PRECIOVENTA = new HashSet<PRECIOVENTA>();
            REGISTROVENTA = new HashSet<REGISTROVENTA>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
        }

        [Key]
        public int IDMONEDA { get; set; }

        [Required]
        [StringLength(5)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(25)]
        public string DESCRIPCIONCORTA { get; set; }

        public int DECIMALES { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRASLADOS> TRASLADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTASCREDITO> NOTASCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITO> PERFILCREDITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOVENTA> PRECIOVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTA> REGISTROVENTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }
    }
}
