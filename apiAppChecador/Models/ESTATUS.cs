namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.ESTATUS")]
    public partial class ESTATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTATUS()
        {
            ENVIOFLUJO = new HashSet<ENVIOFLUJO>();
            ENVIOFLUJO1 = new HashSet<ENVIOFLUJO>();
            COMPRA = new HashSet<COMPRA>();
            COMPRA1 = new HashSet<COMPRA1>();
            COMPRAFLUJO = new HashSet<COMPRAFLUJO>();
            COMPRAFLUJO1 = new HashSet<COMPRAFLUJO1>();
            COMPRAFLUJO2 = new HashSet<COMPRAFLUJO>();
            COMPRAFLUJO11 = new HashSet<COMPRAFLUJO1>();
            COMPRAHISTORICO = new HashSet<COMPRAHISTORICO>();
            COMPRAHISTORICO1 = new HashSet<COMPRAHISTORICO1>();
            COMPRAHISTORICO2 = new HashSet<COMPRAHISTORICO>();
            COMPRAHISTORICO11 = new HashSet<COMPRAHISTORICO1>();
        }

        [Key]
        public int IDESTATUS { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(15)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOFLUJO> ENVIOFLUJO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOFLUJO> ENVIOFLUJO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA1> COMPRA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAFLUJO> COMPRAFLUJO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAFLUJO1> COMPRAFLUJO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAFLUJO> COMPRAFLUJO2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAFLUJO1> COMPRAFLUJO11 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO> COMPRAHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO1> COMPRAHISTORICO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO> COMPRAHISTORICO2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAHISTORICO1> COMPRAHISTORICO11 { get; set; }
    }
}
