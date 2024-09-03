using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6SamVictor
{
    public partial class DatosUsuario : Form
    {
        public DatosUsuario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
            menu.Close();
        }

        private void tkbEdad_Scroll(object sender, EventArgs e)
        {
            lblEdadTrack.Text = tkbEdad.Value.ToString();
        }
    }
}
