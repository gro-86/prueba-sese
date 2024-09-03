using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_SeleccionOpcion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcionSeleccionada(object sender, EventArgs e)
        {

            if (rdButtonO1.Checked == true) {
                lblseleccionado.Text = "Opción 1 seleccionada";
            }
            else if (rdButtonO2.Checked == true)
            {
                lblseleccionado.Text = "Opción 2 seleccionada";
            }
            else if (rdButtonO3.Checked == true)
            {
                lblseleccionado.Text = "Opción 3 seleccionada";
            }

        }
    }
}
