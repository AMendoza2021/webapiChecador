namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTES.REPORTE")]
    public partial class REPORTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPORTE()
        {
            FAVORITO = new HashSet<FAVORITO>();
            HISTORICO = new HashSet<HISTORICO>();
            REPORTEUSUARIO = new HashSet<REPORTEUSUARIO>();
            ROLREPORTE = new HashSet<ROLREPORTE>();
        }

        [Key]
        public int IDREPORTE { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(100)]
        public string RUTA { get; set; }

        [Required]
        [StringLength(50)]
        public string CONEXION { get; set; }

        public bool GLOBAL { get; set; }

        [Required]
        [StringLength(50)]
        public string VERSION { get; set; }

        public int IDREQUISICION { get; set; }

        public DateTime FECHA { get; set; }

        public int IDUSUARIOREALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public bool ACTIVO { get; set; }

        public int IDCATEGORIA { get; set; }

        [StringLength(100)]
        public string FILTROS { get; set; }

        public int? IDUSUARIO { get; set; }

        public bool? MIXTO { get; set; }

        public virtual CATEGORIA1 CATEGORIA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAVORITO> FAVORITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTEUSUARIO> REPORTEUSUARIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLREPORTE> ROLREPORTE { get; set; }
    }
}
