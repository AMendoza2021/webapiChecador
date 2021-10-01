namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.NOTASDEVOLUCIONDETALLE")]
    public partial class NOTASDEVOLUCIONDETALLE
    {
        [Key]
        public int IDNOTADEVOLUCIONDETALLE { get; set; }

        public int IDNOTADEVOLUCION { get; set; }

        public int IDFACTURADETALLE { get; set; }

        public int IDSITUACION { get; set; }

        public decimal CANTIDAD { get; set; }

        public decimal PRECIO { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        public int? IDEXISTENCIA { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual SITUACION SITUACION { get; set; }

        public virtual NOTASDEVOLUCION NOTASDEVOLUCION { get; set; }

        public virtual FACTURASDETALLE FACTURASDETALLE { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
