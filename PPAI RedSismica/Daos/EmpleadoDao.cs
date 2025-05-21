using PPAI_RedSismica.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Daos
{
    internal class EmpleadoDao
    {
        public static List<Empleado> cargarEmpleado()
        {
            List<Empleado> listaEmpleado = new List<Empleado>();

            string conexionstring = "server= localhost ; database= redSismica ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string query = @"SELECT * FROM Empleado";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Empleado p = new Empleado();
                p.Mail = dr.GetString(0);

                listaEmpleado.Add(p);
            }

            conexion.Close();
            return listaEmpleado;
        }
    }
}
