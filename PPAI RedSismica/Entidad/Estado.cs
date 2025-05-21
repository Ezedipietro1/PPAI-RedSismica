using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RedSismica.Entidad
{
    internal class Estado
    {
        private string nombreEstado;
        private string ambito;

        public string NombreEstado
        {  
            get { return nombreEstado; } 
            set { nombreEstado = value; } 
        }

        public string Ambito
        { 
            get { return ambito; } 
            set { ambito = value; } 
        }  
    }
}
