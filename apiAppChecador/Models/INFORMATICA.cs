namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REQUISICION.INFORMATICA")]
    public partial class INFORMATICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INFORMATICA()
        {
            HISTORICO = new HashSet<HISTORICO>();
            INFORMATICAASIGNACION = new HashSet<INFORMATICAASIGNACION>();
            INFORMATICAASIGNACIONE = new HashSet<INFORMATICAASIGNACIONE>();
            INFORMATICAHISTORICO = new HashSet<INFORMATICAHISTORICO>();
        }

        [Key]
        public int IDREQUISICION { get; set; }

        public bool? ACTIVO { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        public int? IDESTATUS { get; set; }

        public int? IDEMPRESA { get; set; }

        public int? IDSUCURSAL { get; set; }

        public int? IDDEPARTAMENTO { get; set; }

        public int? IDUSUARIOSOLICITA { get; set; }

        public int? IDUSUARIOAUTORIZA { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public int? IDFIRMASOLICITA { get; set; }

        public int? IDFIRMAAUTORIZA { get; set; }

        public int? IDFIRMARECIBE { get; set; }

        public DateTime? FECHA { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        [StringLength(1000)]
        public string COMENTARIOS { get; set; }

        [StringLength(50)]
        public string TITULO { get; set; }

        public int? IDUSUARIOCIERRA { get; set; }

        public int? IDCATEGORIA { get; set; }

        public int? IDSUBCATEGORIA { get; set; }

        [StringLength(1000)]
        public string KEYVALUE { get; set; }

        public int? IDFIRMACIERRA { get; set; }

        public virtual DEPARTAMENTO1 DEPARTAMENTO1 { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO> HISTORICO { get; set; }

        public virtual INFORMATICACATEGORIA INFORMATICACATEGORIA { get; set; }

        public virtual INFORMATICAESTATUS INFORMATICAESTATUS { get; set; }

        public virtual INFORMATICASUBCATEGORIA INFORMATICASUBCATEGORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAASIGNACION> INFORMATICAASIGNACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAASIGNACIONE> INFORMATICAASIGNACIONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INFORMATICAHISTORICO> INFORMATICAHISTORICO { get; set; }
    }
}
