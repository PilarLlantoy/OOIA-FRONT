
namespace ooiasoft
{
    partial class frmTutorAlumnosAsignados
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInspeccionarAlumnos = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.lblNoHayDatos = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.Codigo,
            this.Especialidad,
            this.Estado});
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 102);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.RowTemplate.Height = 28;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(787, 175);
            this.dgvAlumnos.TabIndex = 4;
            this.dgvAlumnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlumnos_CellFormatting);
            // 
            // Alumno
            // 
            this.Alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 300;
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 300;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 8;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnInspeccionarAlumnos
            // 
            this.btnInspeccionarAlumnos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInspeccionarAlumnos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInspeccionarAlumnos.Location = new System.Drawing.Point(620, 0);
            this.btnInspeccionarAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInspeccionarAlumnos.Name = "btnInspeccionarAlumnos";
            this.btnInspeccionarAlumnos.Size = new System.Drawing.Size(167, 28);
            this.btnInspeccionarAlumnos.TabIndex = 5;
            this.btnInspeccionarAlumnos.Text = "Inspeccionar Alumno";
            this.btnInspeccionarAlumnos.UseVisualStyleBackColor = false;
            this.btnInspeccionarAlumnos.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.LightBlue;
            this.panelCenter.Controls.Add(this.dgvAlumnos);
            this.panelCenter.Controls.Add(this.lblNoHayDatos);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 28);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(787, 277);
            this.panelCenter.TabIndex = 15;
            // 
            // lblNoHayDatos
            // 
            this.lblNoHayDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoHayDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHayDatos.Location = new System.Drawing.Point(0, 0);
            this.lblNoHayDatos.Name = "lblNoHayDatos";
            this.lblNoHayDatos.Size = new System.Drawing.Size(787, 102);
            this.lblNoHayDatos.TabIndex = 5;
            this.lblNoHayDatos.Text = "No presenta alumnos asignados para el presente ciclo.\r\nPuede asignar un grupo de " +
    "alumnos automáticamente con el botón de Asignar Alumnos.";
            this.lblNoHayDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoHayDatos.Visible = false;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 305);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(787, 25);
            this.panelBot.TabIndex = 14;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Controls.Add(this.btnAsignar);
            this.panelTop.Controls.Add(this.btnInspeccionarAlumnos);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(787, 28);
            this.panelTop.TabIndex = 11;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAsignar.Location = new System.Drawing.Point(0, 0);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(113, 28);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar Alumnos";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmTutorAlumnosAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(787, 330);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTutorAlumnosAsignados";
            this.Text = "frmCitasTutorCachimbos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInspeccionarAlumnos;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblNoHayDatos;
    }
}