using System.Drawing;

namespace Actividad6GroverLorenzo
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
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.pbGana = new System.Windows.Forms.PictureBox();
            this.pbPersonaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(356, 344);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 0;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(356, 373);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 1;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(437, 373);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(84, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(255, 373);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(95, 23);
            this.btnIzq.TabIndex = 3;
            this.btnIzq.Text = "Izquierda";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // pbGana
            // 
            this.pbGana.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbGana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGana.Image = global::Actividad6GroverLorenzo.Properties.Resources.pngwing_com__2_;
            this.pbGana.Location = new System.Drawing.Point(105, 248);
            this.pbGana.Name = "pbGana";
            this.pbGana.Size = new System.Drawing.Size(62, 48);
            this.pbGana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGana.TabIndex = 8;
            this.pbGana.TabStop = false;
            this.pbGana.Visible = false;
            // 
            // pbPersonaje
            // 
            this.pbPersonaje.Image = global::Actividad6GroverLorenzo.Properties.Resources.clown;
            this.pbPersonaje.Location = new System.Drawing.Point(311, 168);
            this.pbPersonaje.Name = "pbPersonaje";
            this.pbPersonaje.Size = new System.Drawing.Size(60, 50);
            this.pbPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonaje.TabIndex = 4;
            this.pbPersonaje.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbGana);
            this.Controls.Add(this.pbPersonaje);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.PictureBox pbPersonaje;
        private System.Windows.Forms.PictureBox pbGana;
    }
}

