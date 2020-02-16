using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorUnaVidaMejor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Mensaje(int a)
        {
            switch (a)
                {
                case 1:
                    MessageBox.Show("Instale el Microsoft.ACE.OLEDB.12.0 EN SU PC", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Ya está inscrito en el curso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Ya existe el id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
        }
        void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatEstudiante a = new MatEstudiante();
            a.MdiParent = this;
            a.Show();
        }
        void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos a = new Cursos();
            a.MdiParent = this;
            a.Show();
        }
        void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes a = new Estudiantes();
            a.MdiParent = this;
            a.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsEstudiante a = new InsEstudiante();
            a.MdiParent = this;
            a.Show();
        }
    }
}
