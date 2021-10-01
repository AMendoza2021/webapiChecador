namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIODETALLE")]
    public partial class INVENTARIODETALLE1
    {
        [Key]
        public long IDREG { get; set; }

        public int? IDALMSUB { get; set; }

        public bool? EXISTENTE { get; set; }

        [StringLength(20)]
        public string ITEM { get; set; }

        [StringLength(20)]
        public string NOLOTE { get; set; }

        [StringLength(20)]
        public string NOPRODUCTO { get; set; }

        [StringLength(100)]
        public string PRODUCTODESC { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public decimal? EXISTENCIA { get; set; }

        public decimal? CONTEOFINAL { get; set; }

        public decimal? DIFERENCIAFINAL { get; set; }

        public decimal? PRIMERCONTEO { get; set; }

        public decimal? SEGUNDOCONTEO { get; set; }

        public decimal? TERCERCONTEO { get; set; }

        [StringLength(5000)]
        public string OBSERVACIONES { get; set; }

        public decimal? PRIMERDIFERENCIA { get; set; }

        public decimal? SEGUNDADIFERENCIA { get; set; }

        public decimal? TERCERDIFERENCIA { get; set; }

        public decimal? CONTEODIFERENCIA { get; set; }

        public decimal? IMPORTEEXISTENCIA { get; set; }

        public decimal? IMPORTECONTEO { get; set; }

        public decimal? IMPORTEDIFERENCIA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAPRIMERCONTEO { get; set; }

        public DateTime? FECHASEGUNDOCONTEO { get; set; }

        public DateTime? FECHATERCERCONTEO { get; set; }

        public int? IDUSUARIOPRIMERCONTEO { get; set; }

        public int? IDUSUARIOSEGUNDOCONTEO { get; set; }

        public int? IDUSUARIOTERCERCONTEO { get; set; }

        public Guid? IDEXISTENCIA { get; set; }

        public Guid? IDSUBTIPO { get; set; }

        public Guid? IDLOCALIDAD { get; set; }

        public Guid? IDPRODUCTO { get; set; }

        public int? IDINVENTA { get; set; }

        public Guid? IDALMACEN { get; set; }

        public int? VALORACION { get; set; }

        public int? IDCONF { get; set; }

        public virtual INVENTARIO_ALMSUBTIPO INVENTARIO_ALMSUBTIPO { get; set; }
    }
}
