namespace Actividades_U6_en_C_
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 95);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 55);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(93, 168);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 58);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(308, 95);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(37, 16);
            this.lblLibro.TabIndex = 3;
            this.lblLibro.Text = "Libro";
            this.lblLibro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(308, 145);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(54, 16);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(308, 195);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(31, 16);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(90, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "Escribe el Nombre, su Director y Su año de estreno  ";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(389, 89);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(319, 22);
            this.txtPelicula.TabIndex = 7;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(389, 139);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(319, 22);
            this.txtDirector.TabIndex = 8;
            this.txtDirector.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(389, 186);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(319, 22);
            this.txtAño.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtAño;
    }
}

