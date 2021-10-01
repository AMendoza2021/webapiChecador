namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.ARCHIVOADJUNTO")]
    public partial class ARCHIVOADJUNTO
    {
        [Key]
        public int IDARCHIVO { get; set; }

        public Guid? IDPADRE { get; set; }

        [StringLength(100)]
        public string NOMBREARCHIVO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public byte[] ARCHIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(50)]
        public string IDCATEGORIAEXPEDIENTE { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
