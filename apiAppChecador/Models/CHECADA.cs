namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RH.CHECADA")]
    public partial class CHECADA
    {
        [Key]
        public int IDCHECADA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? HORAENTRADA { get; set; }

        public DateTime? HORASALIDA { get; set; }

        public int? IDINCIDENCIA { get; set; }

        public int IDPERIODO { get; set; }

        public int IDEMPLEADO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? EXTRA { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public virtual INCIDENCIA INCIDENCIA { get; set; }

        public virtual PERIODONOMINA PERIODONOMINA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
