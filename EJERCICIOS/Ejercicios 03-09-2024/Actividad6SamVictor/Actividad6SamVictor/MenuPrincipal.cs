using Actividad6SamVictor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6SamVictor
{
    public partial class MenuPrincipal : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\Formacion\Desktop\Lorenzo\FormacionSese\UltimoModulo\EjerciciosComun\Actividades6\Actividad6SamVictor\Actividad6SamVictor\Resources\The shire.wav");

        public MenuPrincipal()
        {
            InitializeComponent();
            player.PlayLooping();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos creditos = new Creditos();
            creditos.ShowDialog();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoJuego infoJuego = new InfoJuego();
            infoJuego.ShowDialog();
            this.Close();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosUsuario datosUsuario = new DatosUsuario();
            datosUsuario.ShowDialog();
            this.Close();
        }
    }
}
