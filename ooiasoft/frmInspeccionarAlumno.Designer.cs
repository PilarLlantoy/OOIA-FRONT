
namespace ooiasoft
{
    partial class frmInspeccionarAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigoPUCP = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoPUCP = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.tbTipoAlumno = new System.Windows.Forms.TextBox();
            this.rtbNotas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbPresente = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de notas del alumno";
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Image = global::ooiasoft.Properties.Resources.user;
            this.pbPerfil.Location = new System.Drawing.Point(803, 12);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(289, 235);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 1;
            this.pbPerfil.TabStop = false;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tbTipoAlumno);
            this.gbDatosPersonales.Controls.Add(this.tbEspecialidad);
            this.gbDatosPersonales.Controls.Add(this.tbEdad);
            this.gbDatosPersonales.Controls.Add(this.tbCorreo);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.tbNombre);
            this.gbDatosPersonales.Controls.Add(this.tbCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.lblCorreo);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblEdad);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.lblCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.lblTipo);
            this.gbDatosPersonales.Controls.Add(this.lblEspecialidad);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(785, 235);
            this.gbDatosPersonales.TabIndex = 36;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = " Datos del Alumno";
            // 
            // tbEdad
            // 
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(146, 77);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(66, 22);
            this.tbEdad.TabIndex = 46;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Enabled = false;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(146, 133);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(201, 22);
            this.tbCorreo.TabIndex = 43;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Enabled = false;
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(146, 105);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(201, 22);
            this.tbTelefono.TabIndex = 42;
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(146, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(378, 22);
            this.tbNombre.TabIndex = 41;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.Enabled = false;
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPUCP.Location = new System.Drawing.Point(146, 21);
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.Size = new System.Drawing.Size(201, 22);
            this.tbCodigoPUCP.TabIndex = 39;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(40, 133);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 23);
            this.lblCorreo.TabIndex = 37;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(40, 105);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 36;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(40, 77);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 23);
            this.lblEdad.TabIndex = 35;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 23);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre Completo:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoPUCP
            // 
            this.lblCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPUCP.Location = new System.Drawing.Point(40, 21);
            this.lblCodigoPUCP.Name = "lblCodigoPUCP";
            this.lblCodigoPUCP.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoPUCP.TabIndex = 32;
            this.lblCodigoPUCP.Text = "Codigo PUCP:";
            this.lblCodigoPUCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(11, 189);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(129, 23);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "Tipo de Alumno:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(40, 161);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(100, 23);
            this.lblEspecialidad.TabIndex = 30;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Enabled = false;
            this.tbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEspecialidad.Location = new System.Drawing.Point(146, 161);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(201, 22);
            this.tbEspecialidad.TabIndex = 47;
            // 
            // tbTipoAlumno
            // 
            this.tbTipoAlumno.Enabled = false;
            this.tbTipoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoAlumno.Location = new System.Drawing.Point(146, 189);
            this.tbTipoAlumno.Name = "tbTipoAlumno";
            this.tbTipoAlumno.Size = new System.Drawing.Size(201, 22);
            this.tbTipoAlumno.TabIndex = 48;
            // 
            // rtbNotas
            // 
            this.rtbNotas.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotas.Location = new System.Drawing.Point(12, 273);
            this.rtbNotas.Name = "rtbNotas";
            this.rtbNotas.ReadOnly = true;
            this.rtbNotas.Size = new System.Drawing.Size(524, 205);
            this.rtbNotas.TabIndex = 37;
            this.rtbNotas.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Historial de notas en el presente ciclo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Historial de citas del alumno";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToResizeColumns = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciclo,
            this.Fecha,
            this.Hora,
            this.Estado});
            this.dgvCitas.Location = new System.Drawing.Point(11, 503);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersWidth = 62;
            this.dgvCitas.RowTemplate.Height = 28;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1081, 158);
            this.dgvCitas.TabIndex = 40;
            this.dgvCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCitas_CellFormatting);
            // 
            // Ciclo
            // 
            this.Ciclo.FillWeight = 50F;
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 50;
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 93.27411F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.FillWeight = 93.27411F;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 93.27411F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // rtbPresente
            // 
            this.rtbPresente.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPresente.Location = new System.Drawing.Point(557, 273);
            this.rtbPresente.Name = "rtbPresente";
            this.rtbPresente.ReadOnly = true;
            this.rtbPresente.Size = new System.Drawing.Size(535, 205);
            this.rtbPresente.TabIndex = 41;
            this.rtbPresente.Text = "";
            // 
            // frmInspeccionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 672);
            this.Controls.Add(this.rtbPresente);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbNotas);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInspeccionarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TextBox tbTipoAlumno;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigoPUCP;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoPUCP;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.RichTextBox rtbNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.RichTextBox rtbPresente;
    }
}