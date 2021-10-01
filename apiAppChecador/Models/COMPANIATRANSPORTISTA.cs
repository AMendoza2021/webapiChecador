namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.COMPANIATRANSPORTISTA")]
    public partial class COMPANIATRANSPORTISTA
    {
        [Key]
        public int IDCOMPANIA { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
