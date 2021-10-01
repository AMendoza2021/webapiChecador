namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.FACTORCONVERSION")]
    public partial class FACTORCONVERSION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTORCONVERSION()
        {
            FORMULAMAESTRADETALLE = new HashSet<FORMULAMAESTRADETALLE>();
        }

        [Key]
        public int IDFACTOR { get; set; }

        public int IDUMENTRADA { get; set; }

        public int IDUMSALIDA { get; set; }

        public decimal FACTOR { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMULAMAESTRADETALLE> FORMULAMAESTRADETALLE { get; set; }
    }
}
