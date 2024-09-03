using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEjercicios4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularDias(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan periodo;
            if (dtDias.Value < fechaActual)
            {

                periodo = fechaActual - dtDias.Value;

                lblDias.Text = "Diferencia días: "+periodo.Days.ToString();

            }
            else {

                lblDias.Text = "No puede elegir una fecha mayor que la actual";


            }

        }
    }
}
