namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.UNIDADMEDIDA")]
    public partial class UNIDADMEDIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDADMEDIDA()
        {
            PRODUCTO = new HashSet<PRODUCTO>();
            PRODUCTO1 = new HashSet<PRODUCTO>();
            PRODUCTO2 = new HashSet<PRODUCTO>();
            PRODUCTO3 = new HashSet<PRODUCTO>();
            PRODUCTO4 = new HashSet<PRODUCTO>();
            FORMULAMAESTRADETALLE = new HashSet<FORMULAMAESTRADETALLE>();
            FORMULAMAESTRATAMANO = new HashSet<FORMULAMAESTRATAMANO>();
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
            INVENTARIODETALLE = new HashSet<INVENTARIODETALLE>();
        }

        [Key]
        public int IDMEDIDA { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(15)]
        public string UNIDAD { get; set; }

        [StringLength(20)]
        public string UNIDADMX { get; set; }

        [StringLength(20)]
        public string UNIDADUS { get; set; }

        public int? IDTIPO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [StringLength(5)]
        public string CLAVEFISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRATAMANO> FORMULAMAESTRATAMANO { get; set; }

        public virtual TIPOMEDIDA TIPOMEDIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
