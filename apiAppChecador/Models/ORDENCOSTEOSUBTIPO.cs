namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.ORDENCOSTEOSUBTIPO")]
    public partial class ORDENCOSTEOSUBTIPO
    {
        [Key]
        public int IDSubtipo { get; set; }

        public int IDEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int IDUsuario { get; set; }

        public DateTime? Fecha { get; set; }

        public int IDUsuarioActualizo { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public bool? Activo { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
