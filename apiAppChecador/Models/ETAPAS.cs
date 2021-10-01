namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ETAPAS")]
    public partial class ETAPAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ETAPAS()
        {
            ETAPASOPERACIONES = new HashSet<ETAPASOPERACIONES>();
            ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDETAPA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDESCENARIO { get; set; }

        [StringLength(25)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDAREA { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual ESCENARIO ESCENARIO { get; set; }

        public virtual AREAS1 AREAS1 { get; set; }

        public virtual DEPARTAMENTO1 DEPARTAMENTO1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASOPERACIONES> ETAPASOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
    }
}
