using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDado_Aurora_Benjamin
{
    public partial class Form1 : Form
    {
        static Random ran = new Random();
        int numero1 = ran.Next(1,7);
        int numero2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            switch (numero1) {

                case 1:
                    this.pb1.Visible = true;
                    break;
                case 2:
                    this.pb2.Visible = true;
                    break;
                case 3:
                    this.pb3.Visible = true;
                    break;
                case 4:
                    this.pb4.Visible = true;
                    break;    
                case 5:
                    this.pb5.Visible = true;
                    break;
                case 6:
                    this.pb6.Visible = true;
                    break;
            }

            DialogResult result=MessageBox.Show("¿El siguiente número será mayor?", "Confirme", MessageBoxButtons.YesNo);

            switch (numero1)
            {

                case 1:
                    this.pb1.Visible = false;
                    break;
                case 2:
                    this.pb2.Visible = false;
                    break;
                case 3:
                    this.pb3.Visible = false;
                    break;
                case 4:
                    this.pb4.Visible = false;
                    break;
                case 5:
                    this.pb5.Visible = false;
                    break;
                case 6:
                    this.pb6.Visible = false;
                    break;
            }

            numero2 = ran.Next(1,7);
            switch (numero2)
            {

                case 1:
                    this.pb1.Visible = true;
                    break;
                case 2:
                    this.pb2.Visible = true;
                    break;
                case 3:
                    this.pb3.Visible = true;
                    break;
                case 4:
                    this.pb4.Visible = true;
                    break;
                case 5:
                    this.pb5.Visible = true;
                    break;
                case 6:
                    this.pb6.Visible = true;
                    break;
            }

            if (result == DialogResult.Yes && numero1<numero2)
            {
                MessageBox.Show("¡¡Has ganado!!","Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else if (result == DialogResult.Yes && numero1 > numero2)
            {
                MessageBox.Show("¡¡El número era menor. Has perdido!!", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }


            if (result == DialogResult.No && numero1 < numero2)
            {
                MessageBox.Show("¡¡El número era mayor. Has perdido!!", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else if (result == DialogResult.No && numero1 > numero2)
            {
                MessageBox.Show("¡¡Has ganado!!", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }

            if (result == DialogResult.Yes && numero1 == numero2)
            {
                MessageBox.Show("¡¡El número era igual. Has perdido!!", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else if (result == DialogResult.No && numero1 == numero2) {
                MessageBox.Show("¡¡Has ganado!!", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }


        }
    }
}
