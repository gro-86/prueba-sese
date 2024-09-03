using System.Windows.Forms;

namespace Actividad6SamVictor
{
    partial class DatosUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tkbEdad = new System.Windows.Forms.TrackBar();
            this.lblEdadTrack = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Italic);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(233, 96);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(617, 79);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos para la Partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(285, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué nombre quieres tener?";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(289, 302);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(291, 39);
            this.tbNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEdad.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Italic);
            this.lblEdad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEdad.Location = new System.Drawing.Point(289, 346);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(208, 38);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Indica tu edad";
            // 
            // tkbEdad
            // 
            this.tkbEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tkbEdad.Location = new System.Drawing.Point(289, 390);
            this.tkbEdad.Maximum = 80;
            this.tkbEdad.Minimum = 12;
            this.tkbEdad.Name = "tkbEdad";
            this.tkbEdad.Size = new System.Drawing.Size(518, 56);
            this.tkbEdad.TabIndex = 5;
            this.tkbEdad.Value = 18;
            this.tkbEdad.Scroll += new System.EventHandler(this.tkbEdad_Scroll);
            // 
            // lblEdadTrack
            // 
            this.lblEdadTrack.AutoSize = true;
            this.lblEdadTrack.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadTrack.Location = new System.Drawing.Point(77, 134);
            this.lblEdadTrack.Name = "lblEdadTrack";
            this.lblEdadTrack.Size = new System.Drawing.Size(0, 23);
            this.lblEdadTrack.TabIndex = 6;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Italic);
            this.btnAtras.Location = new System.Drawing.Point(229, 483);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 35);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Volver";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actividad6SamVictor.Properties.Resources._10791;
            this.pictureBox1.Location = new System.Drawing.Point(203, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 327);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad6SamVictor.Properties.Resources.lotr;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblEdadTrack);
            this.Controls.Add(this.tkbEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "DatosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.tkbEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TrackBar tkbEdad;
        private System.Windows.Forms.Label lblEdadTrack;
        private System.Windows.Forms.Button btnAtras;
    }
}