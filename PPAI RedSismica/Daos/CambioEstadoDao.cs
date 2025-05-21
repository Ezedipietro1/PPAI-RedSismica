using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class CambioEstadoDao
    {
        public static List<CambioEstado> cargarCambioEstado()
        {
            List<CambioEstado> listaCambioEstado = new List<CambioEstado>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM CambioEstado";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                CambioEstado p = new CambioEstado();
                p.FechaHoraInicio = dr.GetDateTime(0);
                p.FechaHoraFin = dr.GetDateTime(1);
                p.Estado = dr.GetString(2); 

                listaCambioEstado.Add(p);
            }

            conexion.Close();
            return listaCambioEstado;
        }
    }
}