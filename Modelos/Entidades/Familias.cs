namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Familias
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Fa_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Fa_Empresa { get; set; }

        [Required]
        [StringLength(10)]
        public string Fa_Familia { get; set; }

        [StringLength(30)]
        public string Fa_Descripcion { get; set; }
    }
}
