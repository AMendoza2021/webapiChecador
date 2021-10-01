namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.ETAPAFABRICACION")]
    public partial class ETAPAFABRICACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ETAPAFABRICACION()
        {
            PRODUCTOACONDICIONAMIENTOETAPA = new HashSet<PRODUCTOACONDICIONAMIENTOETAPA>();
        }

        [Key]
        public int IDETAPA { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(255)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOACONDICIONAMIENTOETAPA> PRODUCTOACONDICIONAMIENTOETAPA { get; set; }
    }
}
