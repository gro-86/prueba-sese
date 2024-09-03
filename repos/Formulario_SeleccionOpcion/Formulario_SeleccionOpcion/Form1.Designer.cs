namespace Formulario_SeleccionOpcion
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
            this.gBSeleccion = new System.Windows.Forms.GroupBox();
            this.rdButtonO3 = new System.Windows.Forms.RadioButton();
            this.rdButtonO2 = new System.Windows.Forms.RadioButton();
            this.rdButtonO1 = new System.Windows.Forms.RadioButton();
            this.lblseleccionado = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gBSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSeleccion
            // 
            this.gBSeleccion.Controls.Add(this.rdButtonO3);
            this.gBSeleccion.Controls.Add(this.rdButtonO2);
            this.gBSeleccion.Controls.Add(this.rdButtonO1);
            this.gBSeleccion.Location = new System.Drawing.Point(146, 135);
            this.gBSeleccion.Name = "gBSeleccion";
            this.gBSeleccion.Size = new System.Drawing.Size(200, 119);
            this.gBSeleccion.TabIndex = 0;
            this.gBSeleccion.TabStop = false;
            this.gBSeleccion.Text = "Opciones";
            // 
            // rdButtonO3
            // 
            this.rdButtonO3.AutoSize = true;
            this.rdButtonO3.Location = new System.Drawing.Point(6, 82);
            this.rdButtonO3.Name = "rdButtonO3";
            this.rdButtonO3.Size = new System.Drawing.Size(81, 20);
            this.rdButtonO3.TabIndex = 2;
            this.rdButtonO3.TabStop = true;
            this.rdButtonO3.Text = "Opcion 3";
            this.rdButtonO3.UseVisualStyleBackColor = true;
            // 
            // rdButtonO2
            // 
            this.rdButtonO2.AutoSize = true;
            this.rdButtonO2.Location = new System.Drawing.Point(6, 56);
            this.rdButtonO2.Name = "rdButtonO2";
            this.rdButtonO2.Size = new System.Drawing.Size(81, 20);
            this.rdButtonO2.TabIndex = 1;
            this.rdButtonO2.TabStop = true;
            this.rdButtonO2.Text = "Opcion 2";
            this.rdButtonO2.UseVisualStyleBackColor = true;
            // 
            // rdButtonO1
            // 
            this.rdButtonO1.AutoSize = true;
            this.rdButtonO1.Location = new System.Drawing.Point(6, 30);
            this.rdButtonO1.Name = "rdButtonO1";
            this.rdButtonO1.Size = new System.Drawing.Size(81, 20);
            this.rdButtonO1.TabIndex = 0;
            this.rdButtonO1.TabStop = true;
            this.rdButtonO1.Text = "Opcion 1";
            this.rdButtonO1.UseVisualStyleBackColor = true;
            this.rdButtonO1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblseleccionado
            // 
            this.lblseleccionado.AutoSize = true;
            this.lblseleccionado.Location = new System.Drawing.Point(152, 96);
            this.lblseleccionado.Name = "lblseleccionado";
            this.lblseleccionado.Size = new System.Drawing.Size(0, 16);
            this.lblseleccionado.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(146, 276);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.opcionSeleccionada);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblseleccionado);
            this.Controls.Add(this.gBSeleccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBSeleccion.ResumeLayout(false);
            this.gBSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSeleccion;
        private System.Windows.Forms.RadioButton rdButtonO3;
        private System.Windows.Forms.RadioButton rdButtonO2;
        private System.Windows.Forms.RadioButton rdButtonO1;
        private System.Windows.Forms.Label lblseleccionado;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}

