namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.FORMULAMAESTRA")]
    public partial class FORMULAMAESTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMULAMAESTRA()
        {
            FORMULAMAESTRADETALLE = new HashSet<FORMULAMAESTRADETALLE>();
            FORMULAMAESTRATAMANO = new HashSet<FORMULAMAESTRATAMANO>();
            PROGRAMA = new HashSet<PROGRAMA>();
        }

        [Key]
        public int IDFORMULA { get; set; }

        [Required]
        [StringLength(50)]
        public string CLASE { get; set; }

        public int? IDPRODUCTOFABRICACION { get; set; }

        public int? IDPRODUCTOACONDICIONAMIENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOFORMULA { get; set; }

        [Required]
        [StringLength(75)]
        public string PERIODOCADUCIDAD { get; set; }

        [Required]
        [StringLength(50)]
        public string PNO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public DateTime? FechaElaboro { get; set; }

        public DateTime? FechaReviso { get; set; }

        public DateTime? FechaAutorizo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRATAMANO> FORMULAMAESTRATAMANO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROGRAMA> PROGRAMA { get; set; }
    }
}
