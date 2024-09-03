using System.Windows.Forms;

namespace Actividad6SamVictor
{
    partial class InfoJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoJuego));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblInfoJuego = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::Actividad6SamVictor.Properties.Resources._10791;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lblInfoJuego);
            this.panel1.Location = new System.Drawing.Point(227, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(629, 475);
            this.panel1.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic);
            this.btnVolver.Location = new System.Drawing.Point(498, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 33);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblInfoJuego
            // 
            this.lblInfoJuego.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoJuego.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Italic);
            this.lblInfoJuego.ForeColor = System.Drawing.Color.Black;
            this.lblInfoJuego.Location = new System.Drawing.Point(53, 50);
            this.lblInfoJuego.Name = "lblInfoJuego";
            this.lblInfoJuego.Size = new System.Drawing.Size(417, 1163);
            this.lblInfoJuego.TabIndex = 0;
            this.lblInfoJuego.Text = resources.GetString("lblInfoJuego.Text");
            // 
            // InfoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad6SamVictor.Properties.Resources.lotr;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.panel1);
            this.Name = "InfoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoJuego";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfoJuego;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
    }
}