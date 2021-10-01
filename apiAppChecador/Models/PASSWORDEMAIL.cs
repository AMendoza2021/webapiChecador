namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.PASSWORDEMAIL")]
    public partial class PASSWORDEMAIL
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDUSUARIO { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
