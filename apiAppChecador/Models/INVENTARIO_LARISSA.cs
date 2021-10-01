namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LARISSA.INVENTARIO_LARISSA")]
    public partial class INVENTARIO_LARISSA
    {
        [Key]
        public int IDINVENTARIO { get; set; }

        public int? IDESTATUS { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        public Guid? IDALMACEN { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHAFINAL { get; set; }

        public double? AVANCE { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOCONTO { get; set; }

        public int? IDUSUARIOVALIDO { get; set; }

        public int? IDUSUARIOCAPTURO { get; set; }

        public int? IDUSUARIOLIBERO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDPROYECTO { get; set; }
    }
}
