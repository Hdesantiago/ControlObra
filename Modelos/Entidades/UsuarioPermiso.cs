namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioPermiso")]
    public partial class UsuarioPermiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Us_id { get; set; }

        [StringLength(10)]
        public string Us_Empresa { get; set; }

        [StringLength(15)]
        public string Us_Usuario { get; set; }

        public string Alta_Empresa { get; set; }

        public string Alta_Usuario { get; set; }

        public string Alta_UMedida { get; set; }

        public string Alta_Familia { get; set; }

        public string Alta_CCosto { get; set; }

        public string Alta_Subfamilia { get; set; }

        public string Alta_Cliente { get; set; }

        public string Alta_Proveedor { get; set; }

        public string Alta_Almacen { get; set; }

        public string Alta_Obra { get; set; }
    }
}
