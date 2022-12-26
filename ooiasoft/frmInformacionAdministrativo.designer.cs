
namespace ooiasoft
{
    partial class frmInformacionAdministrativo
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
            this.components = new System.ComponentModel.Container();
            this.panelFill1 = new System.Windows.Forms.Panel();
            this.lblI = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.cbCiclos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFill2 = new System.Windows.Forms.Panel();
            this.panelFill3 = new System.Windows.Forms.Panel();
            this.panelFill4 = new System.Windows.Forms.Panel();
            this.scFirst = new System.Windows.Forms.SplitContainer();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.btAgregarTema = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.scSecond = new System.Windows.Forms.SplitContainer();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.panelFill1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scFirst)).BeginInit();
            this.scFirst.Panel1.SuspendLayout();
            this.scFirst.Panel2.SuspendLayout();
            this.scFirst.SuspendLayout();
            this.panelTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSecond)).BeginInit();
            this.scSecond.Panel2.SuspendLayout();
            this.scSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill1
            // 
            this.panelFill1.Controls.Add(this.lblI);
            this.panelFill1.Controls.Add(this.lblCiclo);
            this.panelFill1.Controls.Add(this.cbCiclos);
            this.panelFill1.Controls.Add(this.panel3);
            this.panelFill1.Controls.Add(this.panel2);
            this.panelFill1.Controls.Add(this.panel1);
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill1.Location = new System.Drawing.Point(0, 0);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Size = new System.Drawing.Size(1243, 60);
            this.panelFill1.TabIndex = 0;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(18, 28);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(217, 16);
            this.lblI.TabIndex = 0;
            this.lblI.Text = "Doble Click en el Tema para Editar";
            // 
            // lblCiclo
            // 
            this.lblCiclo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(1029, 25);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(41, 22);
            this.lblCiclo.TabIndex = 7;
            this.lblCiclo.Text = "Ciclo: ";
            this.lblCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCiclos
            // 
            this.cbCiclos.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCiclos.FormattingEnabled = true;
            this.cbCiclos.Location = new System.Drawing.Point(1070, 25);
            this.cbCiclos.Name = "cbCiclos";
            this.cbCiclos.Size = new System.Drawing.Size(111, 21);
            this.cbCiclos.TabIndex = 6;
            this.cbCiclos.SelectedIndexChanged += new System.EventHandler(this.cbCiclos_SelectedIndexChanged);
            this.cbCiclos.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbCiclos_Format);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1181, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 22);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 13);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 25);
            this.panel1.TabIndex = 1;
            // 
            // panelFill2
            // 
            this.panelFill2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFill2.Location = new System.Drawing.Point(0, 691);
            this.panelFill2.Name = "panelFill2";
            this.panelFill2.Size = new System.Drawing.Size(1243, 20);
            this.panelFill2.TabIndex = 3;
            // 
            // panelFill3
            // 
            this.panelFill3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFill3.Location = new System.Drawing.Point(0, 60);
            this.panelFill3.Name = "panelFill3";
            this.panelFill3.Size = new System.Drawing.Size(20, 631);
            this.panelFill3.TabIndex = 4;
            // 
            // panelFill4
            // 
            this.panelFill4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFill4.Location = new System.Drawing.Point(1223, 60);
            this.panelFill4.Name = "panelFill4";
            this.panelFill4.Size = new System.Drawing.Size(20, 631);
            this.panelFill4.TabIndex = 5;
            // 
            // scFirst
            // 
            this.scFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFirst.IsSplitterFixed = true;
            this.scFirst.Location = new System.Drawing.Point(20, 60);
            this.scFirst.Name = "scFirst";
            // 
            // scFirst.Panel1
            // 
            this.scFirst.Panel1.Controls.Add(this.panelTemas);
            // 
            // scFirst.Panel2
            // 
            this.scFirst.Panel2.Controls.Add(this.scSecond);
            this.scFirst.Size = new System.Drawing.Size(1203, 631);
            this.scFirst.SplitterDistance = 272;
            this.scFirst.TabIndex = 6;
            // 
            // panelTemas
            // 
            this.panelTemas.AutoScroll = true;
            this.panelTemas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTemas.Controls.Add(this.btAgregarTema);
            this.panelTemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemas.Location = new System.Drawing.Point(0, 0);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(272, 631);
            this.panelTemas.TabIndex = 1;
            // 
            // btAgregarTema
            // 
            this.btAgregarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(205)))), ((int)(((byte)(92)))));
            this.btAgregarTema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAgregarTema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregarTema.ImageList = this.imageList1;
            this.btAgregarTema.Location = new System.Drawing.Point(0, 583);
            this.btAgregarTema.Name = "btAgregarTema";
            this.btAgregarTema.Size = new System.Drawing.Size(270, 46);
            this.btAgregarTema.TabIndex = 0;
            this.btAgregarTema.Text = "Agregar Tema (+)";
            this.btAgregarTema.UseVisualStyleBackColor = false;
            this.btAgregarTema.Click += new System.EventHandler(this.btAgregarTema_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Silver;
            // 
            // scSecond
            // 
            this.scSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSecond.IsSplitterFixed = true;
            this.scSecond.Location = new System.Drawing.Point(0, 0);
            this.scSecond.Name = "scSecond";
            // 
            // scSecond.Panel2
            // 
            this.scSecond.Panel2.Controls.Add(this.panelInformacion);
            this.scSecond.Size = new System.Drawing.Size(927, 631);
            this.scSecond.SplitterDistance = 82;
            this.scSecond.TabIndex = 0;
            // 
            // panelInformacion
            // 
            this.panelInformacion.AutoScroll = true;
            this.panelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformacion.Location = new System.Drawing.Point(0, 0);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(841, 631);
            this.panelInformacion.TabIndex = 0;
            // 
            // frmInformacionAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1243, 711);
            this.Controls.Add(this.scFirst);
            this.Controls.Add(this.panelFill4);
            this.Controls.Add(this.panelFill3);
            this.Controls.Add(this.panelFill2);
            this.Controls.Add(this.panelFill1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformacionAdministrativo";
            this.Text = "Form1";
            this.panelFill1.ResumeLayout(false);
            this.panelFill1.PerformLayout();
            this.scFirst.Panel1.ResumeLayout(false);
            this.scFirst.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFirst)).EndInit();
            this.scFirst.ResumeLayout(false);
            this.panelTemas.ResumeLayout(false);
            this.scSecond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSecond)).EndInit();
            this.scSecond.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill1;
        private System.Windows.Forms.Panel panelFill2;
        private System.Windows.Forms.Panel panelFill3;
        private System.Windows.Forms.Panel panelFill4;
        private System.Windows.Forms.SplitContainer scFirst;
        private System.Windows.Forms.SplitContainer scSecond;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Panel panelTemas;
        private System.Windows.Forms.Button btAgregarTema;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCiclos;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblI;
    }
}