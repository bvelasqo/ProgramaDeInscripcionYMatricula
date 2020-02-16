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
    public partial class InsEstudiante : Form
    {
        Operaciones operacion = new Operaciones();
        public InsEstudiante()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtIDC.Text = "";
            txtIDE.Text = "";
        }
        Boolean vacio()
        {
            if (txtIDC.Text == "" || txtIDE.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        void btnInscribir_Click(object sender, EventArgs e)
        {
            if (!vacio())
            {
                Boolean validacion;
                validacion = operacion.InscribirEstudiante(txtIDE.Text, txtIDC.SelectedValue.ToString());
                if (validacion)
                {
                    MessageBox.Show("Inscrito", "Estado de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
        }
        void btnVerInscritos_Click(object sender, EventArgs e)
        {
            dgvRelacion.Visible = true;
            dgvRelacion.DataSource = operacion.verRelaciones();
        }

        private void InsEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'base_De_Datos_Por_Una_Mejor_VidaDataSet1.Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.Cursos);
            // TODO: esta línea de código carga datos en la tabla 'base_De_Datos_Por_Una_Mejor_VidaDataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.base_De_Datos_Por_Una_Mejor_VidaDataSet.Estudiantes);
            limpiar();
        }

        private void txtIDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtIDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
