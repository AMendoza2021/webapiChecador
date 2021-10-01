namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.TIPOVALE")]
    public partial class TIPOVALE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOVALE()
        {
            VALE = new HashSet<VALE>();
        }

        [Key]
        public int IDTIPO { get; set; }

        [StringLength(5)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(25)]
        public string FORMATO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VALE> VALE { get; set; }
    }
}
