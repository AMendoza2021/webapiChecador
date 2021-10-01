namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.ALMACENDETALLE")]
    public partial class ALMACENDETALLE
    {
        [Key]
        public int IDDETALLE { get; set; }

        public int? IDREQUISICION { get; set; }

        [StringLength(5)]
        public string CLASE { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDPROCESODETALLE { get; set; }

        public decimal? CANTIDAD { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        [StringLength(5000)]
        public string COMENTARIO { get; set; }

        public int? IDEXISTENCIAREQUERIDA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDUSUARIOSURTIO { get; set; }

        public decimal? CANTIDADSURTIDA { get; set; }

        public DateTime? FECHASURTIO { get; set; }

        public bool? RECHAZADO { get; set; }

        public decimal? CANTIDADAUTORIZADA { get; set; }
    }
}
