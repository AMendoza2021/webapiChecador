namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.ALMACENARCHIVOADJUNTO")]
    public partial class ALMACENARCHIVOADJUNTO
    {
        [Key]
        public int IDREG { get; set; }

        public int? IDREQUISICION { get; set; }

        [StringLength(50)]
        public string NOMBREARCHIVO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public byte[] ARCHIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual ALMACEN1 ALMACEN1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
