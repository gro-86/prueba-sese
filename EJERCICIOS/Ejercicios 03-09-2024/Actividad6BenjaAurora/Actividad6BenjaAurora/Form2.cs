using Actividad6BenjaAurora.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6BenjaAurora
{
    public partial class Form2 : Form
    {
        string player1 {  get; set; }
        string player2 { get; set; }
        int cont1 { get; set; }
        int cont2 {  get; set; }
        public Form2(string user1, string user2)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            player1 = user1;
            player2 = user2;
            lblUser1.Text = player1;
            lbluser2.Text = player2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rand1 = random.Next(1, 4);
            int rand2 = random.Next(1, 4);

            switch (rand1)
            {
                case 1:
                    pb1.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\fist.png");
                    break;
                case 2:
                    pb1.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\mano.png");
                    break;
                case 3:
                    pb1.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\tijeras.png");
                    break;
            }

            switch (rand2)
            {
                case 1:
                    pb2.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\fist.png");
                    break;
                case 2:
                    pb2.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\mano.png");
                    break;
                case 3:
                    pb2.Image = Image.FromFile(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6BenjaAurora\Actividad6BenjaAurora\Resources\tijeras.png");
                    break;
            }

            comprobarGanador(rand1, rand2);
        }

        private void comprobarGanador(int num1, int num2)
        {
            if (num1 == 1 && num2 == 3 || num1 == 2 && num2 == 1 || num1 == 3 && num2 == 2)
            {
                cont1++;
                lblContador1.Text = "Has ganado " + cont1;
            }
            else if (num2 == 1 && num1 == 3 || num2 == 2 && num1 == 1 || num2 == 3 && num1 == 2)
            {
                cont2++;
                lblContador2.Text = "Has ganado " + cont2;
            }

            if (cont1 == 3)
            {
                MessageBox.Show("El jugador " + player1 + " ha ganado!!!", "Ganador");
                this.Close();
                Application.Exit();
            }else if (cont2 == 3)
            {
                MessageBox.Show("El jugador " + player2 + " ha ganado!!!", "Ganador");
                this.Close();
                Application.Exit();
            }
        }
    }
}
