
namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.txtApellidoL = new System.Windows.Forms.TextBox();
            this.txtCursoL = new System.Windows.Forms.TextBox();
            this.txtParaleloL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlmacenar = new System.Windows.Forms.Button();
            this.btnMostrarL = new System.Windows.Forms.Button();
            this.btnAprovadosL = new System.Windows.Forms.Button();
            this.btnSuspensoL = new System.Windows.Forms.Button();
            this.msktPromedio = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Curso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Paralelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Promedio";
            // 
            // txtNombreL
            // 
            this.txtNombreL.Location = new System.Drawing.Point(372, 97);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(182, 22);
            this.txtNombreL.TabIndex = 6;
            // 
            // txtApellidoL
            // 
            this.txtApellidoL.Location = new System.Drawing.Point(372, 137);
            this.txtApellidoL.Name = "txtApellidoL";
            this.txtApellidoL.Size = new System.Drawing.Size(182, 22);
            this.txtApellidoL.TabIndex = 7;
            // 
            // txtCursoL
            // 
            this.txtCursoL.Location = new System.Drawing.Point(372, 176);
            this.txtCursoL.Name = "txtCursoL";
            this.txtCursoL.Size = new System.Drawing.Size(182, 22);
            this.txtCursoL.TabIndex = 8;
            // 
            // txtParaleloL
            // 
            this.txtParaleloL.Location = new System.Drawing.Point(372, 216);
            this.txtParaleloL.Name = "txtParaleloL";
            this.txtParaleloL.Size = new System.Drawing.Size(182, 22);
            this.txtParaleloL.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 41);
            this.label12.TabIndex = 10;
            this.label12.Text = "Listado Estudiantes";
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.Location = new System.Drawing.Point(149, 315);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(75, 30);
            this.btnAlmacenar.TabIndex = 11;
            this.btnAlmacenar.Text = "Guardar";
            this.btnAlmacenar.UseVisualStyleBackColor = true;
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // btnMostrarL
            // 
            this.btnMostrarL.Location = new System.Drawing.Point(287, 315);
            this.btnMostrarL.Name = "btnMostrarL";
            this.btnMostrarL.Size = new System.Drawing.Size(75, 30);
            this.btnMostrarL.TabIndex = 12;
            this.btnMostrarL.Text = "Mostrar";
            this.btnMostrarL.UseVisualStyleBackColor = true;
            this.btnMostrarL.Click += new System.EventHandler(this.btnMostrarL_Click);
            // 
            // btnAprovadosL
            // 
            this.btnAprovadosL.Location = new System.Drawing.Point(410, 315);
            this.btnAprovadosL.Name = "btnAprovadosL";
            this.btnAprovadosL.Size = new System.Drawing.Size(96, 30);
            this.btnAprovadosL.TabIndex = 13;
            this.btnAprovadosL.Text = "Aprobados";
            this.btnAprovadosL.UseVisualStyleBackColor = true;
            this.btnAprovadosL.Click += new System.EventHandler(this.btnAprovadosL_Click);
            // 
            // btnSuspensoL
            // 
            this.btnSuspensoL.Location = new System.Drawing.Point(556, 315);
            this.btnSuspensoL.Name = "btnSuspensoL";
            this.btnSuspensoL.Size = new System.Drawing.Size(94, 30);
            this.btnSuspensoL.TabIndex = 14;
            this.btnSuspensoL.Text = "Suspensos";
            this.btnSuspensoL.UseVisualStyleBackColor = true;
            this.btnSuspensoL.Click += new System.EventHandler(this.btnSuspensoL_Click);
            // 
            // msktPromedio
            // 
            this.msktPromedio.Location = new System.Drawing.Point(372, 255);
            this.msktPromedio.Mask = "99";
            this.msktPromedio.Name = "msktPromedio";
            this.msktPromedio.Size = new System.Drawing.Size(63, 22);
            this.msktPromedio.TabIndex = 15;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(798, 411);
            this.Controls.Add(this.msktPromedio);
            this.Controls.Add(this.btnSuspensoL);
            this.Controls.Add(this.btnAprovadosL);
            this.Controls.Add(this.btnMostrarL);
            this.Controls.Add(this.btnAlmacenar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtParaleloL);
            this.Controls.Add(this.txtCursoL);
            this.Controls.Add(this.txtApellidoL);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtParalelo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAprobados;
        private System.Windows.Forms.Button btnSuspensos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mktPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.TextBox txtApellidoL;
        private System.Windows.Forms.TextBox txtCursoL;
        private System.Windows.Forms.TextBox txtParaleloL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlmacenar;
        private System.Windows.Forms.Button btnMostrarL;
        private System.Windows.Forms.Button btnAprovadosL;
        private System.Windows.Forms.Button btnSuspensoL;
        private System.Windows.Forms.MaskedTextBox msktPromedio;
    }
}

