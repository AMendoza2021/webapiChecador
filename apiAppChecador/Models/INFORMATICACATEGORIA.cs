namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.INFORMATICACATEGORIA")]
    public partial class INFORMATICACATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INFORMATICACATEGORIA()
        {
            INFORMATICA = new HashSet<INFORMATICA>();
            INFORMATICASUBCATEGORIA = new HashSet<INFORMATICASUBCATEGORIA>();
        }

        [Key]
        public int IDCATEGORIA { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICA> INFORMATICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICASUBCATEGORIA> INFORMATICASUBCATEGORIA { get; set; }
    }
}
