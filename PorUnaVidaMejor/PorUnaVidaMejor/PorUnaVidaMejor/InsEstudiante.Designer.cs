namespace PorUnaVidaMejor
{
    partial class InsEstudiante
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
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.gbxInscripcion = new System.Windows.Forms.GroupBox();
            this.txtIDC = new System.Windows.Forms.ComboBox();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1 = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet1();
            this.txtIDE = new System.Windows.Forms.ComboBox();
            this.estudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet();
            this.btnVerInscritos = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.lblIDC = new System.Windows.Forms.Label();
            this.lblIDE = new System.Windows.Forms.Label();
            this.dgvRelacion = new System.Windows.Forms.DataGridView();
            this.estudiantesTableAdapter = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSetTableAdapters.EstudiantesTableAdapter();
            this.cursosTableAdapter = new PorUnaVidaMejor.Base_De_Datos_Por_Una_Mejor_VidaDataSet1TableAdapters.CursosTableAdapter();
            this.gbxInscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(277, 34);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(153, 34);
            this.lblInscripcion.TabIndex = 1;
            this.lblInscripcion.Text = "Inscripción";
            // 
            // gbxInscripcion
            // 
            this.gbxInscripcion.Controls.Add(this.txtIDC);
            this.gbxInscripcion.Controls.Add(this.txtIDE);
            this.gbxInscripcion.Controls.Add(this.btnVerInscritos);
            this.gbxInscripcion.Controls.Add(this.btnInscribir);
            this.gbxInscripcion.Controls.Add(this.lblIDC);
            this.gbxInscripcion.Controls.Add(this.lblIDE);
            this.gbxInscripcion.Location = new System.Drawing.Point(374, 117);
            this.gbxInscripcion.Name = "gbxInscripcion";
            this.gbxInscripcion.Size = new System.Drawing.Size(341, 354);
            this.gbxInscripcion.TabIndex = 2;
            this.gbxInscripcion.TabStop = false;
            this.gbxInscripcion.Text = "Datos";
            // 
            // txtIDC
            // 
            this.txtIDC.DataSource = this.cursosBindingSource;
            this.txtIDC.DisplayMember = "NombreCurso";
            this.txtIDC.FormattingEnabled = true;
            this.txtIDC.Location = new System.Drawing.Point(74, 184);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(199, 27);
            this.txtIDC.TabIndex = 8;
            this.txtIDC.ValueMember = "IdCurso";
            this.txtIDC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDC_KeyPress);
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet1;
            // 
            // base_De_Datos_Por_Una_Mejor_VidaDataSet1
            // 
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.DataSetName = "Base_De_Datos_Por_Una_Mejor_VidaDataSet1";
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIDE
            // 
            this.txtIDE.DataSource = this.estudiantesBindingSource;
            this.txtIDE.DisplayMember = "Identificacion";
            this.txtIDE.FormattingEnabled = true;
            this.txtIDE.Location = new System.Drawing.Point(74, 80);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(199, 27);
            this.txtIDE.TabIndex = 7;
            this.txtIDE.ValueMember = "Identificacion";
            this.txtIDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDE_KeyPress);
            // 
            // estudiantesBindingSource
            // 
            this.estudiantesBindingSource.DataMember = "Estudiantes";
            this.estudiantesBindingSource.DataSource = this.base_De_Datos_Por_Una_Mejor_VidaDataSet;
            // 
            // base_De_Datos_Por_Una_Mejor_VidaDataSet
            // 
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet.DataSetName = "Base_De_Datos_Por_Una_Mejor_VidaDataSet";
            this.base_De_Datos_Por_Una_Mejor_VidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVerInscritos
            // 
            this.btnVerInscritos.Location = new System.Drawing.Point(119, 301);
            this.btnVerInscritos.Name = "btnVerInscritos";
            this.btnVerInscritos.Size = new System.Drawing.Size(115, 47);
            this.btnVerInscritos.TabIndex = 6;
            this.btnVerInscritos.Text = "Ver Inscripciones";
            this.btnVerInscritos.UseVisualStyleBackColor = true;
            this.btnVerInscritos.Click += new System.EventHandler(this.btnVerInscritos_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(119, 232);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(95, 29);
            this.btnInscribir.TabIndex = 5;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // lblIDC
            // 
            this.lblIDC.AutoSize = true;
            this.lblIDC.Location = new System.Drawing.Point(87, 146);
            this.lblIDC.Name = "lblIDC";
            this.lblIDC.Size = new System.Drawing.Size(170, 19);
            this.lblIDC.TabIndex = 3;
            this.lblIDC.Text = "Identificación del curso";
            // 
            // lblIDE
            // 
            this.lblIDE.AutoSize = true;
            this.lblIDE.Location = new System.Drawing.Point(70, 47);
            this.lblIDE.Name = "lblIDE";
            this.lblIDE.Size = new System.Drawing.Size(203, 19);
            this.lblIDE.TabIndex = 0;
            this.lblIDE.Text = "Identificación del estudiante";
            // 
            // dgvRelacion
            // 
            this.dgvRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelacion.Location = new System.Drawing.Point(12, 117);
            this.dgvRelacion.Name = "dgvRelacion";
            this.dgvRelacion.Size = new System.Drawing.Size(334, 354);
            this.dgvRelacion.TabIndex = 3;
            this.dgvRelacion.Visible = false;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // InsEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(740, 482);
            this.Controls.Add(this.dgvRelacion);
            this.Controls.Add(this.gbxInscripcion);
            this.Controls.Add(this.lblInscripcion);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsEstudiante";
            this.Load += new System.EventHandler(this.InsEstudiante_Load);
            this.gbxInscripcion.ResumeLayout(false);
            this.gbxInscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_De_Datos_Por_Una_Mejor_VidaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.GroupBox gbxInscripcion;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label lblIDC;
        private System.Windows.Forms.Label lblIDE;
        private System.Windows.Forms.DataGridView dgvRelacion;
        private System.Windows.Forms.Button btnVerInscritos;
        private System.Windows.Forms.ComboBox txtIDE;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet base_De_Datos_Por_Una_Mejor_VidaDataSet;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSetTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private System.Windows.Forms.ComboBox txtIDC;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet1 base_De_Datos_Por_Una_Mejor_VidaDataSet1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Base_De_Datos_Por_Una_Mejor_VidaDataSet1TableAdapters.CursosTableAdapter cursosTableAdapter;
    }
}