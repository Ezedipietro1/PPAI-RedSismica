using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class OrdenInspeccionDao
    {
        public static List<OrdenInspeccion> cargarOrdenInspeccion()
        {
            List<OrdenInspeccion> listaOrdenInspeccion = new List<OrdenInspeccion>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM OrdenInspeccion";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                OrdenInspeccion p = new OrdenInspeccion();
                p.FechaHoraInicio = dr.GetDateTime(0);
                p.FechaHoraCierre = dr.GetDateTime(1);
                p.FechaHoraFinalizacion = dr.GetDateTime(2);
                p.NroOrden = dr.GetInt32(3);
                p.ObservacionCierre = dr.GetString(4);

                listaOrdenInspeccion.Add(p);
            }

            conexion.Close();
            return listaOrdenInspeccion;
        }
    }
}
