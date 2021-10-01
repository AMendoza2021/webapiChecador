namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DESCARGASCFDI.BITACORA")]
    public partial class BITACORA
    {
        [Key]
        public int IDBITACORA { get; set; }

        [StringLength(3000)]
        public string DESCRIPCION { get; set; }

        [StringLength(500)]
        public string ASUNTO { get; set; }

        [StringLength(100)]
        public string EMAILORIGEN { get; set; }

        [StringLength(100)]
        public string EMAILDESTINO { get; set; }

        public DateTime? FECHA { get; set; }

        public bool? ANEXO20 { get; set; }

        public bool? VALIDCERTIFICADO { get; set; }

        public bool? VALIDFIRMA { get; set; }

        public bool? VALIDFOLIOS { get; set; }

        [StringLength(500)]
        public string RUTA_ARCHIVOS { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        [StringLength(14)]
        public string RFC_EMISOR { get; set; }

        public bool? VALIDO { get; set; }

        [StringLength(500)]
        public string IDEMAIL { get; set; }

        [StringLength(20)]
        public string RFC_RECEPTOR { get; set; }

        public DateTime? FECHAEMAIL { get; set; }

        public int? IDCONFIGURACION { get; set; }

        public bool? ATENDIDA { get; set; }

        [StringLength(5000)]
        public string MENSAJEATENDIDA { get; set; }

        public bool? ENVIOCORREO { get; set; }

        public int? IDCFDI { get; set; }

        public int? IDUSUARIODESCARGO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
