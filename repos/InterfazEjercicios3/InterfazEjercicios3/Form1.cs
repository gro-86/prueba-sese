using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfazEjercicios3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pbProceso.Style = ProgressBarStyle.Continuous;
            pbProceso.Maximum = 100;
            pbProceso.Value = 0;
        }

        private void subirProceso(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            if (pbProceso.Value == 100)
            {
                this.Cursor = Cursors.Default;
            }
            else if (pbProceso.Value < 100) {

                pbProceso.Value += 10;
            }
        }
    }
}
