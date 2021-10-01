namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONFIGURADOR.EMPRESALOGO")]
    public partial class EMPRESALOGO
    {
        [Key]
        public int IDCONFIGURACION { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        public int? IDEMPRESA { get; set; }

        [StringLength(100)]
        public string PATHLOGO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public byte[] LOGO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }
    }
}
