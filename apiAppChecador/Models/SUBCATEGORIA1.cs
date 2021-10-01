namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.SUBCATEGORIA")]
    public partial class SUBCATEGORIA1
    {
        [Key]
        public int IDSUBCATEGORIA { get; set; }

        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        public DateTime FECHA { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
