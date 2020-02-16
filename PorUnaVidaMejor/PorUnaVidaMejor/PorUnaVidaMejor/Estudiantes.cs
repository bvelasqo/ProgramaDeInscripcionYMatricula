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
    public partial class Estudiantes : Form
    {
        Operaciones operacion = new Operaciones();
        DataTable tabla;
        public Estudiantes()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            txtCelularActualizar.Text = "";
            txtDireccionActualizar.Text = "";
            txtEmailActualizar.Text = "";
            txtEmailBuscar.Text = "";
            txtIdActualizar.Text = "";
            txtIdBuscar.Text = "";
            txtIdEliminar.Text = "";
        }
        void btnEmailBuscar_Click(object sender, EventArgs e)
        {
            lblEmail.Visible = true;
            txtEmailBuscar.Visible = true;
            lblID.Visible = false;
            txtIdBuscar.Visible = false;
            btnBuscar.Visible = true;
        }
        void btnIDBuscar_Click(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
            txtEmailBuscar.Visible = false;
            lblID.Visible = true;
            txtIdBuscar.Visible = true;
            btnBuscar.Visible = true;
            txtIdBuscar.Text = "";
        }
        void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdBuscar.Visible == true)
            {
                if (txtIdBuscar.Text == "")
                {
                    MessageBox.Show("Llene el campo ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabla = operacion.buscarEstudiantes("Identificacion", txtIdBuscar.SelectedValue.ToString());
                    dgvEstudiantes.DataSource = tabla;
                }
            }
            else if (txtEmailBuscar.Visible == true)
            {
                if (txtEmailBuscar.Text == "")
                {
                    MessageBox.Show("Llene el campo Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabla = operacion.buscarEstudiantes("Email", txtEmailBuscar.Text);
                    dgvEstudiantes.DataSource = tabla;
                }
            }
            limpiar();
        }
        void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdEliminar.Text == "")
            {
                MessageBox.Show("seleccione el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                operacion.eliminarEstudiante(txtIdEliminar.SelectedValue.ToString());
                MessageBox.Show("Estudiante Eliminado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            limpiar();
        }
        void btnEmailActualizar_Click(object sender, EventArgs e)
        {
            lblEmailActualizar.Visible = true;
            txtEmailActualizar.Visible = true;
            lblCelularActualizar.Visible = false;
            txtCelularActualizar.Visible = false;
            lblDireccionActualizar.Visible = false;
            txtDireccionActualizar.Visible = false;
            btnActualizar.Visible = true;
        }
        void btnCelularActualizar_Click(object sender, EventArgs e)
        {
            lblEmailActualizar.Visible = false;
            txtEmailActualizar.Visible = false;
            lblCelularActualizar.Visible = true;
            txtCelularActualizar.Visible = true;
            lblDireccionActualizar.Visible = false;
            txtDireccionActualizar.Visible = false;
            btnActualizar.Visible = true;
        }
        void btnDireccionActualizar_Click(object sender, EventArgs e)
        {
            lblEmailActualizar.Visible = false;
            txtEmailActualizar.Visible = false;
            lblCelularActualizar.Visible = false;
            txtCelularActualizar.Visible = false;
            lblDireccionActualizar.Visible = true;
            txtDireccionActualizar.Visible = true;
            btnActualizar.Visible = true;
        }
        void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdActualizar.Text == "")
            {
                MessageBox.Show("seleccione el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lblDireccionActualizar.Visible == true || txtDireccionActualizar.Visible == true)
                {
                    if (txtDireccionActualizar.Text == "")
                    {
                        MessageBox.Show("Llene el campo Direccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        operacion.ActualizarEstudiante("Direccion", txtDireccionActualizar.Text, txtIdActualizar.SelectedValue.ToString());
                        MessageBox.Show("ACTUALIZADO", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (lblEmailActualizar.Visible == true || txtEmailActualizar.Visible == true)
                {
                    if (txtEmailActualizar.Text == "" || !txtEmailActualizar.Text.Contains("@"))
                    {
                        MessageBox.Show("Correo invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        operacion.ActualizarEstudiante("Email", txtEmailActualizar.Text, txtIdActualizar.SelectedValue.ToString());
                        MessageBox.Show("ACTUALIZADO", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (lblCelularActualizar.Visible == true || txtCelularActualizar.Visible == true)
                {
                    if (txtCelularActualizar.Text == "")
                    {
                        MessageBox.Show("Llene el campo Celular", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        operacion.ActualizarEstudiante("Celular", txtCelularActualizar.Text, txtIdActualizar.SelectedValue.ToString());
                        MessageBox.Show("ACTUALIZADO", "ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                dgvEstudiantes.DataSource = operacion.buscarEstudiantes("Identificacion", txtIdActualizar.SelectedValue.ToString());
            }
            limpiar();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'base_De_Datos_Por_Una_Mejor_VidaDataSet.Estudiantes' table. You can move, or remove it, as needed.
            this.estudiantesTableAdapter.Fill(this.base_De_Datos_Por_Una_Mejor_VidaDataSet.Estudiantes);
            limpiar();
            txtIdBuscar.Text = "";
        }

        private void txtIdBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtIdActualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtIdEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
