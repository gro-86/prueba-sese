namespace InterfazEjercicios4
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
            this.dtDias = new System.Windows.Forms.DateTimePicker();
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtDias
            // 
            this.dtDias.Location = new System.Drawing.Point(122, 94);
            this.dtDias.Name = "dtDias";
            this.dtDias.Size = new System.Drawing.Size(200, 22);
            this.dtDias.TabIndex = 0;
            this.dtDias.ValueChanged += new System.EventHandler(this.calcularDias);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(399, 94);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(103, 16);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Diferencia días: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.dtDias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDias;
        private System.Windows.Forms.Label lblDias;
    }
}

