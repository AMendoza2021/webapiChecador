namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ORDENACONDICIONAMIENTOHISTORIAL")]
    public partial class ORDENACONDICIONAMIENTOHISTORIAL
    {
        [Key]
        public int IDHISTORICO { get; set; }

        public int IDORDEN { get; set; }

        public int? IDSITUACION { get; set; }

        public int IDSITUACIONNUEVO { get; set; }

        [StringLength(50)]
        public string ACCION { get; set; }

        [StringLength(255)]
        public string COMENTARIOS { get; set; }

        public bool? REINICIADO { get; set; }

        public DateTime FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public virtual ORDENACONDICIONAMIENTO ORDENACONDICIONAMIENTO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
