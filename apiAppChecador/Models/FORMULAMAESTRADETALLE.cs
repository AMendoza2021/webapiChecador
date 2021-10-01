namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.FORMULAMAESTRADETALLE")]
    public partial class FORMULAMAESTRADETALLE
    {
        [Key]
        public int IDREG { get; set; }

        public int IDFORMULA { get; set; }

        [Required]
        [StringLength(50)]
        public string CLASE { get; set; }

        public int IDPRODUCTO { get; set; }

        public decimal CANTIDAD { get; set; }

        public int IDUMCANTIDAD { get; set; }

        public int IDFACTORCONVERSIONLOTE { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public decimal? FACTORCONVERSION { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(50)]
        public string CLAVE { get; set; }

        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public bool? ESFRACCIONABLE { get; set; }

        public int? FRACCIONES { get; set; }

        public virtual PRODUCTO PRODUCTO { get; set; }

        public virtual FACTORCONVERSION FACTORCONVERSION1 { get; set; }

        public virtual FORMULAMAESTRA FORMULAMAESTRA { get; set; }

        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
