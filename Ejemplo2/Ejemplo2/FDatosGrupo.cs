using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class FDatosGrupo : Form
    {
        public FDatosGrupo()
        {
            InitializeComponent();
        }

        private void FDatosGrupo_Load(object sender, EventArgs e)
        {
            textBox1.Text = DatosGrupo.Materia;
            textBox2.Text = DatosGrupo.Docente;
            textBox3.Text = DatosGrupo.Horario;

            if (DatosGrupo.Imagen != null)
            {
                pbGrupo.Image = DatosGrupo.Imagen;
            }
        }

        private void btFoto_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog ofd = new OpenFileDialog();
            /* ofd.Title = "Seleccionar fotografía";
           ofd.Filter = "Archivos de imagen (.jpg*;.jpeg*;.png*;.bmp*)|.jpg*;.jpeg*;.png*;.bmp*|Todos los archivos (*.*)|*.*";
           */
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbGrupo.Image = Image.FromFile(ofd.FileName);
                pbGrupo.Tag = ofd.FileName;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            // Guardar los valores en la clase estática
            DatosGrupo.Materia = textBox1.Text;
            DatosGrupo.Docente = textBox2.Text;
            DatosGrupo.Horario = textBox3.Text;

            if (pbGrupo.Image != null)
                DatosGrupo.Imagen = (Bitmap)pbGrupo.Image;

            MessageBox.Show("Datos guardados temporalmente en memoria.");
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}