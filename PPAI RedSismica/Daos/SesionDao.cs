using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class SesionDao
    {
        public static List<Sesion> cargarSesion()
        {
            List<Sesion> listaSesion = new List<Sesion>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Sesion";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Sesion p = new Sesion();
                p.FechaHoraInicio = dr.GetDateTime(0);
                p.FechaHoraFin = dr.GetDateTime(1);

                listaSesion.Add(p);
            }

            conexion.Close();
            return listaSesion;
        }
    }
}
