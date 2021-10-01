namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.FORMULAMAESTRATAMANO")]
    public partial class FORMULAMAESTRATAMANO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMULAMAESTRATAMANO()
        {
            PROGRAMA = new HashSet<PROGRAMA>();
        }

        [Key]
        public int IDREG { get; set; }

        public int IDFORMULA { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        public decimal TAMANOLOTE { get; set; }

        public int IDUMTAMANOLOTE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual FORMULAMAESTRA FORMULAMAESTRA { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROGRAMA> PROGRAMA { get; set; }
    }
}
