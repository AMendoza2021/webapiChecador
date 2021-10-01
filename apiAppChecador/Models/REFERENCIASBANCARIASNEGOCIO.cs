namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.REFERENCIASBANCARIASNEGOCIO")]
    public partial class REFERENCIASBANCARIASNEGOCIO
    {
        [Key]
        public int IDREFERENCIABANCARIANEGOCIO { get; set; }

        public int IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int IDFORMAPAGO { get; set; }

        public int? IDBANCO { get; set; }

        [StringLength(50)]
        public string NUMEROCUENTA { get; set; }

        [StringLength(18)]
        public string CLABE { get; set; }

        [StringLength(250)]
        public string NOTAS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(2)]
        public string PREFIJO { get; set; }

        [StringLength(25)]
        public string CUENTACONTABLE { get; set; }

        public virtual BANCO BANCO { get; set; }

        public virtual FORMASPAGO FORMASPAGO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
