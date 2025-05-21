using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Negocio
{
    internal class GestorAdmInspeccion
    {
        private static object riLogueado;

        public static void opCerrarOrdenInspeccion()
        {
            riLogueado = buscarRILogueado();
        }

        public static void buscarRILogueado()
        {
            
        }
    }
}
