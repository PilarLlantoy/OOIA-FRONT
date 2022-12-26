
namespace ooiasoft
{
    partial class frmCitasProgramadasAlumno
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
            this.panelFill1 = new System.Windows.Forms.Panel();
            this.panelOpcionesBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbPasado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelFill5 = new System.Windows.Forms.Panel();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.panelFill3 = new System.Windows.Forms.Panel();
            this.txtNombreAsesor = new System.Windows.Forms.TextBox();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelFill2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOpcionesBusqueda.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFill1
            // 
            this.panelFill1.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill1.Location = new System.Drawing.Point(0, 0);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Size = new System.Drawing.Size(1280, 10);
            this.panelFill1.TabIndex = 1;
            // 
            // panelOpcionesBusqueda
            // 
            this.panelOpcionesBusqueda.BackColor = System.Drawing.Color.LightBlue;
            this.panelOpcionesBusqueda.Controls.Add(this.btnBuscar);
            this.panelOpcionesBusqueda.Controls.Add(this.panel2);
            this.panelOpcionesBusqueda.Controls.Add(this.rbPasado);
            this.panelOpcionesBusqueda.Controls.Add(this.rbPendiente);
            this.panelOpcionesBusqueda.Controls.Add(this.rbTodos);
            this.panelOpcionesBusqueda.Controls.Add(this.lblEstado);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill5);
            this.panelOpcionesBusqueda.Controls.Add(this.btnVerDetalles);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill);
            this.panelOpcionesBusqueda.Controls.Add(this.dtpFechaFin);
            this.panelOpcionesBusqueda.Controls.Add(this.lblHasta);
            this.panelOpcionesBusqueda.Controls.Add(this.dtpFechaIni);
            this.panelOpcionesBusqueda.Controls.Add(this.lblDesde);
            this.panelOpcionesBusqueda.Controls.Add(this.chbFecha);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill3);
            this.panelOpcionesBusqueda.Controls.Add(this.txtNombreAsesor);
            this.panelOpcionesBusqueda.Controls.Add(this.lblAsesor);
            this.panelOpcionesBusqueda.Controls.Add(this.cbCiclo);
            this.panelOpcionesBusqueda.Controls.Add(this.lblCiclo);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill4);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill2);
            this.panelOpcionesBusqueda.Controls.Add(this.panel1);
            this.panelOpcionesBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcionesBusqueda.Location = new System.Drawing.Point(0, 10);
            this.panelOpcionesBusqueda.Name = "panelOpcionesBusqueda";
            this.panelOpcionesBusqueda.Size = new System.Drawing.Size(1280, 45);
            this.panelOpcionesBusqueda.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(1027, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 25);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(1012, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 25);
            this.panel2.TabIndex = 29;
            // 
            // rbPasado
            // 
            this.rbPasado.AutoSize = true;
            this.rbPasado.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPasado.Location = new System.Drawing.Point(951, 10);
            this.rbPasado.Name = "rbPasado";
            this.rbPasado.Size = new System.Drawing.Size(61, 25);
            this.rbPasado.TabIndex = 27;
            this.rbPasado.Text = "Pasado";
            this.rbPasado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPendiente.Location = new System.Drawing.Point(878, 10);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 25);
            this.rbPendiente.TabIndex = 26;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbTodos.Location = new System.Drawing.Point(823, 10);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 25);
            this.rbTodos.TabIndex = 28;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstado.Location = new System.Drawing.Point(775, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 25);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFill5
            // 
            this.panelFill5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill5.Location = new System.Drawing.Point(755, 10);
            this.panelFill5.Name = "panelFill5";
            this.panelFill5.Size = new System.Drawing.Size(20, 25);
            this.panelFill5.TabIndex = 23;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVerDetalles.Location = new System.Drawing.Point(1179, 10);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(86, 25);
            this.btnVerDetalles.TabIndex = 21;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill.Location = new System.Drawing.Point(1265, 10);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(15, 25);
            this.panelFill.TabIndex = 20;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(659, 10);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 10;
            this.dtpFechaFin.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHasta.Enabled = false;
            this.lblHasta.Location = new System.Drawing.Point(611, 10);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 25);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaIni.Enabled = false;
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(515, 10);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaIni.TabIndex = 8;
            this.dtpFechaIni.Value = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesde.Enabled = false;
            this.lblDesde.Location = new System.Drawing.Point(467, 10);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 25);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbFecha.Location = new System.Drawing.Point(408, 10);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(59, 25);
            this.chbFecha.TabIndex = 18;
            this.chbFecha.Text = "Fecha:";
            this.chbFecha.UseVisualStyleBackColor = true;
            this.chbFecha.CheckStateChanged += new System.EventHandler(this.chbFecha_CheckStateChanged);
            // 
            // panelFill3
            // 
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill3.Location = new System.Drawing.Point(387, 10);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(21, 25);
            this.panelFill3.TabIndex = 18;
            // 
            // txtNombreAsesor
            // 
            this.txtNombreAsesor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNombreAsesor.Location = new System.Drawing.Point(244, 10);
            this.txtNombreAsesor.Name = "txtNombreAsesor";
            this.txtNombreAsesor.Size = new System.Drawing.Size(143, 20);
            this.txtNombreAsesor.TabIndex = 6;
            // 
            // lblAsesor
            // 
            this.lblAsesor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAsesor.Location = new System.Drawing.Point(131, 10);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(113, 25);
            this.lblAsesor.TabIndex = 5;
            this.lblAsesor.Text = " Nombre del Asesor:";
            this.lblAsesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCiclo
            // 
            this.cbCiclo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Location = new System.Drawing.Point(55, 10);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(76, 21);
            this.cbCiclo.TabIndex = 6;
            this.cbCiclo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCiclo_Format);
            // 
            // lblCiclo
            // 
            this.lblCiclo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCiclo.Location = new System.Drawing.Point(15, 10);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(40, 25);
            this.lblCiclo.TabIndex = 3;
            this.lblCiclo.Text = "Ciclo:";
            this.lblCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFill4
            // 
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill4.Location = new System.Drawing.Point(0, 10);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(15, 25);
            this.panelFill4.TabIndex = 2;
            // 
            // panelFill2
            // 
            this.panelFill2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill2.Location = new System.Drawing.Point(0, 35);
            this.panelFill2.Name = "panelFill2";
            this.panelFill2.Size = new System.Drawing.Size(1280, 10);
            this.panelFill2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 10);
            this.panel1.TabIndex = 0;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dgvCitas);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 55);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1280, 665);
            this.panelTabla.TabIndex = 7;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToResizeColumns = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciclo,
            this.Asesor,
            this.Telefono,
            this.Correo,
            this.Fecha,
            this.Hora,
            this.Estado});
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(0, 0);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersWidth = 62;
            this.dgvCitas.RowTemplate.Height = 28;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1280, 665);
            this.dgvCitas.TabIndex = 10;
            this.dgvCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCitas_CellFormatting);
            // 
            // Ciclo
            // 
            this.Ciclo.FillWeight = 50F;
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 50;
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            // 
            // Asesor
            // 
            this.Asesor.FillWeight = 93.27411F;
            this.Asesor.HeaderText = "Asesor";
            this.Asesor.MinimumWidth = 200;
            this.Asesor.Name = "Asesor";
            this.Asesor.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 93.27411F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.FillWeight = 93.27411F;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 93.27411F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmCitasProgramadasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelOpcionesBusqueda);
            this.Controls.Add(this.panelFill1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCitasProgramadasAlumno";
            this.Text = "frmCitasProgramadasAlumno";
            this.panelOpcionesBusqueda.ResumeLayout(false);
            this.panelOpcionesBusqueda.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill1;
        private System.Windows.Forms.Panel panelOpcionesBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.TextBox txtNombreAsesor;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.Panel panelFill2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Panel panelFill5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbPasado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblEstado;
    }
}