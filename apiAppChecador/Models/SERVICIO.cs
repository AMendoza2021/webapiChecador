namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.SERVICIO")]
    public partial class SERVICIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO()
        {
            SERVICIOHISTORIAL = new HashSet<SERVICIOHISTORIAL>();
        }

        [Key]
        public int IDSERVICIO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDAREA { get; set; }

        public int IDSITUACION { get; set; }

        [StringLength(25)]
        public string FOLIO { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public int? IDTIPO { get; set; }

        public int? IDGRUPO { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        [StringLength(1)]
        public string PRIORIDAD { get; set; }

        [StringLength(50)]
        public string ASUNTO { get; set; }

        [Required]
        [StringLength(2500)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOSOPORTE { get; set; }

        public int IDUSUARIOFINAL { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHACIERRE { get; set; }

        public DateTime? FECHAVENCIMIENTO { get; set; }

        public int? EVALUACIONSERVICIO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual AREA AREA { get; set; }

        public virtual DEPARTAMENTOS DEPARTAMENTOS { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual SERVICIOCATEGORIA SERVICIOCATEGORIA { get; set; }

        public virtual SERVICIOGRUPO SERVICIOGRUPO { get; set; }

        public virtual SERVICIOSUBCATEGORIA SERVICIOSUBCATEGORIA { get; set; }

        public virtual SERVICIOTIPO SERVICIOTIPO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }

        public virtual USUARIO USUARIO4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOHISTORIAL> SERVICIOHISTORIAL { get; set; }
    }
}
