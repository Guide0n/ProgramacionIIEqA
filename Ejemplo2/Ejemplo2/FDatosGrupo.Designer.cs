namespace Ejemplo2
{
    partial class FDatosGrupo
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
            this.lbmateria = new System.Windows.Forms.Label();
            this.lbdocente = new System.Windows.Forms.Label();
            this.lbhorario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pbGrupo = new System.Windows.Forms.PictureBox();
            this.btFoto = new System.Windows.Forms.Label();
            this.ofdFotografiaG = new System.Windows.Forms.OpenFileDialog();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmateria
            // 
            this.lbmateria.AutoSize = true;
            this.lbmateria.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmateria.Location = new System.Drawing.Point(29, 28);
            this.lbmateria.Name = "lbmateria";
            this.lbmateria.Size = new System.Drawing.Size(91, 25);
            this.lbmateria.TabIndex = 0;
            this.lbmateria.Text = "Materia: ";
            this.lbmateria.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbdocente
            // 
            this.lbdocente.AutoSize = true;
            this.lbdocente.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdocente.Location = new System.Drawing.Point(29, 68);
            this.lbdocente.Name = "lbdocente";
            this.lbdocente.Size = new System.Drawing.Size(98, 25);
            this.lbdocente.TabIndex = 1;
            this.lbdocente.Text = "Docente: ";
            // 
            // lbhorario
            // 
            this.lbhorario.AutoSize = true;
            this.lbhorario.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhorario.Location = new System.Drawing.Point(29, 108);
            this.lbhorario.Name = "lbhorario";
            this.lbhorario.Size = new System.Drawing.Size(85, 25);
            this.lbhorario.TabIndex = 2;
            this.lbhorario.Text = "Horario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 5;
            // 
            // pbGrupo
            // 
            this.pbGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGrupo.Location = new System.Drawing.Point(120, 149);
            this.pbGrupo.Name = "pbGrupo";
            this.pbGrupo.Size = new System.Drawing.Size(153, 122);
            this.pbGrupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrupo.TabIndex = 6;
            this.pbGrupo.TabStop = false;
            // 
            // btFoto
            // 
            this.btFoto.AutoSize = true;
            this.btFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btFoto.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFoto.Location = new System.Drawing.Point(20, 149);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(94, 23);
            this.btFoto.TabIndex = 7;
            this.btFoto.Text = "Fotografía:";
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // ofdFotografiaG
            // 
            this.ofdFotografiaG.FileName = "ofdFotografiaG";
            this.ofdFotografiaG.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(196, 277);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FDatosGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btFoto);
            this.Controls.Add(this.pbGrupo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbhorario);
            this.Controls.Add(this.lbdocente);
            this.Controls.Add(this.lbmateria);
            this.Name = "FDatosGrupo";
            this.Text = "FDatosGrupo";
            this.Load += new System.EventHandler(this.FDatosGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmateria;
        private System.Windows.Forms.Label lbdocente;
        private System.Windows.Forms.Label lbhorario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pbGrupo;
        private System.Windows.Forms.Label btFoto;
        private System.Windows.Forms.OpenFileDialog ofdFotografiaG;
        private System.Windows.Forms.Button btAceptar;
    }
}