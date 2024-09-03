using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Interfaz_TomasSergio
{
    public partial class Form1 : Form
    {

        private int timeLeft;
        Timer timer;
        int numero;
        Random ran;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;
            this.Size = new Size(450, 300);
        }

        private void generarNumero(object sender, EventArgs e)
        {

            ran = new Random();
            int numero = ran.Next(0,11);
            

            if (int.Parse(txtNumero.Text) == numero && (int.Parse(txtNumero.Text) >= 0 && int.Parse(txtNumero.Text) <= 10))
            {
                MessageBox.Show("¡¡Has acertado el número!!");
                this.Close();
            }
            else if (int.Parse(txtNumero.Text) < 0 || int.Parse(txtNumero.Text) > 10)
            {

                MessageBox.Show("El número tiene que estar entre 0 y 10.");

            }
            else {

                MessageBox.Show("Has fallado. El número correcto es: "+numero,"Error");
                txtNumero.Text = "";

            }

        }

    }
}
