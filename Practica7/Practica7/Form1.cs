using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        Alumno alumno = new Alumno();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCalificacion_Click(object sender, EventArgs e)
        {
            int calif;
            if (int.TryParse(txtCalificacion.Text, out calif))
            {
                if (alumno.AgregarCalificacion(calif))
                {
                    listBoxCalificaciones.Items.Add(calif);
                    MessageBox.Show("Calificación agregada.");
                }
                else
                {
                    MessageBox.Show("Calificación no válida (0-100).");
                }
            }
            txtCalificacion.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = alumno.ObtenerPromedio();
            MessageBox.Show($"Promedio: {promedio:F2}");
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            if (alumno.EsRegular())
                MessageBox.Show("El alumno es REGULAR.");
            else
                MessageBox.Show("El alumno NO es regular.");
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                alumno.Fotografia = ofd.FileName;
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
