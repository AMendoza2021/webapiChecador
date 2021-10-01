namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOMICILIO.COLONIA")]
    public partial class COLONIA
    {
        [Key]
        public int IDCOLONIA { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(10)]
        public string CODIGOPOSTAL { get; set; }

        public int? IDPAIS { get; set; }

        public int? IDESTADO { get; set; }

        public int? IDMUNICIPIO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
