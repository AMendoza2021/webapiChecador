namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FISCAL.PRODUCTO")]
    public partial class PRODUCTO1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO1()
        {
            FACTURASDETALLE = new HashSet<FACTURASDETALLE>();
        }

        [Key]
        public int IDPRODUCTOFISCAL { get; set; }

        public int IDPRODUCTO { get; set; }

        [Required]
        [StringLength(12)]
        public string CLAVEFISCAL { get; set; }

        [Required]
        [StringLength(12)]
        public string MEDIDAFISCAL { get; set; }

        public int? IDIMPUESTO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURASDETALLE> FACTURASDETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
