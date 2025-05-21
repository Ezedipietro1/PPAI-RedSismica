using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class MotivoTipoDao
    {
        public static List<MotivoTipo> cargarMotivoTipo()
        {
            List<MotivoTipo> listaMotivoTipo = new List<MotivoTipo>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM MotivoTipo";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                MotivoTipo p = new MotivoTipo();
                p.Descripcion = dr.GetString(0);

                listaMotivoTipo.Add(p);
            }

            conexion.Close();
            return listaMotivoTipo;
        }
    }
}
