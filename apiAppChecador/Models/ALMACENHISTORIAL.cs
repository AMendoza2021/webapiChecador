namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.ALMACENHISTORIAL")]
    public partial class ALMACENHISTORIAL
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int? IDREQUISICION { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDESTATUSNUEVO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? REINICIADO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
