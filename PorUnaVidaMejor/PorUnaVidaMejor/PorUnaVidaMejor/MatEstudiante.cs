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
    public partial class MatEstudiante : Form
    {
        Operaciones operacion = new Operaciones();
        public MatEstudiante()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFHNacimiento.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }
        Boolean vacios()
        {
            if (txtApellidos.Text == "" || txtCelular.Text == "" || txtDireccion.Text == "" || txtEmail.Text == "" || txtIdentificacion.Text == "" || txtNombres.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Correo no válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        void btnMatricular_Click(object sender, EventArgs e)
        {
            Boolean validacion;
            if (!vacios())
            {
                validacion = operacion.MatricularEstudiante(txtIdentificacion.Text, txtNombres.Text, txtApellidos.Text, Convert.ToString(dtpFHNacimiento.Value.Date), txtDireccion.Text, txtCelular.Text, txtEmail.Text);
                if (validacion)
                {
                    MessageBox.Show("Matriculado", "Estado de matricula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            limpiar();
        }
        void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
