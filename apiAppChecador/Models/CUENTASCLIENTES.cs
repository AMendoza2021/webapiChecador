namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTABILIDAD.CUENTASCLIENTES")]
    public partial class CUENTASCLIENTES
    {
        public int IDCLIENTE { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [Key]
        public int IDCUENTACLIENTE { get; set; }

        [StringLength(30)]
        public string COMPLEMENTARIA { get; set; }

        [StringLength(30)]
        public string CUENTAMXN { get; set; }

        [StringLength(30)]
        public string CUENTAUSD { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
