namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.EXISTENCIAANALISIS")]
    public partial class EXISTENCIAANALISIS
    {
        [Key]
        public int IDANALISIS { get; set; }

        public int? IDEXISTENCIA { get; set; }

        public int? IDESTATUS { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        [StringLength(20)]
        public string NOANALISIS { get; set; }

        [Required]
        [StringLength(2)]
        public string TIPO { get; set; }

        public bool? APLICAREANALISIS { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHARESULTADO { get; set; }

        public DateTime? FECHAVIGENCIA { get; set; }

        public double? POTENCIA { get; set; }

        public double? BASEHUMEDA { get; set; }

        public double? BASESECA { get; set; }

        public double? HUMEDAD { get; set; }

        public bool? NOTIFICADO { get; set; }

        public DateTime? FECHANOTIFICADO { get; set; }

        [StringLength(5000)]
        public string OBSERVACIONES { get; set; }

        public DateTime? FECHASOLICITUD { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }
    }
}
