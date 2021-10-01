namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.ENVIO")]
    public partial class ENVIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENVIO()
        {
            ENVIODETALLE = new HashSet<ENVIODETALLE>();
            ENVIOHISTORICO = new HashSet<ENVIOHISTORICO>();
            ENVIOREGISTROVENTA = new HashSet<ENVIOREGISTROVENTA>();
        }

        [Key]
        public int IDENVIO { get; set; }

        public int? IDESTATUS { get; set; }

        [StringLength(50)]
        public string FOLIO { get; set; }

        [StringLength(3000)]
        public string COMENTARIOS { get; set; }

        public bool? PLAGUICIDAS { get; set; }

        public bool? SUSTANCIASTOXICAS { get; set; }

        public bool? CORROSIVOS { get; set; }

        public bool? NUTRIENTESVEGETALES { get; set; }

        [StringLength(10)]
        public string CONDICIONESCAMION { get; set; }

        public int? IDFIRMAENTREGA { get; set; }

        public DateTime? FECHAENTREGA { get; set; }

        public int? IDTRANSPORTISTA { get; set; }

        [StringLength(100)]
        public string PLACAS { get; set; }

        public int? IDFIRMARECIBE { get; set; }

        public DateTime? FECHARECIBE { get; set; }

        public int? IDFIRMACONDUCTOR { get; set; }

        public DateTime? FECHACONDUCTOR { get; set; }

        public int? IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public int? IDUSUARIOENTREGA { get; set; }

        public int? IDUSUARIOCONDUCTOR { get; set; }

        public int? IDUSUARIORECIBE { get; set; }

        public Guid? IDSUCURSALORIGEN { get; set; }

        public Guid? IDSUCURSALDESTINO { get; set; }

        public int? IDREQUISICION { get; set; }

        public int? IDUSUARIOASOLICITARREQ { get; set; }

        public int? IDUSUARIOAUTORIZAREQ { get; set; }

        public Guid? IDCLIENTE { get; set; }

        public Guid? IDSOLICITANTE { get; set; }

        public Guid? IDREGISTROVENTA { get; set; }

        public virtual ESTATUSENVIO ESTATUSENVIO { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL1 { get; set; }

        public virtual FIRMADIGITAL FIRMADIGITAL2 { get; set; }

        public virtual COMPRA1 COMPRA1 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }

        public virtual USUARIO USUARIO2 { get; set; }

        public virtual USUARIO USUARIO3 { get; set; }

        public virtual USUARIO USUARIO4 { get; set; }

        public virtual USUARIO USUARIO5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIODETALLE> ENVIODETALLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOHISTORICO> ENVIOHISTORICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVIOREGISTROVENTA> ENVIOREGISTROVENTA { get; set; }
    }
}
