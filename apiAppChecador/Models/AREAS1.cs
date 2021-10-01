namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.AREAS")]
    public partial class AREAS1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREAS1()
        {
            ETAPAS = new HashSet<ETAPAS>();
            ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
        }

        [Key]
        public int IDAREA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDDEPARTAMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPAS> ETAPAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        public virtual DEPARTAMENTOSUCURSAL DEPARTAMENTOSUCURSAL { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
