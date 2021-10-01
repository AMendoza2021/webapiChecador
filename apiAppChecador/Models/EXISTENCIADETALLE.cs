namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.EXISTENCIADETALLE")]
    public partial class EXISTENCIADETALLE
    {
        [Key]
        public int IDEXISTENCIADETALLE { get; set; }

        public int? IDEXISTENCIA { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        public bool? DISPONIBLE { get; set; }

        public decimal? ENTRADA { get; set; }

        public decimal? SALIDA { get; set; }

        public int? IDALMACEN { get; set; }

        public int? IDLOCALIDAD { get; set; }

        public int? IDPROCESO { get; set; }

        public int? IDREFERENCIA { get; set; }

        public int? IDREFERENCIADETALLE { get; set; }

        [StringLength(1000)]
        public string OBSERVACIONES { get; set; }

        [StringLength(100)]
        public string CODIGO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual ALMACEN ALMACEN { get; set; }

        public virtual ALMACENLOCALIDAD ALMACENLOCALIDAD { get; set; }

        public virtual EXISTENCIA EXISTENCIA { get; set; }

        public virtual PROCESO PROCESO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
