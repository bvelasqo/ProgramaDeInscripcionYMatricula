namespace PorUnaVidaMejor
{
    partial class Estudiantes
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
            this.components = new System.ComponentModel.Container();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.btnIDBuscar = new System.Windows.Forms.Button();
            this.btnEmailBuscar = new System.Windows.Forms.Button();
            this.txtEmailBuscar = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.txtDireccionActualizar = new System.Windows.Forms.TextBox();
            this.lblDireccionActualizar = new System.Windows.Forms.Label();
            this.txtCelularActualizar = new System.Windows.Forms.TextBox();
            this.lblCelularActualizar = new System.Windows.Forms.Label();
            this.txtEmailActualizar = new System.Windows.Forms.TextBox();
            this.lblEmailActualizar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDireccionActualizar = new System.Windows.Forms.Button();
            this.btnCelularActualizar = new System.Windows.Forms.Button();
            this.btnEmailActualizar = new System.Windows.Forms.Button();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbxEliminar = new System.Windows.Forms.GroupBox();
            this.lblIdEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtIdActualizar = new System.Windows.Forms.ComboBox();
            this.txtIdEliminar = new System.Windows.Forms.ComboBox();
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet();
            this.estudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSetTableAdapters.EstudiantesTableAdapter();
            this.txtIdBuscar = new System.Windows.Forms.ComboBox();
            this.baseDeDatosPorUnaMejorVidaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gbxBuscar.SuspendLayout();
            this.gbx.SuspendLayout();
            this.gbxEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(359, 9);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(217, 37);
            this.lblEstudiantes.TabIndex = 0;
            this.lblEstudiantes.Text = "ESTUDIANTES";
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.txtIdBuscar);
            this.gbxBuscar.Controls.Add(this.btnIDBuscar);
            this.gbxBuscar.Controls.Add(this.btnEmailBuscar);
            this.gbxBuscar.Controls.Add(this.txtEmailBuscar);
            this.gbxBuscar.Controls.Add(this.lblEmail);
            this.gbxBuscar.Controls.Add(this.lblID);
            this.gbxBuscar.Controls.Add(this.btnBuscar);
            this.gbxBuscar.Controls.Add(this.lblBuscarPor);
            this.gbxBuscar.Location = new System.Drawing.Point(22, 49);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(272, 215);
            this.gbxBuscar.TabIndex = 1;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar Estudiante";
            // 
            // btnIDBuscar
            // 
            this.btnIDBuscar.Location = new System.Drawing.Point(154, 65);
            this.btnIDBuscar.Name = "btnIDBuscar";
            this.btnIDBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnIDBuscar.TabIndex = 8;
            this.btnIDBuscar.Text = "ID";
            this.btnIDBuscar.UseVisualStyleBackColor = true;
            this.btnIDBuscar.Click += new System.EventHandler(this.btnIDBuscar_Click);
            // 
            // btnEmailBuscar
            // 
            this.btnEmailBuscar.Location = new System.Drawing.Point(34, 65);
            this.btnEmailBuscar.Name = "btnEmailBuscar";
            this.btnEmailBuscar.Size = new System.Drawing.Size(75, 33);
            this.btnEmailBuscar.TabIndex = 7;
            this.btnEmailBuscar.Text = "Email";
            this.btnEmailBuscar.UseVisualStyleBackColor = true;
            this.btnEmailBuscar.Click += new System.EventHandler(this.btnEmailBuscar_Click);
            // 
            // txtEmailBuscar
            // 
            this.txtEmailBuscar.Location = new System.Drawing.Point(114, 117);
            this.txtEmailBuscar.Name = "txtEmailBuscar";
            this.txtEmailBuscar.Size = new System.Drawing.Size(152, 26);
            this.txtEmailBuscar.TabIndex = 6;
            this.txtEmailBuscar.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 120);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(88, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(87, 32);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(90, 19);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.txtIdActualizar);
            this.gbx.Controls.Add(this.txtDireccionActualizar);
            this.gbx.Controls.Add(this.lblDireccionActualizar);
            this.gbx.Controls.Add(this.txtCelularActualizar);
            this.gbx.Controls.Add(this.lblCelularActualizar);
            this.gbx.Controls.Add(this.txtEmailActualizar);
            this.gbx.Controls.Add(this.lblEmailActualizar);
            this.gbx.Controls.Add(this.label2);
            this.gbx.Controls.Add(this.btnDireccionActualizar);
            this.gbx.Controls.Add(this.btnCelularActualizar);
            this.gbx.Controls.Add(this.btnEmailActualizar);
            this.gbx.Controls.Add(this.lblActualizar);
            this.gbx.Controls.Add(this.btnActualizar);
            this.gbx.Location = new System.Drawing.Point(320, 49);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(274, 215);
            this.gbx.TabIndex = 2;
            this.gbx.TabStop = false;
            this.gbx.Text = "Actualizar Estudiante";
            // 
            // txtDireccionActualizar
            // 
            this.txtDireccionActualizar.Location = new System.Drawing.Point(104, 142);
            this.txtDireccionActualizar.Name = "txtDireccionActualizar";
            this.txtDireccionActualizar.Size = new System.Drawing.Size(152, 26);
            this.txtDireccionActualizar.TabIndex = 17;
            this.txtDireccionActualizar.Visible = false;
            // 
            // lblDireccionActualizar
            // 
            this.lblDireccionActualizar.AutoSize = true;
            this.lblDireccionActualizar.Location = new System.Drawing.Point(16, 145);
            this.lblDireccionActualizar.Name = "lblDireccionActualizar";
            this.lblDireccionActualizar.Size = new System.Drawing.Size(75, 19);
            this.lblDireccionActualizar.TabIndex = 16;
            this.lblDireccionActualizar.Text = "Direccion";
            this.lblDireccionActualizar.Visible = false;
            // 
            // txtCelularActualizar
            // 
            this.txtCelularActualizar.Location = new System.Drawing.Point(104, 142);
            this.txtCelularActualizar.Name = "txtCelularActualizar";
            this.txtCelularActualizar.Size = new System.Drawing.Size(152, 26);
            this.txtCelularActualizar.TabIndex = 15;
            this.txtCelularActualizar.Visible = false;
            // 
            // lblCelularActualizar
            // 
            this.lblCelularActualizar.AutoSize = true;
            this.lblCelularActualizar.Location = new System.Drawing.Point(33, 145);
            this.lblCelularActualizar.Name = "lblCelularActualizar";
            this.lblCelularActualizar.Size = new System.Drawing.Size(58, 19);
            this.lblCelularActualizar.TabIndex = 14;
            this.lblCelularActualizar.Text = "Celular";
            this.lblCelularActualizar.Visible = false;
            // 
            // txtEmailActualizar
            // 
            this.txtEmailActualizar.Location = new System.Drawing.Point(104, 142);
            this.txtEmailActualizar.Name = "txtEmailActualizar";
            this.txtEmailActualizar.Size = new System.Drawing.Size(152, 26);
            this.txtEmailActualizar.TabIndex = 13;
            this.txtEmailActualizar.Visible = false;
            // 
            // lblEmailActualizar
            // 
            this.lblEmailActualizar.AutoSize = true;
            this.lblEmailActualizar.Location = new System.Drawing.Point(33, 145);
            this.lblEmailActualizar.Name = "lblEmailActualizar";
            this.lblEmailActualizar.Size = new System.Drawing.Size(47, 19);
            this.lblEmailActualizar.TabIndex = 12;
            this.lblEmailActualizar.Text = "Email";
            this.lblEmailActualizar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // btnDireccionActualizar
            // 
            this.btnDireccionActualizar.Location = new System.Drawing.Point(177, 65);
            this.btnDireccionActualizar.Name = "btnDireccionActualizar";
            this.btnDireccionActualizar.Size = new System.Drawing.Size(91, 33);
            this.btnDireccionActualizar.TabIndex = 11;
            this.btnDireccionActualizar.Text = "Direccion";
            this.btnDireccionActualizar.UseVisualStyleBackColor = true;
            this.btnDireccionActualizar.Click += new System.EventHandler(this.btnDireccionActualizar_Click);
            // 
            // btnCelularActualizar
            // 
            this.btnCelularActualizar.Location = new System.Drawing.Point(87, 65);
            this.btnCelularActualizar.Name = "btnCelularActualizar";
            this.btnCelularActualizar.Size = new System.Drawing.Size(84, 33);
            this.btnCelularActualizar.TabIndex = 10;
            this.btnCelularActualizar.Text = "Celular";
            this.btnCelularActualizar.UseVisualStyleBackColor = true;
            this.btnCelularActualizar.Click += new System.EventHandler(this.btnCelularActualizar_Click);
            // 
            // btnEmailActualizar
            // 
            this.btnEmailActualizar.Location = new System.Drawing.Point(6, 65);
            this.btnEmailActualizar.Name = "btnEmailActualizar";
            this.btnEmailActualizar.Size = new System.Drawing.Size(75, 33);
            this.btnEmailActualizar.TabIndex = 9;
            this.btnEmailActualizar.Text = "Email";
            this.btnEmailActualizar.UseVisualStyleBackColor = true;
            this.btnEmailActualizar.Click += new System.EventHandler(this.btnEmailActualizar_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Location = new System.Drawing.Point(89, 32);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(82, 19);
            this.lblActualizar.TabIndex = 7;
            this.lblActualizar.Text = "Actualizar:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 179);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 30);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbxEliminar
            // 
            this.gbxEliminar.Controls.Add(this.txtIdEliminar);
            this.gbxEliminar.Controls.Add(this.lblIdEliminar);
            this.gbxEliminar.Controls.Add(this.btnEliminar);
            this.gbxEliminar.Location = new System.Drawing.Point(617, 49);
            this.gbxEliminar.Name = "gbxEliminar";
            this.gbxEliminar.Size = new System.Drawing.Size(266, 215);
            this.gbxEliminar.TabIndex = 2;
            this.gbxEliminar.TabStop = false;
            this.gbxEliminar.Text = "Eliminar Estudiante";
            // 
            // lblIdEliminar
            // 
            this.lblIdEliminar.AutoSize = true;
            this.lblIdEliminar.Location = new System.Drawing.Point(22, 65);
            this.lblIdEliminar.Name = "lblIdEliminar";
            this.lblIdEliminar.Size = new System.Drawing.Size(25, 19);
            this.lblIdEliminar.TabIndex = 9;
            this.lblIdEliminar.Text = "ID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(86, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(22, 293);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(861, 164);
            this.dgvEstudiantes.TabIndex = 3;
            // 
            // txtIdActualizar
            // 
            this.txtIdActualizar.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet;
            this.txtIdActualizar.DisplayMember = "Estudiantes.Identificacion";
            this.txtIdActualizar.FormattingEnabled = true;
            this.txtIdActualizar.Location = new System.Drawing.Point(104, 104);
            this.txtIdActualizar.Name = "txtIdActualizar";
            this.txtIdActualizar.Size = new System.Drawing.Size(152, 27);
            this.txtIdActualizar.TabIndex = 18;
            this.txtIdActualizar.ValueMember = "Estudiantes.Identificacion";
            this.txtIdActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdActualizar_KeyPress);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.DataSource = this.estudiantesBindingSource1;
            this.txtIdEliminar.DisplayMember = "Identificacion";
            this.txtIdEliminar.FormattingEnabled = true;
            this.txtIdEliminar.Location = new System.Drawing.Point(101, 62);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(140, 27);
            this.txtIdEliminar.TabIndex = 10;
            this.txtIdEliminar.ValueMember = "Identificacion";
            this.txtIdEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEliminar_KeyPress);
            // 
            // base_De_Datos_Por_Una_Mejor_VidaDataSet
            // 
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet.DataSetName = "Base_De_Datos_Por_Una_Mejor_VidaDataSet";
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantesBindingSource
            // 
            this.estudiantesBindingSource.DataMember = "Estudiantes";
            this.estudiantesBindingSource.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.DataSource = this.estudiantesBindingSource;
            this.txtIdBuscar.DisplayMember = "Identificacion";
            this.txtIdBuscar.FormattingEnabled = true;
            this.txtIdBuscar.Location = new System.Drawing.Point(114, 117);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(152, 27);
            this.txtIdBuscar.TabIndex = 9;
            this.txtIdBuscar.ValueMember = "Identificacion";
            this.txtIdBuscar.Visible = false;
            this.txtIdBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBuscar_KeyPress);
            // 
            // baseDeDatosPorUnaMejorVidaDataSetBindingSource
            // 
            this.baseDeDatosPorUnaMejorVidaDataSetBindingSource.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet;
            this.baseDeDatosPorUnaMejorVidaDataSetBindingSource.Position = 0;
            // 
            // estudiantesBindingSource1
            // 
            this.estudiantesBindingSource1.DataMember = "Estudiantes";
            this.estudiantesBindingSource1.DataSource = this.baseDeDatosPorUnaMejorVidaDataSetBindingSource;
            // 
            // estudiantesBindingSource2
            // 
            this.estudiantesBindingSource2.DataMember = "Estudiantes";
            this.estudiantesBindingSource2.DataSource = this.baseDeDatosPorUnaMejorVidaDataSetBindingSource;
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(909, 469);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.gbxEliminar);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.lblEstudiantes);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.gbxEliminar.ResumeLayout(false);
            this.gbxEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.Button btnIDBuscar;
        private System.Windows.Forms.Button btnEmailBuscar;
        private System.Windows.Forms.TextBox txtEmailBuscar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDireccionActualizar;
        private System.Windows.Forms.Button btnCelularActualizar;
        private System.Windows.Forms.Button btnEmailActualizar;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbxEliminar;
        private System.Windows.Forms.Label lblIdEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox txtDireccionActualizar;
        private System.Windows.Forms.Label lblDireccionActualizar;
        private System.Windows.Forms.TextBox txtCelularActualizar;
        private System.Windows.Forms.Label lblCelularActualizar;
        private System.Windows.Forms.TextBox txtEmailActualizar;
        private System.Windows.Forms.Label lblEmailActualizar;
        private System.Windows.Forms.ComboBox txtIdActualizar;
        private System.Windows.Forms.ComboBox txtIdEliminar;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet base_De_Datos_Por_Una_Mejor_VidaDataSet;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSetTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private System.Windows.Forms.ComboBox txtIdBuscar;
        private System.Windows.Forms.BindingSource estudiantesBindingSource1;
        private System.Windows.Forms.BindingSource baseDeDatosPorUnaMejorVidaDataSetBindingSource;
        private System.Windows.Forms.BindingSource estudiantesBindingSource2;
    }
}