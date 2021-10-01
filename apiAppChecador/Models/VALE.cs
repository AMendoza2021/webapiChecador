namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.VALE")]
    public partial class VALE
    {
        [Key]
        public int IDVALE { get; set; }

        public int? IDTIPO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDEMPLEADO { get; set; }

        public int? NOQUINCENA { get; set; }

        public int? FOLIO { get; set; }

        public DateTime? FECHAVIGENCIA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public virtual TIPOVALE TIPOVALE { get; set; }
    }
}
