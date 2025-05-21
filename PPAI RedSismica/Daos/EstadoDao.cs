using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class EstadoDao
    {
        public static List<Estado> cargarEstado()
        {
            List<Estado> listaEstado = new List<Estado>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Estado";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Estado p = new Estado();
                p.NombreEstado = dr.GetString(0);
                p.Ambito = dr.GetString(1);

                listaEstado.Add(p);
            }

            conexion.Close();
            return listaEstado;
        }
    }
}