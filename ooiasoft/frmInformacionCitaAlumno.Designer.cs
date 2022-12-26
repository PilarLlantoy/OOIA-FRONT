
namespace ooiasoft
{
    partial class frmInformacionCitaAlumno
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panelTC = new System.Windows.Forms.Panel();
            this.pnlTCT = new System.Windows.Forms.Panel();
            this.pnlTR = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pnlTL = new System.Windows.Forms.Panel();
            this.dateTimeFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.scAux = new System.Windows.Forms.SplitContainer();
            this.txtBoxCiclo = new System.Windows.Forms.TextBox();
            this.txtBoxMotivoCita = new System.Windows.Forms.TextBox();
            this.txtBoxTipoCita = new System.Windows.Forms.TextBox();
            this.txtBoxAsistencia = new System.Windows.Forms.TextBox();
            this.txtBoxHora = new System.Windows.Forms.TextBox();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblMotivoCita = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblTipoCita = new System.Windows.Forms.Label();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxRendimiento = new System.Windows.Forms.TextBox();
            this.txtBoxCorreo = new System.Windows.Forms.TextBox();
            this.txtBoxCelular = new System.Windows.Forms.TextBox();
            this.txtBoxCodPUCP = new System.Windows.Forms.TextBox();
            this.txtBoxNombreAsesor = new System.Windows.Forms.TextBox();
            this.lblRendimiento = new System.Windows.Forms.Label();
            this.lblCodPUCP = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbIconoUser = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panelTC.SuspendLayout();
            this.pnlTR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAux)).BeginInit();
            this.scAux.Panel1.SuspendLayout();
            this.scAux.Panel2.SuspendLayout();
            this.scAux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(652, 64);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INFORMACIÓN DE LA CITA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitulo);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 23);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(652, 64);
            this.panelTitle.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panelTC);
            this.pnlTop.Controls.Add(this.pnlTR);
            this.pnlTop.Controls.Add(this.pnlTL);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1052, 87);
            this.pnlTop.TabIndex = 2;
            // 
            // panelTC
            // 
            this.panelTC.Controls.Add(this.panelTitle);
            this.panelTC.Controls.Add(this.pnlTCT);
            this.panelTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTC.Location = new System.Drawing.Point(200, 0);
            this.panelTC.Name = "panelTC";
            this.panelTC.Size = new System.Drawing.Size(652, 87);
            this.panelTC.TabIndex = 3;
            // 
            // pnlTCT
            // 
            this.pnlTCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTCT.Location = new System.Drawing.Point(0, 0);
            this.pnlTCT.Name = "pnlTCT";
            this.pnlTCT.Size = new System.Drawing.Size(652, 23);
            this.pnlTCT.TabIndex = 0;
            // 
            // pnlTR
            // 
            this.pnlTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTR.Controls.Add(this.lblEstado);
            this.pnlTR.Controls.Add(this.lblState);
            this.pnlTR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTR.Location = new System.Drawing.Point(852, 0);
            this.pnlTR.Name = "pnlTR";
            this.pnlTR.Size = new System.Drawing.Size(200, 87);
            this.pnlTR.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(95, 29);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(90, 20);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Pendiente";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.SystemColors.Control;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblState.Location = new System.Drawing.Point(18, 29);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(71, 20);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Estado:";
            // 
            // pnlTL
            // 
            this.pnlTL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTL.Location = new System.Drawing.Point(0, 0);
            this.pnlTL.Name = "pnlTL";
            this.pnlTL.Size = new System.Drawing.Size(200, 87);
            this.pnlTL.TabIndex = 3;
            // 
            // dateTimeFechaRegistro
            // 
            this.dateTimeFechaRegistro.Enabled = false;
            this.dateTimeFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaRegistro.Location = new System.Drawing.Point(176, 151);
            this.dateTimeFechaRegistro.Name = "dateTimeFechaRegistro";
            this.dateTimeFechaRegistro.Size = new System.Drawing.Size(137, 22);
            this.dateTimeFechaRegistro.TabIndex = 3;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFechaRegistro.Location = new System.Drawing.Point(13, 151);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(162, 20);
            this.lblFechaRegistro.TabIndex = 4;
            this.lblFechaRegistro.Text = "Fecha de Registro:";
            this.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(44, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Cita:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeFechaCita
            // 
            this.dateTimeFechaCita.Enabled = false;
            this.dateTimeFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCita.Location = new System.Drawing.Point(176, 189);
            this.dateTimeFechaCita.Name = "dateTimeFechaCita";
            this.dateTimeFechaCita.Size = new System.Drawing.Size(137, 22);
            this.dateTimeFechaCita.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Location = new System.Drawing.Point(55, 228);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(115, 20);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora de Cita:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scAux
            // 
            this.scAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAux.IsSplitterFixed = true;
            this.scAux.Location = new System.Drawing.Point(0, 0);
            this.scAux.Name = "scAux";
            // 
            // scAux.Panel1
            // 
            this.scAux.Panel1.Controls.Add(this.txtBoxCiclo);
            this.scAux.Panel1.Controls.Add(this.txtBoxMotivoCita);
            this.scAux.Panel1.Controls.Add(this.txtBoxTipoCita);
            this.scAux.Panel1.Controls.Add(this.txtBoxAsistencia);
            this.scAux.Panel1.Controls.Add(this.txtBoxHora);
            this.scAux.Panel1.Controls.Add(this.lblCiclo);
            this.scAux.Panel1.Controls.Add(this.lblMotivoCita);
            this.scAux.Panel1.Controls.Add(this.label3);
            this.scAux.Panel1.Controls.Add(this.lblGeneral);
            this.scAux.Panel1.Controls.Add(this.lblTipoCita);
            this.scAux.Panel1.Controls.Add(this.dateTimeFechaCita);
            this.scAux.Panel1.Controls.Add(this.lblHora);
            this.scAux.Panel1.Controls.Add(this.dateTimeFechaRegistro);
            this.scAux.Panel1.Controls.Add(this.label1);
            this.scAux.Panel1.Controls.Add(this.lblFechaRegistro);
            // 
            // scAux.Panel2
            // 
            this.scAux.Panel2.Controls.Add(this.lblAsesor);
            this.scAux.Panel2.Controls.Add(this.btnCancelar);
            this.scAux.Panel2.Controls.Add(this.txtBoxRendimiento);
            this.scAux.Panel2.Controls.Add(this.txtBoxCorreo);
            this.scAux.Panel2.Controls.Add(this.txtBoxCelular);
            this.scAux.Panel2.Controls.Add(this.txtBoxCodPUCP);
            this.scAux.Panel2.Controls.Add(this.txtBoxNombreAsesor);
            this.scAux.Panel2.Controls.Add(this.lblRendimiento);
            this.scAux.Panel2.Controls.Add(this.lblCodPUCP);
            this.scAux.Panel2.Controls.Add(this.lblCorreo);
            this.scAux.Panel2.Controls.Add(this.lblCelular);
            this.scAux.Panel2.Controls.Add(this.lblNombre);
            this.scAux.Panel2.Controls.Add(this.pbIconoUser);
            this.scAux.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.scAux.Panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scAux.Size = new System.Drawing.Size(1052, 477);
            this.scAux.SplitterDistance = 456;
            this.scAux.TabIndex = 9;
            // 
            // txtBoxCiclo
            // 
            this.txtBoxCiclo.Enabled = false;
            this.txtBoxCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCiclo.Location = new System.Drawing.Point(176, 306);
            this.txtBoxCiclo.Name = "txtBoxCiclo";
            this.txtBoxCiclo.ReadOnly = true;
            this.txtBoxCiclo.Size = new System.Drawing.Size(102, 22);
            this.txtBoxCiclo.TabIndex = 25;
            // 
            // txtBoxMotivoCita
            // 
            this.txtBoxMotivoCita.Enabled = false;
            this.txtBoxMotivoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMotivoCita.Location = new System.Drawing.Point(176, 379);
            this.txtBoxMotivoCita.Multiline = true;
            this.txtBoxMotivoCita.Name = "txtBoxMotivoCita";
            this.txtBoxMotivoCita.ReadOnly = true;
            this.txtBoxMotivoCita.Size = new System.Drawing.Size(260, 83);
            this.txtBoxMotivoCita.TabIndex = 24;
            // 
            // txtBoxTipoCita
            // 
            this.txtBoxTipoCita.Enabled = false;
            this.txtBoxTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTipoCita.Location = new System.Drawing.Point(176, 343);
            this.txtBoxTipoCita.Name = "txtBoxTipoCita";
            this.txtBoxTipoCita.ReadOnly = true;
            this.txtBoxTipoCita.Size = new System.Drawing.Size(260, 22);
            this.txtBoxTipoCita.TabIndex = 23;
            // 
            // txtBoxAsistencia
            // 
            this.txtBoxAsistencia.Enabled = false;
            this.txtBoxAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAsistencia.Location = new System.Drawing.Point(176, 266);
            this.txtBoxAsistencia.Name = "txtBoxAsistencia";
            this.txtBoxAsistencia.ReadOnly = true;
            this.txtBoxAsistencia.Size = new System.Drawing.Size(102, 22);
            this.txtBoxAsistencia.TabIndex = 22;
            // 
            // txtBoxHora
            // 
            this.txtBoxHora.Enabled = false;
            this.txtBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHora.Location = new System.Drawing.Point(176, 228);
            this.txtBoxHora.Name = "txtBoxHora";
            this.txtBoxHora.ReadOnly = true;
            this.txtBoxHora.Size = new System.Drawing.Size(137, 22);
            this.txtBoxHora.TabIndex = 21;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCiclo.Location = new System.Drawing.Point(117, 303);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(53, 20);
            this.lblCiclo.TabIndex = 20;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // lblMotivoCita
            // 
            this.lblMotivoCita.AutoSize = true;
            this.lblMotivoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCita.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMotivoCita.Location = new System.Drawing.Point(62, 379);
            this.lblMotivoCita.Name = "lblMotivoCita";
            this.lblMotivoCita.Size = new System.Drawing.Size(108, 20);
            this.lblMotivoCita.TabIndex = 19;
            this.lblMotivoCita.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(73, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Asistencia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(125, 106);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(195, 24);
            this.lblGeneral.TabIndex = 9;
            this.lblGeneral.Text = "DATOS GENERALES";
            // 
            // lblTipoCita
            // 
            this.lblTipoCita.AutoSize = true;
            this.lblTipoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCita.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipoCita.Location = new System.Drawing.Point(104, 343);
            this.lblTipoCita.Name = "lblTipoCita";
            this.lblTipoCita.Size = new System.Drawing.Size(66, 20);
            this.lblTipoCita.TabIndex = 18;
            this.lblTipoCita.Text = "Motivo:";
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsesor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAsesor.Location = new System.Drawing.Point(261, 106);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(88, 24);
            this.lblAsesor.TabIndex = 10;
            this.lblAsesor.Text = "ASESOR";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(232, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 32);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar Cita";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxRendimiento
            // 
            this.txtBoxRendimiento.Enabled = false;
            this.txtBoxRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRendimiento.Location = new System.Drawing.Point(305, 316);
            this.txtBoxRendimiento.Name = "txtBoxRendimiento";
            this.txtBoxRendimiento.ReadOnly = true;
            this.txtBoxRendimiento.Size = new System.Drawing.Size(146, 22);
            this.txtBoxRendimiento.TabIndex = 30;
            // 
            // txtBoxCorreo
            // 
            this.txtBoxCorreo.Enabled = false;
            this.txtBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorreo.Location = new System.Drawing.Point(305, 276);
            this.txtBoxCorreo.Name = "txtBoxCorreo";
            this.txtBoxCorreo.ReadOnly = true;
            this.txtBoxCorreo.Size = new System.Drawing.Size(259, 22);
            this.txtBoxCorreo.TabIndex = 29;
            // 
            // txtBoxCelular
            // 
            this.txtBoxCelular.Enabled = false;
            this.txtBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCelular.Location = new System.Drawing.Point(305, 241);
            this.txtBoxCelular.Name = "txtBoxCelular";
            this.txtBoxCelular.ReadOnly = true;
            this.txtBoxCelular.Size = new System.Drawing.Size(146, 22);
            this.txtBoxCelular.TabIndex = 28;
            // 
            // txtBoxCodPUCP
            // 
            this.txtBoxCodPUCP.Enabled = false;
            this.txtBoxCodPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodPUCP.Location = new System.Drawing.Point(305, 201);
            this.txtBoxCodPUCP.Name = "txtBoxCodPUCP";
            this.txtBoxCodPUCP.ReadOnly = true;
            this.txtBoxCodPUCP.Size = new System.Drawing.Size(146, 22);
            this.txtBoxCodPUCP.TabIndex = 27;
            // 
            // txtBoxNombreAsesor
            // 
            this.txtBoxNombreAsesor.Enabled = false;
            this.txtBoxNombreAsesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreAsesor.Location = new System.Drawing.Point(305, 163);
            this.txtBoxNombreAsesor.Name = "txtBoxNombreAsesor";
            this.txtBoxNombreAsesor.ReadOnly = true;
            this.txtBoxNombreAsesor.Size = new System.Drawing.Size(259, 22);
            this.txtBoxNombreAsesor.TabIndex = 26;
            // 
            // lblRendimiento
            // 
            this.lblRendimiento.AutoSize = true;
            this.lblRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimiento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRendimiento.Location = new System.Drawing.Point(184, 316);
            this.lblRendimiento.Name = "lblRendimiento";
            this.lblRendimiento.Size = new System.Drawing.Size(115, 20);
            this.lblRendimiento.TabIndex = 18;
            this.lblRendimiento.Text = "Rendimiento:";
            this.lblRendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodPUCP
            // 
            this.lblCodPUCP.AutoSize = true;
            this.lblCodPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPUCP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCodPUCP.Location = new System.Drawing.Point(177, 201);
            this.lblCodPUCP.Name = "lblCodPUCP";
            this.lblCodPUCP.Size = new System.Drawing.Size(122, 20);
            this.lblCodPUCP.TabIndex = 17;
            this.lblCodPUCP.Text = "Código PUCP:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCorreo.Location = new System.Drawing.Point(229, 276);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(68, 20);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCelular.Location = new System.Drawing.Point(229, 241);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(70, 20);
            this.lblCelular.TabIndex = 14;
            this.lblCelular.Text = "Celular:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombre.Location = new System.Drawing.Point(223, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // pbIconoUser
            // 
            this.pbIconoUser.Image = global::ooiasoft.Properties.Resources.user1;
            this.pbIconoUser.Location = new System.Drawing.Point(15, 161);
            this.pbIconoUser.Name = "pbIconoUser";
            this.pbIconoUser.Size = new System.Drawing.Size(156, 203);
            this.pbIconoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoUser.TabIndex = 11;
            this.pbIconoUser.TabStop = false;
            // 
            // frmInformacionCitaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 477);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.scAux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInformacionCitaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Cita";
            this.panelTitle.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panelTC.ResumeLayout(false);
            this.pnlTR.ResumeLayout(false);
            this.pnlTR.PerformLayout();
            this.scAux.Panel1.ResumeLayout(false);
            this.scAux.Panel1.PerformLayout();
            this.scAux.Panel2.ResumeLayout(false);
            this.scAux.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAux)).EndInit();
            this.scAux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTR;
        private System.Windows.Forms.Panel pnlTL;
        private System.Windows.Forms.Panel panelTC;
        private System.Windows.Forms.Panel pnlTCT;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.SplitContainer scAux;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbIconoUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodPUCP;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtBoxCiclo;
        private System.Windows.Forms.TextBox txtBoxMotivoCita;
        private System.Windows.Forms.TextBox txtBoxTipoCita;
        private System.Windows.Forms.TextBox txtBoxAsistencia;
        private System.Windows.Forms.TextBox txtBoxHora;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblMotivoCita;
        private System.Windows.Forms.Label lblTipoCita;
        private System.Windows.Forms.Label lblRendimiento;
        private System.Windows.Forms.TextBox txtBoxRendimiento;
        private System.Windows.Forms.TextBox txtBoxCorreo;
        private System.Windows.Forms.TextBox txtBoxCelular;
        private System.Windows.Forms.TextBox txtBoxCodPUCP;
        private System.Windows.Forms.TextBox txtBoxNombreAsesor;
        private System.Windows.Forms.Button btnCancelar;
    }
}