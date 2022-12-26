
namespace ooiasoft
{
    partial class frmConfiguracionCuenta
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Enabled = false;
            this.tbUser.Location = new System.Drawing.Point(128, 145);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(188, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(128, 182);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.PasswordChar = '*';
            this.tbOldPass.Size = new System.Drawing.Size(188, 20);
            this.tbOldPass.TabIndex = 2;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(128, 219);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(188, 20);
            this.tbNewPass.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(75, 149);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 186);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(11, 222);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(111, 13);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Confirmar Contraseña:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(128, 262);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(62, 25);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Actualizar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConfirm_MouseClick);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::ooiasoft.Properties.Resources.user;
            this.pbFoto.Location = new System.Drawing.Point(121, 11);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(120, 117);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // frmConfiguracionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(343, 310);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfiguracionCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de la Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnConfirm;
    }
}