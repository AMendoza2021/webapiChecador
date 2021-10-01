namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.INFORMATICASUBCATEGORIA")]
    public partial class INFORMATICASUBCATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INFORMATICASUBCATEGORIA()
        {
            INFORMATICA = new HashSet<INFORMATICA>();
        }

        [Key]
        public int IDSUBCATEGORIA { get; set; }

        public int? IDCATEGORIA { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int? PRIORIDAD { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public bool? KEYPARAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICA> INFORMATICA { get; set; }

        public virtual INFORMATICACATEGORIA INFORMATICACATEGORIA { get; set; }
    }
}
