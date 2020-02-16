namespace PorUnaVidaMejor
{
    partial class Cursos
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
            this.lblCursos = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.gbxNuevoCurso = new System.Windows.Forms.GroupBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDC = new System.Windows.Forms.Label();
            this.btnNuevoCurso = new System.Windows.Forms.Button();
            this.gbxActualizar = new System.Windows.Forms.GroupBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoInstructor = new System.Windows.Forms.TextBox();
            this.lblNuevoInstructor = new System.Windows.Forms.Label();
            this.btnNuevoNombre = new System.Windows.Forms.Button();
            this.btnNuevoInstructor = new System.Windows.Forms.Button();
            this.btnNuevoCosto = new System.Windows.Forms.Button();
            this.txtNuevoCosto = new System.Windows.Forms.TextBox();
            this.lblNuevoCosto = new System.Windows.Forms.Label();
            this.lblIDA = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.txtIdActualizarCost = new System.Windows.Forms.ComboBox();
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1 = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet1();
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet1TableAdapters.CursosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.gbxNuevoCurso.SuspendLayout();
            this.gbxActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(291, 9);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(111, 37);
            this.lblCursos.TabIndex = 0;
            this.lblCursos.Text = "Cursos";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(114, 322);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(457, 181);
            this.dgvCursos.TabIndex = 1;
            // 
            // gbxNuevoCurso
            // 
            this.gbxNuevoCurso.Controls.Add(this.txtCosto);
            this.gbxNuevoCurso.Controls.Add(this.txtInstructor);
            this.gbxNuevoCurso.Controls.Add(this.txtNombre);
            this.gbxNuevoCurso.Controls.Add(this.label4);
            this.gbxNuevoCurso.Controls.Add(this.lblNombre);
            this.gbxNuevoCurso.Controls.Add(this.label2);
            this.gbxNuevoCurso.Controls.Add(this.txtID);
            this.gbxNuevoCurso.Controls.Add(this.lblIDC);
            this.gbxNuevoCurso.Controls.Add(this.btnNuevoCurso);
            this.gbxNuevoCurso.Location = new System.Drawing.Point(32, 64);
            this.gbxNuevoCurso.Name = "gbxNuevoCurso";
            this.gbxNuevoCurso.Size = new System.Drawing.Size(265, 240);
            this.gbxNuevoCurso.TabIndex = 2;
            this.gbxNuevoCurso.TabStop = false;
            this.gbxNuevoCurso.Text = "Nuevo curso";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(114, 138);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(124, 26);
            this.txtCosto.TabIndex = 12;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(114, 106);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(124, 26);
            this.txtInstructor.TabIndex = 11;
            this.txtInstructor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstructor_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 26);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Instructor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 19);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Costo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(124, 26);
            this.txtID.TabIndex = 7;
            // 
            // lblIDC
            // 
            this.lblIDC.AutoSize = true;
            this.lblIDC.Location = new System.Drawing.Point(20, 45);
            this.lblIDC.Name = "lblIDC";
            this.lblIDC.Size = new System.Drawing.Size(25, 19);
            this.lblIDC.TabIndex = 6;
            this.lblIDC.Text = "ID";
            // 
            // btnNuevoCurso
            // 
            this.btnNuevoCurso.Location = new System.Drawing.Point(82, 192);
            this.btnNuevoCurso.Name = "btnNuevoCurso";
            this.btnNuevoCurso.Size = new System.Drawing.Size(98, 30);
            this.btnNuevoCurso.TabIndex = 5;
            this.btnNuevoCurso.Text = "Inscribir";
            this.btnNuevoCurso.UseVisualStyleBackColor = true;
            this.btnNuevoCurso.Click += new System.EventHandler(this.btnNuevoCurso_Click);
            // 
            // gbxActualizar
            // 
            this.gbxActualizar.Controls.Add(this.txtIdActualizarCost);
            this.gbxActualizar.Controls.Add(this.txtNuevoNombre);
            this.gbxActualizar.Controls.Add(this.lblNuevoNombre);
            this.gbxActualizar.Controls.Add(this.txtNuevoInstructor);
            this.gbxActualizar.Controls.Add(this.lblNuevoInstructor);
            this.gbxActualizar.Controls.Add(this.btnNuevoNombre);
            this.gbxActualizar.Controls.Add(this.btnNuevoInstructor);
            this.gbxActualizar.Controls.Add(this.btnNuevoCosto);
            this.gbxActualizar.Controls.Add(this.txtNuevoCosto);
            this.gbxActualizar.Controls.Add(this.lblNuevoCosto);
            this.gbxActualizar.Controls.Add(this.lblIDA);
            this.gbxActualizar.Controls.Add(this.btnActualizar);
            this.gbxActualizar.Location = new System.Drawing.Point(413, 64);
            this.gbxActualizar.Name = "gbxActualizar";
            this.gbxActualizar.Size = new System.Drawing.Size(288, 240);
            this.gbxActualizar.TabIndex = 3;
            this.gbxActualizar.TabStop = false;
            this.gbxActualizar.Text = "Actualizar Curso";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(124, 131);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(121, 26);
            this.txtNuevoNombre.TabIndex = 17;
            this.txtNuevoNombre.Visible = false;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(10, 134);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(115, 19);
            this.lblNuevoNombre.TabIndex = 16;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            this.lblNuevoNombre.Visible = false;
            // 
            // txtNuevoInstructor
            // 
            this.txtNuevoInstructor.Location = new System.Drawing.Point(140, 131);
            this.txtNuevoInstructor.Name = "txtNuevoInstructor";
            this.txtNuevoInstructor.Size = new System.Drawing.Size(121, 26);
            this.txtNuevoInstructor.TabIndex = 15;
            this.txtNuevoInstructor.Visible = false;
            // 
            // lblNuevoInstructor
            // 
            this.lblNuevoInstructor.AutoSize = true;
            this.lblNuevoInstructor.Location = new System.Drawing.Point(6, 134);
            this.lblNuevoInstructor.Name = "lblNuevoInstructor";
            this.lblNuevoInstructor.Size = new System.Drawing.Size(128, 19);
            this.lblNuevoInstructor.TabIndex = 14;
            this.lblNuevoInstructor.Text = "Nuevo Instructor";
            this.lblNuevoInstructor.Visible = false;
            // 
            // btnNuevoNombre
            // 
            this.btnNuevoNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoNombre.Location = new System.Drawing.Point(194, 34);
            this.btnNuevoNombre.Name = "btnNuevoNombre";
            this.btnNuevoNombre.Size = new System.Drawing.Size(77, 30);
            this.btnNuevoNombre.TabIndex = 13;
            this.btnNuevoNombre.Text = "Nombre";
            this.btnNuevoNombre.UseVisualStyleBackColor = true;
            this.btnNuevoNombre.Click += new System.EventHandler(this.btnNuevoNombre_Click);
            // 
            // btnNuevoInstructor
            // 
            this.btnNuevoInstructor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInstructor.Location = new System.Drawing.Point(95, 34);
            this.btnNuevoInstructor.Name = "btnNuevoInstructor";
            this.btnNuevoInstructor.Size = new System.Drawing.Size(93, 30);
            this.btnNuevoInstructor.TabIndex = 12;
            this.btnNuevoInstructor.Text = "Instructor";
            this.btnNuevoInstructor.UseVisualStyleBackColor = true;
            this.btnNuevoInstructor.Click += new System.EventHandler(this.btnNuevoInstructor_Click);
            // 
            // btnNuevoCosto
            // 
            this.btnNuevoCosto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCosto.Location = new System.Drawing.Point(14, 34);
            this.btnNuevoCosto.Name = "btnNuevoCosto";
            this.btnNuevoCosto.Size = new System.Drawing.Size(76, 30);
            this.btnNuevoCosto.TabIndex = 11;
            this.btnNuevoCosto.Text = "costo";
            this.btnNuevoCosto.UseVisualStyleBackColor = true;
            this.btnNuevoCosto.Click += new System.EventHandler(this.btnNuevoCosto_Click);
            // 
            // txtNuevoCosto
            // 
            this.txtNuevoCosto.Location = new System.Drawing.Point(124, 131);
            this.txtNuevoCosto.Name = "txtNuevoCosto";
            this.txtNuevoCosto.Size = new System.Drawing.Size(121, 26);
            this.txtNuevoCosto.TabIndex = 10;
            this.txtNuevoCosto.Visible = false;
            this.txtNuevoCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoCosto_KeyPress);
            // 
            // lblNuevoCosto
            // 
            this.lblNuevoCosto.AutoSize = true;
            this.lblNuevoCosto.Location = new System.Drawing.Point(23, 134);
            this.lblNuevoCosto.Name = "lblNuevoCosto";
            this.lblNuevoCosto.Size = new System.Drawing.Size(95, 19);
            this.lblNuevoCosto.TabIndex = 9;
            this.lblNuevoCosto.Text = "Nuevo costo";
            this.lblNuevoCosto.Visible = false;
            // 
            // lblIDA
            // 
            this.lblIDA.AutoSize = true;
            this.lblIDA.Location = new System.Drawing.Point(47, 84);
            this.lblIDA.Name = "lblIDA";
            this.lblIDA.Size = new System.Drawing.Size(50, 19);
            this.lblIDA.TabIndex = 7;
            this.lblIDA.Text = "Curso";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(84, 179);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 30);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(316, 148);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(75, 60);
            this.btnVerCursos.TabIndex = 4;
            this.btnVerCursos.Text = "Ver cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // txtIdActualizarCost
            // 
            this.txtIdActualizarCost.DataSource = this.cursosBindingSource;
            this.txtIdActualizarCost.DisplayMember = "NombreCurso";
            this.txtIdActualizarCost.FormattingEnabled = true;
            this.txtIdActualizarCost.Location = new System.Drawing.Point(124, 81);
            this.txtIdActualizarCost.Name = "txtIdActualizarCost";
            this.txtIdActualizarCost.Size = new System.Drawing.Size(137, 27);
            this.txtIdActualizarCost.TabIndex = 18;
            this.txtIdActualizarCost.ValueMember = "IdCurso";
            this.txtIdActualizarCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdActualizarCost_KeyPress);
            // 
            // base_De_Datos_Por_Una_Mejor_VidaDataSet1
            // 
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.DataSetName = "Base_De_Datos_Por_Una_Mejor_VidaDataSet1";
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDeDatosPorUnaMejorVidaDataSet1BindingSource
            // 
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet1;
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource.Position = 0;
            // 
            // baseDeDatosPorUnaMejorVidaDataSet1BindingSource1
            // 
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet1;
            this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1.Position = 0;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(728, 515);
            this.Controls.Add(this.btnVerCursos);
            this.Controls.Add(this.gbxActualizar);
            this.Controls.Add(this.gbxNuevoCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.lblCursos);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.gbxNuevoCurso.ResumeLayout(false);
            this.gbxNuevoCurso.PerformLayout();
            this.gbxActualizar.ResumeLayout(false);
            this.gbxActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDatosPorUnaMejorVidaDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.GroupBox gbxNuevoCurso;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDC;
        private System.Windows.Forms.Button btnNuevoCurso;
        private System.Windows.Forms.GroupBox gbxActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.TextBox txtNuevoCosto;
        private System.Windows.Forms.Label lblNuevoCosto;
        private System.Windows.Forms.Label lblIDA;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoInstructor;
        private System.Windows.Forms.Label lblNuevoInstructor;
        private System.Windows.Forms.Button btnNuevoNombre;
        private System.Windows.Forms.Button btnNuevoInstructor;
        private System.Windows.Forms.Button btnNuevoCosto;
        private System.Windows.Forms.ComboBox txtIdActualizarCost;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet1 base_De_Datos_Por_Una_Mejor_VidaDataSet1;
        private System.Windows.Forms.BindingSource baseDeDatosPorUnaMejorVidaDataSet1BindingSource;
        private System.Windows.Forms.BindingSource baseDeDatosPorUnaMejorVidaDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet1TableAdapters.CursosTableAdapter cursosTableAdapter;
    }
}