namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.FLUJOS")]
    public partial class FLUJOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FLUJOS()
        {
            PAGOSHISTORIAL = new HashSet<PAGOSHISTORIAL>();
            PERFILCREDITOHISTORICO = new HashSet<PERFILCREDITOHISTORICO>();
            REGISTROVENTAHISTORIAL = new HashSet<REGISTROVENTAHISTORIAL>();
            SERVICIOHISTORIAL = new HashSet<SERVICIOHISTORIAL>();
        }

        [Key]
        public int IDFLUJO { get; set; }

        [Required]
        [StringLength(25)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }

        public int IDSITUACION { get; set; }

        public int IDSITUACIONNUEVO { get; set; }

        public bool REQUIEREFIRMA { get; set; }

        public bool VISIBLE { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDDOCUMENTO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual SITUACION SITUACION1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOSHISTORIAL> PAGOSHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFILCREDITOHISTORICO> PERFILCREDITOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTROVENTAHISTORIAL> REGISTROVENTAHISTORIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }
    }
}
