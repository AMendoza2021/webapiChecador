namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ETAPASSUBOPERACIONES")]
    public partial class ETAPASSUBOPERACIONES
    {
        [Key]
        public int IDSUBOPERACION { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDESCENARIO { get; set; }

        public int IDETAPA { get; set; }

        public int IDOPERACION { get; set; }

        public int IDDEPARTAMENTO { get; set; }

        public int IDAREA { get; set; }

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

        public int? IDEDIFICIO { get; set; }

        public virtual ESCENARIO ESCENARIO { get; set; }

        public virtual ETAPAS ETAPAS { get; set; }

        public virtual ETAPASOPERACIONES ETAPASOPERACIONES { get; set; }

        public virtual AREAS1 AREAS1 { get; set; }

        public virtual DEPARTAMENTO1 DEPARTAMENTO1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
