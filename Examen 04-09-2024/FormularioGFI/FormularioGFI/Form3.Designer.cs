namespace FormularioGFI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblAdivinar = new Label();
            txtAdivinar = new TextBox();
            btnVerificar = new Button();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // lblAdivinar
            // 
            lblAdivinar.AutoSize = true;
            lblAdivinar.Location = new Point(161, 120);
            lblAdivinar.Name = "lblAdivinar";
            lblAdivinar.Size = new Size(249, 20);
            lblAdivinar.TabIndex = 0;
            lblAdivinar.Text = "¿Puedes adivinar cuál es tu favorito?";
            // 
            // txtAdivinar
            // 
            txtAdivinar.Location = new Point(190, 164);
            txtAdivinar.Name = "txtAdivinar";
            txtAdivinar.Size = new Size(125, 27);
            txtAdivinar.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(190, 260);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += verificar;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(419, 260);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(94, 29);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += reiniciar;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 548);
            Controls.Add(btnReiniciar);
            Controls.Add(btnVerificar);
            Controls.Add(txtAdivinar);
            Controls.Add(lblAdivinar);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdivinar;
        private TextBox txtAdivinar;
        private Button btnVerificar;
        private Button btnReiniciar;
    }
}