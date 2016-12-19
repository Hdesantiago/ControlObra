namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subfamilia")]
    public partial class Subfamilia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sf_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Sf_Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Sf_familia { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Sf_Subfamilia { get; set; }

        [StringLength(30)]
        public string Sf_Descripcion { get; set; }
    }
}
