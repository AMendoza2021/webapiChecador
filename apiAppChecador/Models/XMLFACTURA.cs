namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MIGRACION.XMLFACTURA")]
    public partial class XMLFACTURA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDXMLDATA { get; set; }

        public int? IDEMPRESA { get; set; }

        public Guid? IDEMPRESALARISSA { get; set; }

        [StringLength(15)]
        public string EMPRESARFC { get; set; }

        public int? IDSUCURSAL { get; set; }

        public Guid? IDSUCURSALLARISSA { get; set; }

        public int? IDCLIENTE { get; set; }

        public Guid? IDCLIENTELARISSA { get; set; }

        [StringLength(15)]
        public string CLIENTECLAVE { get; set; }

        [StringLength(1024)]
        public string CLIENTE { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        public int? IDUSOCFDI { get; set; }

        [StringLength(5)]
        public string USOCFDI { get; set; }

        [StringLength(25)]
        public string SERIE { get; set; }

        [StringLength(25)]
        public string FOLIO { get; set; }

        public DateTime? FECHAEMISION { get; set; }

        public Guid? IDUSUARIOLARISSA { get; set; }

        public int? IDUSUARIO { get; set; }

        public Guid? IDSITUACIONLARISSA { get; set; }

        public int? IDSITUACION { get; set; }

        public decimal? IMPORTESUBTOTAL { get; set; }

        public decimal? IMPORTEIVA { get; set; }

        public decimal? IMPORTETOTAL { get; set; }

        public int? IDMONEDA { get; set; }

        [StringLength(5)]
        public string MONEDACLAVE { get; set; }

        [StringLength(1)]
        public string TIPOCOMPROBANTE { get; set; }

        public int? IDMETODOPAGO { get; set; }

        [StringLength(5)]
        public string METODOPAGOCLAVE { get; set; }

        [StringLength(5)]
        public string LUGAREXPEDICION { get; set; }

        [StringLength(50)]
        public string FOLIOFISCAL { get; set; }

        public DateTime? FECHATIMBRADO { get; set; }

        [StringLength(15)]
        public string RFCPAC { get; set; }

        public int? IDFORMAPAGO { get; set; }

        [StringLength(5)]
        public string FORMAPAGOCLAVE { get; set; }

        public bool? PROCESAR { get; set; }

        public bool? PROCESADO { get; set; }

        public int? IDREGISTROVENTA { get; set; }

        public Guid? IDREGISTROVENTALARISSA { get; set; }

        public int? IDFACTURA { get; set; }

        public Guid? IDFACTURALARISSA { get; set; }

        public int? IDFACTURAELECTRONICA { get; set; }

        public Guid? IDFACTURAELECTRONICALARISSA { get; set; }

        public bool? CANCELADA { get; set; }
    }
}
