
namespace ooiasoft
{
    partial class frmVerEditarAlumno
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
            this.btFoto = new System.Windows.Forms.Button();
            this.cbTipoAlumno = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCodigoPUCP = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCodigoPUCP = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbCredenciales = new System.Windows.Forms.GroupBox();
            this.lblConfirmacionCredenciales = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.OpenFileDialog();
            this.lblFormatosFoto = new System.Windows.Forms.Label();
            this.nudEscala = new System.Windows.Forms.NumericUpDown();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            this.gbCredenciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerar
            // 
            this.btGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(360, 55);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(69, 22);
            this.btGenerar.TabIndex = 67;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // btFoto
            // 
            this.btFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFoto.Location = new System.Drawing.Point(634, 356);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(123, 33);
            this.btFoto.TabIndex = 64;
            this.btFoto.Text = "Subir Foto";
            this.btFoto.UseVisualStyleBackColor = true;
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // cbTipoAlumno
            // 
            this.cbTipoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoAlumno.FormattingEnabled = true;
            this.cbTipoAlumno.Location = new System.Drawing.Point(174, 362);
            this.cbTipoAlumno.Name = "cbTipoAlumno";
            this.cbTipoAlumno.Size = new System.Drawing.Size(165, 24);
            this.cbTipoAlumno.TabIndex = 59;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(174, 55);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(165, 22);
            this.tbPassword.TabIndex = 58;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(174, 270);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(165, 22);
            this.tbCorreo.TabIndex = 56;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(174, 241);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(165, 22);
            this.tbTelefono.TabIndex = 55;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(250, 215);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(57, 19);
            this.rbMujer.TabIndex = 54;
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
            this.rbHombre.TabIndex = 53;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(174, 158);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(114, 22);
            this.dtpFecha.TabIndex = 52;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.Location = new System.Drawing.Point(174, 75);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(165, 22);
            this.tbDNI.TabIndex = 50;
            // 
            // tbCodigoPUCP
            // 
            this.tbCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoPUCP.Location = new System.Drawing.Point(174, 47);
            this.tbCodigoPUCP.Name = "tbCodigoPUCP";
            this.tbCodigoPUCP.Size = new System.Drawing.Size(165, 22);
            this.tbCodigoPUCP.TabIndex = 49;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(186, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 22);
            this.tbID.TabIndex = 48;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::ooiasoft.Properties.Resources.user;
            this.pbFoto.Location = new System.Drawing.Point(560, 59);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(270, 270);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 63;
            this.pbFoto.TabStop = false;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tbNombres);
            this.gbDatosPersonales.Controls.Add(this.tbEdad);
            this.gbDatosPersonales.Controls.Add(this.tbApellidos);
            this.gbDatosPersonales.Controls.Add(this.lblApellidos);
            this.gbDatosPersonales.Controls.Add(this.lblNombres);
            this.gbDatosPersonales.Controls.Add(this.nudEscala);
            this.gbDatosPersonales.Controls.Add(this.cbEspecialidad);
            this.gbDatosPersonales.Controls.Add(this.lblCorreo);
            this.gbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.lblEdad);
            this.gbDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPersonales.Controls.Add(this.cbTipoAlumno);
            this.gbDatosPersonales.Controls.Add(this.lblDNI);
            this.gbDatosPersonales.Controls.Add(this.lblCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.tbCorreo);
            this.gbDatosPersonales.Controls.Add(this.lblEscala);
            this.gbDatosPersonales.Controls.Add(this.tbTelefono);
            this.gbDatosPersonales.Controls.Add(this.lblTipo);
            this.gbDatosPersonales.Controls.Add(this.rbMujer);
            this.gbDatosPersonales.Controls.Add(this.lblEspecialidad);
            this.gbDatosPersonales.Controls.Add(this.rbHombre);
            this.gbDatosPersonales.Controls.Add(this.lblID);
            this.gbDatosPersonales.Controls.Add(this.tbCodigoPUCP);
            this.gbDatosPersonales.Controls.Add(this.tbDNI);
            this.gbDatosPersonales.Controls.Add(this.dtpFecha);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 3);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(505, 399);
            this.gbDatosPersonales.TabIndex = 68;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = " Datos Personales ";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(174, 330);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(165, 24);
            this.cbEspecialidad.TabIndex = 63;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(65, 268);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 23);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(68, 241);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Celular: ";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(65, 213);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(100, 23);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(68, 186);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 23);
            this.lblEdad.TabIndex = 22;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 156);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(145, 23);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(65, 75);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(100, 23);
            this.lblDNI.TabIndex = 19;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoPUCP
            // 
            this.lblCodigoPUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPUCP.Location = new System.Drawing.Point(65, 46);
            this.lblCodigoPUCP.Name = "lblCodigoPUCP";
            this.lblCodigoPUCP.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoPUCP.TabIndex = 18;
            this.lblCodigoPUCP.Text = "Codigo PUCP:";
            this.lblCodigoPUCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEscala
            // 
            this.lblEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscala.Location = new System.Drawing.Point(36, 300);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(129, 23);
            this.lblEscala.TabIndex = 17;
            this.lblEscala.Text = "Escala de Pago:";
            this.lblEscala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(36, 362);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(129, 23);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo de Alumno:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(65, 330);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(100, 23);
            this.lblEspecialidad.TabIndex = 15;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(119, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 23);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCredenciales
            // 
            this.gbCredenciales.Controls.Add(this.lblConfirmacionCredenciales);
            this.gbCredenciales.Controls.Add(this.lblUsuario);
            this.gbCredenciales.Controls.Add(this.lblPassword);
            this.gbCredenciales.Controls.Add(this.btGenerar);
            this.gbCredenciales.Controls.Add(this.tbUsuario);
            this.gbCredenciales.Controls.Add(this.tbPassword);
            this.gbCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCredenciales.Location = new System.Drawing.Point(12, 408);
            this.gbCredenciales.Name = "gbCredenciales";
            this.gbCredenciales.Size = new System.Drawing.Size(505, 101);
            this.gbCredenciales.TabIndex = 69;
            this.gbCredenciales.TabStop = false;
            this.gbCredenciales.Text = " Credenciales ";
            // 
            // lblConfirmacionCredenciales
            // 
            this.lblConfirmacionCredenciales.AutoSize = true;
            this.lblConfirmacionCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionCredenciales.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmacionCredenciales.Location = new System.Drawing.Point(119, 83);
            this.lblConfirmacionCredenciales.Name = "lblConfirmacionCredenciales";
            this.lblConfirmacionCredenciales.Size = new System.Drawing.Size(310, 13);
            this.lblConfirmacionCredenciales.TabIndex = 70;
            this.lblConfirmacionCredenciales.Text = "Sus credenciales se han generado satisfactoriamente";
            this.lblConfirmacionCredenciales.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(83, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 23);
            this.lblUsuario.TabIndex = 68;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(83, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 23);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(174, 21);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(165, 22);
            this.tbUsuario.TabIndex = 59;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(717, 466);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 32);
            this.btCancelar.TabIndex = 71;
            this.btCancelar.Text = "Volver";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Location = new System.Drawing.Point(588, 466);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(92, 33);
            this.btGuardar.TabIndex = 70;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(560, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 27);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // buscador
            // 
            this.buscador.FileName = "openFileDialog1";
            // 
            // lblFormatosFoto
            // 
            this.lblFormatosFoto.AutoSize = true;
            this.lblFormatosFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFormatosFoto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblFormatosFoto.Location = new System.Drawing.Point(570, 332);
            this.lblFormatosFoto.Name = "lblFormatosFoto";
            this.lblFormatosFoto.Size = new System.Drawing.Size(250, 13);
            this.lblFormatosFoto.TabIndex = 73;
            this.lblFormatosFoto.Text = "Los formatos permitidos para la foto son JPG y PNG";
            // 
            // nudEscala
            // 
            this.nudEscala.Location = new System.Drawing.Point(174, 303);
            this.nudEscala.Name = "nudEscala";
            this.nudEscala.Size = new System.Drawing.Size(66, 22);
            this.nudEscala.TabIndex = 66;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(36, 130);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(129, 23);
            this.lblApellidos.TabIndex = 68;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(39, 102);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 23);
            this.lblNombres.TabIndex = 67;
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(174, 131);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(310, 22);
            this.tbApellidos.TabIndex = 69;
            // 
            // tbEdad
            // 
            this.tbEdad.Enabled = false;
            this.tbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEdad.Location = new System.Drawing.Point(174, 186);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(66, 22);
            this.tbEdad.TabIndex = 70;
            // 
            // tbNombres
            // 
            this.tbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.Location = new System.Drawing.Point(174, 102);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(310, 22);
            this.tbNombres.TabIndex = 71;
            // 
            // frmVerEditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 520);
            this.Controls.Add(this.lblFormatosFoto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.gbCredenciales);
            this.Controls.Add(this.gbDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerEditarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbCredenciales.ResumeLayout(false);
            this.gbCredenciales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Button btFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cbTipoAlumno;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCodigoPUCP;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.GroupBox gbCredenciales;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCodigoPUCP;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.OpenFileDialog buscador;
        private System.Windows.Forms.Label lblConfirmacionCredenciales;
        private System.Windows.Forms.Label lblFormatosFoto;
        private System.Windows.Forms.NumericUpDown nudEscala;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbNombres;
    }
}