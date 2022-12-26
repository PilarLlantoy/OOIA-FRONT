
namespace ooiasoft
{
    partial class frmGestionarAlumnos
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelCenterTablaEspacio = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEspacioTabla = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopCenter = new System.Windows.Forms.Panel();
            this.panelTCC = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSeleccionar = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panelNombreArchivo = new System.Windows.Forms.Panel();
            this.tbNombreArchivo = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTopBot = new System.Windows.Forms.Panel();
            this.panelCambiosRight = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelCambiosLeft = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lblCodigoNombre = new System.Windows.Forms.Label();
            this.panelTopTop = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelSelTop = new System.Windows.Forms.Panel();
            this.panelSelBot = new System.Windows.Forms.Panel();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.TimerAlumnos = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelCenterTablaEspacio.SuspendLayout();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panelBot.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelTopCenter.SuspendLayout();
            this.panelTCC.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSeleccionar.SuspendLayout();
            this.panelNombreArchivo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelTopBot.SuspendLayout();
            this.panelCambiosRight.SuspendLayout();
            this.panelCambiosLeft.SuspendLayout();
            this.panelTopTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelCenter);
            this.panelPrincipal.Controls.Add(this.panelBot);
            this.panelPrincipal.Controls.Add(this.panelTop);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1280, 720);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelCenterTablaEspacio);
            this.panelCenter.Controls.Add(this.panelEspacioTabla);
            this.panelCenter.Controls.Add(this.panelRight);
            this.panelCenter.Controls.Add(this.panelLeft);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 100);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1280, 573);
            this.panelCenter.TabIndex = 3;
            // 
            // panelCenterTablaEspacio
            // 
            this.panelCenterTablaEspacio.Controls.Add(this.panelTabla);
            this.panelCenterTablaEspacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterTablaEspacio.Location = new System.Drawing.Point(50, 34);
            this.panelCenterTablaEspacio.Name = "panelCenterTablaEspacio";
            this.panelCenterTablaEspacio.Size = new System.Drawing.Size(1180, 539);
            this.panelCenterTablaEspacio.TabIndex = 3;
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.LightBlue;
            this.panelTabla.Controls.Add(this.dgvAlumnos);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(0, 0);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1180, 539);
            this.panelTabla.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombres,
            this.Especialidad,
            this.ColTelefono,
            this.ColCorreo});
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1180, 539);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlumnos_CellFormatting);
            // 
            // ColCodigo
            // 
            this.ColCodigo.FillWeight = 85.91267F;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            // 
            // ColNombres
            // 
            this.ColNombres.FillWeight = 221.2594F;
            this.ColNombres.HeaderText = "Nombres";
            this.ColNombres.Name = "ColNombres";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // ColTelefono
            // 
            this.ColTelefono.FillWeight = 82.88017F;
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.Name = "ColTelefono";
            // 
            // ColCorreo
            // 
            this.ColCorreo.FillWeight = 106.0113F;
            this.ColCorreo.HeaderText = "Correo";
            this.ColCorreo.Name = "ColCorreo";
            // 
            // panelEspacioTabla
            // 
            this.panelEspacioTabla.BackColor = System.Drawing.Color.LightBlue;
            this.panelEspacioTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEspacioTabla.Location = new System.Drawing.Point(50, 0);
            this.panelEspacioTabla.Name = "panelEspacioTabla";
            this.panelEspacioTabla.Size = new System.Drawing.Size(1180, 34);
            this.panelEspacioTabla.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1230, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(50, 573);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(50, 573);
            this.panelLeft.TabIndex = 0;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.panel6);
            this.panelBot.Controls.Add(this.panel5);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 673);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1280, 47);
            this.panelBot.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.btnCargar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1230, 47);
            this.panel6.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCargar.Enabled = false;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(1115, 0);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(115, 47);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1230, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 47);
            this.panel5.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopCenter);
            this.panelTop.Controls.Add(this.panelTopLeft);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 100);
            this.panelTop.TabIndex = 1;
            // 
            // panelTopCenter
            // 
            this.panelTopCenter.Controls.Add(this.panelTCC);
            this.panelTopCenter.Controls.Add(this.panelTopBot);
            this.panelTopCenter.Controls.Add(this.panelTopTop);
            this.panelTopCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopCenter.Location = new System.Drawing.Point(50, 0);
            this.panelTopCenter.Name = "panelTopCenter";
            this.panelTopCenter.Size = new System.Drawing.Size(1180, 100);
            this.panelTopCenter.TabIndex = 2;
            // 
            // panelTCC
            // 
            this.panelTCC.Controls.Add(this.panel2);
            this.panelTCC.Controls.Add(this.panelTitulo);
            this.panelTCC.Controls.Add(this.panel1);
            this.panelTCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTCC.Location = new System.Drawing.Point(0, 33);
            this.panelTCC.Name = "panelTCC";
            this.panelTCC.Size = new System.Drawing.Size(1180, 33);
            this.panelTCC.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelNombreArchivo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 33);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 33);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSeleccionar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(305, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 33);
            this.panel4.TabIndex = 1;
            // 
            // panelSeleccionar
            // 
            this.panelSeleccionar.BackColor = System.Drawing.Color.LightBlue;
            this.panelSeleccionar.Controls.Add(this.btnSeleccionar);
            this.panelSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeleccionar.Location = new System.Drawing.Point(0, 0);
            this.panelSeleccionar.Name = "panelSeleccionar";
            this.panelSeleccionar.Size = new System.Drawing.Size(155, 33);
            this.panelSeleccionar.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(0, 0);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(155, 33);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar Archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panelNombreArchivo
            // 
            this.panelNombreArchivo.Controls.Add(this.tbNombreArchivo);
            this.panelNombreArchivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNombreArchivo.Location = new System.Drawing.Point(0, 0);
            this.panelNombreArchivo.Name = "panelNombreArchivo";
            this.panelNombreArchivo.Size = new System.Drawing.Size(257, 33);
            this.panelNombreArchivo.TabIndex = 0;
            // 
            // tbNombreArchivo
            // 
            this.tbNombreArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombreArchivo.Enabled = false;
            this.tbNombreArchivo.Location = new System.Drawing.Point(0, 0);
            this.tbNombreArchivo.Multiline = true;
            this.tbNombreArchivo.Name = "tbNombreArchivo";
            this.tbNombreArchivo.ReadOnly = true;
            this.tbNombreArchivo.Size = new System.Drawing.Size(257, 33);
            this.tbNombreArchivo.TabIndex = 2;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.LightBlue;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(369, 33);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Alumnos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 33);
            this.panel1.TabIndex = 4;
            // 
            // panelTopBot
            // 
            this.panelTopBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopBot.Controls.Add(this.panelCambiosRight);
            this.panelTopBot.Controls.Add(this.panelCambiosLeft);
            this.panelTopBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTopBot.Location = new System.Drawing.Point(0, 66);
            this.panelTopBot.Name = "panelTopBot";
            this.panelTopBot.Size = new System.Drawing.Size(1180, 34);
            this.panelTopBot.TabIndex = 2;
            // 
            // panelCambiosRight
            // 
            this.panelCambiosRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelCambiosRight.Controls.Add(this.btnEliminar);
            this.panelCambiosRight.Controls.Add(this.btnNuevo);
            this.panelCambiosRight.Controls.Add(this.btnModificar);
            this.panelCambiosRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCambiosRight.Location = new System.Drawing.Point(832, 0);
            this.panelCambiosRight.Name = "panelCambiosRight";
            this.panelCambiosRight.Size = new System.Drawing.Size(348, 34);
            this.panelCambiosRight.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(196, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 26);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(20, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 26);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(112, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 26);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Ver";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelCambiosLeft
            // 
            this.panelCambiosLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelCambiosLeft.Controls.Add(this.btnBuscar);
            this.panelCambiosLeft.Controls.Add(this.panelFill);
            this.panelCambiosLeft.Controls.Add(this.tbBuscar);
            this.panelCambiosLeft.Controls.Add(this.lblCodigoNombre);
            this.panelCambiosLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCambiosLeft.Location = new System.Drawing.Point(0, 0);
            this.panelCambiosLeft.Name = "panelCambiosLeft";
            this.panelCambiosLeft.Size = new System.Drawing.Size(697, 34);
            this.panelCambiosLeft.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(485, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 34);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill.Location = new System.Drawing.Point(462, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(23, 34);
            this.panelFill.TabIndex = 8;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(141, 0);
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(321, 34);
            this.tbBuscar.TabIndex = 5;
            // 
            // lblCodigoNombre
            // 
            this.lblCodigoNombre.BackColor = System.Drawing.Color.LightBlue;
            this.lblCodigoNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCodigoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoNombre.Location = new System.Drawing.Point(0, 0);
            this.lblCodigoNombre.Name = "lblCodigoNombre";
            this.lblCodigoNombre.Size = new System.Drawing.Size(141, 34);
            this.lblCodigoNombre.TabIndex = 7;
            this.lblCodigoNombre.Text = "Código o Nombre:";
            this.lblCodigoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTopTop
            // 
            this.panelTopTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopTop.Controls.Add(this.panel14);
            this.panelTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTop.Location = new System.Drawing.Point(0, 0);
            this.panelTopTop.Name = "panelTopTop";
            this.panelTopTop.Size = new System.Drawing.Size(1180, 33);
            this.panelTopTop.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(372, 33);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 61);
            this.panel14.TabIndex = 4;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(50, 100);
            this.panelTopLeft.TabIndex = 1;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopRight.Controls.Add(this.panelSelTop);
            this.panelTopRight.Controls.Add(this.panelSelBot);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(1230, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(50, 100);
            this.panelTopRight.TabIndex = 0;
            // 
            // panelSelTop
            // 
            this.panelSelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelSelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelTop.Location = new System.Drawing.Point(0, 0);
            this.panelSelTop.Name = "panelSelTop";
            this.panelSelTop.Size = new System.Drawing.Size(50, 33);
            this.panelSelTop.TabIndex = 2;
            // 
            // panelSelBot
            // 
            this.panelSelBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelSelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelBot.Location = new System.Drawing.Point(0, 66);
            this.panelSelBot.Name = "panelSelBot";
            this.panelSelBot.Size = new System.Drawing.Size(50, 34);
            this.panelSelBot.TabIndex = 1;
            // 
            // TimerAlumnos
            // 
            this.TimerAlumnos.Tick += new System.EventHandler(this.TimerAlumnos_Tick);
            // 
            // frmGestionarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarAlumnos";
            this.Text = "Gestión de alumnos";
            this.panelPrincipal.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenterTablaEspacio.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panelBot.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTopCenter.ResumeLayout(false);
            this.panelTCC.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelSeleccionar.ResumeLayout(false);
            this.panelNombreArchivo.ResumeLayout(false);
            this.panelNombreArchivo.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTopBot.ResumeLayout(false);
            this.panelCambiosRight.ResumeLayout(false);
            this.panelCambiosLeft.ResumeLayout(false);
            this.panelCambiosLeft.PerformLayout();
            this.panelTopTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelSeleccionar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel panelSelTop;
        private System.Windows.Forms.Panel panelSelBot;
        private System.Windows.Forms.Panel panelTopCenter;
        private System.Windows.Forms.Panel panelTopBot;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTopTop;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelTCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelNombreArchivo;
        private System.Windows.Forms.TextBox tbNombreArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelCambiosRight;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panelCenterTablaEspacio;
        private System.Windows.Forms.Panel panelEspacioTabla;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panelCambiosLeft;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblCodigoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.Timer TimerAlumnos;
    }
}