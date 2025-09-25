namespace Ejemplo2
{
    partial class FdatosEstudiante
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
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.lbcarrera = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lbnum = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.Button();
            this.pbFotografia = new System.Windows.Forms.PictureBox();
            this.ofdFotografia = new System.Windows.Forms.OpenFileDialog();
            this.btaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(54, 36);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(98, 25);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre: ";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Location = new System.Drawing.Point(148, 42);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(95, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcarrera.Location = new System.Drawing.Point(148, 90);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(100, 20);
            this.txtcarrera.TabIndex = 3;
            this.txtcarrera.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbcarrera
            // 
            this.lbcarrera.AutoSize = true;
            this.lbcarrera.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcarrera.Location = new System.Drawing.Point(54, 84);
            this.lbcarrera.Name = "lbcarrera";
            this.lbcarrera.Size = new System.Drawing.Size(80, 25);
            this.lbcarrera.TabIndex = 2;
            this.lbcarrera.Text = "Carrera:";
            this.lbcarrera.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(183, 142);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 5;
            this.txtnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnum.Location = new System.Drawing.Point(54, 136);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(123, 25);
            this.lbnum.TabIndex = 4;
            this.lbnum.Text = "No. Control:";
            this.lbnum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Foto
            // 
            this.Foto.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foto.Location = new System.Drawing.Point(59, 179);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(68, 32);
            this.Foto.TabIndex = 6;
            this.Foto.Text = "Foto";
            this.Foto.UseVisualStyleBackColor = true;
            this.Foto.Click += new System.EventHandler(this.Foto_Click);
            // 
            // pbFotografia
            // 
            this.pbFotografia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFotografia.Location = new System.Drawing.Point(148, 179);
            this.pbFotografia.Name = "pbFotografia";
            this.pbFotografia.Size = new System.Drawing.Size(135, 79);
            this.pbFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotografia.TabIndex = 7;
            this.pbFotografia.TabStop = false;
            this.pbFotografia.Click += new System.EventHandler(this.pbFotografia_Click);
            // 
            // ofdFotografia
            // 
            this.ofdFotografia.FileName = "ofdFotografia";
            // 
            // btaceptar
            // 
            this.btaceptar.Location = new System.Drawing.Point(208, 276);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(75, 23);
            this.btaceptar.TabIndex = 8;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FdatosEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.pbFotografia);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbnum);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.lbcarrera);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbnombre);
            this.Name = "FdatosEstudiante";
            this.Text = "FdatosEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label lbcarrera;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Button Foto;
        private System.Windows.Forms.PictureBox pbFotografia;
        private System.Windows.Forms.OpenFileDialog ofdFotografia;
        private System.Windows.Forms.Button btaceptar;
    }
}