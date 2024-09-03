using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6GroverLorenzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - pbPersonaje.Width;
            int maxY = this.ClientSize.Height - pbPersonaje.Height;


            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                if (clickedButton.Name == "btnDerecha")
                {
                    if (pbPersonaje.Location.X + 10 <= maxX)
                    {
                        pbPersonaje.Location = new Point(pbPersonaje.Location.X + 10, pbPersonaje.Location.Y);
                    }
                }else if(clickedButton.Name == "btnIzq")
                {
                    if (pbPersonaje.Location.X - 10 >= 0)
                    {
                        pbPersonaje.Location = new Point(pbPersonaje.Location.X - 10, pbPersonaje.Location.Y);
                    }
                }else if (clickedButton.Name == "btnArriba")
                {
                    if (pbPersonaje.Location.Y + 10 >= 0)
                    {
                        pbPersonaje.Location = new Point(pbPersonaje.Location.X, pbPersonaje.Location.Y - 10);
                    }
                }
                else if (clickedButton.Name == "btnAbajo")
                {
                    if (pbPersonaje.Location.Y - 10 <= maxY)
                    {
                        pbPersonaje.Location = new Point(pbPersonaje.Location.X, pbPersonaje.Location.Y + 10);
                    }
                }

                if (pbPersonaje.Location.X <= (pbGana.Location.X + pbGana.Width) && pbPersonaje.Location.Y >= (pbGana.Location.Y - pbGana.Width))
                {
                    pbGana.Visible = true;
                    MessageBox.Show("Has encontrado el tesoro", "Ganaste");
                    this.Close();
                }
            }
        }

    }
}
