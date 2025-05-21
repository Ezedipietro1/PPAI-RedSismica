using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class Sismografo
    {
        private int IDSismografo;

        public int _IDSismografo
        { 
            get { return IDSismografo; } 
            set { IDSismografo = value; } 
        }
        public static List<Sismografo> ObtenerTodas()
        {
            return SismografoDao.cargarSismografo();
        }
    }
}
