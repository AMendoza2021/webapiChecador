namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.DEPARTAMENTO")]
    public partial class DEPARTAMENTO1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTAMENTO1()
        {
            ETAPAS = new HashSet<ETAPAS>();
            ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
            DEPARTAMENTOSUCURSAL = new HashSet<DEPARTAMENTOSUCURSAL>();
            EMPLEADO = new HashSet<EMPLEADO>();
            INFORMATICA = new HashSet<INFORMATICA>();
            RH = new HashSet<RH>();
        }

        [Key]
        public int IDDEPARTAMENTO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPAS> ETAPAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTOSUCURSAL> DEPARTAMENTOSUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICA> INFORMATICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH> RH { get; set; }
    }
}
