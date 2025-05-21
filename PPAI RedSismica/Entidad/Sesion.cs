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

    }
}
