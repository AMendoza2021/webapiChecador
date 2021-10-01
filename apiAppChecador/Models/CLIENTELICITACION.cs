namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NEGOCIO.CLIENTELICITACION")]
    public partial class CLIENTELICITACION
    {
        [Key]
        public int IDCLIENTELICITACION { get; set; }

        public int IDCLIENTE { get; set; }

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

        public virtual CLIENTES2 CLIENTES2 { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual USUARIO USUARIO1 { get; set; }
    }
}
