namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cl_Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Cl_Empresa { get; set; }

        [Required]
        [StringLength(40)]
        public string Cl_Cliente { get; set; }

        [StringLength(40)]
        public string Cl_Contacto { get; set; }

        [Required]
        [StringLength(14)]
        public string Cl_Telefono { get; set; }

        [StringLength(40)]
        public string Cl_Email { get; set; }

        [StringLength(13)]
        public string Cl_RFC { get; set; }

        [StringLength(30)]
        public string Cl_pais { get; set; }

        [StringLength(30)]
        public string Cl_Municipio { get; set; }

        [StringLength(30)]
        public string Cl_Colonia { get; set; }

        [StringLength(30)]
        public string Cl_Ciudad { get; set; }

        [StringLength(100)]
        public string Cl_Calle { get; set; }

        [StringLength(30)]
        public string Cl_Estado { get; set; }

        [StringLength(10)]
        public string Cl_NoExterior { get; set; }

        [StringLength(10)]
        public string Cl_NoInterior { get; set; }

        public DateTime? Cl_fum { get; set; }

        [StringLength(30)]
        public string Cl_Apaterno { get; set; }

        [StringLength(30)]
        public string Cl_AMaterno { get; set; }
    }
}
