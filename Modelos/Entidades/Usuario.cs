namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Us_Id { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(10, ErrorMessage = "Longitud Maxima 10")]
        public string Us_Empresa { get; set; }

        [StringLength(15, ErrorMessage = "Longitud Maxima 15")]
        public string Us_Usuario { get; set; }

        [StringLength(40, ErrorMessage = "Longitud Maxima 40")]
        public string Us_Nombre { get; set; }

        [Required (ErrorMessage ="Campo necesario")]
        [StringLength(40)]
        public string Us_Password { get; set; }

        public DateTime? Us_Fum { get; set; }

        [StringLength(20, ErrorMessage = "Longitud Maxima 20")]
        public string Us_Puesto { get; set; }
    }
}
