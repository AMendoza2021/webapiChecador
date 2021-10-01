namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.ROL")]
    public partial class ROL1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROL1()
        {
            LINKSMENU = new HashSet<LINKSMENU>();
            USUARIOMODULO = new HashSet<USUARIOMODULO>();
        }

        [Key]
        public int IDROL { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string CLAVE { get; set; }

        [StringLength(500)]
        public string NOMBRE { get; set; }

        public bool? MOSTRAR { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINKSMENU> LINKSMENU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOMODULO> USUARIOMODULO { get; set; }
    }
}
