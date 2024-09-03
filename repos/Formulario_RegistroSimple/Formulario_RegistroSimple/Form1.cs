using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_RegistroSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviarFormulario(object sender, EventArgs e)
        {

            if (txtCorreo.Text != "" && txtNombre.Text != "" && cbPais.SelectedIndex != -1)
            {

                MessageBox.Show("Nombre: " + txtNombre.Text + "\nCorreo: " + txtCorreo.Text + "\nPaís: " + cbPais.SelectedItem);

            }
            else {

                MessageBox.Show("Debe tener completados el nombre, correo y un país seleccionado. ");


            }

        }
    }
}
