using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6BenjaAurora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnJugar_Click(object sender, EventArgs e)
        {
            if(tbUser1.Text == "" || tbUser2.Text == "" || tbUser1.Text == tbUser2.Text)
            {
                lblCargando.Text = "Los nombres no pueden ser iguales o estar vacíos";
            }
            else
            {
                lblCargando.Text = "Cargando juego, por favor espere";
                await cargarBarraAsync();
                this.Hide();
                Form2 pantalla2 = new Form2(tbUser1.Text, tbUser2.Text);
                pantalla2.Show();
            }
        }

        private async Task cargarBarraAsync()
        {
            Cursor = Cursors.WaitCursor;
            pbCargando.Show();
            while(pbCargando.Value != pbCargando.Maximum)
            {
                pbCargando.Value += 20;
                await Task.Delay(500);
            }
            Cursor = Cursors.Default;
            
        }
    }
}
