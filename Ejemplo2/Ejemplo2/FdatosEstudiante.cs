using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo2
{
    public partial class FdatosEstudiante : Form
    {
        public FdatosEstudiante()
        {
            InitializeComponent();
            this.Load +=new System.EventHandler(this.FdatosEstudiante_Load);    
        }

        private void FdatosEstudiante_Load(object sender, EventArgs e)
        {
            txtnombre.Text = DatosEstudiante.Nombre;
            txtcarrera.Text = DatosEstudiante.Carrera;
            txtnum.Text = DatosEstudiante.Numero;

            if (DatosEstudiante.Fotografia != null)
            {
                pbFotografia.Image = DatosEstudiante.Fotografia;
            }
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            if (ofdFotografia.ShowDialog(this) == DialogResult.OK)
            {
                pbFotografia.Image = new Bitmap(ofdFotografia.FileName);
                pbFotografia.Tag = ofdFotografia.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guardar datos en la clase estática
            DatosEstudiante.Nombre = txtnombre.Text;
            DatosEstudiante.Carrera = txtcarrera.Text;
            DatosEstudiante.Numero = txtnum.Text;

            if (pbFotografia.Image != null)
                DatosEstudiante.Fotografia = (Bitmap)pbFotografia.Image;

            MessageBox.Show("Datos del estudiante guardados en memoria.");
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pbFotografia_Click(object sender, EventArgs e) { }
    }
}