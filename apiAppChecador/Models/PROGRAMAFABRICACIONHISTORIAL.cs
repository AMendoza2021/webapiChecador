namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICACION.PROGRAMAFABRICACIONHISTORIAL")]
    public partial class PROGRAMAFABRICACIONHISTORIAL
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHISTORICO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPROGRAMA { get; set; }

        public int? IDSITUACION { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSITUACIONNUEVO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ACCION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string COMENTARIOS { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool REINICIADO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }
    }
}
