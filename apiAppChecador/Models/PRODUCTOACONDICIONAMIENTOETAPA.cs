namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.PRODUCTOACONDICIONAMIENTOETAPA")]
    public partial class PRODUCTOACONDICIONAMIENTOETAPA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDREG { get; set; }

        public int IDETAPA { get; set; }

        public int IDPRODUCTO { get; set; }

        public int? SECUENCIA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual ETAPAFABRICACION ETAPAFABRICACION { get; set; }

        public virtual PRODUCTOACONDICIONAMIENTO PRODUCTOACONDICIONAMIENTO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
