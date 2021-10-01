namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FISCAL.CLIENTESHISTORIAL")]
    public partial class CLIENTESHISTORIAL
    {
        [Key]
        public int IDHISTORIAL { get; set; }

        public int IDCLIENTEFISCAL { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDCLIENTE { get; set; }

        public int IDUSOCFDI { get; set; }

        [StringLength(255)]
        public string BUZONFISCAL { get; set; }

        public decimal? DESCUENTOPORCIENTO { get; set; }

        public int? IDREFERENCIA { get; set; }

        [StringLength(50)]
        public string CUENTACONTABLE { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual USOCFDI USOCFDI { get; set; }

        public virtual REFERENCIASBANCARIAS REFERENCIASBANCARIAS { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
