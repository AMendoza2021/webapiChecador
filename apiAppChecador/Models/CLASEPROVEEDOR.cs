namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.CLASEPROVEEDOR")]
    public partial class CLASEPROVEEDOR
    {
        [Key]
        public int IDCLASEPROVEEDOR { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE { get; set; }

        public int IDCLASEPADRE { get; set; }

        public int IDUSUARIO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
