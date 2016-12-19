namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Emp_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Emp_Cia { get; set; }

        [StringLength(50)]
        public string Emp_Nombre { get; set; }

        [StringLength(80)]
        public string Emp_Direccion { get; set; }

        [StringLength(50)]
        public string Emp_Colonia { get; set; }

        [StringLength(20)]
        public string Emp_Estado { get; set; }

        [StringLength(20)]
        public string Emp_Ciudad { get; set; }

        [StringLength(20)]
        public string Emp_Pais { get; set; }

        [StringLength(15)]
        public string Emp_Telefono { get; set; }

        [StringLength(13)]
        public string Emp_RFC { get; set; }

        [StringLength(30)]
        public string Emp_Mail { get; set; }

        [StringLength(30)]
        public string Emp_CuentaBanco1 { get; set; }

        [StringLength(30)]
        public string Emp_CuentaBanco2 { get; set; }

        [StringLength(30)]
        public string Emp_CuentaBanco3 { get; set; }

        [StringLength(30)]
        public string Emp_CuentaBanco4 { get; set; }

        [StringLength(30)]
        public string Emp_CuentaBanco5 { get; set; }

        [StringLength(1)]
        public string Emp_Estatus { get; set; }

        public byte[] Emp_Imagen { get; set; }

        public int? Emp_NoUsuario { get; set; }

        public DateTime? Emp_Fum { get; set; }
    }
}
