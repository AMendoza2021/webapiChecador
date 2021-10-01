namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.ALMACEN")]
    public partial class ALMACEN1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALMACEN1()
        {
            ALMACENARCHIVOADJUNTO = new HashSet<ALMACENARCHIVOADJUNTO>();
        }

        [Key]
        public int IDREQUISICION { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDPROCESO { get; set; }

        public int? IDPROCESOREGISTRO { get; set; }

        [Required]
        [StringLength(50)]
        public string FOLIOPROCESO { get; set; }

        [StringLength(5000)]
        public string COMENTARIOS { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOSOLICITA { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public int? IDFIRMAREALIZO { get; set; }

        public int? IDFIRMAAUTORIZO { get; set; }

        public int? IDFIRMAALMACEN { get; set; }

        public bool? PORSISTEMA { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public int? IDEMPLEADOSOLICITA { get; set; }

        public Guid? IDADJUNTO { get; set; }

        public virtual PROCESO PROCESO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMACENARCHIVOADJUNTO> ALMACENARCHIVOADJUNTO { get; set; }
    }
}
