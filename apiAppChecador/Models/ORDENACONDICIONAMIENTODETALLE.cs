namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.ORDENACONDICIONAMIENTODETALLE")]
    public partial class ORDENACONDICIONAMIENTODETALLE
    {
        [Key]
        public int IDREG { get; set; }

        public int IDORDEN { get; set; }

        public int IDFORMULADETALLE { get; set; }

        [StringLength(50)]
        public string CLASE { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDEXISTENCIA { get; set; }

        public decimal? CANTIDADUNITARIA { get; set; }

        public int? IDUMCANTIDADUNITARIA { get; set; }

        public decimal? CANTIDADPORLOTE { get; set; }

        public int? IDUMCANTIDADPORLOTE { get; set; }

        public decimal? CANTIDADREQUERIDA { get; set; }

        public bool? ESDUPLICADO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public decimal? CANTIDADSURTIDA { get; set; }

        public int? IDUSUARIOSURTIO { get; set; }

        public DateTime? FECHASURTIO { get; set; }

        public int? IDUSUARIOVERIFICO { get; set; }

        public DateTime? FECHAVERIFICO { get; set; }

        public int? IDUSUARIORECIBIO { get; set; }

        public DateTime? FECHARECIBIO { get; set; }

        public decimal? CANTIDADDEVOLUCION { get; set; }

        public int? IDUSUARIODEVULUCION { get; set; }

        public DateTime? FECHADEVOLUCION { get; set; }

        public decimal? CANTIDADDESPERDICIO { get; set; }

        public int? IDUSUARIODESPERDICIO { get; set; }

        public DateTime? FECHADESPERDICIO { get; set; }

        public DateTime? FECHACADUCIDAD { get; set; }

        public decimal? CANTIDADAPARTADA { get; set; }

        public bool? SINEXISTENCIA { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        [StringLength(50)]
        public string LOTE { get; set; }

        public int? CONSECUTIVO { get; set; }
    }
}
