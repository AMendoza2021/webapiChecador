namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.FAVORITO")]
    public partial class FAVORITO
    {
        [Key]
        public int IDFAVORITO { get; set; }

        public int IDREPORTE { get; set; }

        public int IDUSUARIO { get; set; }

        public int CONTADOR { get; set; }

        public DateTime FECHA { get; set; }

        public bool ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual REPORTE REPORTE { get; set; }
    }
}
