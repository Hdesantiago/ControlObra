namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacenes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Alm_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Alm_Empresa { get; set; }

        [Required]
        [StringLength(3)]
        public string Alm_Clave { get; set; }

        [Required]
        [StringLength(30)]
        public string Alm_Descripcion { get; set; }

        public DateTime? Alm_fum { get; set; }

        [StringLength(10)]
        public string Alm_Usr { get; set; }
    }
}
