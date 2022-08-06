
namespace ProyectoFinal
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvSuspensos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspensos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado Estudiantes Suspensos";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(328, 125);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 27);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dgvSuspensos
            // 
            this.dgvSuspensos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSuspensos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuspensos.Location = new System.Drawing.Point(50, 177);
            this.dgvSuspensos.Name = "dgvSuspensos";
            this.dgvSuspensos.RowHeadersWidth = 51;
            this.dgvSuspensos.RowTemplate.Height = 24;
            this.dgvSuspensos.Size = new System.Drawing.Size(690, 229);
            this.dgvSuspensos.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSuspensos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuspensos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dgvSuspensos;
    }
}