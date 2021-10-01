namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.EMPLEADOIMPORTACION")]
    public partial class EMPLEADOIMPORTACION
    {
        [Key]
        public long IDREG { get; set; }

        [StringLength(50)]
        public string NOEMPLEADO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APATERNO { get; set; }

        [StringLength(50)]
        public string AMATERNO { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public DateTime? FECHAINGRESO { get; set; }

        [StringLength(100)]
        public string EMPRESA { get; set; }

        [StringLength(100)]
        public string EMPRESA_ERP { get; set; }

        [StringLength(100)]
        public string SUCURSAL { get; set; }

        [StringLength(100)]
        public string SUCURSAL_ERP { get; set; }

        [StringLength(100)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(100)]
        public string DEPARTAMENTO_ERP { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOIMPORTA { get; set; }

        [StringLength(100)]
        public string MSG { get; set; }
    }
}
