
namespace ooiasoft
{
    partial class frmNuevoPersonal
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
            this.panelTipo = new System.Windows.Forms.Panel();
            this.rbPsicologo = new System.Windows.Forms.RadioButton();
            this.rbTutor = new System.Windows.Forms.RadioButton();
            this.rbAdministrativo = new System.Windows.Forms.RadioButton();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTipo
            // 
            this.panelTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo.Controls.Add(this.rbPsicologo);
            this.panelTipo.Controls.Add(this.rbTutor);
            this.panelTipo.Controls.Add(this.rbAdministrativo);
            this.panelTipo.Location = new System.Drawing.Point(33, 108);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(200, 100);
            this.panelTipo.TabIndex = 1;
            // 
            // rbPsicologo
            // 
            this.rbPsicologo.AutoSize = true;
            this.rbPsicologo.Location = new System.Drawing.Point(50, 70);
            this.rbPsicologo.Name = "rbPsicologo";
            this.rbPsicologo.Size = new System.Drawing.Size(71, 17);
            this.rbPsicologo.TabIndex = 2;
            this.rbPsicologo.TabStop = true;
            this.rbPsicologo.Text = "Psicólogo";
            this.rbPsicologo.UseVisualStyleBackColor = true;
            // 
            // rbTutor
            // 
            this.rbTutor.AutoSize = true;
            this.rbTutor.Location = new System.Drawing.Point(50, 40);
            this.rbTutor.Name = "rbTutor";
            this.rbTutor.Size = new System.Drawing.Size(50, 17);
            this.rbTutor.TabIndex = 1;
            this.rbTutor.TabStop = true;
            this.rbTutor.Text = "Tutor";
            this.rbTutor.UseVisualStyleBackColor = true;
            // 
            // rbAdministrativo
            // 
            this.rbAdministrativo.AutoSize = true;
            this.rbAdministrativo.Location = new System.Drawing.Point(50, 9);
            this.rbAdministrativo.Name = "rbAdministrativo";
            this.rbAdministrativo.Size = new System.Drawing.Size(90, 17);
            this.rbAdministrativo.TabIndex = 0;
            this.rbAdministrativo.TabStop = true;
            this.rbAdministrativo.Text = "Administrativo";
            this.rbAdministrativo.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(200, 66);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Seleccione el tipo de personal que desea registrar";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(49, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(141, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(263, 277);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panelTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección del tipo de personal";
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.RadioButton rbPsicologo;
        private System.Windows.Forms.RadioButton rbTutor;
        private System.Windows.Forms.RadioButton rbAdministrativo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}