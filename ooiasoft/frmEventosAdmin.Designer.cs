
namespace ooiasoft
{
    partial class frmEventosAdmin
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
            this.dgvEventosAdmin = new System.Windows.Forms.DataGridView();
            this.ColCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NInscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.panelTopTable = new System.Windows.Forms.Panel();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            this.panelFill1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelFill6 = new System.Windows.Forms.Panel();
            this.cbCicloReporte = new System.Windows.Forms.ComboBox();
            this.lblCicloReporte = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFill2 = new System.Windows.Forms.Panel();
            this.rbPasado = new System.Windows.Forms.RadioButton();
            this.rbPendiente = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelFill7 = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.chbFechaEvento = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbCiclos = new System.Windows.Forms.ComboBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelFill3 = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosAdmin)).BeginInit();
            this.panelTabla.SuspendLayout();
            this.panelTopTable.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
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
            this.ColCiclo,
            this.nombreEvento,
            this.fechaRegistro,
            this.fechaRealizacion,
            this.HoraIni,
            this.duracion,
            this.NInscritos,
            this.Capacidad,
            this.ColEstado});
            this.dgvEventosAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventosAdmin.Location = new System.Drawing.Point(0, 72);
            this.dgvEventosAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventosAdmin.Name = "dgvEventosAdmin";
            this.dgvEventosAdmin.ReadOnly = true;
            this.dgvEventosAdmin.RowHeadersWidth = 62;
            this.dgvEventosAdmin.RowTemplate.Height = 28;
            this.dgvEventosAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventosAdmin.Size = new System.Drawing.Size(1240, 529);
            this.dgvEventosAdmin.TabIndex = 2;
            this.dgvEventosAdmin.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEventosAdmin_CellFormatting);
            // 
            // ColCiclo
            // 
            this.ColCiclo.FillWeight = 80F;
            this.ColCiclo.HeaderText = "Ciclo";
            this.ColCiclo.MinimumWidth = 80;
            this.ColCiclo.Name = "ColCiclo";
            this.ColCiclo.ReadOnly = true;
            // 
            // nombreEvento
            // 
            this.nombreEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombreEvento.HeaderText = "Nombre del evento";
            this.nombreEvento.MinimumWidth = 250;
            this.nombreEvento.Name = "nombreEvento";
            this.nombreEvento.ReadOnly = true;
            this.nombreEvento.Width = 250;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha de Registro";
            this.fechaRegistro.MinimumWidth = 150;
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // fechaRealizacion
            // 
            this.fechaRealizacion.HeaderText = "Fecha de Realización";
            this.fechaRealizacion.MinimumWidth = 150;
            this.fechaRealizacion.Name = "fechaRealizacion";
            this.fechaRealizacion.ReadOnly = true;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora de Inicio";
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.FillWeight = 70F;
            this.duracion.HeaderText = "Duración";
            this.duracion.MinimumWidth = 70;
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // NInscritos
            // 
            this.NInscritos.FillWeight = 70F;
            this.NInscritos.HeaderText = "Nº Inscritos";
            this.NInscritos.MinimumWidth = 70;
            this.NInscritos.Name = "NInscritos";
            this.NInscritos.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 621);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 20);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 601);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1260, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 601);
            this.panel5.TabIndex = 10;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.dgvEventosAdmin);
            this.panelTabla.Controls.Add(this.panelTopTable);
            this.panelTabla.Controls.Add(this.panelControl);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(20, 20);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1240, 601);
            this.panelTabla.TabIndex = 11;
            // 
            // panelTopTable
            // 
            this.panelTopTable.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopTable.Controls.Add(this.btnDescargarReporte);
            this.panelTopTable.Controls.Add(this.panel6);
            this.panelTopTable.Controls.Add(this.panel1);
            this.panelTopTable.Controls.Add(this.btnNuevoEvento);
            this.panelTopTable.Controls.Add(this.panelFill1);
            this.panelTopTable.Controls.Add(this.btnEditar);
            this.panelTopTable.Controls.Add(this.panelFill);
            this.panelTopTable.Controls.Add(this.btnEliminar);
            this.panelTopTable.Controls.Add(this.panelFill6);
            this.panelTopTable.Controls.Add(this.cbCicloReporte);
            this.panelTopTable.Controls.Add(this.lblCicloReporte);
            this.panelTopTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTable.Location = new System.Drawing.Point(0, 45);
            this.panelTopTable.Name = "panelTopTable";
            this.panelTopTable.Size = new System.Drawing.Size(1240, 27);
            this.panelTopTable.TabIndex = 8;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDescargarReporte.Location = new System.Drawing.Point(231, 0);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(126, 27);
            this.btnDescargarReporte.TabIndex = 14;
            this.btnDescargarReporte.Text = "Descargar Reporte";
            this.btnDescargarReporte.UseVisualStyleBackColor = true;
            this.btnDescargarReporte.Click += new System.EventHandler(this.btnDescargarReporte_Click_1);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(216, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 27);
            this.panel6.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(986, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 27);
            this.panel1.TabIndex = 15;
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevoEvento.Location = new System.Drawing.Point(1001, 0);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(65, 27);
            this.btnNuevoEvento.TabIndex = 11;
            this.btnNuevoEvento.Text = "Nuevo";
            this.btnNuevoEvento.UseVisualStyleBackColor = true;
            this.btnNuevoEvento.Click += new System.EventHandler(this.btnNuevoEvento_Click);
            // 
            // panelFill1
            // 
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill1.Location = new System.Drawing.Point(1066, 0);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Size = new System.Drawing.Size(15, 27);
            this.panelFill1.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.Location = new System.Drawing.Point(1081, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 27);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Ver";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill.Location = new System.Drawing.Point(1135, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(15, 27);
            this.panelFill.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.Location = new System.Drawing.Point(1150, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panelFill6
            // 
            this.panelFill6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill6.Location = new System.Drawing.Point(1225, 0);
            this.panelFill6.Name = "panelFill6";
            this.panelFill6.Size = new System.Drawing.Size(15, 27);
            this.panelFill6.TabIndex = 11;
            // 
            // cbCicloReporte
            // 
            this.cbCicloReporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCicloReporte.FormattingEnabled = true;
            this.cbCicloReporte.Location = new System.Drawing.Point(125, 0);
            this.cbCicloReporte.Name = "cbCicloReporte";
            this.cbCicloReporte.Size = new System.Drawing.Size(91, 21);
            this.cbCicloReporte.TabIndex = 18;
            this.cbCicloReporte.Text = "Seleccionar";
            this.cbCicloReporte.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCicloReporte_Format);
            // 
            // lblCicloReporte
            // 
            this.lblCicloReporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCicloReporte.Location = new System.Drawing.Point(0, 0);
            this.lblCicloReporte.Name = "lblCicloReporte";
            this.lblCicloReporte.Size = new System.Drawing.Size(125, 27);
            this.lblCicloReporte.TabIndex = 17;
            this.lblCicloReporte.Text = "Ciclo para Reporte:";
            this.lblCicloReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelOpciones);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1240, 45);
            this.panelControl.TabIndex = 7;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.panelOpciones.Controls.Add(this.btnBuscar);
            this.panelOpciones.Controls.Add(this.panelFill2);
            this.panelOpciones.Controls.Add(this.rbPasado);
            this.panelOpciones.Controls.Add(this.rbPendiente);
            this.panelOpciones.Controls.Add(this.rbTodos);
            this.panelOpciones.Controls.Add(this.lblEstado);
            this.panelOpciones.Controls.Add(this.panelFill7);
            this.panelOpciones.Controls.Add(this.dtpFechaFin);
            this.panelOpciones.Controls.Add(this.lblHasta);
            this.panelOpciones.Controls.Add(this.dtpFechaIni);
            this.panelOpciones.Controls.Add(this.lblFechaIni);
            this.panelOpciones.Controls.Add(this.chbFechaEvento);
            this.panelOpciones.Controls.Add(this.panel7);
            this.panelOpciones.Controls.Add(this.txtNombre);
            this.panelOpciones.Controls.Add(this.lblNombre);
            this.panelOpciones.Controls.Add(this.cbCiclos);
            this.panelOpciones.Controls.Add(this.lblCiclo);
            this.panelOpciones.Controls.Add(this.panelFill4);
            this.panelOpciones.Controls.Add(this.panelFill3);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1240, 45);
            this.panelOpciones.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(1000, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 25);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelFill2
            // 
            this.panelFill2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill2.Location = new System.Drawing.Point(985, 10);
            this.panelFill2.Name = "panelFill2";
            this.panelFill2.Size = new System.Drawing.Size(15, 25);
            this.panelFill2.TabIndex = 24;
            // 
            // rbPasado
            // 
            this.rbPasado.AutoSize = true;
            this.rbPasado.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPasado.Location = new System.Drawing.Point(924, 10);
            this.rbPasado.Name = "rbPasado";
            this.rbPasado.Size = new System.Drawing.Size(61, 25);
            this.rbPasado.TabIndex = 22;
            this.rbPasado.Text = "Pasado";
            this.rbPasado.UseVisualStyleBackColor = true;
            // 
            // rbPendiente
            // 
            this.rbPendiente.AutoSize = true;
            this.rbPendiente.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPendiente.Location = new System.Drawing.Point(851, 10);
            this.rbPendiente.Name = "rbPendiente";
            this.rbPendiente.Size = new System.Drawing.Size(73, 25);
            this.rbPendiente.TabIndex = 21;
            this.rbPendiente.Text = "Pendiente";
            this.rbPendiente.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbTodos.Location = new System.Drawing.Point(796, 10);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 25);
            this.rbTodos.TabIndex = 23;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstado.Location = new System.Drawing.Point(748, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 25);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFill7
            // 
            this.panelFill7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill7.Location = new System.Drawing.Point(733, 10);
            this.panelFill7.Name = "panelFill7";
            this.panelFill7.Size = new System.Drawing.Size(15, 25);
            this.panelFill7.TabIndex = 19;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(637, 10);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 10;
            this.dtpFechaFin.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHasta.Enabled = false;
            this.lblHasta.Location = new System.Drawing.Point(589, 10);
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
            this.dtpFechaIni.Location = new System.Drawing.Point(493, 10);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaIni.TabIndex = 8;
            this.dtpFechaIni.Value = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaIni.Enabled = false;
            this.lblFechaIni.Location = new System.Drawing.Point(445, 10);
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
            this.chbFechaEvento.Location = new System.Drawing.Point(386, 10);
            this.chbFechaEvento.Name = "chbFechaEvento";
            this.chbFechaEvento.Size = new System.Drawing.Size(59, 25);
            this.chbFechaEvento.TabIndex = 18;
            this.chbFechaEvento.Text = "Fecha:";
            this.chbFechaEvento.UseVisualStyleBackColor = true;
            this.chbFechaEvento.CheckedChanged += new System.EventHandler(this.chbFechaEvento_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(371, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 25);
            this.panel7.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNombre.Location = new System.Drawing.Point(228, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombre.Location = new System.Drawing.Point(116, 10);
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
            this.cbCiclos.Location = new System.Drawing.Point(40, 10);
            this.cbCiclos.Name = "cbCiclos";
            this.cbCiclos.Size = new System.Drawing.Size(76, 21);
            this.cbCiclos.TabIndex = 6;
            this.cbCiclos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCiclos_Format);
            // 
            // lblCiclo
            // 
            this.lblCiclo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCiclo.Location = new System.Drawing.Point(0, 10);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(40, 25);
            this.lblCiclo.TabIndex = 3;
            this.lblCiclo.Text = "Ciclo:";
            this.lblCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFill4
            // 
            this.panelFill4.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill4.Location = new System.Drawing.Point(0, 35);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(1240, 10);
            this.panelFill4.TabIndex = 1;
            // 
            // panelFill3
            // 
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill3.Location = new System.Drawing.Point(0, 0);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(1240, 10);
            this.panelFill3.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LightBlue;
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1280, 20);
            this.panelTitulo.TabIndex = 6;
            // 
            // frmEventosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 641);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventosAdmin";
            this.Text = "frmEventosPasadosAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosAdmin)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panelTopTable.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventosAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelFill7;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.CheckBox chbFechaEvento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbCiclos;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.Panel panelTopTable;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Panel panelFill1;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelFill6;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbPasado;
        private System.Windows.Forms.RadioButton rbPendiente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panelFill2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCiclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.Button btnDescargarReporte;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCicloReporte;
        private System.Windows.Forms.Label lblCicloReporte;
    }
}