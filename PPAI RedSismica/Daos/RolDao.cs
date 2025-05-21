using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class RolDao
    {
        public static List<Rol> cargarRol()
        {
            List<Rol> listaRol = new List<Rol>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Rol";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Rol p = new Rol();
                p.Nombre = dr.GetString(0);

                listaRol.Add(p);
            }

            conexion.Close();
            return listaRol;
        }
    }
}
