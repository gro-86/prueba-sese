﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            nombre = txtBNombre.Text;
            apellido = txtBApellido.Text;

            lblNombreCompleto.Text = "El nombre completo es: "+nombre+" "+apellido;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkBAccion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkBAccion.Checked)
            {
                lblAceptar.Text = "Usted ha sido aceptado";
            }
            else {
                lblAceptar.Text = "No ha sido aceptado";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPlaya.Checked)
            {

                rBMontania.Checked = false;

            }
            else if (rBMontania.Checked)
            {
                rBPlaya.Checked = false;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
