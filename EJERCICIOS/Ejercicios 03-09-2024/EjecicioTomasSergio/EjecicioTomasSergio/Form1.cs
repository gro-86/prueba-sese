using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecicioTomasSergio
{
    public partial class Form1 : Form
    {
        int? conver;
        public Form1()
        {
            InitializeComponent();
        }

        private void jugar(object sender, EventArgs e)
        {
            //Asignación del parámetro para identificar qué tipo de botón se ha pulsado.
            Button presionado = sender as Button;
            int puntosEquipo1 = int.Parse(lblPuntosC1.Text);
            int puntosEquipo2 = int.Parse(lblPuntosC2.Text);
            int setsEquipo1 = int.Parse(lblNumero1.Text);
            int setsEquipo2 = int.Parse(lblNumero2.Text);

            //Si el set es menor a 2 se sigue jugando
            if (setsEquipo1 < 2 && setsEquipo2 < 2)
            {
                //Sumar punto normalmente si se presiona
                if (presionado.Text == "Accion 1")
                {
                    puntosEquipo1++;
                    lblPuntosC1.Text = puntosEquipo1.ToString();
                }
                else if (presionado.Text == "Accion 2")
                {
                    puntosEquipo2++;
                    lblPuntosC2.Text = puntosEquipo2.ToString();
                }
                
                //Si se llega a 21 puntos y hay una diferencia de 2 ó más puntos se gana el set
                if ((puntosEquipo1 >= 21 || puntosEquipo2 >= 21) && Math.Abs(puntosEquipo1 - puntosEquipo2) >= 2)
                {
                    if (puntosEquipo1 > puntosEquipo2)
                    {
                        setsEquipo1++;
                        lblNumero1.Text = setsEquipo1.ToString();
                        MessageBox.Show("¡Equipo 1 ha ganado un set!");
                    }
                    else
                    {
                        setsEquipo2++;
                        lblNumero2.Text = setsEquipo2.ToString();
                        MessageBox.Show("¡Equipo 2 ha ganado un set!");
                    }

                    //Volver a reiniciar el marcador de puntos
                    lblPuntosC1.Text = "0";
                    lblPuntosC2.Text = "0";
                    puntosEquipo1 = 0;
                    puntosEquipo2 = 0;
                }

                //Si gana se cierra el programa
                if (setsEquipo1 == 2)
                {
                    MessageBox.Show("¡Equipo 1 ha ganado el partido!");
                    this.Close(); 
                }
                else if (setsEquipo2 == 2)
                {
                    MessageBox.Show("¡Equipo 2 ha ganado el partido!");
                    this.Close(); 
                }
            }
        }
    }
}
