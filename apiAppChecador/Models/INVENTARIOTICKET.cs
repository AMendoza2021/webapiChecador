namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIOTICKET")]
    public partial class INVENTARIOTICKET
    {
        [Key]
        public long IDREG { get; set; }

        public int? TICKET { get; set; }

        [StringLength(50)]
        public string ESTATUS { get; set; }
    }
}
