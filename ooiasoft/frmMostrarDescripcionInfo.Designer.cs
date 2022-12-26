
namespace ooiasoft
{
    partial class frmMostrarDescripcionInfo
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scMid = new System.Windows.Forms.SplitContainer();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scMid)).BeginInit();
            this.scMid.Panel1.SuspendLayout();
            this.scMid.Panel2.SuspendLayout();
            this.scMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 16);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 16);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1112, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 306);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 306);
            this.panel3.TabIndex = 5;
            // 
            // scMid
            // 
            this.scMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMid.Location = new System.Drawing.Point(14, 16);
            this.scMid.Name = "scMid";
            // 
            // scMid.Panel1
            // 
            this.scMid.Panel1.Controls.Add(this.pbImagen);
            // 
            // scMid.Panel2
            // 
            this.scMid.Panel2.Controls.Add(this.rtbDescripcion);
            this.scMid.Panel2.Controls.Add(this.panel5);
            this.scMid.Size = new System.Drawing.Size(1098, 306);
            this.scMid.SplitterDistance = 321;
            this.scMid.TabIndex = 6;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Image = global::ooiasoft.Properties.Resources.imagen;
            this.pbImagen.Location = new System.Drawing.Point(0, 0);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(321, 306);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescripcion.Location = new System.Drawing.Point(14, 0);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(759, 306);
            this.rtbDescripcion.TabIndex = 7;
            this.rtbDescripcion.Text = "";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 306);
            this.panel5.TabIndex = 6;
            // 
            // frmMostrarDescripcionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMostrarDescripcionInfo";
            this.Size = new System.Drawing.Size(1126, 338);
            this.scMid.Panel1.ResumeLayout(false);
            this.scMid.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMid)).EndInit();
            this.scMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer scMid;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
    }
}
