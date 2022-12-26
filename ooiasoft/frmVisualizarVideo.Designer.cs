
namespace ooiasoft
{
    partial class frmVisualizarVideo
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
            this.wbVideo = new System.Windows.Forms.WebBrowser();
            this.textLink = new System.Windows.Forms.TextBox();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wbVideo
            // 
            this.wbVideo.Location = new System.Drawing.Point(52, 66);
            this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVideo.Name = "wbVideo";
            this.wbVideo.Size = new System.Drawing.Size(600, 286);
            this.wbVideo.TabIndex = 0;
            // 
            // textLink
            // 
            this.textLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLink.Location = new System.Drawing.Point(151, 27);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(407, 22);
            this.textLink.TabIndex = 1;
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualizar.Location = new System.Drawing.Point(577, 22);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(75, 33);
            this.buttonVisualizar.TabIndex = 2;
            this.buttonVisualizar.Text = "Visualizar";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(476, 373);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 36);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(577, 373);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 36);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(49, 29);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(96, 16);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Link del Video:";
            // 
            // frmVisualizarVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(724, 413);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVisualizar);
            this.Controls.Add(this.textLink);
            this.Controls.Add(this.wbVideo);
            this.Name = "frmVisualizarVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización del video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbVideo;
        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label lblLink;
    }
}