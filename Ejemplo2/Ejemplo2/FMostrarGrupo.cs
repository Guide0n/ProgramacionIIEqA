using System;
using System.Drawing;
using System.Windows.Forms;
using Ejemplo2;

namespace Ejemplo2
{
    public partial class FMostrarGrupo : Form
    {
        private Label lblMateria;
        private Label lblDocente;
        private Label lblHorario;
        private PictureBox pbFoto;
        private Button btnCerrar;



        private void InicializarComponentes()
        {
            // Configuración de la ventana
            this.Text = "Datos del Grupo";
            this.Size = new Size(400, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Labels
            lblMateria = new Label();
            lblMateria.Text = "Materia:";
            lblMateria.Location = new Point(20, 20);
            lblMateria.AutoSize = true;

            lblDocente = new Label();
            lblDocente.Text = "Docente:";
            lblDocente.Location = new Point(20, 60);
            lblDocente.AutoSize = true;

            lblHorario = new Label();
            lblHorario.Text = "Horario:";
            lblHorario.Location = new Point(20, 100);
            lblHorario.AutoSize = true;

            // PictureBox
            pbFoto = new PictureBox();
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(20, 140);
            pbFoto.Size = new Size(340, 200);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            // Botón cerrar
            btnCerrar = new Button();
            btnCerrar.Text = "Cerrar";
            btnCerrar.Location = new Point(150, 360);
            btnCerrar.Click += BtnCerrar_Click;

            // Agregar controles al formulario
            this.Controls.Add(lblMateria);
            this.Controls.Add(lblDocente);
            this.Controls.Add(lblHorario);
            this.Controls.Add(pbFoto);
            this.Controls.Add(btnCerrar);

            // Evento Load
            this.Load += FMostrarGrupo_Load;
        }

        private void FMostrarGrupo_Load(object sender, EventArgs e)
        {
            // Mostrar datos guardados en memoria
            lbMateria.Text = "Materia: " + DatosGrupo.Materia;
            lbDocente.Text = "Docente: " + DatosGrupo.Docente;
            lbHorario.Text = "Horario: " + DatosGrupo.Horario;

            // Mostrar imagen si existe


            if (DatosGrupo.Imagen != null)
            {
                pbFoto.Image = DatosGrupo.Imagen;
            }
            else
            {
                pbFoto.Image = null; // O una imagen por defecto
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}