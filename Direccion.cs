namespace WebAppEmpresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Direccion")]
    public partial class Direccion
    {
        public int ID { get; set; }

        public int IDEmpresa { get; set; }

        [Column("Direccion")]
        [Required]
        [StringLength(50)]
        public string Direccion1 { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
