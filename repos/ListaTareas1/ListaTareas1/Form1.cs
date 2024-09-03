using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTareas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarTarea(object sender, EventArgs e)
        {

            if (txtbNombre.Text != ""  && (rbAlta.Checked==true || rbMedia.Checked == true || rbBaja.Checked == true))
            {
                if (chkbImportante.Checked == true)
                {
                    //lbTareas.Items.Add(txtbNombre.Text + " - " + dtpFecha.Value.ToString("dd-MM-yyyy"));
                    lvTareas.Items.Add(txtbNombre.Text + " - " + dtpFecha.Value.ToString("dd-MM-yyyy"));
                }
                else
                {
                    //lbTareas.Items.Add(txtbNombre.Text + " - " + dtpFecha.Value.ToString("dd-MM-yyyy"));
                }
                
            }
            else {
                MessageBox.Show("Tiene que haber un nombre y una prioridad seleccionada");
            }

        }

        private void marcarTarea(object sender, EventArgs e)
        {
            
        }

        private void eliminarTarea(object sender, EventArgs e)
        {

            if (lbTareas.SelectedItem != null)
            {

                lbTareas.Items.Remove(lbTareas.SelectedItem);

            }

        }
    }
}
