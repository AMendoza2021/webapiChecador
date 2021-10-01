namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.TIPOFACTURA")]
    public partial class TIPOFACTURA
    {
        [Key]
        public int IDTIPOFACTURA { get; set; }

        [Required]
        [StringLength(20)]
        public string TIPO { get; set; }

        [StringLength(100)]
        public string RUTAARCHIVO { get; set; }

        [StringLength(50)]
        public string NOMBREARCHIVO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
