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
        private static List<Sismografo> listaSismografo;
        private static Sismografo sismografoSelec;
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
        public static Sismografo sosMiSismografo(int idEstacion)
        {
            listaSismografo = SismografoDao.cargarSismografo();
            foreach (Sismografo sismografo in listaSismografo)
            {
                if (sismografo._IDSismografo == idEstacion)
                {
                    sismografoSelec = sismografo;
                }
            }
            return sismografoSelec;
        }

        public static int getID(Sismografo sismografo)
        {
            return sismografo._IDSismografo;
        }
    }
}
