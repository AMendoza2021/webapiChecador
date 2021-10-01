namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COSTOS.HOJACOSTOSPRODUCCION")]
    public partial class HOJACOSTOSPRODUCCION
    {
        [Key]
        public int IDREG { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDPRODUCTO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public decimal? TAMANOLOTE { get; set; }

        public decimal? KGACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public decimal? GRANULADOS1 { get; set; }

        public decimal? SECADO2 { get; set; }

        public decimal? GRANULADOS2 { get; set; }

        public decimal? MEZCLADO1 { get; set; }

        public decimal? MEZCLADO2 { get; set; }

        public decimal? TABLETEADO1 { get; set; }

        public decimal? TABLETEADO2 { get; set; }

        public decimal? TABLETEADO3 { get; set; }

        public decimal? TABLETEADO4 { get; set; }

        public decimal? TABLETEADO5 { get; set; }

        public decimal? TABLETEADO6 { get; set; }

        public decimal? ENCAPSULADO2 { get; set; }

        public decimal? ABRILLANTADO { get; set; }

        public decimal? RECUBRIMIENTO1 { get; set; }

        public decimal? RECUBRIMIENTO2 { get; set; }

        public decimal? MEZCLADOBETA { get; set; }

        public decimal? ENCAPSULADOBETA { get; set; }

        public decimal? ABRILLANTADOBETA { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
