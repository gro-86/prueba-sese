using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3BenjaAurora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            String vip = "";

            if (ckbVip.Checked)
            {
                vip = "Sí";
            }
            else
            {
                vip = "No";
            }

            if (cobGimnasios.Text == "" || tbNombre.Text == "" || tbApellidos.Text == "" || 
                tbEdad.Text == "" || cobActividades.Text == "" || cobEntrenador.Text == "")
            {
                MessageBox.Show("Debe introducir todos los campos", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Datos introducidos:\n\n" +
                                                      "Gimnasio: " + cobGimnasios.Text + "\n" +
                                                      "Nombre: " + tbNombre.Text + "\n" +
                                                      "Apellido: " + tbApellidos.Text + "\n" +
                                                      "Edad: " + tbEdad.Text + "\n" +
                                                      "VIP: " + vip + "\n" +
                                                      "Actividad: " + cobActividades.Text + "\n" +
                                                      "Entrenador: " + cobEntrenador.Text, "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Usuario inscrito correctamente", "Inscripción");
                }
            }
        }
    }
}
