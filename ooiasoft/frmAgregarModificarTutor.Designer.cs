
namespace ooiasoft
{
    partial class frmAgregarModificarTutor
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
            this.btGenerar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btFoto = new System.Windows.Forms.Button();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCodigoPUCP = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFechaAsociacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAsociacion = new System.Windows.Forms.Label();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConfirmacionCredenciales = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFormatosFoto = new System.Windows.Forms.Label();
            this.gbDatosPersonales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(368, 57);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(72, 22);
            this.btGenerar.TabIndex = 97;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(712, 436);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(109, 32);
            this.btCancelar.TabIndex = 96;
            this.btCancelar.Text = "Volver";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(572, 435);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(115, 33);
            this.btGuardar.TabIndex = 95;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btFoto
            // 
            this.btFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFoto.Location = new System.Drawing.Point(637, 335);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(140, 33);
            this.btFoto.TabIndex = 94;
            this.btFoto.Text = "Subir Foto ";
            this.btFoto.UseVisualStyleBackColor = true;
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(179, 189);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(66, 22);
            this.tbEdad.TabIndex = 92;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(179, 302);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(165, 24);
            this.cbEspecialidad.TabIndex = 91;
            this.cbEspecialidad.Text = "Seleccionar";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(179, 57);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(165, 22);
            this.tbPassword.TabIndex = 90;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(179, 29);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(165, 22);
            this.tbUsuario.TabIndex = 89;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(179, 270);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(165, 22);
            this.tbCorreo.TabIndex = 88;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(179, 242);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(165, 22);
            this.tbTelefono.TabIndex = 87;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(257, 217);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(57, 19);
            this.rbMujer.TabIndex = 86;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHombre.Location = new System.Drawing.Point(179, 217);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(70, 19);
            this.rbHombre.TabIndex = 85;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(179, 163);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(118, 22);
            this.dateFecha.TabIndex = 84;
            this.dateFecha.ValueChanged += new System.EventHandler(this.dateFecha_ValueChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(179, 77);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(165, 22);
            this.tbDNI.TabIndex = 82;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPUCP.Location = new System.Drawing.Point(179, 49);
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.Size = new System.Drawing.Size(165, 22);
            this.tbCodigoPUCP.TabIndex = 81;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(179, 21);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 23);
            this.label14.TabIndex = 79;
            this.label14.Text = "Password:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 23);
            this.label13.TabIndex = 78;
            this.label13.Text = "Usuario:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 23);
            this.label12.TabIndex = 77;
            this.label12.Text = "Correo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 76;
            this.label11.Text = "Celular:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 75;
            this.label10.Text = "Sexo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 74;
            this.label9.Text = "Edad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 73;
            this.label8.Text = "Fecha de Nacimiento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "DNI:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Codigo PUCP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(33, 302);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(140, 23);
            this.lblEspecialidad.TabIndex = 69;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateFechaAsociacion
            // 
            this.dateFechaAsociacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAsociacion.Location = new System.Drawing.Point(179, 333);
            this.dateFechaAsociacion.Name = "dateFechaAsociacion";
            this.dateFechaAsociacion.Size = new System.Drawing.Size(118, 22);
            this.dateFechaAsociacion.TabIndex = 99;
            // 
            // lblFechaAsociacion
            // 
            this.lblFechaAsociacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAsociacion.Location = new System.Drawing.Point(33, 333);
            this.lblFechaAsociacion.Name = "lblFechaAsociacion";
            this.lblFechaAsociacion.Size = new System.Drawing.Size(140, 23);
            this.lblFechaAsociacion.TabIndex = 98;
            this.lblFechaAsociacion.Text = "Fecha de Asociación:";
            this.lblFechaAsociacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buscador
            // 
            this.buscador.FileName = "buscador";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tbNombres);
            this.gbDatosPersonales.Controls.Add(this.lblNombres);
            this.gbDatosPersonales.Controls.Add(this.tbApellidos);
            this.gbDatosPersonales.Controls.Add(this.lblApellidos);
            this.gbDatosPersonales.Controls.Add(this.tbCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.dateFechaAsociacion);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Controls.Add(this.lblFechaAsociacion);
            this.gbDatosPersonales.Controls.Add(this.lblEspecialidad);
            this.gbDatosPersonales.Controls.Add(this.label5);
            this.gbDatosPersonales.Controls.Add(this.tbEdad);
            this.gbDatosPersonales.Controls.Add(this.label6);
            this.gbDatosPersonales.Controls.Add(this.cbEspecialidad);
            this.gbDatosPersonales.Controls.Add(this.label8);
            this.gbDatosPersonales.Controls.Add(this.label9);
            this.gbDatosPersonales.Controls.Add(this.tbCorreo);
            this.gbDatosPersonales.Controls.Add(this.label10);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.label11);
            this.gbDatosPersonales.Controls.Add(this.rbMujer);
            this.gbDatosPersonales.Controls.Add(this.label12);
            this.gbDatosPersonales.Controls.Add(this.rbHombre);
            this.gbDatosPersonales.Controls.Add(this.tbID);
            this.gbDatosPersonales.Controls.Add(this.dateFecha);
            this.gbDatosPersonales.Controls.Add(this.tbDNI);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(527, 369);
            this.gbDatosPersonales.TabIndex = 100;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // tbNombres
            // 
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.Location = new System.Drawing.Point(179, 105);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(310, 22);
            this.tbNombres.TabIndex = 145;
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(44, 105);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 23);
            this.lblNombres.TabIndex = 144;
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(179, 133);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(310, 22);
            this.tbApellidos.TabIndex = 147;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(44, 133);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(129, 23);
            this.lblApellidos.TabIndex = 146;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConfirmacionCredenciales);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btGenerar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 113);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // lblConfirmacionCredenciales
            // 
            this.lblConfirmacionCredenciales.AutoSize = true;
            this.lblConfirmacionCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionCredenciales.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmacionCredenciales.Location = new System.Drawing.Point(130, 89);
            this.lblConfirmacionCredenciales.Name = "lblConfirmacionCredenciales";
            this.lblConfirmacionCredenciales.Size = new System.Drawing.Size(310, 13);
            this.lblConfirmacionCredenciales.TabIndex = 155;
            this.lblConfirmacionCredenciales.Text = "Sus credenciales se han generado satisfactoriamente";
            this.lblConfirmacionCredenciales.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::ooiasoft.Properties.Resources.user2;
            this.pbFoto.Location = new System.Drawing.Point(560, 42);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(270, 262);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 93;
            this.pbFoto.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(560, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 27);
            this.btnEditar.TabIndex = 145;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblFormatosFoto
            // 
            this.lblFormatosFoto.AutoSize = true;
            this.lblFormatosFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFormatosFoto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblFormatosFoto.Location = new System.Drawing.Point(569, 307);
            this.lblFormatosFoto.Name = "lblFormatosFoto";
            this.lblFormatosFoto.Size = new System.Drawing.Size(250, 13);
            this.lblFormatosFoto.TabIndex = 155;
            this.lblFormatosFoto.Text = "Los formatos permitidos para la foto son JPG y PNG";
            // 
            // frmAgregarModificarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 512);
            this.Controls.Add(this.lblFormatosFoto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btFoto);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgregarModificarTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Tutor";
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCodigoPUCP;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFechaAsociacion;
        private System.Windows.Forms.Label lblFechaAsociacion;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblConfirmacionCredenciales;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFormatosFoto;
    }
}