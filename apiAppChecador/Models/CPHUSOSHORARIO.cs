namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.CPHUSOSHORARIO")]
    public partial class CPHUSOSHORARIO
    {
        [Key]
        public int IDCPHUSOSHORARIO { get; set; }

        [Required]
        [StringLength(6)]
        public string strCodigoPostal { get; set; }

        [StringLength(5)]
        public string strClaveEstado { get; set; }

        [StringLength(5)]
        public string strMunicipio { get; set; }

        [StringLength(5)]
        public string strLocalidad { get; set; }

        public int intEstimuloFronterizo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtdInicioVigencia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dtdFinVigencia { get; set; }

        [StringLength(200)]
        public string strHusoHorario { get; set; }

        [StringLength(20)]
        public string strMesHIVerano { get; set; }

        [StringLength(30)]
        public string strDiaHVerano { get; set; }

        [StringLength(10)]
        public string dtdHoraIHVerano { get; set; }

        public int? intDiferenciaHVerano { get; set; }

        [StringLength(20)]
        public string strMesHIInvierrno { get; set; }

        [StringLength(30)]
        public string strDiaHInvierno { get; set; }

        [StringLength(10)]
        public string dtdHoraIHInvierno { get; set; }

        public int? intDiferenciaHInvierno { get; set; }
    }
}
