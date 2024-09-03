using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_3VasitosAuroraBenjamin
{
    public partial class Form1 : Form
    {
        static Random ran = new Random();
        int contador = 2;
        int numero_aleatorio = ran.Next(1, 4);
        public Form1()
        {
            InitializeComponent();

        }

        private void elegirVaso(object sender, EventArgs e)
        {

            if (contador > 0)
            {

                if (rbVasito1.Checked == true && numero_aleatorio != 1)
                {
                    contador--;
                    MessageBox.Show("Ha fallado. Le quedan "+contador+" intentos");
                }
                else if (rbVasito2.Checked == true && numero_aleatorio != 2)
                {
                    contador--;
                    MessageBox.Show("Ha fallado. Le quedan " + contador + " intentos");
                }
                else if (rbVasito3.Checked == true && numero_aleatorio != 3)
                {
                    contador--;
                    MessageBox.Show("Ha fallado. Le quedan " + contador + " intentos");
                }

                else
                {

                    lblResultado.Text = "¡¡Has acertado!!";
                    if (rbVasito1.Checked == true && numero_aleatorio == 1)
                    {
                        this.imagen_bola1.Visible = true;
                        this.picture_vaso1.Visible = false;
                    }
                    else if (rbVasito2.Checked == true && numero_aleatorio == 2)
                    {
                        this.imagen_bola2.Visible = true;
                        this.picture_vaso2.Visible = false;
                    }
                    else if (rbVasito3.Checked == true && numero_aleatorio == 3)
                    {
                        this.imagen_bola3.Visible = true;
                        this.picture_vaso3.Visible = false;
                    }


                }

            }
            else {

                MessageBox.Show("No le quedan más intentos");

            }         

        }
    }
}
