namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.PROGRAMAFABRICACIONDETALLE")]
    public partial class PROGRAMAFABRICACIONDETALLE
    {
        [Key]
        public int IDPROGRAMADET { get; set; }

        public int IDPrograma { get; set; }

        public int IDProductoFabricacion { get; set; }

        public int IDFormula { get; set; }

        [StringLength(50)]
        public string Codigo { get; set; }

        public decimal? TamanoFabricar { get; set; }

        public decimal? TamanoEstandar { get; set; }

        public decimal? TamanoRestante { get; set; }

        public decimal? TamanoTransformado { get; set; }

        public int IDTamanoEstandar { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? FechaActualizo { get; set; }

        public int? IDUsuarioActualizo { get; set; }

        public bool? Activo { get; set; }
    }
}
