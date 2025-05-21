using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class SismografoDao
    {
        public static List<Sismografo> cargarSismografo()
        {
            List<Sismografo> listaSismografo = new List<Sismografo>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Sismografo";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Sismografo p = new Sismografo();
                p._IDSismografo = dr.GetInt32(0);

                listaSismografo.Add(p);
            }

            conexion.Close();
            return listaSismografo;
        }
    }
}
