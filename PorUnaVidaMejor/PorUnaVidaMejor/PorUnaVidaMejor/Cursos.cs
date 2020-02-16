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
    public partial class Cursos : Form
    {
        Operaciones operacion = new Operaciones();
        DataTable tabla;
        public Cursos()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtInstructor.Text = "";
            txtCosto.Text = "";
            txtIdActualizarCost.Text = "";
            txtNuevoCosto.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoInstructor.Text = "";
        }
        Boolean vacios(int  a)
        {
            switch (a)
            {
                case 1:
                    if (txtCosto.Text == "" || txtInstructor.Text == "" || txtNombre.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    break;
                case 2:
                    if (txtNuevoCosto.Text == ""||txtIdActualizarCost.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    break;
                case 3:
                    if (txtNuevoInstructor.Text == "" || txtIdActualizarCost.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    break;
                case 4:
                    if (txtNuevoNombre.Text == "" || txtIdActualizarCost.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    break;
            }
            return false;
        }
        void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            Boolean validacion;
            if (!vacios(1))
            {
                double costo = Convert.ToDouble(txtCosto.Text);
                validacion = operacion.InscribirCurso(txtID.Text, txtNombre.Text, txtInstructor.Text, costo.ToString("C"));
                if (validacion)
                {
                    MessageBox.Show("Curso inscrito", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            limpiar();
        }
        void btnVerCursos_Click(object sender, EventArgs e)
        {
            tabla = operacion.VerTodosLosCursos();
            dgvCursos.DataSource = tabla;
        }
        void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lblNuevoCosto.Visible)
            {
                if (!vacios(2))
                {
                    double costo = Convert.ToDouble(txtNuevoCosto.Text);
                    operacion.ActualizarCosto(costo.ToString("C"), txtIdActualizarCost.SelectedValue.ToString());
                    MessageBox.Show("Costo actualizado", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (lblNuevoInstructor.Visible)
            {
                if (!vacios(3))
                {
                    operacion.ActualizarInstructor(txtNuevoInstructor.Text, txtIdActualizarCost.SelectedValue.ToString());
                    MessageBox.Show("Instructor actualizado", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (lblNuevoNombre.Visible)
            {
                if (!vacios(4))
                {
                    operacion.ActualizarNombre(txtNuevoNombre.Text, txtIdActualizarCost.SelectedValue.ToString());
                    MessageBox.Show("Nombre actualizado", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            limpiar();
            dgvCursos.DataSource = operacion.VerTodosLosCursos();
        }
        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
        void txtInstructor_KeyPress(object sender, KeyPressEventArgs e)
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
        void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
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
        void txtNuevoCosto_KeyPress(object sender, KeyPressEventArgs e)
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
        void btnNuevoCosto_Click(object sender, EventArgs e)
        {
            lblNuevoCosto.Visible = true;
            txtNuevoCosto.Visible = true;
            lblNuevoInstructor.Visible = false;
            txtNuevoInstructor.Visible = false;
            lblNuevoNombre.Visible = false;
            txtNuevoNombre.Visible = false;
        }
        void btnNuevoInstructor_Click(object sender, EventArgs e)
        {
            lblNuevoCosto.Visible = false;
            txtNuevoCosto.Visible = false;
            lblNuevoInstructor.Visible = true;
            txtNuevoInstructor.Visible = true;
            lblNuevoNombre.Visible = false;
            txtNuevoNombre.Visible = false;
        }
        void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            lblNuevoCosto.Visible = false;
            txtNuevoCosto.Visible = false;
            lblNuevoInstructor.Visible = false;
            txtNuevoInstructor.Visible = false;
            lblNuevoNombre.Visible = true;
            txtNuevoNombre.Visible = true;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'base_De_Datos_Por_Una_Mejor_VidaDataSet1.Cursos' table. You can move, or remove it, as needed.
            this.cursosTableAdapter.Fill(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.Cursos);
            limpiar();
        }

        private void txtIdActualizarCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
