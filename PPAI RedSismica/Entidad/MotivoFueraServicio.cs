using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class MotivoFueraServicio
    {
        private string comentario;

        public string Comentario
        { 
            get { return comentario; }
            set { comentario = value; }
        }
        public static List<MotivoFueraServicio> ObtenerTodas()
        {
            return MotivoFueraServicioDao.cargarMotivoFueraServicio();
        }
    }
}
