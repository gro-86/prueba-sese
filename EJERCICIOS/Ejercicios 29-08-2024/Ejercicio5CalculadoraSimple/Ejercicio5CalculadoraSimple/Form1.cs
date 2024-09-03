using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5CalculadoraSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tbNumSeleccion.Value <= 100 && tbNumSeleccion.Value >= 75)
            {
                lblTexto.Text = tbNombre.Text + " es un máquina";
            }
            else if (tbNumSeleccion.Value <= 74 && tbNumSeleccion.Value >= 51)
            {
                lblTexto.Text = "A " + tbNombre.Text + " le queda poco para la perfección";
            }
            else if (tbNumSeleccion.Value == 50)
            {
                lblTexto.Text = tbNombre.Text + " media persona";
            }
            else if (tbNumSeleccion.Value <= 49 && tbNumSeleccion.Value >= 25)
            {
                lblTexto.Text = "Uy " + tbNombre.Text + ", un poco menos y no lo cuentas";
            }
            else if (tbNumSeleccion.Value <= 24 && tbNumSeleccion.Value >= 1)
            {
                lblTexto.Text = "Uy " + tbNombre.Text + ", eres un perdedor";
            }
            else if (tbNumSeleccion.Value == 0)
            {
                MessageBox.Show("Tienes que mover el cursor primero", "Error");
            }
        }
    }
}
