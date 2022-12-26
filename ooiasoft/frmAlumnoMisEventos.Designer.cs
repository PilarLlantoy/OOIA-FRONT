
namespace ooiasoft
{
    partial class frmAlumnoMisEventos
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFill7 = new System.Windows.Forms.Panel();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.rbPasado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.chbFechaEvento = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbCiclos = new System.Windows.Forms.ComboBox();
            this.panelFill6 = new System.Windows.Forms.Panel();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.panelFill5 = new System.Windows.Forms.Panel();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelFill3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToResizeColumns = false;
            this.dgvEventos.AllowUserToResizeRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciclo,
            this.NombreEvento,
            this.FechaEvento,
            this.HoraIni,
            this.Vacantes,
            this.Estado});
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(0, 45);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(1216, 541);
            this.dgvEventos.TabIndex = 1;
            this.dgvEventos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEventos_CellFormatting);
            // 
            // Ciclo
            // 
            this.Ciclo.FillWeight = 50F;
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 50;
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            // 
            // NombreEvento
            // 
            this.NombreEvento.FillWeight = 150F;
            this.NombreEvento.HeaderText = "Nombre de Evento";
            this.NombreEvento.MinimumWidth = 150;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.ReadOnly = true;
            // 
            // FechaEvento
            // 
            this.FechaEvento.HeaderText = "Fecha de Evento";
            this.FechaEvento.MinimumWidth = 50;
            this.FechaEvento.Name = "FechaEvento";
            this.FechaEvento.ReadOnly = true;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora de Inicio";
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.ReadOnly = true;
            // 
            // Vacantes
            // 
            this.Vacantes.HeaderText = "Vacantes";
            this.Vacantes.MinimumWidth = 50;
            this.Vacantes.Name = "Vacantes";
            this.Vacantes.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 50;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.panelFill7);
            this.panelOpciones.Controls.Add(this.btnVerDetalles);
            this.panelOpciones.Controls.Add(this.rbPasado);
            this.panelOpciones.Controls.Add(this.rbPendiente);
            this.panelOpciones.Controls.Add(this.rbTodos);
            this.panelOpciones.Controls.Add(this.lblEstado);
            this.panelOpciones.Controls.Add(this.dtpFechaFin);
            this.panelOpciones.Controls.Add(this.lblHasta);
            this.panelOpciones.Controls.Add(this.dtpFechaIni);
            this.panelOpciones.Controls.Add(this.lblFechaIni);
            this.panelOpciones.Controls.Add(this.chbFechaEvento);
            this.panelOpciones.Controls.Add(this.panel1);
            this.panelOpciones.Controls.Add(this.txtNombre);
            this.panelOpciones.Controls.Add(this.lblNombre);
            this.panelOpciones.Controls.Add(this.cbCiclos);
            this.panelOpciones.Controls.Add(this.panelFill6);
            this.panelOpciones.Controls.Add(this.lblCiclo);
            this.panelOpciones.Controls.Add(this.panelFill5);
            this.panelOpciones.Controls.Add(this.panelFill4);
            this.panelOpciones.Controls.Add(this.panelFill3);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1216, 45);
            this.panelOpciones.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(1006, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 25);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelFill7
            // 
            this.panelFill7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill7.Location = new System.Drawing.Point(991, 10);
            this.panelFill7.Name = "panelFill7";
            this.panelFill7.Size = new System.Drawing.Size(15, 25);
            this.panelFill7.TabIndex = 19;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVerDetalles.Location = new System.Drawing.Point(1121, 10);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(80, 25);
            this.btnVerDetalles.TabIndex = 15;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // rbPasado
            // 
            this.rbPasado.AutoSize = true;
            this.rbPasado.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPasado.Location = new System.Drawing.Point(930, 10);
            this.rbPasado.Name = "rbPasado";
            this.rbPasado.Size = new System.Drawing.Size(61, 25);
            this.rbPasado.TabIndex = 14;
            this.rbPasado.Text = "Pasada";
            this.rbPasado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPendiente.Location = new System.Drawing.Point(857, 10);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 25);
            this.rbPendiente.TabIndex = 13;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbTodos.Location = new System.Drawing.Point(802, 10);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 25);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstado.Location = new System.Drawing.Point(748, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 25);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado: ";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(652, 10);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 10;
            this.dtpFechaFin.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHasta.Enabled = false;
            this.lblHasta.Location = new System.Drawing.Point(604, 10);
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
            this.dtpFechaIni.Location = new System.Drawing.Point(508, 10);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaIni.TabIndex = 8;
            this.dtpFechaIni.Value = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaIni.Enabled = false;
            this.lblFechaIni.Location = new System.Drawing.Point(460, 10);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(48, 25);
            this.lblFechaIni.TabIndex = 7;
            this.lblFechaIni.Text = "Desde:";
            this.lblFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbFechaEvento
            // 
            this.chbFechaEvento.AutoSize = true;
            this.chbFechaEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbFechaEvento.Location = new System.Drawing.Point(401, 10);
            this.chbFechaEvento.Name = "chbFechaEvento";
            this.chbFechaEvento.Size = new System.Drawing.Size(59, 25);
            this.chbFechaEvento.TabIndex = 18;
            this.chbFechaEvento.Text = "Fecha:";
            this.chbFechaEvento.UseVisualStyleBackColor = true;
            this.chbFechaEvento.CheckStateChanged += new System.EventHandler(this.chbFechaEvento_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(386, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 25);
            this.panel1.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNombre.Location = new System.Drawing.Point(243, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombre.Location = new System.Drawing.Point(131, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = " Nombre del Evento:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCiclos
            // 
            this.cbCiclos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCiclos.FormattingEnabled = true;
            this.cbCiclos.Location = new System.Drawing.Point(55, 10);
            this.cbCiclos.Name = "cbCiclos";
            this.cbCiclos.Size = new System.Drawing.Size(76, 21);
            this.cbCiclos.TabIndex = 6;
            this.cbCiclos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCiclos_Format);
            // 
            // panelFill6
            // 
            this.panelFill6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill6.Location = new System.Drawing.Point(1201, 10);
            this.panelFill6.Name = "panelFill6";
            this.panelFill6.Size = new System.Drawing.Size(15, 25);
            this.panelFill6.TabIndex = 5;
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
            // panelFill5
            // 
            this.panelFill5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill5.Location = new System.Drawing.Point(0, 10);
            this.panelFill5.Name = "panelFill5";
            this.panelFill5.Size = new System.Drawing.Size(15, 25);
            this.panelFill5.TabIndex = 2;
            // 
            // panelFill4
            // 
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill4.Location = new System.Drawing.Point(0, 35);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(1216, 10);
            this.panelFill4.TabIndex = 1;
            // 
            // panelFill3
            // 
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill3.Location = new System.Drawing.Point(0, 0);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(1216, 10);
            this.panelFill3.TabIndex = 0;
            // 
            // frmAlumnoMisEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1216, 586);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumnoMisEventos";
            this.Text = "frmAlumnoMisEventos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.RadioButton rbPasado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Panel panelFill5;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Panel panelFill6;
        private System.Windows.Forms.ComboBox cbCiclos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chbFechaEvento;
        private System.Windows.Forms.Panel panelFill7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}