namespace Formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gBLugares = new System.Windows.Forms.GroupBox();
            this.rdbPlaya = new System.Windows.Forms.RadioButton();
            this.rdbMontana = new System.Windows.Forms.RadioButton();
            this.lblPais = new System.Windows.Forms.Label();
            this.rdButtonEspacio = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.gBLugares.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alemania",
            "Francia",
            "Singapur"});
            this.comboBox1.Location = new System.Drawing.Point(418, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gBLugares
            // 
            this.gBLugares.Controls.Add(this.rdButtonEspacio);
            this.gBLugares.Controls.Add(this.rdbMontana);
            this.gBLugares.Controls.Add(this.rdbPlaya);
            this.gBLugares.Location = new System.Drawing.Point(643, 253);
            this.gBLugares.Name = "gBLugares";
            this.gBLugares.Size = new System.Drawing.Size(200, 131);
            this.gBLugares.TabIndex = 3;
            this.gBLugares.TabStop = false;
            this.gBLugares.Text = "Lugares";
            // 
            // rdbPlaya
            // 
            this.rdbPlaya.AutoSize = true;
            this.rdbPlaya.Location = new System.Drawing.Point(7, 29);
            this.rdbPlaya.Name = "rdbPlaya";
            this.rdbPlaya.Size = new System.Drawing.Size(63, 20);
            this.rdbPlaya.TabIndex = 0;
            this.rdbPlaya.TabStop = true;
            this.rdbPlaya.Text = "Playa";
            this.rdbPlaya.UseVisualStyleBackColor = true;
            // 
            // rdbMontana
            // 
            this.rdbMontana.AutoSize = true;
            this.rdbMontana.Location = new System.Drawing.Point(7, 54);
            this.rdbMontana.Name = "rdbMontana";
            this.rdbMontana.Size = new System.Drawing.Size(80, 20);
            this.rdbMontana.TabIndex = 1;
            this.rdbMontana.TabStop = true;
            this.rdbMontana.Text = "Montaña";
            this.rdbMontana.UseVisualStyleBackColor = true;
            this.rdbMontana.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(904, 307);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(0, 16);
            this.lblPais.TabIndex = 4;
            this.lblPais.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // rdButtonEspacio
            // 
            this.rdButtonEspacio.AutoSize = true;
            this.rdButtonEspacio.Location = new System.Drawing.Point(7, 80);
            this.rdButtonEspacio.Name = "rdButtonEspacio";
            this.rdButtonEspacio.Size = new System.Drawing.Size(78, 20);
            this.rdButtonEspacio.TabIndex = 2;
            this.rdButtonEspacio.TabStop = true;
            this.rdButtonEspacio.Text = "Espacio";
            this.rdButtonEspacio.UseVisualStyleBackColor = true;
            this.rdButtonEspacio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(898, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Determinar país";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Francia",
            "Colombia",
            "Cuba",
            "Nicaragua",
            "Ecuador"});
            this.cbPais.Location = new System.Drawing.Point(898, 226);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 24);
            this.cbPais.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Elección";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1077, 573);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.gBLugares);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gBLugares.ResumeLayout(false);
            this.gBLugares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Label lblEtiquetaNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.CheckBox chkBAccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAceptar;
        private System.Windows.Forms.RadioButton rBPlaya;
        private System.Windows.Forms.RadioButton rBMontania;
        private System.Windows.Forms.GroupBox gBEntorno;
        private System.Windows.Forms.Button btnEleccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gBLugares;
        private System.Windows.Forms.RadioButton rdbMontana;
        private System.Windows.Forms.RadioButton rdbPlaya;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.RadioButton rdButtonEspacio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button button4;
    }
}

