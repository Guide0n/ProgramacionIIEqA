namespace Practica7
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);


            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.listBoxCalificaciones = new System.Windows.Forms.ListBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnRegular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(20, 60);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(20, 100);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(91, 13);
            this.lblControl.TabIndex = 2;
            this.lblControl.Text = "Número de control";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(120, 60);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(200, 20);
            this.txtCarrera.TabIndex = 4;
            // 
            // txtNumeroControl

            this.txtNumeroControl.Location = new System.Drawing.Point(120, 100);
            this.txtNumeroControl.Name = "txtNumeroControl";
            this.txtNumeroControl.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroControl.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(350, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(350, 180);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(150, 23);
            this.btnCargarFoto.TabIndex = 7;
            this.btnCargarFoto.Text = "Cargar Fotografía";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(20, 150);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(64, 13);
            this.lblCalificacion.TabIndex = 8;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(120, 150);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 9;
            // 
            // btnAgregarCalificacion
            // 
            this.btnAgregarCalificacion.Location = new System.Drawing.Point(230, 148);
            this.btnAgregarCalificacion.Name = "btnAgregarCalificacion";
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(90, 23);
            this.btnAgregarCalificacion.TabIndex = 10;
            this.btnAgregarCalificacion.Text = "Agregar";
            this.btnAgregarCalificacion.UseVisualStyleBackColor = true;
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);
            // 
            // listBoxCalificaciones
            // 
            this.listBoxCalificaciones.FormattingEnabled = true;
            this.listBoxCalificaciones.Location = new System.Drawing.Point(20, 190);
            this.listBoxCalificaciones.Name = "listBoxCalificaciones";
            this.listBoxCalificaciones.Size = new System.Drawing.Size(300, 95);
            this.listBoxCalificaciones.TabIndex = 11;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(20, 300);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(100, 23);
            this.btnPromedio.TabIndex = 12;
            this.btnPromedio.Text = "Ver Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnRegular
            // 
            this.btnRegular.Location = new System.Drawing.Point(150, 300);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(120, 23);
this.btnRegular.TabIndex = 13;
            this.btnRegular.Text = "Ver Regularidad";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.btnRegular);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.listBoxCalificaciones);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumeroControl);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Gestión de Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.ListBox listBoxCalificaciones;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnRegular;
    }
}


