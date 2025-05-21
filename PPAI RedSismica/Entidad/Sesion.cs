using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Usuario usuario;

        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }
        public DateTime FechaHoraFin
        {
            get { return fechaHoraFin; }
            set { fechaHoraFin = value; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }   

        public Empleado obtenerRILogueado()
        {
            return  Usuario.getRILogueado();
        }
        public static List<Sesion> ObtenerTodas()
        {
            return SesionDao.cargarSesion();
        }
    }
}
