namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.INCIDENCIA")]
    public partial class INCIDENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INCIDENCIA()
        {
            CHECADA = new HashSet<CHECADA>();
        }

        [Key]
        public int IDINCIDENCIA { get; set; }

        [Required]
        [StringLength(100)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? APLICAHORARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECADA> CHECADA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
