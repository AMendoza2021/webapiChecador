namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.INFORMATICAUSUARIOE")]
    public partial class INFORMATICAUSUARIOE
    {
        [Key]
        public int IDEXTERNO { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string CONTACTO { get; set; }

        [StringLength(100)]
        public string TELEFONOS { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
