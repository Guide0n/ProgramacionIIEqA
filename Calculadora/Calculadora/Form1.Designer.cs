namespace Calculadora
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
            this.lbCalc = new System.Windows.Forms.Label();
            this.btmas = new System.Windows.Forms.Button();
            this.btres = new System.Windows.Forms.Button();
            this.btmulti = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btdeleate = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btigual = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btpunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCalc
            // 
            this.lbCalc.AutoSize = true;
            this.lbCalc.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalc.Location = new System.Drawing.Point(125, 17);
            this.lbCalc.Name = "lbCalc";
            this.lbCalc.Size = new System.Drawing.Size(105, 25);
            this.lbCalc.TabIndex = 0;
            this.lbCalc.Text = "CalculaTec";
            this.lbCalc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btmas
            // 
            this.btmas.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmas.Location = new System.Drawing.Point(106, 99);
            this.btmas.Name = "btmas";
            this.btmas.Size = new System.Drawing.Size(71, 49);
            this.btmas.TabIndex = 5;
            this.btmas.Text = "+";
            this.btmas.UseVisualStyleBackColor = true;
            this.btmas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btres
            // 
            this.btres.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btres.Location = new System.Drawing.Point(260, 209);
            this.btres.Name = "btres";
            this.btres.Size = new System.Drawing.Size(71, 49);
            this.btres.TabIndex = 7;
            this.btres.Text = "-";
            this.btres.UseVisualStyleBackColor = true;
            this.btres.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btmulti
            // 
            this.btmulti.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmulti.Location = new System.Drawing.Point(260, 154);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(71, 49);
            this.btmulti.TabIndex = 8;
            this.btmulti.Text = "*";
            this.btmulti.UseVisualStyleBackColor = true;
            this.btmulti.Click += new System.EventHandler(this.btmulti_Click);
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.Location = new System.Drawing.Point(183, 99);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(71, 49);
            this.btdiv.TabIndex = 9;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // btdeleate
            // 
            this.btdeleate.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleate.Location = new System.Drawing.Point(29, 99);
            this.btdeleate.Name = "btdeleate";
            this.btdeleate.Size = new System.Drawing.Size(71, 49);
            this.btdeleate.TabIndex = 10;
            this.btdeleate.Text = "Del";
            this.btdeleate.UseVisualStyleBackColor = true;
            this.btdeleate.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(29, 209);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(71, 49);
            this.bt4.TabIndex = 11;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(183, 154);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(71, 49);
            this.bt9.TabIndex = 12;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(106, 154);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(71, 49);
            this.bt8.TabIndex = 13;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(29, 154);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(71, 49);
            this.bt7.TabIndex = 14;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.button9_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(183, 264);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(71, 49);
            this.bt3.TabIndex = 15;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(106, 264);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(71, 49);
            this.bt2.TabIndex = 16;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(29, 264);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(71, 49);
            this.bt1.TabIndex = 17;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button12_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(183, 209);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(71, 49);
            this.bt6.TabIndex = 18;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(106, 209);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(71, 49);
            this.bt5.TabIndex = 19;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.Location = new System.Drawing.Point(52, 62);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(251, 20);
            this.txtScreen.TabIndex = 20;
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btigual
            // 
            this.btigual.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btigual.Location = new System.Drawing.Point(260, 264);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(71, 104);
            this.btigual.TabIndex = 21;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.button15_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(29, 319);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(148, 49);
            this.bt0.TabIndex = 22;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.button16_Click);
            // 
            // btpunto
            // 
            this.btpunto.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpunto.Location = new System.Drawing.Point(183, 319);
            this.btpunto.Name = "btpunto";
            this.btpunto.Size = new System.Drawing.Size(71, 49);
            this.btpunto.TabIndex = 23;
            this.btpunto.Text = ".";
            this.btpunto.UseVisualStyleBackColor = true;
            this.btpunto.Click += new System.EventHandler(this.btpunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.btpunto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btdeleate);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.btres);
            this.Controls.Add(this.btmas);
            this.Controls.Add(this.lbCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCalc;
        private System.Windows.Forms.Button btmas;
        private System.Windows.Forms.Button btres;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btdeleate;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btpunto;
    }
}

