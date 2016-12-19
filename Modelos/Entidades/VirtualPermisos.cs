using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class VirtualPermisos
    {
        public int Us_id { get; set; }
        public String Us_Empresa { get; set; }
        public String Us_Usuario { get; set; }
        public Boolean Alta_Empresa { get; set; }
        public Boolean Alta_Usuario { get; set; }
        public Boolean Alta_UMedida { get; set; }
        public Boolean Alta_Familia { get; set; }
        public Boolean Alta_CCosto { get; set; }
        public Boolean Alta_Subfamilia { get; set; }
        public Boolean Alta_Cliente { get; set; }
        public Boolean Alta_Proveedor { get; set; }
        public Boolean Alta_Almacen { get; set; }
        public Boolean Alta_Obra { get; set; }
    }
}
