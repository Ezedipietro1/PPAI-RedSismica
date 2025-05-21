using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class EstacionSismologicaDao
    {
        public static List<EstacionSismologica> cargarEstacionSismologica()
        {
            List<EstacionSismologica> listaEstacionSismologica = new List<EstacionSismologica>();

            string conexionstring = "server= localhost ; database= redSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM CambioEstado";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                EstacionSismologica p = new EstacionSismologica();
                p.CodigoEstacion = dr.GetInt32(0);
                p.Nombre = dr.GetString(1);

                listaEstacionSismologica.Add(p);
            }

            conexion.Close();
            return listaEstacionSismologica;
        }
    }
}