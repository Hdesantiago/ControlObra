namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pr_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Pr_Empresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Pr_Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Pr_Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Pr_Ciudad { get; set; }

        [Required]
        [StringLength(15)]
        public string Pr_Estado { get; set; }

        [Required]
        [StringLength(15)]
        public string Pr_Pais { get; set; }

        [Required]
        [StringLength(15)]
        public string Pr_Telefono { get; set; }

        [Required]
        [StringLength(30)]
        public string Pr_Email { get; set; }

        [StringLength(50)]
        public string Pr_SitioWeb { get; set; }

        [Required]
        [StringLength(13)]
        public string Pr_Rfc { get; set; }

        [StringLength(50)]
        public string Pr_Contacto { get; set; }

        [StringLength(50)]
        public string Pr_OficinaHorarios { get; set; }

        public int? Pr_DiasCredito { get; set; }

        [Required]
        [StringLength(1)]
        public string Pr_Almacen { get; set; }

        [StringLength(30)]
        public string Pr_Cuenta1 { get; set; }

        [StringLength(30)]
        public string Pr_Cuenta2 { get; set; }

        [StringLength(30)]
        public string Pr_Cuenta3 { get; set; }

        [StringLength(30)]
        public string Pr_Cuenta4 { get; set; }

        [StringLength(10)]
        public string Pr_NoAlmacen { get; set; }

        public DateTime? Pr_fum { get; set; }

        [StringLength(10)]
        public string Pr_Usr { get; set; }
    }
}
