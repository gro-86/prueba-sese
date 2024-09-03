using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_ConfiguradorPreferencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accion(object sender, EventArgs e)
        {

            if (rbVerde.Checked == true) {

                this.BackColor = Color.Green;

            } else if (rbRojo.Checked == true)
            {

                this.BackColor = Color.Red;

            }else if (rbAzul.Checked == true)
            {

                this.BackColor = Color.Blue;

            }

           

            if (chkOcultarLabel.Checked == true)
            {
                btnEjecutar.Visible = false;
            }
            else
            {
                chkOcultarLabel.Visible = true;
                
            }

        }

        private void visibilidadBoton(object sender, EventArgs e)
        {
            if (chkOcultarBoton.Checked == true)
            {
                btnEjecutar.Visible = false;
            }
            else
            {
                btnEjecutar.Visible = true;
            }
        }

        private void visibilidadLabel(object sender, EventArgs e)
        {
            if (chkOcultarLabel.Checked == true)
            {
                lblResultado.Visible = false;
            }
            else
            {
                lblResultado.Visible = true;
            }
        }

        private void tamanioTexto(object sender, EventArgs e)
        {
            lblResultado.Font = new Font("Arial",int.Parse(cbTamanio.SelectedItem.ToString()));
           
        }
    }
}
