namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.RECEPCIONCOMPRA")]
    public partial class RECEPCIONCOMPRA
    {
        [Key]
        public int IDRECEPCION { get; set; }

        public int? IDCOMPRA { get; set; }

        public int? IDCOMPRADETALLE { get; set; }

        public int? IDPRODUCTO { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        public decimal? RECIBIDO { get; set; }

        public decimal? DEVUELTO { get; set; }

        [StringLength(50)]
        public string NOLOTEINTERNO { get; set; }

        [StringLength(50)]
        public string NOLOTEPROVEEDOR { get; set; }

        [StringLength(500)]
        public string FABRICANTE { get; set; }

        [StringLength(5000)]
        public string FORMADEENTREGA { get; set; }

        public DateTime? FECHARECEPCION { get; set; }

        public DateTime? FECHAFABRICACION { get; set; }

        public DateTime? FECHACADUCIDAD { get; set; }

        [StringLength(100)]
        public string GUIA { get; set; }

        [StringLength(100)]
        public string FACTURA { get; set; }

        [StringLength(500)]
        public string OBSERVACIONES { get; set; }

        public int? IDEXISTENCIA { get; set; }

        public int? IDEXISTENCIADETALLE { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDFACTURA { get; set; }
    }
}
