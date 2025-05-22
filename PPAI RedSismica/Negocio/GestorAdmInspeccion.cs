using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// para obtener la lista de las entidades usamos --> var lista = OrdenInspeccion.ObtenerTodas();

namespace PPAI_RedSismica.Negocio
{
    internal class GestorAdmInspeccion
    {
        private static object riLogueado;
        private Sesion sesionActual; // Agregar una instancia de Sesion  

        public GestorAdmInspeccion(Sesion sesion)
        {
            this.sesionActual = sesion;
        }

        public void opCerrarOrdenInspeccion()
        {
            riLogueado = buscarRILogueado();

        }

        public Empleado buscarRILogueado()
        {
            return sesionActual.obtenerRILogueado(); // Usar la instancia de Sesion  
        }

        public void buscarOrdenesInspeccion(Empleado riLogueado)
        {
            OrdenInspeccion.esDeRILogueado(riLogueado);
        }
    }
}
