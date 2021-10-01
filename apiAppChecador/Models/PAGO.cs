namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPP.PAGO")]
    public partial class PAGO
    {
        [Key]
        public int IDPAGO { get; set; }

        public int IDCFDI { get; set; }

        public decimal IMPORTE { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        public int? IDBANCOORIGEN { get; set; }

        public int? IDBANCODESTINO { get; set; }

        [StringLength(100)]
        public string TITULARORIGEN { get; set; }

        [StringLength(100)]
        public string TITULARDESTINO { get; set; }

        [StringLength(100)]
        public string CUENTAORIGEN { get; set; }

        [StringLength(100)]
        public string CUENTADESTINO { get; set; }

        public DateTime? FECHAOPERACION { get; set; }

        [StringLength(100)]
        public string FORMAPAGO { get; set; }

        [StringLength(100)]
        public string REFERENCIA { get; set; }

        [StringLength(1000)]
        public string CONCEPTO { get; set; }

        public bool? ACTIVO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [StringLength(5)]
        public string TIPOMONEDA { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual BANCO BANCO1 { get; set; }

        public virtual CFDI CFDI { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
