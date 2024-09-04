namespace FormularioGFI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblComentario = new Label();
            cmbColor = new ComboBox();
            btnJugar = new Button();
            pbWelcome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbWelcome).BeginInit();
            SuspendLayout();
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(43, 290);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(194, 20);
            lblComentario.TabIndex = 0;
            lblComentario.Text = "Selecciona tu color favorito:";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Rojo", "Verde", "Azul", "Amarillo", "Naranja" });
            cmbColor.Location = new Point(280, 287);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(151, 28);
            cmbColor.TabIndex = 1;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(529, 286);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(94, 29);
            btnJugar.TabIndex = 2;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += jugar;
            // 
            // pbWelcome
            // 
            pbWelcome.BackgroundImage = (Image)resources.GetObject("pbWelcome.BackgroundImage");
            pbWelcome.Location = new Point(43, 12);
            pbWelcome.Name = "pbWelcome";
            pbWelcome.Size = new Size(156, 129);
            pbWelcome.TabIndex = 3;
            pbWelcome.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 548);
            Controls.Add(pbWelcome);
            Controls.Add(btnJugar);
            Controls.Add(cmbColor);
            Controls.Add(lblComentario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbWelcome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComentario;
        private ComboBox cmbColor;
        private Button btnJugar;
        private PictureBox pbWelcome;
    }
}
