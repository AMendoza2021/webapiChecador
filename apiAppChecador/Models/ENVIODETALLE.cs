namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.ENVIODETALLE")]
    public partial class ENVIODETALLE
    {
        [Key]
        public int IDENVIODETALLE { get; set; }

        public int IDENVIO { get; set; }

        public Guid? IDPARTE { get; set; }

        [StringLength(100)]
        public string NOLOTE { get; set; }

        public int? CANTIDAD { get; set; }

        public int? CANTIDADRECIBIDA { get; set; }

        public bool? INCOMPLETO { get; set; }

        [StringLength(3000)]
        public string MOTIVOINCOMPLETO { get; set; }

        [StringLength(3000)]
        public string OBSERVACIONES { get; set; }

        public int? IDUSUARIOACTUALIZA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZA { get; set; }

        public DateTime? FECHAFABRICACION { get; set; }

        public DateTime? FECHACADUCIDAD { get; set; }

        public Guid? IDEXISTENCIA { get; set; }

        public int? CANTIDADFALTANTE { get; set; }

        public bool? PROCESADO { get; set; }

        public Guid? IDALMACEN { get; set; }

        public Guid? IDALMACENLOCALIDAD { get; set; }

        [StringLength(20)]
        public string CLAVEPRODUCTO { get; set; }

        [StringLength(100)]
        public string FOLIODOCUMENTO { get; set; }

        [StringLength(20)]
        public string CLAVEPRODUCTODESTINO { get; set; }

        public virtual ENVIO ENVIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
