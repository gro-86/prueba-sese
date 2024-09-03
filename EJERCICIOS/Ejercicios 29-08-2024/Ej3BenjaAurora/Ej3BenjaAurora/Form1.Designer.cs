namespace Ej3BenjaAurora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cobGimnasios = new System.Windows.Forms.ComboBox();
            this.lblGimnasio = new System.Windows.Forms.Label();
            this.gpDatosUser = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.ckbVip = new System.Windows.Forms.CheckBox();
            this.gbPreferencias = new System.Windows.Forms.GroupBox();
            this.cobActividades = new System.Windows.Forms.ComboBox();
            this.lblActividadesInteres = new System.Windows.Forms.Label();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.cobEntrenador = new System.Windows.Forms.ComboBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gpDatosUser.SuspendLayout();
            this.gbPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(51, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INSCRIPCIÓN AL GIMNASIO";
            // 
            // cobGimnasios
            // 
            this.cobGimnasios.FormattingEnabled = true;
            this.cobGimnasios.Items.AddRange(new object[] {
            "VivaGym",
            "AltaFit"});
            this.cobGimnasios.Location = new System.Drawing.Point(286, 54);
            this.cobGimnasios.Name = "cobGimnasios";
            this.cobGimnasios.Size = new System.Drawing.Size(121, 24);
            this.cobGimnasios.TabIndex = 1;
            // 
            // lblGimnasio
            // 
            this.lblGimnasio.AutoSize = true;
            this.lblGimnasio.Location = new System.Drawing.Point(52, 57);
            this.lblGimnasio.Name = "lblGimnasio";
            this.lblGimnasio.Size = new System.Drawing.Size(228, 16);
            this.lblGimnasio.TabIndex = 2;
            this.lblGimnasio.Text = "Seleccione el gimnasio a inscribirse: ";
            this.lblGimnasio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpDatosUser
            // 
            this.gpDatosUser.Controls.Add(this.ckbVip);
            this.gpDatosUser.Controls.Add(this.tbEdad);
            this.gpDatosUser.Controls.Add(this.lblEdad);
            this.gpDatosUser.Controls.Add(this.tbApellidos);
            this.gpDatosUser.Controls.Add(this.tbNombre);
            this.gpDatosUser.Controls.Add(this.lblApellidos);
            this.gpDatosUser.Controls.Add(this.lblNombre);
            this.gpDatosUser.Location = new System.Drawing.Point(55, 108);
            this.gpDatosUser.Name = "gpDatosUser";
            this.gpDatosUser.Size = new System.Drawing.Size(366, 168);
            this.gpDatosUser.TabIndex = 3;
            this.gpDatosUser.TabStop = false;
            this.gpDatosUser.Text = "Datos Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(16, 60);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 16);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(98, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(140, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(98, 57);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(140, 22);
            this.tbApellidos.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(16, 88);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(98, 85);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(140, 22);
            this.tbEdad.TabIndex = 5;
            // 
            // ckbVip
            // 
            this.ckbVip.AutoSize = true;
            this.ckbVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVip.Location = new System.Drawing.Point(19, 124);
            this.ckbVip.Name = "ckbVip";
            this.ckbVip.Size = new System.Drawing.Size(295, 19);
            this.ckbVip.TabIndex = 6;
            this.ckbVip.Text = "Inscripción VIP. No necesitarás reservar actividad";
            this.ckbVip.UseVisualStyleBackColor = true;
            // 
            // gbPreferencias
            // 
            this.gbPreferencias.Controls.Add(this.lblEntrenador);
            this.gbPreferencias.Controls.Add(this.cobEntrenador);
            this.gbPreferencias.Controls.Add(this.lblActividadesInteres);
            this.gbPreferencias.Controls.Add(this.cobActividades);
            this.gbPreferencias.Location = new System.Drawing.Point(55, 303);
            this.gbPreferencias.Name = "gbPreferencias";
            this.gbPreferencias.Size = new System.Drawing.Size(366, 100);
            this.gbPreferencias.TabIndex = 4;
            this.gbPreferencias.TabStop = false;
            this.gbPreferencias.Text = "Preferencias";
            // 
            // cobActividades
            // 
            this.cobActividades.FormattingEnabled = true;
            this.cobActividades.Items.AddRange(new object[] {
            "Cinta",
            "Press de banca",
            "Mancuernas"});
            this.cobActividades.Location = new System.Drawing.Point(180, 34);
            this.cobActividades.Name = "cobActividades";
            this.cobActividades.Size = new System.Drawing.Size(121, 24);
            this.cobActividades.TabIndex = 5;
            // 
            // lblActividadesInteres
            // 
            this.lblActividadesInteres.AutoSize = true;
            this.lblActividadesInteres.Location = new System.Drawing.Point(16, 37);
            this.lblActividadesInteres.Name = "lblActividadesInteres";
            this.lblActividadesInteres.Size = new System.Drawing.Size(143, 16);
            this.lblActividadesInteres.TabIndex = 7;
            this.lblActividadesInteres.Text = "Actividades de interés:";
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Location = new System.Drawing.Point(16, 67);
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Size = new System.Drawing.Size(149, 16);
            this.lblEntrenador.TabIndex = 9;
            this.lblEntrenador.Text = "Selecciona entrenador: ";
            // 
            // cobEntrenador
            // 
            this.cobEntrenador.FormattingEnabled = true;
            this.cobEntrenador.Items.AddRange(new object[] {
            "Pepe",
            "Pepa",
            "Carla",
            "Carlo"});
            this.cobEntrenador.Location = new System.Drawing.Point(180, 64);
            this.cobEntrenador.Name = "cobEntrenador";
            this.cobEntrenador.Size = new System.Drawing.Size(121, 24);
            this.cobEntrenador.TabIndex = 8;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Location = new System.Drawing.Point(185, 423);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(108, 26);
            this.btnInscribirse.TabIndex = 5;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(509, 89);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(249, 267);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.gbPreferencias);
            this.Controls.Add(this.gpDatosUser);
            this.Controls.Add(this.lblGimnasio);
            this.Controls.Add(this.cobGimnasios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpDatosUser.ResumeLayout(false);
            this.gpDatosUser.PerformLayout();
            this.gbPreferencias.ResumeLayout(false);
            this.gbPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cobGimnasios;
        private System.Windows.Forms.Label lblGimnasio;
        private System.Windows.Forms.GroupBox gpDatosUser;
        private System.Windows.Forms.CheckBox ckbVip;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbPreferencias;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.ComboBox cobEntrenador;
        private System.Windows.Forms.Label lblActividadesInteres;
        private System.Windows.Forms.ComboBox cobActividades;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

