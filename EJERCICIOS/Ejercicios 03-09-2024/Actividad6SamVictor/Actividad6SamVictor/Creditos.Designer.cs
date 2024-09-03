using System.Windows.Forms;

namespace Actividad6SamVictor
{
    partial class Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creditos));
            this.lblCreditos = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoEllipsis = true;
            this.lblCreditos.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic);
            this.lblCreditos.Location = new System.Drawing.Point(231, 98);
            this.lblCreditos.Margin = new System.Windows.Forms.Padding(0);
            this.lblCreditos.MinimumSize = new System.Drawing.Size(0, 50);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Padding = new System.Windows.Forms.Padding(60);
            this.lblCreditos.Size = new System.Drawing.Size(658, 438);
            this.lblCreditos.TabIndex = 0;
            this.lblCreditos.Text = resources.GetString("lblCreditos.Text");
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic);
            this.btnVolver.Location = new System.Drawing.Point(249, 117);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad6SamVictor.Properties.Resources.lotr;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCreditos);
            this.Name = "Creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Button btnVolver;
    }
}