using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class Usuario
    {
        private string nombreUsuario;
        private string contraseña;
        private Empleado empleado;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }

        public Empleado getRILogueado()
        {
            return empleado;        
        }
    }
}
