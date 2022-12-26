
namespace ooiasoft
{
    partial class frmAlumnosAdministrativo
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.lblRegistroNotas = new System.Windows.Forms.Label();
            this.panelDatosAlum = new System.Windows.Forms.Panel();
            this.lblRegistroDatos = new System.Windows.Forms.Label();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.panelNotas.SuspendLayout();
            this.panelDatosAlum.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1214, 20);
            this.panelTop.TabIndex = 4;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.LightBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 645);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1214, 20);
            this.panelBot.TabIndex = 6;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 20);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(20, 625);
            this.panelLeft.TabIndex = 7;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1194, 20);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(20, 625);
            this.panelRight.TabIndex = 8;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.panelOpciones.Controls.Add(this.panelNotas);
            this.panelOpciones.Controls.Add(this.panelDatosAlum);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(20, 20);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1174, 25);
            this.panelOpciones.TabIndex = 9;
            // 
            // panelNotas
            // 
            this.panelNotas.BackColor = System.Drawing.Color.White;
            this.panelNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotas.Controls.Add(this.lblRegistroNotas);
            this.panelNotas.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNotas.Location = new System.Drawing.Point(123, 0);
            this.panelNotas.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(125, 25);
            this.panelNotas.TabIndex = 2;
            // 
            // lblRegistroNotas
            // 
            this.lblRegistroNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistroNotas.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroNotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroNotas.Name = "lblRegistroNotas";
            this.lblRegistroNotas.Size = new System.Drawing.Size(123, 23);
            this.lblRegistroNotas.TabIndex = 4;
            this.lblRegistroNotas.Text = "Gestión de Notas";
            this.lblRegistroNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistroNotas.Click += new System.EventHandler(this.lblRegistroNotas_Click);
            // 
            // panelDatosAlum
            // 
            this.panelDatosAlum.BackColor = System.Drawing.Color.Gray;
            this.panelDatosAlum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosAlum.Controls.Add(this.lblRegistroDatos);
            this.panelDatosAlum.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDatosAlum.Location = new System.Drawing.Point(0, 0);
            this.panelDatosAlum.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosAlum.Name = "panelDatosAlum";
            this.panelDatosAlum.Size = new System.Drawing.Size(123, 25);
            this.panelDatosAlum.TabIndex = 1;
            // 
            // lblRegistroDatos
            // 
            this.lblRegistroDatos.BackColor = System.Drawing.Color.Gray;
            this.lblRegistroDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistroDatos.ForeColor = System.Drawing.Color.White;
            this.lblRegistroDatos.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroDatos.Name = "lblRegistroDatos";
            this.lblRegistroDatos.Size = new System.Drawing.Size(121, 23);
            this.lblRegistroDatos.TabIndex = 1;
            this.lblRegistroDatos.Text = "Gestión de Alumnos";
            this.lblRegistroDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistroDatos.Click += new System.EventHandler(this.lblRegistroDatos_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Control;
            this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(20, 45);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1174, 600);
            this.panelFondo.TabIndex = 10;
            // 
            // frmAlumnosAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1214, 665);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumnosAdministrativo";
            this.Text = "frmAlumnosAdministrativo";
            this.panelOpciones.ResumeLayout(false);
            this.panelNotas.ResumeLayout(false);
            this.panelDatosAlum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.Label lblRegistroNotas;
        private System.Windows.Forms.Panel panelDatosAlum;
        private System.Windows.Forms.Label lblRegistroDatos;
        private System.Windows.Forms.Panel panelFondo;
    }
}