namespace Actividad6BenjaAurora
{
    partial class Form2
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
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lbluser2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblContador1 = new System.Windows.Forms.Label();
            this.lblContador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb2
            // 
            this.pb2.Image = global::Actividad6BenjaAurora.Properties.Resources._2green;
            this.pb2.Location = new System.Drawing.Point(423, 51);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(313, 189);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::Actividad6BenjaAurora.Properties.Resources.Icon_1__set_orange_;
            this.pb1.Location = new System.Drawing.Point(52, 51);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(313, 189);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Location = new System.Drawing.Point(189, 260);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(0, 16);
            this.lblUser1.TabIndex = 2;
            // 
            // lbluser2
            // 
            this.lbluser2.AutoSize = true;
            this.lbluser2.Location = new System.Drawing.Point(568, 260);
            this.lbluser2.Name = "lbluser2";
            this.lbluser2.Size = new System.Drawing.Size(0, 16);
            this.lbluser2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(365, 363);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Tirar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblContador1
            // 
            this.lblContador1.AutoSize = true;
            this.lblContador1.Location = new System.Drawing.Point(182, 308);
            this.lblContador1.Name = "lblContador1";
            this.lblContador1.Size = new System.Drawing.Size(0, 16);
            this.lblContador1.TabIndex = 5;
            // 
            // lblContador2
            // 
            this.lblContador2.AutoSize = true;
            this.lblContador2.Location = new System.Drawing.Point(555, 308);
            this.lblContador2.Name = "lblContador2";
            this.lblContador2.Size = new System.Drawing.Size(0, 16);
            this.lblContador2.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 522);
            this.Controls.Add(this.lblContador2);
            this.Controls.Add(this.lblContador1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbluser2);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lbluser2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblContador1;
        private System.Windows.Forms.Label lblContador2;
    }
}