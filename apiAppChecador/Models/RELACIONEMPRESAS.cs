namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.RELACIONEMPRESAS")]
    public partial class RELACIONEMPRESAS
    {
        [Key]
        public int IDRELACION { get; set; }

        public Guid? IDEMPRESALARISSA { get; set; }

        public int? IDEMPRESAERP { get; set; }
    }
}
