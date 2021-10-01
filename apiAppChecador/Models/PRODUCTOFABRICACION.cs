namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.PRODUCTOFABRICACION")]
    public partial class PRODUCTOFABRICACION
    {
        [Key]
        public int IDPRODUCTO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDPRODUCTOSALIDA { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        [StringLength(15)]
        public string CODIGO { get; set; }

        [StringLength(255)]
        public string NOMBRE { get; set; }

        [StringLength(255)]
        public string NOMBREGENERICO { get; set; }

        [StringLength(50)]
        public string ANALISIS { get; set; }

        [StringLength(50)]
        public string CONCENTRACION { get; set; }

        public int? IDUMCONCENTRACION { get; set; }

        public int? IDFORMAFARMACEUTICA { get; set; }

        public int? RENDIMIENTOMAXIMO { get; set; }

        public int? RENDIMIENTOMINIMO { get; set; }

        public int? IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
