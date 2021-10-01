namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.ROL")]
    public partial class ROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROL()
        {
            ROLREPORTE = new HashSet<ROLREPORTE>();
            ROLUSUARIO = new HashSet<ROLUSUARIO>();
        }

        [Key]
        public int IDROL { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLREPORTE> ROLREPORTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLUSUARIO> ROLUSUARIO { get; set; }
    }
}
