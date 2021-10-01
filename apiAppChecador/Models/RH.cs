namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.RH")]
    public partial class RH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH()
        {
            RHHISTORICO = new HashSet<RHHISTORICO>();
        }

        [Key]
        public int IDREQUISICION { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDEMPLEADOSOLICITA { get; set; }

        [StringLength(20)]
        public string TIPO { get; set; }

        [StringLength(100)]
        public string CONDICION { get; set; }

        [StringLength(100)]
        public string CONCENTIMIENTO { get; set; }

        public DateTime? FECHAINICIAL { get; set; }

        public DateTime? FECHAFINAL { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDUSUARIOREALIZO { get; set; }

        public int? IDUSUARIOAUTORIZO { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public int? IDFIRMAAUTORIZO { get; set; }

        public int? IDFIRMARECIBE { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public bool? DESCARGADA { get; set; }

        [StringLength(5000)]
        public string COMENTARIOS { get; set; }

        public virtual DEPARTAMENTO1 DEPARTAMENTO1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public virtual RHESTATUS RHESTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RHHISTORICO> RHHISTORICO { get; set; }
    }
}
