namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.CUENTAS")]
    public partial class CUENTAS1
    {
        [Key]
        public int IDCUENTA { get; set; }

        public int IDEMPRESA { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDDEPARTAMENTO { get; set; }

        public int IDAREA { get; set; }

        public int IDCUENTACOSTOS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public virtual CUENTASCOSTOS CUENTASCOSTOS { get; set; }

        public virtual DEPARTAMENTOSUCURSAL DEPARTAMENTOSUCURSAL { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
