namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnidadMedida")]
    public partial class UnidadMedida
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Un_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Un_Empresa { get; set; }

        [Required]
        [StringLength(10)]
        public string Un_Unidad { get; set; }

        [StringLength(30)]
        public string Un_Descripcion { get; set; }
    }
}
