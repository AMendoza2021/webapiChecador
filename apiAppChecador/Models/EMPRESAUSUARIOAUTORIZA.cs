namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.EMPRESAUSUARIOAUTORIZA")]
    public partial class EMPRESAUSUARIOAUTORIZA
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }
    }
}
