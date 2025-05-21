using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class UsuarioDao
    {
        public static List<Usuario> cargarUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Usuario";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Usuario p = new Usuario();
                p.Contraseña = dr.GetString(0);
                p.NombreUsuario = dr.GetString(1);

                listaUsuario.Add(p);
            }

            conexion.Close();
            return listaUsuario;
        }
    }
}