
namespace ooiasoft
{
    partial class frmAgregarModificarPsicologo
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCodigoPUCP = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblColegiatura = new System.Windows.Forms.Label();
            this.tbColegiatura = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCodigoPUCP = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.gbCredenciales = new System.Windows.Forms.GroupBox();
            this.lblConfirmacionCredenciales = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFormatosFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            this.gbCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGenerar
            // 
            this.btGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(369, 52);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(65, 23);
            this.btGenerar.TabIndex = 129;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(718, 407);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 32);
            this.btCancelar.TabIndex = 128;
            this.btCancelar.Text = "Volver";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(588, 406);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(92, 33);
            this.btGuardar.TabIndex = 127;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btFoto
            // 
            this.btFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFoto.Location = new System.Drawing.Point(633, 340);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(123, 33);
            this.btFoto.TabIndex = 126;
            this.btFoto.Text = "Subir Foto ";
            this.btFoto.UseVisualStyleBackColor = true;
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // tbEdad
            // 
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(174, 186);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(66, 22);
            this.tbEdad.TabIndex = 124;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(171, 53);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(165, 22);
            this.tbPassword.TabIndex = 122;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(171, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(165, 22);
            this.tbUsuario.TabIndex = 121;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(174, 266);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(165, 22);
            this.tbCorreo.TabIndex = 120;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(174, 239);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(165, 22);
            this.tbTelefono.TabIndex = 119;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(250, 214);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(57, 19);
            this.rbMujer.TabIndex = 118;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHombre.Location = new System.Drawing.Point(174, 214);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(70, 19);
            this.rbHombre.TabIndex = 117;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(174, 158);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(117, 22);
            this.dtpFechaNacimiento.TabIndex = 116;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(174, 71);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(165, 22);
            this.tbDNI.TabIndex = 114;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPUCP.Location = new System.Drawing.Point(174, 43);
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.Size = new System.Drawing.Size(165, 22);
            this.tbCodigoPUCP.TabIndex = 113;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(186, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 112;
            // 
            // lblColegiatura
            // 
            this.lblColegiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColegiatura.Location = new System.Drawing.Point(14, 294);
            this.lblColegiatura.Name = "lblColegiatura";
            this.lblColegiatura.Size = new System.Drawing.Size(151, 23);
            this.lblColegiatura.TabIndex = 101;
            this.lblColegiatura.Text = "Número de Colegiatura:";
            this.lblColegiatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColegiatura
            // 
            this.tbColegiatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColegiatura.Location = new System.Drawing.Point(174, 295);
            this.tbColegiatura.Name = "tbColegiatura";
            this.tbColegiatura.Size = new System.Drawing.Size(165, 22);
            this.tbColegiatura.TabIndex = 130;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::ooiasoft.Properties.Resources.user1;
            this.pbFoto.Location = new System.Drawing.Point(560, 42);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(270, 270);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 125;
            this.pbFoto.TabStop = false;
            // 
            // buscador
            // 
            this.buscador.FileName = "buscador";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(65, 266);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 23);
            this.lblCorreo.TabIndex = 139;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(65, 238);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 138;
            this.lblTelefono.Text = "Celular:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(65, 213);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(100, 23);
            this.lblSexo.TabIndex = 137;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(68, 185);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 23);
            this.lblEdad.TabIndex = 136;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(23, 157);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(145, 23);
            this.lblFechaNacimiento.TabIndex = 135;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(68, 70);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(100, 23);
            this.lblDNI.TabIndex = 133;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoPUCP
            // 
            this.lblCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPUCP.Location = new System.Drawing.Point(68, 42);
            this.lblCodigoPUCP.Name = "lblCodigoPUCP";
            this.lblCodigoPUCP.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoPUCP.TabIndex = 132;
            this.lblCodigoPUCP.Text = "Codigo PUCP:";
            this.lblCodigoPUCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(143, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 23);
            this.lblID.TabIndex = 131;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(83, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 23);
            this.lblUsuario.TabIndex = 140;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(83, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 23);
            this.lblPassword.TabIndex = 141;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tbNombres);
            this.gbDatosPersonales.Controls.Add(this.lblNombres);
            this.gbDatosPersonales.Controls.Add(this.tbApellidos);
            this.gbDatosPersonales.Controls.Add(this.lblApellidos);
            this.gbDatosPersonales.Controls.Add(this.lblCorreo);
            this.gbDatosPersonales.Controls.Add(this.tbCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.tbDNI);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.lblEdad);
            this.gbDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.tbEdad);
            this.gbDatosPersonales.Controls.Add(this.lblColegiatura);
            this.gbDatosPersonales.Controls.Add(this.rbHombre);
            this.gbDatosPersonales.Controls.Add(this.lblDNI);
            this.gbDatosPersonales.Controls.Add(this.rbMujer);
            this.gbDatosPersonales.Controls.Add(this.lblCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.tbCorreo);
            this.gbDatosPersonales.Controls.Add(this.tbColegiatura);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 8);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(505, 329);
            this.gbDatosPersonales.TabIndex = 142;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = " Datos Personales ";
            // 
            // tbNombres
            // 
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.Location = new System.Drawing.Point(174, 99);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(310, 22);
            this.tbNombres.TabIndex = 145;
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(39, 99);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 23);
            this.lblNombres.TabIndex = 144;
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(174, 127);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(310, 22);
            this.tbApellidos.TabIndex = 147;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(39, 127);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(129, 23);
            this.lblApellidos.TabIndex = 146;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCredenciales
            // 
            this.gbCredenciales.Controls.Add(this.lblConfirmacionCredenciales);
            this.gbCredenciales.Controls.Add(this.tbPassword);
            this.gbCredenciales.Controls.Add(this.lblPassword);
            this.gbCredenciales.Controls.Add(this.btGenerar);
            this.gbCredenciales.Controls.Add(this.tbUsuario);
            this.gbCredenciales.Controls.Add(this.lblUsuario);
            this.gbCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCredenciales.Location = new System.Drawing.Point(12, 343);
            this.gbCredenciales.Name = "gbCredenciales";
            this.gbCredenciales.Size = new System.Drawing.Size(505, 96);
            this.gbCredenciales.TabIndex = 143;
            this.gbCredenciales.TabStop = false;
            this.gbCredenciales.Text = " Credenciales ";
            // 
            // lblConfirmacionCredenciales
            // 
            this.lblConfirmacionCredenciales.AutoSize = true;
            this.lblConfirmacionCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionCredenciales.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmacionCredenciales.Location = new System.Drawing.Point(124, 80);
            this.lblConfirmacionCredenciales.Name = "lblConfirmacionCredenciales";
            this.lblConfirmacionCredenciales.Size = new System.Drawing.Size(310, 13);
            this.lblConfirmacionCredenciales.TabIndex = 155;
            this.lblConfirmacionCredenciales.Text = "Sus credenciales se han generado satisfactoriamente";
            this.lblConfirmacionCredenciales.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(560, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 27);
            this.btnEditar.TabIndex = 144;
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
            this.lblFormatosFoto.Location = new System.Drawing.Point(569, 314);
            this.lblFormatosFoto.Name = "lblFormatosFoto";
            this.lblFormatosFoto.Size = new System.Drawing.Size(250, 13);
            this.lblFormatosFoto.TabIndex = 155;
            this.lblFormatosFoto.Text = "Los formatos permitidos para la foto son JPG y PNG";
            // 
            // frmAgregarModificarPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 446);
            this.Controls.Add(this.lblFormatosFoto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbCredenciales);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.gbDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgregarModificarPsicologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Psicólogo";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbCredenciales.ResumeLayout(false);
            this.gbCredenciales.PerformLayout();
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
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCodigoPUCP;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblColegiatura;
        private System.Windows.Forms.TextBox tbColegiatura;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCodigoPUCP;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbCredenciales;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblConfirmacionCredenciales;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFormatosFoto;
    }
}