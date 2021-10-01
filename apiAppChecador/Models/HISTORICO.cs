namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.HISTORICO")]
    public partial class HISTORICO
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int IDREPORTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string RUTA { get; set; }

        [Required]
        [StringLength(50)]
        public string CONEXION { get; set; }

        public bool GLOBAL { get; set; }

        [Required]
        [StringLength(50)]
        public string VERSION { get; set; }

        public int IDREQUISICION { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOREALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public int IDCATEGORIA { get; set; }

        public virtual CATEGORIA1 CATEGORIA1 { get; set; }

        public virtual REPORTE REPORTE { get; set; }

        public virtual INFORMATICA INFORMATICA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
