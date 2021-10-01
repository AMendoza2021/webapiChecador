namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.PROGRAMA")]
    public partial class PROGRAMA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPROGRAMA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDESTATUS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CLASE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRIORIDAD { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDEMPRESA { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSUCURSAL { get; set; }

        public int? IDPRODUCTOFABRICACION { get; set; }

        public int? IDPRODUCTOACONDICIONAMIENTO { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFORMULA { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTAMANOESTANDAR { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal TAMANOFABRICAR { get; set; }

        [StringLength(255)]
        public string COMENTARIOS { get; set; }

        public DateTime? FECHAEMISION { get; set; }

        public DateTime? FECHACOMPROMISO { get; set; }

        public DateTime? FECHAPLANEADAINICIO { get; set; }

        public DateTime? FECHAPLANEADAFIN { get; set; }

        public DateTime? FECHAINACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool ACTIVO { get; set; }

        public virtual FORMULAMAESTRA FORMULAMAESTRA { get; set; }

        public virtual FORMULAMAESTRATAMANO FORMULAMAESTRATAMANO { get; set; }

        public virtual ESTATUSPROCESO ESTATUSPROCESO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
