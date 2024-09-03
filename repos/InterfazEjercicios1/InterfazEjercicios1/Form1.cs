using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEjercicios1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cambiarImagen(object sender, EventArgs e)
        {

            try
            {
                string newImagePath = @"C:\Users\formacion\Desktop\plastic1.png";
                imagen.Image = System.Drawing.Image.FromFile(newImagePath);
                

                lblMensaje.Text = "Imagen cambiada exitosamente.";
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si la imagen no se puede cargar
                lblMensaje.Text = "Error al cambiar la imagen: " + ex.Message;
            }

        }
    }
}
