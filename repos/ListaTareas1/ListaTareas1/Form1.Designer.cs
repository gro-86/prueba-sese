namespace ListaTareas1
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
            this.lbTareas = new System.Windows.Forms.ListBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbImportante = new System.Windows.Forms.CheckBox();
            this.gbPrioridad = new System.Windows.Forms.GroupBox();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pbProgresoTareas = new System.Windows.Forms.ProgressBar();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.lvTareas = new System.Windows.Forms.ListView();
            this.gbPrioridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTareas
            // 
            this.lbTareas.FormattingEnabled = true;
            this.lbTareas.ItemHeight = 16;
            this.lbTareas.Location = new System.Drawing.Point(27, 36);
            this.lbTareas.Name = "lbTareas";
            this.lbTareas.Size = new System.Drawing.Size(225, 84);
            this.lbTareas.TabIndex = 0;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(33, 144);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 22);
            this.txtbNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 405);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.agregarTarea);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(198, 405);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.marcarTarea);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(380, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.eliminarTarea);
            // 
            // chkbImportante
            // 
            this.chkbImportante.AutoSize = true;
            this.chkbImportante.Location = new System.Drawing.Point(27, 189);
            this.chkbImportante.Name = "chkbImportante";
            this.chkbImportante.Size = new System.Drawing.Size(92, 20);
            this.chkbImportante.TabIndex = 5;
            this.chkbImportante.Text = "Importante";
            this.chkbImportante.UseVisualStyleBackColor = true;
            // 
            // gbPrioridad
            // 
            this.gbPrioridad.Controls.Add(this.rbAlta);
            this.gbPrioridad.Controls.Add(this.rbMedia);
            this.gbPrioridad.Controls.Add(this.rbBaja);
            this.gbPrioridad.Location = new System.Drawing.Point(27, 236);
            this.gbPrioridad.Name = "gbPrioridad";
            this.gbPrioridad.Size = new System.Drawing.Size(200, 100);
            this.gbPrioridad.TabIndex = 6;
            this.gbPrioridad.TabStop = false;
            this.gbPrioridad.Text = "groupBox1";
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Location = new System.Drawing.Point(6, 74);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(51, 20);
            this.rbAlta.TabIndex = 2;
            this.rbAlta.TabStop = true;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(6, 48);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(66, 20);
            this.rbMedia.TabIndex = 1;
            this.rbMedia.TabStop = true;
            this.rbMedia.Text = "Media";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Location = new System.Drawing.Point(7, 22);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(56, 20);
            this.rbBaja.TabIndex = 0;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(258, 36);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(44, 16);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Texto:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(261, 142);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(300, 22);
            this.dtpFecha.TabIndex = 8;
            // 
            // pbProgresoTareas
            // 
            this.pbProgresoTareas.Location = new System.Drawing.Point(261, 189);
            this.pbProgresoTareas.Name = "pbProgresoTareas";
            this.pbProgresoTareas.Size = new System.Drawing.Size(100, 23);
            this.pbProgresoTareas.TabIndex = 9;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(261, 245);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 50);
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(31, 123);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(90, 16);
            this.lblNombreTarea.TabIndex = 11;
            this.lblNombreTarea.Text = "Nombre tarea";
            // 
            // lvTareas
            // 
            this.lvTareas.HideSelection = false;
            this.lvTareas.Location = new System.Drawing.Point(615, 294);
            this.lvTareas.Name = "lvTareas";
            this.lvTareas.Size = new System.Drawing.Size(121, 97);
            this.lvTareas.TabIndex = 12;
            this.lvTareas.UseCompatibleStateImageBehavior = false;
            this.lvTareas.SelectedIndexChanged += new System.EventHandler(this.agregarTarea);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvTareas);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.pbProgresoTareas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.gbPrioridad);
            this.Controls.Add(this.chkbImportante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lbTareas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPrioridad.ResumeLayout(false);
            this.gbPrioridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTareas;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbImportante;
        private System.Windows.Forms.GroupBox gbPrioridad;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ProgressBar pbProgresoTareas;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.ListView lvTareas;
    }
}

