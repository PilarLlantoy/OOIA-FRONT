
namespace ooiasoft
{
    partial class frmAlumnoEventosOpciones
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
            this.panelFill2 = new System.Windows.Forms.Panel();
            this.panelFill3 = new System.Windows.Forms.Panel();
            this.panelContenedorOpciones = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelInscripcion = new System.Windows.Forms.Panel();
            this.lblInscribirse = new System.Windows.Forms.Label();
            this.panelEventosInscritos = new System.Windows.Forms.Panel();
            this.lblEventosInscritos = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.panelContenedorOpciones.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panelInscripcion.SuspendLayout();
            this.panelEventosInscritos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill1
            // 
            this.panelFill1.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill1.Location = new System.Drawing.Point(0, 0);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Size = new System.Drawing.Size(800, 20);
            this.panelFill1.TabIndex = 0;
            // 
            // panelFill2
            // 
            this.panelFill2.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill2.Location = new System.Drawing.Point(0, 20);
            this.panelFill2.Name = "panelFill2";
            this.panelFill2.Size = new System.Drawing.Size(40, 430);
            this.panelFill2.TabIndex = 1;
            // 
            // panelFill3
            // 
            this.panelFill3.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill3.Location = new System.Drawing.Point(760, 20);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(40, 430);
            this.panelFill3.TabIndex = 2;
            // 
            // panelContenedorOpciones
            // 
            this.panelContenedorOpciones.BackColor = System.Drawing.Color.LightBlue;
            this.panelContenedorOpciones.Controls.Add(this.panelOpciones);
            this.panelContenedorOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenedorOpciones.Location = new System.Drawing.Point(40, 20);
            this.panelContenedorOpciones.Name = "panelContenedorOpciones";
            this.panelContenedorOpciones.Size = new System.Drawing.Size(720, 32);
            this.panelContenedorOpciones.TabIndex = 3;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelInscripcion);
            this.panelOpciones.Controls.Add(this.panelEventosInscritos);
            this.panelOpciones.Location = new System.Drawing.Point(2, 4);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(276, 23);
            this.panelOpciones.TabIndex = 0;
            // 
            // panelInscripcion
            // 
            this.panelInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInscripcion.Controls.Add(this.lblInscribirse);
            this.panelInscripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInscripcion.Location = new System.Drawing.Point(123, 0);
            this.panelInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.panelInscripcion.Name = "panelInscripcion";
            this.panelInscripcion.Size = new System.Drawing.Size(132, 23);
            this.panelInscripcion.TabIndex = 2;
            // 
            // lblInscribirse
            // 
            this.lblInscribirse.BackColor = System.Drawing.Color.White;
            this.lblInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInscribirse.Location = new System.Drawing.Point(0, 0);
            this.lblInscribirse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscribirse.Name = "lblInscribirse";
            this.lblInscribirse.Size = new System.Drawing.Size(130, 21);
            this.lblInscribirse.TabIndex = 4;
            this.lblInscribirse.Text = "Inscripción a eventos";
            this.lblInscribirse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInscribirse.Click += new System.EventHandler(this.lblInscribirse_Click);
            // 
            // panelEventosInscritos
            // 
            this.panelEventosInscritos.BackColor = System.Drawing.Color.Gray;
            this.panelEventosInscritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEventosInscritos.Controls.Add(this.lblEventosInscritos);
            this.panelEventosInscritos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEventosInscritos.Location = new System.Drawing.Point(0, 0);
            this.panelEventosInscritos.Margin = new System.Windows.Forms.Padding(2);
            this.panelEventosInscritos.Name = "panelEventosInscritos";
            this.panelEventosInscritos.Size = new System.Drawing.Size(123, 23);
            this.panelEventosInscritos.TabIndex = 1;
            // 
            // lblEventosInscritos
            // 
            this.lblEventosInscritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventosInscritos.ForeColor = System.Drawing.Color.White;
            this.lblEventosInscritos.Location = new System.Drawing.Point(0, 0);
            this.lblEventosInscritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventosInscritos.Name = "lblEventosInscritos";
            this.lblEventosInscritos.Size = new System.Drawing.Size(121, 21);
            this.lblEventosInscritos.TabIndex = 1;
            this.lblEventosInscritos.Text = "Eventos Inscritos";
            this.lblEventosInscritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEventosInscritos.Click += new System.EventHandler(this.lblEventosInscritos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(40, 52);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(720, 378);
            this.panelContenido.TabIndex = 4;
            // 
            // panelFill4
            // 
            this.panelFill4.BackColor = System.Drawing.Color.LightBlue;
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill4.Location = new System.Drawing.Point(40, 430);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(720, 20);
            this.panelFill4.TabIndex = 5;
            // 
            // frmAlumnoEventosOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelFill4);
            this.Controls.Add(this.panelContenedorOpciones);
            this.Controls.Add(this.panelFill3);
            this.Controls.Add(this.panelFill2);
            this.Controls.Add(this.panelFill1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlumnoEventosOpciones";
            this.Text = "frmAlumnoEventosOpciones";
            this.panelContenedorOpciones.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panelInscripcion.ResumeLayout(false);
            this.panelEventosInscritos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill1;
        private System.Windows.Forms.Panel panelFill2;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.Panel panelContenedorOpciones;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelInscripcion;
        private System.Windows.Forms.Label lblInscribirse;
        private System.Windows.Forms.Panel panelEventosInscritos;
        private System.Windows.Forms.Label lblEventosInscritos;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelFill4;
    }
}