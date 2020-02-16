namespace PorUnaVidaMejor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.inscripcionesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1241, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.matriculaToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.matriculaToolStripMenuItem.Text = "Matriculas";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PorUnaVidaMejor.Properties.Resources.fondo_textura_papel_azul_amarillo_blanco_7190_2100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 656);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
    }
}

