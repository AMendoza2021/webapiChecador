namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.CONFIGURACIONPRODUCTOENVIO")]
    public partial class CONFIGURACIONPRODUCTOENVIO
    {
        [Key]
        public int IDREG { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVEORIGEN { get; set; }

        public Guid IDSUCURSALORIGEN { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVEDESTINO { get; set; }

        public Guid IDSUCURSALDESTINO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
