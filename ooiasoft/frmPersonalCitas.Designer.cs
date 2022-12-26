
namespace ooiasoft
{
    partial class frmPersonalCitas
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
            this.lblNombrePersonal = new System.Windows.Forms.Label();
            this.lblTipoPersonal = new System.Windows.Forms.Label();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.pbPersonal = new System.Windows.Forms.PictureBox();
            this.lklblCorreo = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePersonal
            // 
            this.lblNombrePersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombrePersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersonal.Location = new System.Drawing.Point(10, 10);
            this.lblNombrePersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePersonal.Name = "lblNombrePersonal";
            this.lblNombrePersonal.Size = new System.Drawing.Size(181, 35);
            this.lblNombrePersonal.TabIndex = 0;
            this.lblNombrePersonal.Text = "Nombre Apellido Personal";
            this.lblNombrePersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoPersonal
            // 
            this.lblTipoPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipoPersonal.Location = new System.Drawing.Point(10, 45);
            this.lblTipoPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPersonal.Name = "lblTipoPersonal";
            this.lblTipoPersonal.Size = new System.Drawing.Size(181, 20);
            this.lblTipoPersonal.TabIndex = 1;
            this.lblTipoPersonal.Text = "Cargo Personal";
            this.lblTipoPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPersonal
            // 
            this.panelPersonal.Controls.Add(this.pbPersonal);
            this.panelPersonal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPersonal.Location = new System.Drawing.Point(191, 10);
            this.panelPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(77, 77);
            this.panelPersonal.TabIndex = 3;
            // 
            // pbPersonal
            // 
            this.pbPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPersonal.Image = global::ooiasoft.Properties.Resources.placeholder;
            this.pbPersonal.Location = new System.Drawing.Point(0, 0);
            this.pbPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.pbPersonal.Name = "pbPersonal";
            this.pbPersonal.Size = new System.Drawing.Size(77, 77);
            this.pbPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonal.TabIndex = 0;
            this.pbPersonal.TabStop = false;
            // 
            // lklblCorreo
            // 
            this.lklblCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lklblCorreo.Location = new System.Drawing.Point(10, 65);
            this.lklblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklblCorreo.Name = "lklblCorreo";
            this.lklblCorreo.Size = new System.Drawing.Size(181, 22);
            this.lklblCorreo.TabIndex = 4;
            this.lklblCorreo.TabStop = true;
            this.lklblCorreo.Text = "Correo Electrónico";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 97);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 97);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 10);
            this.panel4.TabIndex = 7;
            // 
            // frmPersonalCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lklblCorreo);
            this.Controls.Add(this.lblTipoPersonal);
            this.Controls.Add(this.lblNombrePersonal);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPersonalCitas";
            this.Size = new System.Drawing.Size(278, 97);
            this.panelPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePersonal;
        private System.Windows.Forms.Label lblTipoPersonal;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.PictureBox pbPersonal;
        private System.Windows.Forms.LinkLabel lklblCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
