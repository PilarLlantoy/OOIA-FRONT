
namespace ooiasoft
{
    partial class frmCitas
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHorario = new System.Windows.Forms.Button();
            this.panelAgendar = new System.Windows.Forms.Panel();
            this.lblAgendar = new System.Windows.Forms.Label();
            this.panelCitasProg = new System.Windows.Forms.Panel();
            this.lblCitasProg = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelOpcionesTop = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelOpciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAgendar.SuspendLayout();
            this.panelCitasProg.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelOpcionesTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 28);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1218, 599);
            this.panelContenido.TabIndex = 5;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.panelOpciones.Controls.Add(this.panel2);
            this.panelOpciones.Controls.Add(this.btnHorario);
            this.panelOpciones.Controls.Add(this.panelAgendar);
            this.panelOpciones.Controls.Add(this.panelCitasProg);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1218, 28);
            this.panelOpciones.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDescargarReporte);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 28);
            this.panel2.TabIndex = 1;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDescargarReporte.Location = new System.Drawing.Point(709, 0);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(156, 28);
            this.btnDescargarReporte.TabIndex = 0;
            this.btnDescargarReporte.Text = "Descargar Reporte Citas";
            this.btnDescargarReporte.UseVisualStyleBackColor = true;
            this.btnDescargarReporte.Visible = false;
            this.btnDescargarReporte.Click += new System.EventHandler(this.btnDescargarReporte_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 28);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(865, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 28);
            this.panel3.TabIndex = 1;
            // 
            // btnHorario
            // 
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHorario.Location = new System.Drawing.Point(1112, 0);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(106, 28);
            this.btnHorario.TabIndex = 9;
            this.btnHorario.Text = "Editar Horario";
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Visible = false;
            this.btnHorario.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAgendar
            // 
            this.panelAgendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAgendar.Controls.Add(this.lblAgendar);
            this.panelAgendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAgendar.Location = new System.Drawing.Point(101, 0);
            this.panelAgendar.Margin = new System.Windows.Forms.Padding(2);
            this.panelAgendar.Name = "panelAgendar";
            this.panelAgendar.Size = new System.Drawing.Size(87, 28);
            this.panelAgendar.TabIndex = 8;
            // 
            // lblAgendar
            // 
            this.lblAgendar.BackColor = System.Drawing.Color.White;
            this.lblAgendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgendar.Location = new System.Drawing.Point(0, 0);
            this.lblAgendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgendar.Name = "lblAgendar";
            this.lblAgendar.Size = new System.Drawing.Size(85, 26);
            this.lblAgendar.TabIndex = 10;
            this.lblAgendar.Text = "Agendar Cita";
            this.lblAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgendar.Click += new System.EventHandler(this.lblAgendar_Click);
            // 
            // panelCitasProg
            // 
            this.panelCitasProg.BackColor = System.Drawing.Color.Gray;
            this.panelCitasProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCitasProg.Controls.Add(this.lblCitasProg);
            this.panelCitasProg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCitasProg.ForeColor = System.Drawing.Color.White;
            this.panelCitasProg.Location = new System.Drawing.Point(0, 0);
            this.panelCitasProg.Margin = new System.Windows.Forms.Padding(2);
            this.panelCitasProg.Name = "panelCitasProg";
            this.panelCitasProg.Size = new System.Drawing.Size(101, 28);
            this.panelCitasProg.TabIndex = 7;
            // 
            // lblCitasProg
            // 
            this.lblCitasProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCitasProg.Location = new System.Drawing.Point(0, 0);
            this.lblCitasProg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitasProg.Name = "lblCitasProg";
            this.lblCitasProg.Size = new System.Drawing.Size(99, 26);
            this.lblCitasProg.TabIndex = 9;
            this.lblCitasProg.Text = "Citas Programadas";
            this.lblCitasProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCitasProg.Click += new System.EventHandler(this.lblCitasProg_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(29, 680);
            this.panelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 680);
            this.panel1.TabIndex = 8;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(29, 655);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1218, 25);
            this.panelBot.TabIndex = 8;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(29, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1218, 28);
            this.panelTop.TabIndex = 9;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelContenido);
            this.panelCenter.Controls.Add(this.panelOpcionesTop);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(29, 28);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1218, 627);
            this.panelCenter.TabIndex = 10;
            // 
            // panelOpcionesTop
            // 
            this.panelOpcionesTop.Controls.Add(this.panelOpciones);
            this.panelOpcionesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcionesTop.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesTop.Name = "panelOpcionesTop";
            this.panelOpcionesTop.Size = new System.Drawing.Size(1218, 28);
            this.panelOpcionesTop.TabIndex = 11;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitas";
            this.Text = "frmCitasTutor";
            this.panelOpciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAgendar.ResumeLayout(false);
            this.panelCitasProg.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelOpcionesTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelCitasProg;
        private System.Windows.Forms.Panel panelAgendar;
        private System.Windows.Forms.Label lblCitasProg;
        private System.Windows.Forms.Label lblAgendar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelOpcionesTop;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDescargarReporte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}