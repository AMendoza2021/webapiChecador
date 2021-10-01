namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTAS.TARJETASPODERDETALLE")]
    public partial class TARJETASPODERDETALLE
    {
        [Key]
        public int IDTARJETAPODERDETALLE { get; set; }

        public int IDTARJETAPODER { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(50)]
        public string APELLIDOS { get; set; }

        [StringLength(50)]
        public string TELEFONO { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual TARJETASPODER TARJETASPODER { get; set; }
    }
}
