namespace EjecicioTomasSergio
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
            this.lblSet1 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.btnEquipo1 = new System.Windows.Forms.Button();
            this.btnEquipo2 = new System.Windows.Forms.Button();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblSet2 = new System.Windows.Forms.Label();
            this.lblPuntos1 = new System.Windows.Forms.Label();
            this.lblPuntosC1 = new System.Windows.Forms.Label();
            this.lblPuntosC2 = new System.Windows.Forms.Label();
            this.lblPuntos2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSet1
            // 
            this.lblSet1.AutoSize = true;
            this.lblSet1.Location = new System.Drawing.Point(91, 63);
            this.lblSet1.Name = "lblSet1";
            this.lblSet1.Size = new System.Drawing.Size(66, 16);
            this.lblSet1.TabIndex = 0;
            this.lblSet1.Text = "Equipo 1: ";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(163, 63);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(14, 16);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "0";
            // 
            // btnEquipo1
            // 
            this.btnEquipo1.Location = new System.Drawing.Point(94, 149);
            this.btnEquipo1.Name = "btnEquipo1";
            this.btnEquipo1.Size = new System.Drawing.Size(75, 23);
            this.btnEquipo1.TabIndex = 2;
            this.btnEquipo1.Text = "Accion 1";
            this.btnEquipo1.UseVisualStyleBackColor = true;
            this.btnEquipo1.Click += new System.EventHandler(this.jugar);
            // 
            // btnEquipo2
            // 
            this.btnEquipo2.Location = new System.Drawing.Point(283, 149);
            this.btnEquipo2.Name = "btnEquipo2";
            this.btnEquipo2.Size = new System.Drawing.Size(75, 23);
            this.btnEquipo2.TabIndex = 3;
            this.btnEquipo2.Text = "Accion 2";
            this.btnEquipo2.UseVisualStyleBackColor = true;
            this.btnEquipo2.Click += new System.EventHandler(this.jugar);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(364, 63);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(14, 16);
            this.lblNumero2.TabIndex = 5;
            this.lblNumero2.Text = "0";
            // 
            // lblSet2
            // 
            this.lblSet2.AutoSize = true;
            this.lblSet2.Location = new System.Drawing.Point(292, 63);
            this.lblSet2.Name = "lblSet2";
            this.lblSet2.Size = new System.Drawing.Size(66, 16);
            this.lblSet2.TabIndex = 4;
            this.lblSet2.Text = "Equipo 2: ";
            // 
            // lblPuntos1
            // 
            this.lblPuntos1.AutoSize = true;
            this.lblPuntos1.Location = new System.Drawing.Point(91, 98);
            this.lblPuntos1.Name = "lblPuntos1";
            this.lblPuntos1.Size = new System.Drawing.Size(61, 16);
            this.lblPuntos1.TabIndex = 6;
            this.lblPuntos1.Text = "Puntos 1:";
            // 
            // lblPuntosC1
            // 
            this.lblPuntosC1.AutoSize = true;
            this.lblPuntosC1.Location = new System.Drawing.Point(163, 98);
            this.lblPuntosC1.Name = "lblPuntosC1";
            this.lblPuntosC1.Size = new System.Drawing.Size(14, 16);
            this.lblPuntosC1.TabIndex = 7;
            this.lblPuntosC1.Text = "0";
            // 
            // lblPuntosC2
            // 
            this.lblPuntosC2.AutoSize = true;
            this.lblPuntosC2.Location = new System.Drawing.Point(364, 98);
            this.lblPuntosC2.Name = "lblPuntosC2";
            this.lblPuntosC2.Size = new System.Drawing.Size(14, 16);
            this.lblPuntosC2.TabIndex = 9;
            this.lblPuntosC2.Text = "0";
            // 
            // lblPuntos2
            // 
            this.lblPuntos2.AutoSize = true;
            this.lblPuntos2.Location = new System.Drawing.Point(292, 98);
            this.lblPuntos2.Name = "lblPuntos2";
            this.lblPuntos2.Size = new System.Drawing.Size(61, 16);
            this.lblPuntos2.TabIndex = 8;
            this.lblPuntos2.Text = "Puntos 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuntosC2);
            this.Controls.Add(this.lblPuntos2);
            this.Controls.Add(this.lblPuntosC1);
            this.Controls.Add(this.lblPuntos1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblSet2);
            this.Controls.Add(this.btnEquipo2);
            this.Controls.Add(this.btnEquipo1);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblSet1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSet1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Button btnEquipo1;
        private System.Windows.Forms.Button btnEquipo2;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblSet2;
        private System.Windows.Forms.Label lblPuntos1;
        private System.Windows.Forms.Label lblPuntosC1;
        private System.Windows.Forms.Label lblPuntosC2;
        private System.Windows.Forms.Label lblPuntos2;
    }
}

