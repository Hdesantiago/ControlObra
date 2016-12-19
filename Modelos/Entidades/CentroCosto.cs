namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CentroCosto")]
    public partial class CentroCosto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ce_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Ce_Empresa { get; set; }

        [Required]
        [StringLength(10)]
        public string Ce_CentroCosto { get; set; }

        [StringLength(100)]
        public string Ce_Descripcion { get; set; }

        public DateTime? Ce_FUM { get; set; }
    }
}
