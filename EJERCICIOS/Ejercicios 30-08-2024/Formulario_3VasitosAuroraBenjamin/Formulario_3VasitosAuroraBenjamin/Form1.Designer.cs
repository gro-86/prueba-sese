using System.Windows.Forms;

namespace Formulario_3VasitosAuroraBenjamin
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
            this.gbVasitos = new System.Windows.Forms.GroupBox();
            this.rbVasito3 = new System.Windows.Forms.RadioButton();
            this.rbVasito2 = new System.Windows.Forms.RadioButton();
            this.rbVasito1 = new System.Windows.Forms.RadioButton();
            this.btnElegir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.picture_vaso1 = new System.Windows.Forms.PictureBox();
            this.picture_vaso2 = new System.Windows.Forms.PictureBox();
            this.picture_vaso3 = new System.Windows.Forms.PictureBox();
            this.imagen_bola1 = new System.Windows.Forms.PictureBox();
            this.imagen_bola2 = new System.Windows.Forms.PictureBox();
            this.imagen_bola3 = new System.Windows.Forms.PictureBox();
            this.gbVasitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVasitos
            // 
            this.gbVasitos.Controls.Add(this.rbVasito3);
            this.gbVasitos.Controls.Add(this.rbVasito2);
            this.gbVasitos.Controls.Add(this.rbVasito1);
            this.gbVasitos.Location = new System.Drawing.Point(460, 35);
            this.gbVasitos.Name = "gbVasitos";
            this.gbVasitos.Size = new System.Drawing.Size(200, 113);
            this.gbVasitos.TabIndex = 0;
            this.gbVasitos.TabStop = false;
            this.gbVasitos.Text = "Vasitos";
            // 
            // rbVasito3
            // 
            this.rbVasito3.AutoSize = true;
            this.rbVasito3.Location = new System.Drawing.Point(7, 74);
            this.rbVasito3.Name = "rbVasito3";
            this.rbVasito3.Size = new System.Drawing.Size(76, 20);
            this.rbVasito3.TabIndex = 2;
            this.rbVasito3.TabStop = true;
            this.rbVasito3.Text = "Vasito 3";
            this.rbVasito3.UseVisualStyleBackColor = true;
            // 
            // rbVasito2
            // 
            this.rbVasito2.AutoSize = true;
            this.rbVasito2.Location = new System.Drawing.Point(7, 48);
            this.rbVasito2.Name = "rbVasito2";
            this.rbVasito2.Size = new System.Drawing.Size(76, 20);
            this.rbVasito2.TabIndex = 1;
            this.rbVasito2.TabStop = true;
            this.rbVasito2.Text = "Vasito 2";
            this.rbVasito2.UseVisualStyleBackColor = true;
            // 
            // rbVasito1
            // 
            this.rbVasito1.AutoSize = true;
            this.rbVasito1.Location = new System.Drawing.Point(7, 21);
            this.rbVasito1.Name = "rbVasito1";
            this.rbVasito1.Size = new System.Drawing.Size(76, 20);
            this.rbVasito1.TabIndex = 0;
            this.rbVasito1.TabStop = true;
            this.rbVasito1.Text = "Vasito 1";
            this.rbVasito1.UseVisualStyleBackColor = true;
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(460, 175);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 1;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.elegirVaso);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(704, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // picture_vaso1
            // 
            this.picture_vaso1.Image = ((System.Drawing.Image)(resources.GetObject("picture_vaso1.Image")));
            this.picture_vaso1.Location = new System.Drawing.Point(31, 12);
            this.picture_vaso1.Name = "picture_vaso1";
            this.picture_vaso1.Size = new System.Drawing.Size(180, 188);
            this.picture_vaso1.TabIndex = 3;
            this.picture_vaso1.TabStop = false;
            // 
            // picture_vaso2
            // 
            this.picture_vaso2.Image = ((System.Drawing.Image)(resources.GetObject("picture_vaso2.Image")));
            this.picture_vaso2.Location = new System.Drawing.Point(31, 216);
            this.picture_vaso2.Name = "picture_vaso2";
            this.picture_vaso2.Size = new System.Drawing.Size(180, 195);
            this.picture_vaso2.TabIndex = 4;
            this.picture_vaso2.TabStop = false;
            // 
            // picture_vaso3
            // 
            this.picture_vaso3.Image = ((System.Drawing.Image)(resources.GetObject("picture_vaso3.Image")));
            this.picture_vaso3.Location = new System.Drawing.Point(31, 432);
            this.picture_vaso3.Name = "picture_vaso3";
            this.picture_vaso3.Size = new System.Drawing.Size(180, 208);
            this.picture_vaso3.TabIndex = 5;
            this.picture_vaso3.TabStop = false;
            // 
            // imagen_bola1
            // 
            this.imagen_bola1.Image = ((System.Drawing.Image)(resources.GetObject("imagen_bola1.Image")));
            this.imagen_bola1.Location = new System.Drawing.Point(254, 35);
            this.imagen_bola1.Name = "imagen_bola1";
            this.imagen_bola1.Size = new System.Drawing.Size(152, 163);
            this.imagen_bola1.TabIndex = 6;
            this.imagen_bola1.TabStop = false;
            this.imagen_bola1.Visible = false;
            // 
            // imagen_bola2
            // 
            this.imagen_bola2.Image = ((System.Drawing.Image)(resources.GetObject("imagen_bola2.Image")));
            this.imagen_bola2.Location = new System.Drawing.Point(254, 242);
            this.imagen_bola2.Name = "imagen_bola2";
            this.imagen_bola2.Size = new System.Drawing.Size(152, 169);
            this.imagen_bola2.TabIndex = 7;
            this.imagen_bola2.TabStop = false;
            this.imagen_bola2.Visible = false;
            // 
            // imagen_bola3
            // 
            this.imagen_bola3.Image = ((System.Drawing.Image)(resources.GetObject("imagen_bola3.Image")));
            this.imagen_bola3.Location = new System.Drawing.Point(254, 460);
            this.imagen_bola3.Name = "imagen_bola3";
            this.imagen_bola3.Size = new System.Drawing.Size(152, 160);
            this.imagen_bola3.TabIndex = 8;
            this.imagen_bola3.TabStop = false;
            this.imagen_bola3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 652);
            this.Controls.Add(this.imagen_bola3);
            this.Controls.Add(this.imagen_bola2);
            this.Controls.Add(this.imagen_bola1);
            this.Controls.Add(this.picture_vaso3);
            this.Controls.Add(this.picture_vaso2);
            this.Controls.Add(this.picture_vaso1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.gbVasitos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbVasitos.ResumeLayout(false);
            this.gbVasitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_vaso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_bola3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVasitos;
        private System.Windows.Forms.RadioButton rbVasito3;
        private System.Windows.Forms.RadioButton rbVasito2;
        private System.Windows.Forms.RadioButton rbVasito1;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox picture_vaso1;
        private PictureBox picture_vaso2;
        private PictureBox picture_vaso3;
        private PictureBox imagen_bola1;
        private PictureBox imagen_bola2;
        private PictureBox imagen_bola3;
    }
}

