namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Obras
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ob_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Ob_Empresa { get; set; }

        [Required]
        [StringLength(10)]
        public string Ob_Clave { get; set; }

        [Required]
        [StringLength(50)]
        public string Ob_Descripcion { get; set; }

        public DateTime Ob_Inicio { get; set; }

        public DateTime Ob_Fin { get; set; }

        [Column(TypeName = "money")]
        public decimal Ob_Monto { get; set; }

        public int Ob_NoContrato { get; set; }

        [Required]
        [StringLength(20)]
        public string Ob_ClaveContrato { get; set; }

        [StringLength(100)]
        public string Ob_Ubicacion { get; set; }

        [StringLength(100)]
        public string Ob_Observaciones { get; set; }

        [StringLength(50)]
        public string Ob_Cliente { get; set; }

        [StringLength(1)]
        public string Ob_Limites { get; set; }

        public int? Ob_FolioRequisicion { get; set; }

        public int? Ob_FolioOrdenCompra { get; set; }

        public int? Ob_FolioRecepcion { get; set; }

        public int? Ob_FolioTrabajoMo { get; set; }

        public int? Ob_FolioNomina { get; set; }

        public int? Ob_FolioOrdenCompraAlmacen { get; set; }
    }
}
