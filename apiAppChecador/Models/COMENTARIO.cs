namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.COMENTARIO")]
    public partial class COMENTARIO
    {
        [Key]
        public int IDCOMENTARIO { get; set; }

        public Guid? IDAGRUPADOR { get; set; }

        public bool? BORRADO { get; set; }

        public bool? PRIVADO { get; set; }

        [StringLength(5000)]
        public string COMENTARIOS { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
