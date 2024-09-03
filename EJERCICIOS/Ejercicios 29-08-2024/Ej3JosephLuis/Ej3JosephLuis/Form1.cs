using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3JosephLuis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string aceptaTerCond = " ";

            if (cbTerminosCondiciones.Checked)
            {
                aceptaTerCond = "Sí";
            }
            else
            {
                aceptaTerCond = "No";
            }

            if (rbMasculino.Checked)
            {
                MessageBox.Show("Nombre: " + tbNombre.Text + "\n" +
                            "Género: " + rbMasculino.Text + "\n" +
                            "Términos y condiciones: " + aceptaTerCond + "\n" +
                            "País: " + cobPaises.Text, "Datos");
            }else if(rbFemenino.Checked)
            {
                MessageBox.Show("Nombre: " + tbNombre.Text + "\n" +
                           "Género: " + rbFemenino.Text + "\n" +
                           "Términos y condiciones: " + aceptaTerCond + "\n" +
                           "País: " + cobPaises.Text, "Datos");
            }
            
        }
    }
}
