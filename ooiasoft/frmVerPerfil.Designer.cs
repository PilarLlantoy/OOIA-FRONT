
namespace ooiasoft
{
    partial class frmVerPerfil
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCodigoPUCP = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditarFoto = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.btnAccion = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(223, 285);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(310, 22);
            this.tbNombre.TabIndex = 91;
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(223, 249);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(165, 22);
            this.tbDNI.TabIndex = 90;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.Enabled = false;
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPUCP.Location = new System.Drawing.Point(223, 212);
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.Size = new System.Drawing.Size(165, 22);
            this.tbCodigoPUCP.TabIndex = 89;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(223, 174);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 88;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(73, 284);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(129, 23);
            this.lblNombreCompleto.TabIndex = 87;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            this.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(102, 249);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(100, 23);
            this.lblDNI.TabIndex = 86;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(102, 211);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 85;
            this.lblCodigo.Text = "Codigo PUCP:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(117, 173);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(85, 23);
            this.lblID.TabIndex = 84;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(223, 323);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(112, 22);
            this.dtpFecha.TabIndex = 93;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 323);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 23);
            this.lblFecha.TabIndex = 92;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(331, 361);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(57, 19);
            this.rbMujer.TabIndex = 97;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHombre.Location = new System.Drawing.Point(223, 361);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(70, 19);
            this.rbHombre.TabIndex = 96;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(102, 358);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(100, 23);
            this.lblSexo.TabIndex = 95;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(223, 435);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(165, 22);
            this.tbCorreo.TabIndex = 103;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(223, 398);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(165, 22);
            this.tbTelefono.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 100;
            this.label12.Text = "Correo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(102, 397);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(100, 23);
            this.lblCelular.TabIndex = 99;
            this.lblCelular.Text = "Celular:";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(242, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 32);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditarFoto
            // 
            this.btnEditarFoto.Location = new System.Drawing.Point(331, 119);
            this.btnEditarFoto.Name = "btnEditarFoto";
            this.btnEditarFoto.Size = new System.Drawing.Size(30, 23);
            this.btnEditarFoto.TabIndex = 106;
            this.btnEditarFoto.Text = "...";
            this.btnEditarFoto.UseVisualStyleBackColor = true;
            this.btnEditarFoto.Click += new System.EventHandler(this.btnEditarFoto_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.Location = new System.Drawing.Point(451, 7);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(96, 32);
            this.btnAccion.TabIndex = 107;
            this.btnAccion.Text = "Editar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::ooiasoft.Properties.Resources.user;
            this.pbFoto.Location = new System.Drawing.Point(198, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(163, 130);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // frmVerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(560, 509);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnEditarFoto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbCodigoPUCP);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCodigoPUCP;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditarFoto;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.Windows.Forms.Button btnAccion;
    }
}