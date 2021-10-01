namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ETAPASOPERACIONES")]
    public partial class ETAPASOPERACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ETAPASOPERACIONES()
        {
            ETAPASSUBOPERACIONES = new HashSet<ETAPASSUBOPERACIONES>();
            RUTASOPERACIONESDETALLE = new HashSet<RUTASOPERACIONESDETALLE>();
        }

        [Key]
        public int IDOPERACION { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDESCENARIO { get; set; }

        public int IDETAPA { get; set; }

        [Required]
        [StringLength(25)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(150)]
        public string DESCRIPCION { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual ESCENARIO ESCENARIO { get; set; }

        public virtual ETAPAS ETAPAS { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ETAPASSUBOPERACIONES> ETAPASSUBOPERACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTASOPERACIONESDETALLE> RUTASOPERACIONESDETALLE { get; set; }
    }
}
