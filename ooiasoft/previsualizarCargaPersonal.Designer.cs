
namespace ooiasoft
{
    partial class previsualizarCargaPersonal
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
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AllowUserToResizeColumns = false;
            this.dgvPersonal.AllowUserToResizeRows = false;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTipo,
            this.ColCodigo,
            this.ColNombres,
            this.ColEdad,
            this.ColTelefono,
            this.ColCorreo});
            this.dgvPersonal.Location = new System.Drawing.Point(50, 84);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(1026, 427);
            this.dgvPersonal.TabIndex = 2;
            this.dgvPersonal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPersonal_CellFormatting);
            // 
            // ColTipo
            // 
            this.ColTipo.FillWeight = 189.0946F;
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.MinimumWidth = 70;
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColCodigo
            // 
            this.ColCodigo.FillWeight = 55.97922F;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 100;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            // 
            // ColNombres
            // 
            this.ColNombres.FillWeight = 238.523F;
            this.ColNombres.HeaderText = "Nombres";
            this.ColNombres.MinimumWidth = 300;
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.ReadOnly = true;
            // 
            // ColEdad
            // 
            this.ColEdad.FillWeight = 19.84515F;
            this.ColEdad.HeaderText = "Edad";
            this.ColEdad.MinimumWidth = 60;
            this.ColEdad.Name = "ColEdad";
            this.ColEdad.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.FillWeight = 54.0033F;
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.MinimumWidth = 120;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.FillWeight = 69.07514F;
            this.ColCorreo.HeaderText = "Correo";
            this.ColCorreo.MinimumWidth = 300;
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(955, 540);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(811, 540);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(50, 540);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Fila Seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(47, 42);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(210, 16);
            this.lblNro.TabIndex = 8;
            this.lblNro.Text = "Cantidad de Personal a Registrar:";
            this.lblNro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(263, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previsualizarCargaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1127, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "previsualizarCargaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previsualizacion de Carga de Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label label2;
    }
}