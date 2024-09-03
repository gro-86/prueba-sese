using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_CalculadoraSimple
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void accionCalculadora(object sender, EventArgs e)
        {
            
            Button botonPresionado = sender as Button;
            
            if (txtNumero2.Text != "" && txtNumero1.Text != "")
            {
                int n1 = int.Parse(txtNumero1.Text);
                int n2 = int.Parse(txtNumero2.Text);

                if (botonPresionado.Text == "Sumar")
                {
                    lblResultado.Text = "Resultado = "+(n1 + n2).ToString();

                }
                else if (botonPresionado.Text == "Restar")
                {
                    lblResultado.Text = "Resultado = " + (n1-n2).ToString();
                    
                }
                else if (botonPresionado.Text == "Multiplicar")
                {
                    lblResultado.Text = "Resultado = " + (n1 * n2).ToString();
                    
                }
                else if (botonPresionado.Text == "Dividir")
                {

                    if (n2 != 0) 
                    {
                        lblResultado.Text = "Resultado = " + (n1 / n2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else {

                MessageBox.Show("No puede haber valores nulos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

        }
    }
}
