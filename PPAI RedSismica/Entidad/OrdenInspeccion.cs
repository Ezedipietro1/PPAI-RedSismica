using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_RedSismica.Daos;
using System.Collections.Generic;

namespace PPAI_RedSismica.Entidad
{
    internal class OrdenInspeccion
    {
        private DateTime fechaHoraCierre;
        private DateTime fechaHoraFinalizacion;
        private DateTime fechaHoraInicio;
        private int nroOrden;
        private string observacionCierre;

        public DateTime FechaHoraCierre 
        { 
            get { return fechaHoraCierre; } 
            set { fechaHoraCierre = value; } 
        } 
        public DateTime FechaHoraFinalizacion
        { 
            get { return fechaHoraFinalizacion; } 
            set { fechaHoraFinalizacion = value; } 
        }
        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }

        public int NroOrden
        { 
            get { return nroOrden; } 
            set { nroOrden = value; } 
        }
        public string ObservacionCierre
        {
            get { return observacionCierre; }
            set { observacionCierre = value; }
        }
        public static List<OrdenInspeccion> ObtenerTodas()
        {
            return OrdenInspeccionDao.cargarOrdenInspeccion();
        }
    }
}
