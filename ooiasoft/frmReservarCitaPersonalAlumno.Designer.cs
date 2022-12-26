
namespace ooiasoft
{
    partial class frmReservarCitaPersonalAlumno
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.CodigoPUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFill0 = new System.Windows.Forms.Panel();
            this.txtCodigoNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoNombre = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.cbMotivoCita = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panelFill6 = new System.Windows.Forms.Panel();
            this.lblFormatoHora = new System.Windows.Forms.Label();
            this.numUPHora = new System.Windows.Forms.NumericUpDown();
            this.btnReservarCita = new System.Windows.Forms.Button();
            this.panelFill5 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTexto = new System.Windows.Forms.Label();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelFill3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelCenter.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelFill6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUPHora)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(20, 460);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(846, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(20, 460);
            this.panelRight.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(20, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(826, 27);
            this.panelTop.TabIndex = 2;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(20, 430);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(826, 30);
            this.panelBot.TabIndex = 3;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panel4);
            this.panelCenter.Controls.Add(this.panel2);
            this.panelCenter.Controls.Add(this.panelOpciones);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(20, 27);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(826, 403);
            this.panelCenter.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAlumnos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 287);
            this.panel4.TabIndex = 17;
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
            this.CodigoPUCP,
            this.Nombre,
            this.Correo,
            this.Telefono});
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(826, 287);
            this.dgvAlumnos.TabIndex = 17;
            // 
            // CodigoPUCP
            // 
            this.CodigoPUCP.DataPropertyName = "codigoPUCP";
            this.CodigoPUCP.HeaderText = "Código PUCP";
            this.CodigoPUCP.Name = "CodigoPUCP";
            this.CodigoPUCP.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombreCompleto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.panelFill0);
            this.panel2.Controls.Add(this.txtCodigoNombre);
            this.panel2.Controls.Add(this.lblCodigoNombre);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 45);
            this.panel2.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Location = new System.Drawing.Point(343, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelFill0
            // 
            this.panelFill0.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill0.Location = new System.Drawing.Point(318, 10);
            this.panelFill0.Name = "panelFill0";
            this.panelFill0.Size = new System.Drawing.Size(25, 25);
            this.panelFill0.TabIndex = 18;
            // 
            // txtCodigoNombre
            // 
            this.txtCodigoNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCodigoNombre.Location = new System.Drawing.Point(152, 10);
            this.txtCodigoNombre.Name = "txtCodigoNombre";
            this.txtCodigoNombre.Size = new System.Drawing.Size(166, 20);
            this.txtCodigoNombre.TabIndex = 4;
            // 
            // lblCodigoNombre
            // 
            this.lblCodigoNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCodigoNombre.Location = new System.Drawing.Point(0, 10);
            this.lblCodigoNombre.Name = "lblCodigoNombre";
            this.lblCodigoNombre.Size = new System.Drawing.Size(152, 25);
            this.lblCodigoNombre.TabIndex = 12;
            this.lblCodigoNombre.Text = "Código o Nombre del Alumno:";
            this.lblCodigoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(826, 10);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(826, 10);
            this.panel8.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpciones.Controls.Add(this.cbMotivoCita);
            this.panelOpciones.Controls.Add(this.lblMotivo);
            this.panelOpciones.Controls.Add(this.panelFill6);
            this.panelOpciones.Controls.Add(this.btnReservarCita);
            this.panelOpciones.Controls.Add(this.panelFill5);
            this.panelOpciones.Controls.Add(this.lblHora);
            this.panelOpciones.Controls.Add(this.panelFill);
            this.panelOpciones.Controls.Add(this.dtpFechaCita);
            this.panelOpciones.Controls.Add(this.lblFechaTexto);
            this.panelOpciones.Controls.Add(this.panelFill4);
            this.panelOpciones.Controls.Add(this.panelFill3);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 26);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(826, 45);
            this.panelOpciones.TabIndex = 15;
            // 
            // cbMotivoCita
            // 
            this.cbMotivoCita.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbMotivoCita.FormattingEnabled = true;
            this.cbMotivoCita.Location = new System.Drawing.Point(376, 10);
            this.cbMotivoCita.Name = "cbMotivoCita";
            this.cbMotivoCita.Size = new System.Drawing.Size(254, 21);
            this.cbMotivoCita.TabIndex = 24;
            // 
            // lblMotivo
            // 
            this.lblMotivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMotivo.Location = new System.Drawing.Point(332, 10);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(44, 25);
            this.lblMotivo.TabIndex = 23;
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFill6
            // 
            this.panelFill6.Controls.Add(this.lblFormatoHora);
            this.panelFill6.Controls.Add(this.numUPHora);
            this.panelFill6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill6.Location = new System.Drawing.Point(224, 10);
            this.panelFill6.Name = "panelFill6";
            this.panelFill6.Size = new System.Drawing.Size(108, 25);
            this.panelFill6.TabIndex = 22;
            // 
            // lblFormatoHora
            // 
            this.lblFormatoHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormatoHora.Location = new System.Drawing.Point(66, 0);
            this.lblFormatoHora.Name = "lblFormatoHora";
            this.lblFormatoHora.Size = new System.Drawing.Size(42, 25);
            this.lblFormatoHora.TabIndex = 19;
            this.lblFormatoHora.Text = "a.m.";
            this.lblFormatoHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numUPHora
            // 
            this.numUPHora.Dock = System.Windows.Forms.DockStyle.Left;
            this.numUPHora.Location = new System.Drawing.Point(0, 0);
            this.numUPHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUPHora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numUPHora.Name = "numUPHora";
            this.numUPHora.Size = new System.Drawing.Size(66, 20);
            this.numUPHora.TabIndex = 18;
            this.numUPHora.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUPHora.ValueChanged += new System.EventHandler(this.numUPHora_ValueChanged);
            // 
            // btnReservarCita
            // 
            this.btnReservarCita.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReservarCita.Location = new System.Drawing.Point(710, 10);
            this.btnReservarCita.Name = "btnReservarCita";
            this.btnReservarCita.Size = new System.Drawing.Size(91, 25);
            this.btnReservarCita.TabIndex = 20;
            this.btnReservarCita.Text = "Reservar cita";
            this.btnReservarCita.UseVisualStyleBackColor = true;
            this.btnReservarCita.Click += new System.EventHandler(this.btnReservarCita_Click);
            // 
            // panelFill5
            // 
            this.panelFill5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill5.Location = new System.Drawing.Point(801, 10);
            this.panelFill5.Name = "panelFill5";
            this.panelFill5.Size = new System.Drawing.Size(25, 25);
            this.panelFill5.TabIndex = 19;
            // 
            // lblHora
            // 
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHora.Location = new System.Drawing.Point(186, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 25);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora:";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill.Location = new System.Drawing.Point(166, 10);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(20, 25);
            this.panelFill.TabIndex = 17;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(58, 10);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaCita.TabIndex = 13;
            // 
            // lblFechaTexto
            // 
            this.lblFechaTexto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaTexto.Location = new System.Drawing.Point(0, 10);
            this.lblFechaTexto.Name = "lblFechaTexto";
            this.lblFechaTexto.Size = new System.Drawing.Size(58, 25);
            this.lblFechaTexto.TabIndex = 7;
            this.lblFechaTexto.Text = "Fecha:";
            this.lblFechaTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFill4
            // 
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill4.Location = new System.Drawing.Point(0, 35);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(826, 10);
            this.panelFill4.TabIndex = 1;
            // 
            // panelFill3
            // 
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill3.Location = new System.Drawing.Point(0, 0);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(826, 10);
            this.panelFill3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 26);
            this.panel1.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(0, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(292, 25);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Reservar Cita con un Alumno";
            // 
            // frmReservarCitaPersonalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(866, 460);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservarCitaPersonalAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar cita de un alumno";
            this.panelCenter.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelFill6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUPHora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFechaTexto;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFill0;
        private System.Windows.Forms.TextBox txtCodigoNombre;
        private System.Windows.Forms.Label lblCodigoNombre;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnReservarCita;
        private System.Windows.Forms.Panel panelFill5;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel panelFill6;
        private System.Windows.Forms.ComboBox cbMotivoCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.NumericUpDown numUPHora;
        private System.Windows.Forms.Label lblFormatoHora;
    }
}