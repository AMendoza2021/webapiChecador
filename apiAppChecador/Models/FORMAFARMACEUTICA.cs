namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.FORMAFARMACEUTICA")]
    public partial class FORMAFARMACEUTICA
    {
        [Key]
        public int IDFORMAFARMACEUTICA { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(255)]
        public string NOMBRE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
