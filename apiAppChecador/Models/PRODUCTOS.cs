namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.PRODUCTOS")]
    public partial class PRODUCTOS
    {
        [Key]
        public int IDPRODUCTO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(10)]
        public string CLAVE { get; set; }

        [StringLength(10)]
        public string PREFIJOLOTE { get; set; }

        [StringLength(1000)]
        public string NOMBRE { get; set; }

        [StringLength(1000)]
        public string NOMBREUS { get; set; }

        [StringLength(1000)]
        public string DESCRIPCION { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        public int? IDUNIDADMEDIDA { get; set; }

        [StringLength(5)]
        public string CLASE { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDPAISORIGEN { get; set; }

        public int? IDPAISVENDEDOR { get; set; }

        public decimal? COSTOESTANDAR { get; set; }

        public bool? SUJETOINSPECCION { get; set; }

        public bool? APLICAIVA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUNIDADMEDIDALOTE { get; set; }

        public decimal? MINIMO { get; set; }
    }
}
