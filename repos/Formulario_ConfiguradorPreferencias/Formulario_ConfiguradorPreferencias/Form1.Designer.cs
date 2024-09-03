namespace Formulario_ConfiguradorPreferencias
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
            this.chkOcultarLabel = new System.Windows.Forms.CheckBox();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.cbTamanio = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.chkOcultarBoton = new System.Windows.Forms.CheckBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.gbColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkOcultarLabel
            // 
            this.chkOcultarLabel.AutoSize = true;
            this.chkOcultarLabel.Location = new System.Drawing.Point(180, 119);
            this.chkOcultarLabel.Name = "chkOcultarLabel";
            this.chkOcultarLabel.Size = new System.Drawing.Size(123, 20);
            this.chkOcultarLabel.TabIndex = 0;
            this.chkOcultarLabel.Text = "Ocultar Etiqueta";
            this.chkOcultarLabel.UseVisualStyleBackColor = true;
            this.chkOcultarLabel.CheckedChanged += new System.EventHandler(this.visibilidadLabel);
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(6, 70);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(65, 20);
            this.rbVerde.TabIndex = 1;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            // 
            // cbTamanio
            // 
            this.cbTamanio.FormattingEnabled = true;
            this.cbTamanio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "40"});
            this.cbTamanio.Location = new System.Drawing.Point(180, 315);
            this.cbTamanio.Name = "cbTamanio";
            this.cbTamanio.Size = new System.Drawing.Size(121, 24);
            this.cbTamanio.TabIndex = 2;
            this.cbTamanio.Text = "Tamaño";
            this.cbTamanio.SelectedValueChanged += new System.EventHandler(this.tamanioTexto);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(462, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(133, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "TEXTO DE PRUEBA";
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(6, 44);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(57, 20);
            this.rbRojo.TabIndex = 4;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(6, 96);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(53, 20);
            this.rbAzul.TabIndex = 5;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            // 
            // gbColores
            // 
            this.gbColores.Controls.Add(this.rbRojo);
            this.gbColores.Controls.Add(this.rbAzul);
            this.gbColores.Controls.Add(this.rbVerde);
            this.gbColores.Location = new System.Drawing.Point(180, 160);
            this.gbColores.Name = "gbColores";
            this.gbColores.Size = new System.Drawing.Size(200, 131);
            this.gbColores.TabIndex = 6;
            this.gbColores.TabStop = false;
            this.gbColores.Text = "Colores";
            // 
            // chkOcultarBoton
            // 
            this.chkOcultarBoton.AutoSize = true;
            this.chkOcultarBoton.Location = new System.Drawing.Point(180, 93);
            this.chkOcultarBoton.Name = "chkOcultarBoton";
            this.chkOcultarBoton.Size = new System.Drawing.Size(109, 20);
            this.chkOcultarBoton.TabIndex = 7;
            this.chkOcultarBoton.Text = "Ocultar Botón";
            this.chkOcultarBoton.UseVisualStyleBackColor = true;
            this.chkOcultarBoton.CheckedChanged += new System.EventHandler(this.visibilidadBoton);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(180, 369);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.accion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.chkOcultarBoton);
            this.Controls.Add(this.gbColores);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbTamanio);
            this.Controls.Add(this.chkOcultarLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbColores.ResumeLayout(false);
            this.gbColores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOcultarLabel;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.ComboBox cbTamanio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.CheckBox chkOcultarBoton;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

