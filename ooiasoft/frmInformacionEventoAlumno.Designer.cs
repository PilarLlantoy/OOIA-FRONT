
namespace ooiasoft
{
    partial class frmInformacionEventoAlumno
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
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblLugarTxt = new System.Windows.Forms.Label();
            this.lblFechaTxt = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVacantesTexto = new System.Windows.Forms.Label();
            this.lblVacantes = new System.Windows.Forms.Label();
            this.pbEvento = new System.Windows.Forms.PictureBox();
            this.lblTextoHora = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblOrganizadoresTexto = new System.Windows.Forms.Label();
            this.lblOrganizadores = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.RichTextBox();
            this.lblInscritos = new System.Windows.Forms.Label();
            this.lblInscritosEvento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(54, 239);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(540, 176);
            this.rtbDescripcion.TabIndex = 2;
            this.rtbDescripcion.Text = "";
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.Color.Gold;
            this.btnAccion.Location = new System.Drawing.Point(245, 568);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(143, 27);
            this.btnAccion.TabIndex = 10;
            this.btnAccion.Text = "Inscribirme";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblLugarTxt
            // 
            this.lblLugarTxt.AutoSize = true;
            this.lblLugarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarTxt.Location = new System.Drawing.Point(55, 474);
            this.lblLugarTxt.Name = "lblLugarTxt";
            this.lblLugarTxt.Size = new System.Drawing.Size(45, 16);
            this.lblLugarTxt.TabIndex = 11;
            this.lblLugarTxt.Text = "Lugar:";
            // 
            // lblFechaTxt
            // 
            this.lblFechaTxt.AutoSize = true;
            this.lblFechaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTxt.Location = new System.Drawing.Point(51, 505);
            this.lblFechaTxt.Name = "lblFechaTxt";
            this.lblFechaTxt.Size = new System.Drawing.Size(49, 16);
            this.lblFechaTxt.TabIndex = 12;
            this.lblFechaTxt.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(102, 474);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(173, 23);
            this.lblLugar.TabIndex = 13;
            this.lblLugar.Text = "Lugar";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(102, 505);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 23);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVacantesTexto
            // 
            this.lblVacantesTexto.AutoSize = true;
            this.lblVacantesTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacantesTexto.Location = new System.Drawing.Point(123, 420);
            this.lblVacantesTexto.Name = "lblVacantesTexto";
            this.lblVacantesTexto.Size = new System.Drawing.Size(81, 20);
            this.lblVacantesTexto.TabIndex = 15;
            this.lblVacantesTexto.Text = "Vacantes:";
            // 
            // lblVacantes
            // 
            this.lblVacantes.AutoSize = true;
            this.lblVacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacantes.Location = new System.Drawing.Point(210, 420);
            this.lblVacantes.Name = "lblVacantes";
            this.lblVacantes.Size = new System.Drawing.Size(77, 20);
            this.lblVacantes.TabIndex = 16;
            this.lblVacantes.Text = "Vacantes";
            // 
            // pbEvento
            // 
            this.pbEvento.Image = global::ooiasoft.Properties.Resources.imagen;
            this.pbEvento.Location = new System.Drawing.Point(54, 22);
            this.pbEvento.Name = "pbEvento";
            this.pbEvento.Size = new System.Drawing.Size(540, 168);
            this.pbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEvento.TabIndex = 0;
            this.pbEvento.TabStop = false;
            // 
            // lblTextoHora
            // 
            this.lblTextoHora.AutoSize = true;
            this.lblTextoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoHora.Location = new System.Drawing.Point(59, 535);
            this.lblTextoHora.Name = "lblTextoHora";
            this.lblTextoHora.Size = new System.Drawing.Size(41, 16);
            this.lblTextoHora.TabIndex = 17;
            this.lblTextoHora.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(102, 535);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(102, 23);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora";
            // 
            // lblOrganizadoresTexto
            // 
            this.lblOrganizadoresTexto.AutoSize = true;
            this.lblOrganizadoresTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizadoresTexto.Location = new System.Drawing.Point(331, 474);
            this.lblOrganizadoresTexto.Name = "lblOrganizadoresTexto";
            this.lblOrganizadoresTexto.Size = new System.Drawing.Size(100, 16);
            this.lblOrganizadoresTexto.TabIndex = 19;
            this.lblOrganizadoresTexto.Text = "Organizadores:";
            // 
            // lblOrganizadores
            // 
            this.lblOrganizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizadores.Location = new System.Drawing.Point(437, 474);
            this.lblOrganizadores.Name = "lblOrganizadores";
            this.lblOrganizadores.Size = new System.Drawing.Size(157, 93);
            this.lblOrganizadores.TabIndex = 20;
            this.lblOrganizadores.Text = "Organizadores";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(54, 196);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.ReadOnly = true;
            this.lblTitulo.Size = new System.Drawing.Size(540, 37);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "";
            // 
            // lblInscritos
            // 
            this.lblInscritos.AutoSize = true;
            this.lblInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscritos.Location = new System.Drawing.Point(350, 420);
            this.lblInscritos.Name = "lblInscritos";
            this.lblInscritos.Size = new System.Drawing.Size(73, 20);
            this.lblInscritos.TabIndex = 22;
            this.lblInscritos.Text = "Inscritos:";
            // 
            // lblInscritosEvento
            // 
            this.lblInscritosEvento.AutoSize = true;
            this.lblInscritosEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscritosEvento.Location = new System.Drawing.Point(429, 420);
            this.lblInscritosEvento.Name = "lblInscritosEvento";
            this.lblInscritosEvento.Size = new System.Drawing.Size(69, 20);
            this.lblInscritosEvento.TabIndex = 23;
            this.lblInscritosEvento.Text = "Inscritos";
            // 
            // frmInformacionEventoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(638, 601);
            this.Controls.Add(this.lblInscritosEvento);
            this.Controls.Add(this.lblInscritos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblOrganizadores);
            this.Controls.Add(this.lblOrganizadoresTexto);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTextoHora);
            this.Controls.Add(this.lblVacantes);
            this.Controls.Add(this.lblVacantesTexto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblFechaTxt);
            this.Controls.Add(this.lblLugarTxt);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.pbEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformacionEventoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Evento";
            ((System.ComponentModel.ISupportInitialize)(this.pbEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEvento;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblLugarTxt;
        private System.Windows.Forms.Label lblFechaTxt;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVacantesTexto;
        private System.Windows.Forms.Label lblVacantes;
        private System.Windows.Forms.Label lblTextoHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblOrganizadoresTexto;
        private System.Windows.Forms.Label lblOrganizadores;
        private System.Windows.Forms.RichTextBox lblTitulo;
        private System.Windows.Forms.Label lblInscritos;
        private System.Windows.Forms.Label lblInscritosEvento;
    }
}