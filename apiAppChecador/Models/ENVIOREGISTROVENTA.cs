namespace apiAppChecador.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN.ENVIOREGISTROVENTA")]
    public partial class ENVIOREGISTROVENTA
    {
        [Key]
        public int IDREG { get; set; }

        public int IDENVIO { get; set; }

        public Guid IDREGISTROVENTA { get; set; }

        public int IDUSUARIOACUTUALIZO { get; set; }

        public DateTime FECHAACTUALIZO { get; set; }

        public virtual ENVIO ENVIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
