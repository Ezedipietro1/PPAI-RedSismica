using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class MotivoFueraServicioDao
    {
        public static List<MotivoFueraServicio> cargarMotivoFueraServicio()
        {
            List<MotivoFueraServicio> listaMotivoFueraServicio = new List<MotivoFueraServicio>();

            string conexionstring = "server= localhost ; database= RedSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM MotivoFueraServicio";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                MotivoFueraServicio p = new MotivoFueraServicio();
                p.Comentario = dr.GetString(0);

                listaMotivoFueraServicio.Add(p);
            }

            conexion.Close();
            return listaMotivoFueraServicio;
        }
    }
}
