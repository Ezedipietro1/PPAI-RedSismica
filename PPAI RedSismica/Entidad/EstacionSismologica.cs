using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class EstacionSismologica
    {
        private int codigoEstacion;
        private string nombre;

        public int CodigoEstacion
        { 
            get { return codigoEstacion; } 
            set { codigoEstacion = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public static List<EstacionSismologica> ObtenerTodas()
        {
            return EstacionSismologicaDao.cargarEstacionSismologica();
        }

        public static string getNombre(EstacionSismologica estacion)
        {
            return estacion.nombre;
        }

        public static int obtenerIDSismografo(EstacionSismologica estacion)
        {
            return Sismografo.getID(Sismografo.sosMiSismografo(estacion.codigoEstacion));
        }
    }
}
