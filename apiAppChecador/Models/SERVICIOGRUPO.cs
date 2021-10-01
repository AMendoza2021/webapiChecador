namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.SERVICIOGRUPO")]
    public partial class SERVICIOGRUPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIOGRUPO()
        {
            SERVICIO = new HashSet<SERVICIO>();
            SERVICIOHISTORIAL = new HashSet<SERVICIOHISTORIAL>();
        }

        [Key]
        public int IDGRUPO { get; set; }

        public int IDEMPRESA { get; set; }

        [Required]
        [StringLength(3)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO> SERVICIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }
    }
}
