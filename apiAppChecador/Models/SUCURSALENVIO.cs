namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.SUCURSALENVIO")]
    public partial class SUCURSALENVIO
    {
        [Key]
        public int IDCONFIGURACION { get; set; }

        public Guid? IDSUCURSALORIGEN { get; set; }

        public Guid? IDSUCURSALDESTINO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
