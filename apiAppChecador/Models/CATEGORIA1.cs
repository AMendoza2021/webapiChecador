namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.CATEGORIA")]
    public partial class CATEGORIA1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORIA1()
        {
            REPORTE = new HashSet<REPORTE>();
            HISTORICO = new HashSet<HISTORICO>();
        }

        [Key]
        public int IDCATEGORIA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CLAVE { get; set; }

        public DateTime FECHA { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTE> REPORTE { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }
    }
}
