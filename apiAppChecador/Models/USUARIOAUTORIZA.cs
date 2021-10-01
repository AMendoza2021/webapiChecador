namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.USUARIOAUTORIZA")]
    public partial class USUARIOAUTORIZA
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
