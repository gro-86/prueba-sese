namespace Actividad6BenjaAurora
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.pbCargando = new System.Windows.Forms.ProgressBar();
            this.btnJugar = new System.Windows.Forms.Button();
            this.tbUser1 = new System.Windows.Forms.TextBox();
            this.tbUser2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::Actividad6BenjaAurora.Properties.Resources.sp_366_02;
            this.pbImagen.Location = new System.Drawing.Point(209, 77);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(365, 100);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Location = new System.Drawing.Point(217, 232);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(212, 16);
            this.lblUser1.TabIndex = 1;
            this.lblUser1.Text = "Introduzca el nombre del jugador 1";
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.Location = new System.Drawing.Point(217, 271);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(212, 16);
            this.lblUser2.TabIndex = 2;
            this.lblUser2.Text = "Introduzca el nombre del jugador 2";
            // 
            // lblCargando
            // 
            this.lblCargando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(260, 362);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(0, 16);
            this.lblCargando.TabIndex = 3;
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCargando
            // 
            this.pbCargando.Location = new System.Drawing.Point(305, 394);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(188, 23);
            this.pbCargando.TabIndex = 4;
            this.pbCargando.Visible = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(358, 318);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 5;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // tbUser1
            // 
            this.tbUser1.Location = new System.Drawing.Point(453, 230);
            this.tbUser1.Name = "tbUser1";
            this.tbUser1.Size = new System.Drawing.Size(117, 22);
            this.tbUser1.TabIndex = 6;
            // 
            // tbUser2
            // 
            this.tbUser2.Location = new System.Drawing.Point(453, 269);
            this.tbUser2.Name = "tbUser2";
            this.tbUser2.Size = new System.Drawing.Size(117, 22);
            this.tbUser2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbUser2);
            this.Controls.Add(this.tbUser1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.lblUser2);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.pbImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.ProgressBar pbCargando;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox tbUser1;
        private System.Windows.Forms.TextBox tbUser2;
    }
}

