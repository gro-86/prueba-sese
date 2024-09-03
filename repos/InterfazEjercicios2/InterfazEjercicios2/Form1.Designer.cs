namespace InterfazEjercicios2
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
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.lvNombre = new System.Windows.Forms.ListView();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 16;
            this.lbNombres.Items.AddRange(new object[] {
            "Raymel",
            "Javier",
            "Dania",
            "Esmeralda",
            "Vivienne",
            "Isabel",
            "Inés"});
            this.lbNombres.Location = new System.Drawing.Point(72, 69);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(120, 84);
            this.lbNombres.TabIndex = 0;
            this.lbNombres.SelectedIndexChanged += new System.EventHandler(this.mostrarDetalles);
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(72, 208);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 23);
            this.bntAgregar.TabIndex = 1;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.agregarNombre);
            // 
            // lvNombre
            // 
            this.lvNombre.HideSelection = false;
            this.lvNombre.Location = new System.Drawing.Point(302, 69);
            this.lvNombre.Name = "lvNombre";
            this.lvNombre.Size = new System.Drawing.Size(179, 248);
            this.lvNombre.TabIndex = 2;
            this.lvNombre.UseCompatibleStateImageBehavior = false;
            this.lvNombre.View = System.Windows.Forms.View.List;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(72, 173);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(100, 22);
            this.txtBNombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.lvNombre);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.lbNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.ListView lvNombre;
        private System.Windows.Forms.TextBox txtBNombre;
    }
}

