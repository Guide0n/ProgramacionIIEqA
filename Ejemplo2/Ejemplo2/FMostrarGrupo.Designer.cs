namespace Ejemplo2
{
    partial class FMostrarGrupo
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
            this.lbMateria = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbDocente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(23, 18);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(35, 13);
            this.lbMateria.TabIndex = 0;
            this.lbMateria.Text = "label1";
            this.lbMateria.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(23, 67);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(35, 13);
            this.lbHorario.TabIndex = 1;
            this.lbHorario.Text = "label2";
            // 
            // lbDocente
            // 
            this.lbDocente.AutoSize = true;
            this.lbDocente.Location = new System.Drawing.Point(23, 42);
            this.lbDocente.Name = "lbDocente";
            this.lbDocente.Size = new System.Drawing.Size(35, 13);
            this.lbDocente.TabIndex = 2;
            this.lbDocente.Text = "label3";
            // 
            // FMostrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDocente);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbMateria);
            this.Name = "FMostrarGrupo";
            this.Text = "FMostrarGrupo";
            this.Load += new System.EventHandler(this.FMostrarGrupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbDocente;
    }
}