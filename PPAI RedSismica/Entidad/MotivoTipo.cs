using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class MotivoTipo
    {
        private string descripcion;

        public string Descripcion
        {  
            get { return descripcion; } 
            set { descripcion = value; }
        }
        public static List<MotivoTipo> ObtenerTodas()
        {
            return MotivoTipoDao.cargarMotivoTipo();
        }
    }
}
