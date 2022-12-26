
namespace ooiasoft
{
    partial class frmEventosAlumno
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelOpcionesBusqueda = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.panelFill7 = new System.Windows.Forms.Panel();
            this.chbFechaEvento = new System.Windows.Forms.CheckBox();
            this.panelFill6 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelFill5 = new System.Windows.Forms.Panel();
            this.lblNoHayEventos = new System.Windows.Forms.Label();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelOpcionesBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Orange;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(853, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Próximos Eventos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(853, 41);
            this.panelTitulo.TabIndex = 4;
            // 
            // panelBot
            // 
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 365);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(853, 23);
            this.panelBot.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(853, 41);
            this.panelTop.TabIndex = 0;
            // 
            // panelOpcionesBusqueda
            // 
            this.panelOpcionesBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcionesBusqueda.Controls.Add(this.dtpFechaFin);
            this.panelOpcionesBusqueda.Controls.Add(this.lblHasta);
            this.panelOpcionesBusqueda.Controls.Add(this.dtpFechaIni);
            this.panelOpcionesBusqueda.Controls.Add(this.lblFechaIni);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill7);
            this.panelOpcionesBusqueda.Controls.Add(this.chbFechaEvento);
            this.panelOpcionesBusqueda.Controls.Add(this.panelFill6);
            this.panelOpcionesBusqueda.Controls.Add(this.btnBuscar);
            this.panelOpcionesBusqueda.Controls.Add(this.txtNombre);
            this.panelOpcionesBusqueda.Controls.Add(this.lblNombre);
            this.panelOpcionesBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcionesBusqueda.Location = new System.Drawing.Point(0, 41);
            this.panelOpcionesBusqueda.Name = "panelOpcionesBusqueda";
            this.panelOpcionesBusqueda.Size = new System.Drawing.Size(853, 28);
            this.panelOpcionesBusqueda.TabIndex = 8;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(653, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 26;
            this.dtpFechaFin.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHasta.Enabled = false;
            this.lblHasta.Location = new System.Drawing.Point(597, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 26);
            this.lblHasta.TabIndex = 25;
            this.lblHasta.Text = "Hasta: ";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpFechaIni.Enabled = false;
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(501, 0);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaIni.TabIndex = 24;
            this.dtpFechaIni.Value = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaIni.Enabled = false;
            this.lblFechaIni.Location = new System.Drawing.Point(453, 0);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(48, 26);
            this.lblFechaIni.TabIndex = 23;
            this.lblFechaIni.Text = "Desde:";
            this.lblFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFill7
            // 
            this.panelFill7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill7.Location = new System.Drawing.Point(432, 0);
            this.panelFill7.Name = "panelFill7";
            this.panelFill7.Size = new System.Drawing.Size(21, 26);
            this.panelFill7.TabIndex = 30;
            // 
            // chbFechaEvento
            // 
            this.chbFechaEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbFechaEvento.Location = new System.Drawing.Point(373, 0);
            this.chbFechaEvento.Name = "chbFechaEvento";
            this.chbFechaEvento.Size = new System.Drawing.Size(59, 26);
            this.chbFechaEvento.TabIndex = 28;
            this.chbFechaEvento.Text = "Fecha:";
            this.chbFechaEvento.UseVisualStyleBackColor = true;
            this.chbFechaEvento.CheckedChanged += new System.EventHandler(this.chbFechaEvento_CheckedChanged);
            // 
            // panelFill6
            // 
            this.panelFill6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill6.Location = new System.Drawing.Point(255, 0);
            this.panelFill6.Name = "panelFill6";
            this.panelFill6.Size = new System.Drawing.Size(118, 26);
            this.panelFill6.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.Location = new System.Drawing.Point(788, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 26);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNombre.Location = new System.Drawing.Point(112, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 26);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = " Nombre del Evento:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFill
            // 
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill.Location = new System.Drawing.Point(0, 69);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(853, 23);
            this.panelFill.TabIndex = 9;
            // 
            // panelFill4
            // 
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill4.Location = new System.Drawing.Point(0, 92);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(20, 273);
            this.panelFill4.TabIndex = 11;
            // 
            // panelFill5
            // 
            this.panelFill5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill5.Location = new System.Drawing.Point(833, 92);
            this.panelFill5.Name = "panelFill5";
            this.panelFill5.Size = new System.Drawing.Size(20, 273);
            this.panelFill5.TabIndex = 12;
            // 
            // lblNoHayEventos
            // 
            this.lblNoHayEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoHayEventos.Location = new System.Drawing.Point(20, 92);
            this.lblNoHayEventos.Name = "lblNoHayEventos";
            this.lblNoHayEventos.Size = new System.Drawing.Size(813, 64);
            this.lblNoHayEventos.TabIndex = 13;
            this.lblNoHayEventos.Text = "No hay eventos para mostrar.";
            this.lblNoHayEventos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoHayEventos.Visible = false;
            // 
            // panelEventos
            // 
            this.panelEventos.AutoScroll = true;
            this.panelEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventos.Location = new System.Drawing.Point(20, 156);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(813, 209);
            this.panelEventos.TabIndex = 14;
            // 
            // frmEventosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(853, 388);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.lblNoHayEventos);
            this.Controls.Add(this.panelFill5);
            this.Controls.Add(this.panelFill4);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelOpcionesBusqueda);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEventosAlumno";
            this.Text = "frmEventosAlumno";
            this.panelTitulo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelOpcionesBusqueda.ResumeLayout(false);
            this.panelOpcionesBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelOpcionesBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.CheckBox chbFechaEvento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.Panel panelFill5;
        private System.Windows.Forms.Label lblNoHayEventos;
        private System.Windows.Forms.Panel panelFill7;
        private System.Windows.Forms.Panel panelFill6;
        private System.Windows.Forms.Panel panelEventos;
    }
}