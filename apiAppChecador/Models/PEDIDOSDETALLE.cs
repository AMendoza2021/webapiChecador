namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.PEDIDOSDETALLE")]
    public partial class PEDIDOSDETALLE
    {
        [Key]
        public int IDPEDIDODETALLE { get; set; }

        public int IDPEDIDO { get; set; }

        public int IDPRODUCTO { get; set; }

        public int IDSITUACION { get; set; }

        public decimal CANTIDAD { get; set; }

        public int? IDPRECIOVENTALISTA { get; set; }

        public int? IDPRECIOVENTALISTACLIENTE { get; set; }

        public int? DESCUENTOBASE100 { get; set; }

        public int IDPRECIOVENTA { get; set; }

        public decimal PRECIO { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        public int? IDIMPUESTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual PRECIOVENTA PRECIOVENTA { get; set; }
    }
}
