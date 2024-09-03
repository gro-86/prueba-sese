using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEjercicios2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarDetalles(object sender, EventArgs e)
        {

           lvNombre.Items.Add(lbNombres.SelectedItem.ToString());
            
        }

        private void agregarNombre(object sender, EventArgs e)
        {
            if (txtBNombre != null)
            {

                lbNombres.Items.Add(txtBNombre.Text);
                txtBNombre.Text = "";
            }

        }
    }
}
