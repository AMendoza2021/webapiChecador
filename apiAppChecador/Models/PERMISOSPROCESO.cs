namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGO.PERMISOSPROCESO")]
    public partial class PERMISOSPROCESO
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PROCESO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PERMISO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUSUARIO { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHAACTUALIZO { get; set; }
    }
}
