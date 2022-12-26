
namespace ooiasoft
{
    partial class frmAgregarInformacion
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
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbDescripcion = new ooiasoft.BeautyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVisible = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo de la información:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(250, 20);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(303, 22);
            this.tbTitulo.TabIndex = 2;
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::ooiasoft.Properties.Resources.imagen;
            this.pbImagen.Location = new System.Drawing.Point(795, 22);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(282, 267);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(860, 308);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(154, 23);
            this.btUpload.TabIndex = 4;
            this.btUpload.Text = "Subir Imagen";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(795, 356);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(130, 23);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(947, 356);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(29, 103);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.RTF = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Microsoft Sans Serif;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\par" +
    "d\\f0\\fs17\\par\r\n}\r\n";
            this.tbDescripcion.Size = new System.Drawing.Size(744, 259);
            this.tbDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Visibilidad a partir de:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpVisible
            // 
            this.dtpVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisible.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisible.Location = new System.Drawing.Point(250, 50);
            this.dtpVisible.Name = "dtpVisible";
            this.dtpVisible.Size = new System.Drawing.Size(119, 22);
            this.dtpVisible.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAgregarInformacion
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1105, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVisible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgregarInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Informacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog buscador;
        private BeautyTextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVisible;
        private System.Windows.Forms.Label label3;
    }
}