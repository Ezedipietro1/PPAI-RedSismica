using PPAI_RedSismica.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Estado estado;

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

        public object Estado
        { 
            get { return estado; } 
            set { estado = (Estado)value; } 
        }
        public static List<CambioEstado> ObtenerTodas()
        {
            return CambioEstadoDao.cargarCambioEstado();
        }
    }
}
