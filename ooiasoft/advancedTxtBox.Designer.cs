
namespace ooiasoft
{
    partial class advancedTxtBox
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
            this.pnFill1 = new System.Windows.Forms.Panel();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btColores = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btHigh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btItalic = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.pnFill2 = new System.Windows.Forms.Panel();
            this.btFont = new System.Windows.Forms.Button();
            this.rTxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnFill1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFill1
            // 
            this.pnFill1.Controls.Add(this.txtColor);
            this.pnFill1.Controls.Add(this.panel6);
            this.pnFill1.Controls.Add(this.panel5);
            this.pnFill1.Controls.Add(this.panel4);
            this.pnFill1.Controls.Add(this.panel3);
            this.pnFill1.Controls.Add(this.btColores);
            this.pnFill1.Controls.Add(this.btSub);
            this.pnFill1.Controls.Add(this.btHigh);
            this.pnFill1.Controls.Add(this.panel2);
            this.pnFill1.Controls.Add(this.txtSize);
            this.pnFill1.Controls.Add(this.panel1);
            this.pnFill1.Controls.Add(this.txtFont);
            this.pnFill1.Controls.Add(this.pnFill2);
            this.pnFill1.Controls.Add(this.btFont);
            this.pnFill1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFill1.Location = new System.Drawing.Point(0, 0);
            this.pnFill1.Name = "pnFill1";
            this.pnFill1.Size = new System.Drawing.Size(780, 37);
            this.pnFill1.TabIndex = 6;
            // 
            // txtColor
            // 
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColor.Location = new System.Drawing.Point(738, 10);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(31, 20);
            this.txtColor.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(769, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 16);
            this.panel6.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(738, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(42, 11);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(738, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 10);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(727, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 37);
            this.panel3.TabIndex = 10;
            // 
            // btColores
            // 
            this.btColores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btColores.ForeColor = System.Drawing.Color.Blue;
            this.btColores.Location = new System.Drawing.Point(550, 0);
            this.btColores.Name = "btColores";
            this.btColores.Size = new System.Drawing.Size(177, 37);
            this.btColores.TabIndex = 1;
            this.btColores.Text = "Paleta de Colores";
            this.btColores.UseVisualStyleBackColor = true;
            this.btColores.Click += new System.EventHandler(this.btColores_Click);
            // 
            // btSub
            // 
            this.btSub.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(490, 0);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(60, 37);
            this.btSub.TabIndex = 2;
            this.btSub.Text = "S";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btHigh
            // 
            this.btHigh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHigh.Location = new System.Drawing.Point(430, 0);
            this.btHigh.Name = "btHigh";
            this.btHigh.Size = new System.Drawing.Size(60, 37);
            this.btHigh.TabIndex = 3;
            this.btHigh.Text = "A";
            this.btHigh.UseVisualStyleBackColor = true;
            this.btHigh.Click += new System.EventHandler(this.btHigh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btItalic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 37);
            this.panel2.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(21, 37);
            this.panel7.TabIndex = 9;
            // 
            // btItalic
            // 
            this.btItalic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btItalic.Location = new System.Drawing.Point(22, 0);
            this.btItalic.Name = "btItalic";
            this.btItalic.Size = new System.Drawing.Size(61, 37);
            this.btItalic.TabIndex = 4;
            this.btItalic.Text = "I";
            this.btItalic.UseVisualStyleBackColor = true;
            this.btItalic.Click += new System.EventHandler(this.btItalic_Click);
            // 
            // txtSize
            // 
            this.txtSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(293, 0);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(54, 37);
            this.txtSize.TabIndex = 6;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 37);
            this.panel1.TabIndex = 8;
            // 
            // txtFont
            // 
            this.txtFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFont.Enabled = false;
            this.txtFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFont.Location = new System.Drawing.Point(136, 0);
            this.txtFont.Multiline = true;
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(145, 37);
            this.txtFont.TabIndex = 5;
            this.txtFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnFill2
            // 
            this.pnFill2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFill2.Location = new System.Drawing.Point(114, 0);
            this.pnFill2.Name = "pnFill2";
            this.pnFill2.Size = new System.Drawing.Size(22, 37);
            this.pnFill2.TabIndex = 7;
            // 
            // btFont
            // 
            this.btFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.btFont.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFont.Location = new System.Drawing.Point(0, 0);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(114, 37);
            this.btFont.TabIndex = 4;
            this.btFont.Text = "FontStyles";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // rTxtDescripcion
            // 
            this.rTxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtDescripcion.Location = new System.Drawing.Point(0, 37);
            this.rTxtDescripcion.Name = "rTxtDescripcion";
            this.rTxtDescripcion.Size = new System.Drawing.Size(780, 332);
            this.rTxtDescripcion.TabIndex = 7;
            this.rTxtDescripcion.Text = "";
            // 
            // advancedTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rTxtDescripcion);
            this.Controls.Add(this.pnFill1);
            this.Name = "advancedTxtBox";
            this.Size = new System.Drawing.Size(780, 369);
            this.pnFill1.ResumeLayout(false);
            this.pnFill1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFill1;
        private System.Windows.Forms.RichTextBox rTxtDescripcion;
        private System.Windows.Forms.Button btColores;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Button btHigh;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Panel pnFill2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btItalic;
    }
}
