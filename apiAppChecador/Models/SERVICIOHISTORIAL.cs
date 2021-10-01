namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.SERVICIOHISTORIAL")]
    public partial class SERVICIOHISTORIAL
    {
        [Key]
        public int IDHISTORIAL { get; set; }

        public int? IDFLUJO { get; set; }

        [StringLength(100)]
        public string ACCION { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public int IDSERVICIO { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDAREA { get; set; }

        public int IDSITUACION { get; set; }

        [Required]
        [StringLength(25)]
        public string FOLIO { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public int? IDTIPO { get; set; }

        public int? IDGRUPO { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        [StringLength(1)]
        public string PRIORIDAD { get; set; }

        [Required]
        [StringLength(50)]
        public string ASUNTO { get; set; }

        [Required]
        [StringLength(2500)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOSOPORTE { get; set; }

        public int? IDUSUARIOFINAL { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHACIERRE { get; set; }

        public DateTime? FECHAVENCIMIENTO { get; set; }

        public int? EVALUACIONSERVICIO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual FLUJOS FLUJOS { get; set; }

        public virtual AREA AREA { get; set; }

        public virtual DEPARTAMENTOS DEPARTAMENTOS { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual SERVICIO SERVICIO { get; set; }

        public virtual SERVICIOCATEGORIA SERVICIOCATEGORIA { get; set; }

        public virtual SERVICIOGRUPO SERVICIOGRUPO { get; set; }

        public virtual SERVICIOSUBCATEGORIA SERVICIOSUBCATEGORIA { get; set; }

        public virtual SERVICIOTIPO SERVICIOTIPO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }
    }
}
