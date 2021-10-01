namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIOCONFIGURACION")]
    public partial class INVENTARIOCONFIGURACION1
    {
        [Key]
        public int IDCONF { get; set; }

        public int? IDINVENTARIO { get; set; }

        public bool? PROCESADO { get; set; }

        public Guid? IDALMACEN { get; set; }

        public Guid? IDLOCALIDAD { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
