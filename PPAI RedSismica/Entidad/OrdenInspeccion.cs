using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_RedSismica.Daos;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Data;

namespace PPAI_RedSismica.Entidad
{
    internal class OrdenInspeccion
    {
        private DateTime fechaHoraCierre;
        private DateTime fechaHoraFinalizacion;
        private DateTime fechaHoraInicio;
        private int nroOrden;
        private Empleado empleado;
        private Estado estado;
        private EstacionSismologica estacionSismologica;
        private string observacionCierre;
        private static List<OrdenInspeccion> ordenesDelRI;
        private static List<OrdenInspeccion> listaOrdenes;

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
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }   

        public static List<OrdenInspeccion> esDeRILogueado(Empleado riLogueado)
        {
            listaOrdenes = OrdenInspeccionDao.cargarOrdenInspeccion();
            foreach (OrdenInspeccion orden in listaOrdenes)
            {
                if ((orden.empleado == riLogueado) && esCompletamenteRealizada(orden.estado))
                {
                  ordenesDelRI.Add(orden);
                }
            }
            foreach (OrdenInspeccion orden in ordenesDelRI)
            {
                mostrarDatosOrdenInspeccion(orden);
            }
            return ordenesDelRI;
        }

        public static bool esCompletamenteRealizada(Estado estadoActual)
        {
            return Estado.sosCompletamenteRealizada(estadoActual);
        }

        public static int mostrarDatosOrdenInspeccion(OrdenInspeccion orden)
        {
            return getNroOrden(orden); getFechaHoraFinalizacion(orden); EstacionSismologica.getNombre(orden.estacionSismologica); EstacionSismologica.obtenerIDSismografo(orden.estacionSismologica);
        }

        public static int getNroOrden(OrdenInspeccion orden)
        {
            return orden.nroOrden;
        }
        public static DateTime getFechaHoraFinalizacion(OrdenInspeccion orden)
        {
            return orden.fechaHoraFinalizacion;
        }

        public static DataTable CrearDataTable(DataTable table)
        {

            // Agregar columnas al DataTable
            table.Columns.Add("Nro Orden", typeof(string));
            table.Columns.Add("Fecha Finalizacion", typeof(DateTime));
            table.Columns.Add("Nombre Estacion", typeof(string));
            table.Columns.Add("Id Sismografo", typeof(int));
            // Agregar filas al DataTable

            return table;
        }
    }
}
