namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.ROLREPORTE")]
    public partial class ROLREPORTE
    {
        [Key]
        public int IDREPORTEROL { get; set; }

        public int IDREPORTE { get; set; }

        public int IDROL { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual REPORTE REPORTE { get; set; }

        public virtual ROL ROL { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
