
namespace ooiasoft
{
    partial class frmVerInscritosEvento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelAsistentes = new System.Windows.Forms.Panel();
            this.lblInscritosEvento = new System.Windows.Forms.Label();
            this.lblInscritos = new System.Windows.Forms.Label();
            this.panelCapacidad = new System.Windows.Forms.Panel();
            this.lblCapEvento = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.panelFechaRealizacion = new System.Windows.Forms.Panel();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvEventosAdmin = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelAsistentes.SuspendLayout();
            this.panelCapacidad.SuspendLayout();
            this.panelFechaRealizacion.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panelTitulo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 121);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panelAsistentes);
            this.panel7.Controls.Add(this.panelCapacidad);
            this.panel7.Controls.Add(this.panelFechaRealizacion);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(40, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(904, 38);
            this.panel7.TabIndex = 5;
            // 
            // panelAsistentes
            // 
            this.panelAsistentes.Controls.Add(this.lblInscritosEvento);
            this.panelAsistentes.Controls.Add(this.lblInscritos);
            this.panelAsistentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAsistentes.Location = new System.Drawing.Point(609, 0);
            this.panelAsistentes.Name = "panelAsistentes";
            this.panelAsistentes.Size = new System.Drawing.Size(293, 36);
            this.panelAsistentes.TabIndex = 8;
            // 
            // lblInscritosEvento
            // 
            this.lblInscritosEvento.AutoSize = true;
            this.lblInscritosEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscritosEvento.Location = new System.Drawing.Point(151, 11);
            this.lblInscritosEvento.Name = "lblInscritosEvento";
            this.lblInscritosEvento.Size = new System.Drawing.Size(22, 16);
            this.lblInscritosEvento.TabIndex = 0;
            this.lblInscritosEvento.Text = "48";
            this.lblInscritosEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInscritos
            // 
            this.lblInscritos.AutoSize = true;
            this.lblInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscritos.Location = new System.Drawing.Point(85, 11);
            this.lblInscritos.Name = "lblInscritos";
            this.lblInscritos.Size = new System.Drawing.Size(60, 16);
            this.lblInscritos.TabIndex = 2;
            this.lblInscritos.Text = "Inscritos:";
            // 
            // panelCapacidad
            // 
            this.panelCapacidad.Controls.Add(this.lblCapEvento);
            this.panelCapacidad.Controls.Add(this.lblCapacidad);
            this.panelCapacidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCapacidad.Location = new System.Drawing.Point(325, 0);
            this.panelCapacidad.Name = "panelCapacidad";
            this.panelCapacidad.Size = new System.Drawing.Size(284, 36);
            this.panelCapacidad.TabIndex = 7;
            // 
            // lblCapEvento
            // 
            this.lblCapEvento.AutoSize = true;
            this.lblCapEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapEvento.Location = new System.Drawing.Point(172, 11);
            this.lblCapEvento.Name = "lblCapEvento";
            this.lblCapEvento.Size = new System.Drawing.Size(22, 16);
            this.lblCapEvento.TabIndex = 0;
            this.lblCapEvento.Text = "60";
            this.lblCapEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(88, 10);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(78, 16);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // panelFechaRealizacion
            // 
            this.panelFechaRealizacion.Controls.Add(this.lblFechaEvento);
            this.panelFechaRealizacion.Controls.Add(this.lblFecha);
            this.panelFechaRealizacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFechaRealizacion.Location = new System.Drawing.Point(0, 0);
            this.panelFechaRealizacion.Name = "panelFechaRealizacion";
            this.panelFechaRealizacion.Size = new System.Drawing.Size(325, 36);
            this.panelFechaRealizacion.TabIndex = 6;
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEvento.Location = new System.Drawing.Point(193, 12);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(72, 16);
            this.lblFechaEvento.TabIndex = 0;
            this.lblFechaEvento.Text = "17/05/2020";
            this.lblFechaEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(45, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(142, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de Realización:";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.SlateGray;
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(40, 32);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(904, 35);
            this.panelTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(902, 33);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Taller de Control de Ansiedad 2021-1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(944, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 73);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 73);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 16);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 32);
            this.panel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightBlue;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 441);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(984, 20);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightBlue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 121);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(40, 320);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(944, 121);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(40, 320);
            this.panel10.TabIndex = 3;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dgvEventosAdmin);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(40, 121);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(904, 320);
            this.panelTabla.TabIndex = 4;
            // 
            // dgvEventosAdmin
            // 
            this.dgvEventosAdmin.AllowUserToAddRows = false;
            this.dgvEventosAdmin.AllowUserToDeleteRows = false;
            this.dgvEventosAdmin.AllowUserToResizeColumns = false;
            this.dgvEventosAdmin.AllowUserToResizeRows = false;
            this.dgvEventosAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventosAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventosAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.Especialidad,
            this.ColCorreo,
            this.Telefono});
            this.dgvEventosAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventosAdmin.Location = new System.Drawing.Point(0, 0);
            this.dgvEventosAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventosAdmin.MultiSelect = false;
            this.dgvEventosAdmin.Name = "dgvEventosAdmin";
            this.dgvEventosAdmin.ReadOnly = true;
            this.dgvEventosAdmin.RowHeadersWidth = 62;
            this.dgvEventosAdmin.RowTemplate.Height = 28;
            this.dgvEventosAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventosAdmin.Size = new System.Drawing.Size(904, 320);
            this.dgvEventosAdmin.TabIndex = 3;
            this.dgvEventosAdmin.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEventosAdmin_CellFormatting);
            // 
            // ColCodigo
            // 
            this.ColCodigo.FillWeight = 40F;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 40;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombre.FillWeight = 230F;
            this.ColNombre.HeaderText = "Nombre Completo";
            this.ColNombre.MinimumWidth = 230;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 230;
            // 
            // Especialidad
            // 
            this.Especialidad.FillWeight = 80F;
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.HeaderText = "Correo";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.FillWeight = 80F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVerInscritosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerInscritosEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Inscritos";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelAsistentes.ResumeLayout(false);
            this.panelAsistentes.PerformLayout();
            this.panelCapacidad.ResumeLayout(false);
            this.panelCapacidad.PerformLayout();
            this.panelFechaRealizacion.ResumeLayout(false);
            this.panelFechaRealizacion.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvEventosAdmin;
        private System.Windows.Forms.Label lblInscritos;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelAsistentes;
        private System.Windows.Forms.Panel panelCapacidad;
        private System.Windows.Forms.Panel panelFechaRealizacion;
        private System.Windows.Forms.Label lblInscritosEvento;
        private System.Windows.Forms.Label lblCapEvento;
        private System.Windows.Forms.Label lblFechaEvento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnVolver;
    }
}