﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarEtiqueta(object sender, EventArgs e)
        {

            lblTitulo.Text = "¡¡¡HAS HECHO CLICK EN EL BOTÓN!!!";

        }
    }
}
