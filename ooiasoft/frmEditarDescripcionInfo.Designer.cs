
namespace ooiasoft
{
    partial class frmEditarDescripcionInfo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.scMid = new System.Windows.Forms.SplitContainer();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btImagen = new System.Windows.Forms.Button();
            this.tbDescripcion = new ooiasoft.BeautyTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtpVisible = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.scMid)).BeginInit();
            this.scMid.Panel1.SuspendLayout();
            this.scMid.Panel2.SuspendLayout();
            this.scMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 318);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1112, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 318);
            this.panel4.TabIndex = 3;
            // 
            // scMid
            // 
            this.scMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMid.Location = new System.Drawing.Point(14, 10);
            this.scMid.Name = "scMid";
            // 
            // scMid.Panel1
            // 
            this.scMid.Panel1.Controls.Add(this.pbImagen);
            this.scMid.Panel1.Controls.Add(this.panel5);
            this.scMid.Panel1.Controls.Add(this.btImagen);
            // 
            // scMid.Panel2
            // 
            this.scMid.Panel2.Controls.Add(this.tbDescripcion);
            this.scMid.Panel2.Controls.Add(this.panel8);
            this.scMid.Panel2.Controls.Add(this.panel7);
            this.scMid.Panel2.Controls.Add(this.panel6);
            this.scMid.Size = new System.Drawing.Size(1098, 318);
            this.scMid.SplitterDistance = 297;
            this.scMid.TabIndex = 4;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Image = global::ooiasoft.Properties.Resources.imagen;
            this.pbImagen.Location = new System.Drawing.Point(0, 0);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(297, 269);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 16);
            this.panel5.TabIndex = 2;
            // 
            // btImagen
            // 
            this.btImagen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImagen.Location = new System.Drawing.Point(0, 285);
            this.btImagen.Name = "btImagen";
            this.btImagen.Size = new System.Drawing.Size(297, 33);
            this.btImagen.TabIndex = 0;
            this.btImagen.Text = "Subir Imagen";
            this.btImagen.UseVisualStyleBackColor = true;
            this.btImagen.Click += new System.EventHandler(this.btImagen_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescripcion.Location = new System.Drawing.Point(14, 0);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.RTF = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Microsoft Sans Serif;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\par" +
    "d\\f0\\fs17\\par\r\n}\r\n";
            this.tbDescripcion.Size = new System.Drawing.Size(783, 285);
            this.tbDescripcion.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(14, 285);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(783, 10);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btGuardar);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(14, 295);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(783, 23);
            this.panel7.TabIndex = 4;
            // 
            // btGuardar
            // 
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(526, 0);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(97, 23);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btEliminar);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(623, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(160, 23);
            this.panel10.TabIndex = 4;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(59, 0);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(101, 23);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtpVisible);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 23);
            this.panel9.TabIndex = 3;
            // 
            // dtpVisible
            // 
            this.dtpVisible.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisible.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisible.Location = new System.Drawing.Point(100, 0);
            this.dtpVisible.Name = "dtpVisible";
            this.dtpVisible.Size = new System.Drawing.Size(138, 22);
            this.dtpVisible.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Visible:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 318);
            this.panel6.TabIndex = 3;
            // 
            // frmEditarDescripcionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditarDescripcionInfo";
            this.Size = new System.Drawing.Size(1126, 338);
            this.scMid.Panel1.ResumeLayout(false);
            this.scMid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMid)).EndInit();
            this.scMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer scMid;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btImagen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Panel panel9;
        private BeautyTextBox tbDescripcion;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DateTimePicker dtpVisible;
        private System.Windows.Forms.Label label1;
    }
}
