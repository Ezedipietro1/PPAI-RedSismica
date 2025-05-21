using PPAI_RedSísmica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_RedSismica.Formularios
{
    public partial class PantallaCerrarOrdenInspeccion : Form
    {
        public PantallaCerrarOrdenInspeccion()
        {
            InitializeComponent();
        }

        private void tomarOpCerrarOrdenInspeccion(object sender, EventArgs e)
        {
            this.Hide();
            PantallaAdmInspeccion pantallaAdm = new PantallaAdmInspeccion();
            pantallaAdm.habilitarPantalla();
     
        }

        private void botonSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
