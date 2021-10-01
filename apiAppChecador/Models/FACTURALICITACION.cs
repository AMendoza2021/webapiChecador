namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTURACION.FACTURALICITACION")]
    public partial class FACTURALICITACION
    {
        [Key]
        public int IDFACTURALICITACION { get; set; }

        public int IDFACTURA { get; set; }

        [StringLength(255)]
        public string CHRCAMPO1 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO2 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO3 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO4 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO5 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO6 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO7 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO8 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO9 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO10 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO11 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO12 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO13 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO14 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO15 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO16 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO17 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO18 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO19 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO20 { get; set; }

        public int IDUSUARIO { get; set; }

        public DateTime? FECHA { get; set; }

        public int IDUSUARIOACTUALIZO { get; set; }

        public DateTime? FECHAACTUALIZO { get; set; }

        public bool? ACTIVO { get; set; }

        public int IDTIPOFACTURA { get; set; }

        [StringLength(255)]
        public string CHRCAMPO21 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO22 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO23 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO24 { get; set; }

        [StringLength(255)]
        public string CHRCAMPO25 { get; set; }

        [StringLength(3000)]
        public string CHRRECUADRO { get; set; }

        public virtual FACTURAS FACTURAS { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
