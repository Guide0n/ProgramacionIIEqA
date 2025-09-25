using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FdatosEstudiante ventana_datos_estudiante = new FdatosEstudiante();

            ventana_datos_estudiante.ShowDialog();
        }
        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDatosGrupo ventana_datos_grupo = new FDatosGrupo();

            ventana_datos_grupo.ShowDialog();
        }

        private void grupoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FDatosGrupo ventana_datos_grupo = new FDatosGrupo();

            ventana_datos_grupo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMostrarGrupo f = new FMostrarGrupo();
            f.ShowDialog();

        }
    }
}
