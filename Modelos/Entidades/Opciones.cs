namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Opciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Op_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Op_Opcion { get; set; }

        public DateTime? Us_Fum { get; set; }
    }
}
