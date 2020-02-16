namespace PorUnaVidaMejor
{
    partial class MatEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.dtpFHNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(220, 9);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(149, 37);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.dtpFHNacimiento);
            this.gbxDatos.Controls.Add(this.btnMatricular);
            this.gbxDatos.Controls.Add(this.txtCelular);
            this.gbxDatos.Controls.Add(this.lblCelular);
            this.gbxDatos.Controls.Add(this.txtEmail);
            this.gbxDatos.Controls.Add(this.lblEmail);
            this.gbxDatos.Controls.Add(this.txtDireccion);
            this.gbxDatos.Controls.Add(this.lblDireccion);
            this.gbxDatos.Controls.Add(this.lblFechaDeNacimiento);
            this.gbxDatos.Controls.Add(this.lblApellidos);
            this.gbxDatos.Controls.Add(this.txtApellidos);
            this.gbxDatos.Controls.Add(this.txtNombres);
            this.gbxDatos.Controls.Add(this.lblNombres);
            this.gbxDatos.Controls.Add(this.txtIdentificacion);
            this.gbxDatos.Controls.Add(this.lblIdentificacion);
            this.gbxDatos.Controls.Add(this.lblInformacion);
            this.gbxDatos.Location = new System.Drawing.Point(31, 49);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(543, 425);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // dtpFHNacimiento
            // 
            this.dtpFHNacimiento.Location = new System.Drawing.Point(244, 162);
            this.dtpFHNacimiento.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtpFHNacimiento.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFHNacimiento.Name = "dtpFHNacimiento";
            this.dtpFHNacimiento.Size = new System.Drawing.Size(262, 25);
            this.dtpFHNacimiento.TabIndex = 16;
            this.dtpFHNacimiento.Value = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            // 
            // btnMatricular
            // 
            this.btnMatricular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMatricular.Location = new System.Drawing.Point(163, 330);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(119, 31);
            this.btnMatricular.TabIndex = 15;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = false;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(244, 238);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(159, 25);
            this.txtCelular.TabIndex = 14;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(97, 241);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 17);
            this.lblCelular.TabIndex = 13;
            this.lblCelular.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(244, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(244, 200);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(159, 25);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(94, 203);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(69, 17);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(94, 168);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(135, 17);
            this.lblFechaDeNacimiento.TabIndex = 7;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(94, 126);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 17);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(244, 123);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(159, 25);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(244, 82);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(159, 25);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(94, 85);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(65, 17);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(244, 43);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(159, 25);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(94, 46);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(95, 17);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(6, 403);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(259, 17);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "*Favor Llenar todos los datos solicitados";
            // 
            // MatEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(598, 499);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatEstudiante";
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpFHNacimiento;
    }
}