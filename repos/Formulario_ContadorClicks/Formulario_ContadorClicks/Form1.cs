﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_ContadorClicks
{
    public partial class Form1 : Form
    {
        int numero = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void FunbtnIncrementar(object sender, EventArgs e)
        {
            numero += 1;
            lblContador.Text = "Número de clicks: "+ numero;
            

        }

        
    }
}
