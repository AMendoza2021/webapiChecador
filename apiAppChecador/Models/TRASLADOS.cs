namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.TRASLADOS")]
    public partial class TRASLADOS
    {
        [Key]
        public int IDTRASLADO { get; set; }

        public int IDEMPRESA { get; set; }

        [StringLength(15)]
        public string SERIE { get; set; }

        [Required]
        [StringLength(15)]
        public string FOLIO { get; set; }

        public int IDUSOCFDI { get; set; }

        [Required]
        [StringLength(10)]
        public string LUGAREXPEDICION { get; set; }

        public int IDSUCURSAL { get; set; }

        public int IDDOMICILIO { get; set; }

        public int IDSUCURSALDESTINO { get; set; }

        public int IDDOMICILIODESTINO { get; set; }

        public decimal IMPORTESUBTOTAL { get; set; }

        public decimal IMPORTEDESCUENTO { get; set; }

        public decimal IMPORTEIVA { get; set; }

        public decimal IMPORTETOTAL { get; set; }

        public string IMPORTELETRA { get; set; }

        public int IDMONEDA { get; set; }

        public decimal TIPOCAMBIO { get; set; }

        [StringLength(2500)]
        public string NOTAS { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public virtual EMPRESA1 EMPRESA1 { get; set; }

        public virtual MONEDAS MONEDAS { get; set; }

        public virtual SUCURSAL SUCURSAL { get; set; }

        public virtual SUCURSAL SUCURSAL1 { get; set; }

        public virtual USOCFDI USOCFDI { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
