using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class Estado
    {
        private string nombreEstado;
        private string ambito;

        public string NombreEstado
        {  
            get { return nombreEstado; } 
            set { nombreEstado = value; } 
        }

        public string Ambito
        { 
            get { return ambito; } 
            set { ambito = value; } 
        }
        public static List<Estado> ObtenerTodas()
        {
            return EstadoDao.cargarEstado();
        }

        public static bool sosCompletamenteRealizada(Estado estadoActual)
        {
            if (estadoActual.nombreEstado == "Completamente Realizada")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
