namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.PROGRAMAACONDICIONAMIENTODETALLE")]
    public partial class PROGRAMAACONDICIONAMIENTODETALLE
    {
        public int IDPROGRAMA { get; set; }

        public int IDPRODUCTOACONDICIONAMIENTO { get; set; }

        public int IDFORMULA { get; set; }

        public decimal? TAMANOFABRICAR { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public int IDTAMANOESTANDAR { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        public decimal? TAMANOESTANDAR { get; set; }

        [Key]
        public int IDPROGRAMADET { get; set; }
    }
}
