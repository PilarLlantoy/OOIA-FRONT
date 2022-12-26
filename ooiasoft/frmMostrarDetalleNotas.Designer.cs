
namespace ooiasoft
{
    partial class frmMostrarDetalleNotas
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
            this.rtbReporte = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbCiclos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbReporte
            // 
            this.rtbReporte.BackColor = System.Drawing.Color.White;
            this.rtbReporte.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReporte.Location = new System.Drawing.Point(58, 78);
            this.rtbReporte.Name = "rtbReporte";
            this.rtbReporte.ReadOnly = true;
            this.rtbReporte.Size = new System.Drawing.Size(808, 411);
            this.rtbReporte.TabIndex = 24;
            this.rtbReporte.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(361, 515);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(165, 26);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbCiclos
            // 
            this.cbCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiclos.FormattingEnabled = true;
            this.cbCiclos.Location = new System.Drawing.Point(102, 38);
            this.cbCiclos.Name = "cbCiclos";
            this.cbCiclos.Size = new System.Drawing.Size(156, 24);
            this.cbCiclos.TabIndex = 26;
            this.cbCiclos.SelectedIndexChanged += new System.EventHandler(this.cbCiclos_SelectedIndexChanged);
            this.cbCiclos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCiclos_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ciclo:";
            // 
            // frmMostrarDetalleNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(918, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCiclos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.rtbReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMostrarDetalleNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Notas del Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbCiclos;
        private System.Windows.Forms.Label label1;
    }
}