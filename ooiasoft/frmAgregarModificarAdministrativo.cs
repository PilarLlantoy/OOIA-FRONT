﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmAgregarModificarAdministrativo : Form
    {
        private PersonaWS.PersonaWSClient daoPersonal;
        private PersonaWS.administrativo personalSeleccionado;
        int operacion = 0;

        public frmAgregarModificarAdministrativo()
        {
            InitializeComponent();
            daoPersonal = new PersonaWS.PersonaWSClient();

            //ComboBox de Tipo de Administrativos
            BindingList<PersonaWS.tipoAdministrativo> tipos = new BindingList<PersonaWS.tipoAdministrativo>();
            tipos.Add(PersonaWS.tipoAdministrativo.Apoyo);
            tipos.Add(PersonaWS.tipoAdministrativo.Coordinador);
            tipos.Add(PersonaWS.tipoAdministrativo.Practicante);
            tipos.Add(PersonaWS.tipoAdministrativo.Secretario);
            tipos.Add(PersonaWS.tipoAdministrativo.SuperUsuario);
            cbTipoAdministrativo.DataSource = tipos;
            cbTipoAdministrativo.SelectedIndex = -1;

            //Para identificar que es un registro
            operacion = 0;
        }

        //CONSTRUCTOR PARA CUANDO QUIERO MODIFICAR
        public frmAgregarModificarAdministrativo(PersonaWS.administrativo personalSeleccionado)
        {
            InitializeComponent();
            daoPersonal = new PersonaWS.PersonaWSClient();
            this.personalSeleccionado = personalSeleccionado;

            //comboBox 
            BindingList<PersonaWS.tipoAdministrativo> tipos = new BindingList<PersonaWS.tipoAdministrativo>();
            tipos.Add(PersonaWS.tipoAdministrativo.Apoyo);
            tipos.Add(PersonaWS.tipoAdministrativo.Coordinador);
            tipos.Add(PersonaWS.tipoAdministrativo.Practicante);
            tipos.Add(PersonaWS.tipoAdministrativo.Secretario);
            tipos.Add(PersonaWS.tipoAdministrativo.SuperUsuario);
            cbTipoAdministrativo.DataSource = tipos;
            cbTipoAdministrativo.SelectedIndex = -1;

            llenarCampos();

            //Para identificar que es una modificacion
            operacion = 1;
            btnEditar.Visible = true;

            bloquearComponentes();
            btCancelar.Enabled = true;
            btCancelar.Text = "Volver";
        }

        public string generarPassword()
        {
            string pass = "";
            Random rand = new Random();
            string alphanum = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j = 0; j < 10; j++) pass += alphanum[rand.Next(alphanum.Length)];
            return pass;
        }

        public string obtener_nombre(string cadena)
        {
            string nombre;
            int pos;
            for (pos = 0; pos < cadena.Length; pos++)
                if (cadena.ElementAt(pos) == ',')
                    break;

            nombre = cadena.Substring(pos + 2, cadena.Length - pos - 2);
            return nombre;
        }

        public string obtener_apellido(string cadena)
        {
            string apellido;
            int pos;
            for (pos = 0; pos < cadena.Length; pos++)
                if (cadena.ElementAt(pos) == ',')
                    break;

            apellido = cadena.Substring(0, pos);
            return apellido;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            // Validaciones de que esten llenos los campos

            if (tbCodigoPUCP.Text == "")
            {
                MessageBox.Show("No ha ingresado el codigo PUCP.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbDNI.Text == "")
            {
                MessageBox.Show("No ha ingresado el DNI.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbNombres.Text == "")
            {
                MessageBox.Show("No ha ingresado los nombres.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbApellidos.Text == "")
            {
                MessageBox.Show("No ha ingresado los apellidos.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rbHombre.Checked && !rbMujer.Checked)
            {
                MessageBox.Show("No ha seleccionado el sexo.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbTelefono.Text == "")
            {
                MessageBox.Show("No ha ingresado el telefono.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbCorreo.Text == "")
            {
                MessageBox.Show("No ha ingresado el correo.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTipoAdministrativo.SelectedIndex == -1)
            {
                MessageBox.Show("No ha ingresado un cargo.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validaciones

            //para el codigo

            if (!Regex.IsMatch(tbCodigoPUCP.Text, @"^\d+$"))
            {
                MessageBox.Show("El codigo debe contener solo números", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbCodigoPUCP.Text.Length != 8)
            {
                MessageBox.Show("El código debe tener 8 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(tbCodigoPUCP.Text) < 19000000 || Int32.Parse(tbCodigoPUCP.Text) > 29999999)
            {
                MessageBox.Show("El código es invalido", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //para el DNI

            if (!Regex.IsMatch(tbDNI.Text, @"^\d+$"))
            {
                MessageBox.Show("El DNI debe contener solo números", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //para el celular

            if (!Regex.IsMatch(tbTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("El telefono celular debe contener solo números", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbTelefono.Text.Length != 9)
            {
                MessageBox.Show("El telefono celular debe tener 9 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(tbTelefono.Text) < 900000000 || Int32.Parse(tbTelefono.Text) > 999999999)
            {
                MessageBox.Show("El telefono celular debe iniciar con 9", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Son validas las fechas

            if (dtpFechaNacimiento.Value >= DateTime.Now.Date)
            {
                MessageBox.Show("Fecha de nacimiento inválida.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //nombres y apellidos validos 

            if (!Regex.IsMatch(tbNombres.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Los nombres deben contener solo letras del abecedario.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(tbApellidos.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Los apellidos deben contener solo letras del abecedario.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //No se ha generado credenciales

            if (tbUsuario.Text == "")
            {
                MessageBox.Show("No ha generado credenciales para el usuario", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //No se selecciona tipo de administrativo

            if (cbTipoAdministrativo.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado un tipo de administrativo", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //para el correo

            if (!esBuenCorreo(tbCorreo.Text))
            {
                MessageBox.Show("Debe colocar un correo válido", "Datos erróneos.",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAdministrativo;
            PersonaWS.administrativo administrativo = new PersonaWS.administrativo();

            administrativo.codigoPUCP = tbCodigoPUCP.Text;
            administrativo.DNI = tbDNI.Text;
            administrativo.nombreCompleto = tbApellidos.Text.ToUpper() + ", " + tbNombres.Text.ToUpper();
            administrativo.fechaNacimiento = dtpFechaNacimiento.Value;
            administrativo.fechaNacimientoSpecified = true;
            administrativo.edad = DateTime.Today.AddTicks(-administrativo.fechaNacimiento.Ticks).Year - 1;
            if (administrativo.edad < 0)
            {
                MessageBox.Show("La fecha de nacimiento tiene que ser menor a la fecha actual.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbEdad.Text = "" + administrativo.edad;

            if (rbHombre.Checked == true)
                administrativo.sexo = 'M';
            else administrativo.sexo = 'F';
            administrativo.telefono = tbTelefono.Text;
            administrativo.correo = tbCorreo.Text;
            administrativo.usuario = tbCodigoPUCP.Text;
            administrativo.password = tbCodigoPUCP.Text;

            administrativo.tipo = (PersonaWS.tipoAdministrativo)cbTipoAdministrativo.SelectedItem;
            administrativo.tipoSpecified = true;

            MemoryStream ms = new MemoryStream();
            if (pbFoto.Image != null)
            {
                pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                administrativo.foto = ms.ToArray();
            }

            //AQUI TENGO QUE HACER LA DISTINCIÓN DE SI ES PARA REGISTRAR O MODIFICAR

            if (operacion == 0)
            {
                idAdministrativo = daoPersonal.insertarAdministrativo(administrativo);
                if (idAdministrativo == 0)
                {
                    MessageBox.Show("Registro del psicólogo incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (idAdministrativo == -1)
                {
                    MessageBox.Show("Está ingresando un administrativo con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se ha registrado al administrador con éxito, asimismo el usuario recibirá una notificación", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbID.Text = idAdministrativo.ToString();
                    bloquearComponentes();
                    btCancelar.Enabled = true;
                    btCancelar.Text = "Volver";
                    try
                    {
                        MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                        MailAddress to = new MailAddress(administrativo.correo, administrativo.nombreCompleto);
                        List<MailAddress> cc = new List<MailAddress>();
                        cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                        SendEmail("Confirmacion de credenciales OOIA", from, to, cc);
                    }
                    catch (Exception ex) { }
                }
            }
            else
            { 
                administrativo.idPersona = Int32.Parse(tbID.Text);
                int resultado = daoPersonal.modificarAdministrativo(administrativo);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha modificado al administrador con exito, asimismo el usuario recibirá una notificación", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bloquearComponentes();
                    btnEditar.Enabled = true;
                    btCancelar.Enabled = true;
                    btCancelar.Text = "Volver";

                    MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                    MailAddress to = new MailAddress(administrativo.correo, administrativo.nombreCompleto);
                    List<MailAddress> cc = new List<MailAddress>();
                    cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                    SendEmail("Confirmacion de credenciales OOIA", from, to, cc);
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bloquearComponentes();
            }
        }

        private void bloquearComponentes()
        {
            tbID.Enabled = false;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Enabled = false;
            tbNombres.Enabled = false;
            tbApellidos.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            tbEdad.Enabled = false;
            rbHombre.Enabled = false;
            rbMujer.Enabled = false;
            tbTelefono.Enabled = false;
            tbCorreo.Enabled = false;
            tbUsuario.Enabled = false;
            tbPassword.Enabled = false;
            cbTipoAdministrativo.Enabled = false;
            pbFoto.Enabled = false;
            btGenerar.Enabled = false;
            btFoto.Enabled = false;
            btGuardar.Enabled = false;
            btGuardar.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (operacion == 1 && btCancelar.Text.CompareTo("Cancelar") == 0)
            {
                llenarCampos();
                bloquearComponentes();
                btnEditar.Enabled = true;
                btCancelar.Text = "Volver";
            }
            else this.Close();
        }

        private void llenarCampos()
        {
            //Completar campos de texto
            tbID.Text = "" + personalSeleccionado.idPersona;
            tbCodigoPUCP.Text = personalSeleccionado.codigoPUCP;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Text = personalSeleccionado.DNI;

            tbNombres.Text = obtener_nombre(personalSeleccionado.nombreCompleto);
            tbApellidos.Text = obtener_apellido(personalSeleccionado.nombreCompleto);

            dtpFechaNacimiento.Value = personalSeleccionado.fechaNacimiento.Date;
            tbEdad.Text = personalSeleccionado.edad.ToString();
            if (personalSeleccionado.sexo == 'M')
                rbHombre.Checked = true;
            else rbMujer.Checked = true;
            tbTelefono.Text = personalSeleccionado.telefono;
            tbCorreo.Text = personalSeleccionado.correo;
            tbUsuario.Text = personalSeleccionado.usuario;
            tbPassword.Text = personalSeleccionado.password;

            //Mostrar la foto solo si tiene una
            if (personalSeleccionado.foto != null)
            {
                MemoryStream ms = new MemoryStream(personalSeleccionado.foto);
                pbFoto.Image = new Bitmap(ms);
            }

            // Completar ComboBox de tipoAlumno
            if (personalSeleccionado.tipo == PersonaWS.tipoAdministrativo.Apoyo)
                cbTipoAdministrativo.SelectedIndex = 0;
            if (personalSeleccionado.tipo == PersonaWS.tipoAdministrativo.Coordinador)
                cbTipoAdministrativo.SelectedIndex = 1;
            if (personalSeleccionado.tipo == PersonaWS.tipoAdministrativo.Practicante)
                cbTipoAdministrativo.SelectedIndex = 2;
            if (personalSeleccionado.tipo == PersonaWS.tipoAdministrativo.Secretario)
                cbTipoAdministrativo.SelectedIndex = 3;
            if (personalSeleccionado.tipo == PersonaWS.tipoAdministrativo.SuperUsuario)
                cbTipoAdministrativo.SelectedIndex = 4;
        }

        private void btFoto_Click_1(object sender, EventArgs e)
        {
            String ruta;
            try
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbDNI.Enabled = true;
            tbNombres.Enabled = true;
            tbApellidos.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            rbHombre.Enabled = true;
            rbMujer.Enabled = true;
            tbTelefono.Enabled = true;
            tbCorreo.Enabled = true;
            pbFoto.Enabled = true;
            btGenerar.Enabled = true;
            btFoto.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btnEditar.Enabled = false;
            cbTipoAdministrativo.Enabled = true;
            btCancelar.Text = "Cancelar";
        }

        private void btGenerar_Click_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbCodigoPUCP.Text, @"^\d+$") ||
                    (Int32.Parse(tbCodigoPUCP.Text) < 19000000 || Int32.Parse(tbCodigoPUCP.Text) > 29999999) ||
                    tbCodigoPUCP.Text == "")
            {
                MessageBox.Show("El código debe ser correcto para generar las credenciales", "Error en la generación de las credenciales.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else
            {
                tbUsuario.Text = "a" + tbCodigoPUCP.Text;
                tbPassword.Text = generarPassword();
                btGenerar.Enabled = false;
                lblConfirmacionCredenciales.Visible = true;
            }
            //Se verifica que solo se genere una vez los credenciales
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "<p><strong>Estimado {0}:</strong></p><p> Usted acaba de ser registrado en el sistema de la OOIA con las siguientes credenciales:</p><p><strong>Usuario:</strong>{1}</p><p><strong>Contrasena: </strong>{2}</p><p>Esperamos que pueda tener una buena experiencia usando la aplicacion de escritorio.</p><p> Atentamente, el equipo administrativo de la OOIA.</p><p><span><em> El contenido de este correo electronico es confidencial y esta destinado unicamente al destinatario especificado en el mensaje.Esta estrictamente prohibido compartir cualquier parte de este mensaje con terceros, sin el consentimiento por escrito del remitente. Si recibio este mensaje por error, responda a este mensaje y continue con su eliminacion, para que podamos asegurarnos de que ese error no ocurra en el futuro.</em></span></p>";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new System.Net.NetworkCredential("lp2ooiasoft2021@gmail.com", "freddyCrack123+"); // llenar con contrasenia
            MailMessage msgMail;

            Text = String.Format(Text, tbApellidos.Text + ", " + tbNombres.Text, tbUsuario.Text, tbPassword.Text);

            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            try
            {
                mailClient.Send(msgMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar el email.", "Error en el envío del correo");
            } 
            msgMail.Dispose();
        }

        private bool esBuenCorreo(string correo)
        {
            bool flagArroba = false, flagPunto = false;
            int i;

            for (i = 0; i < correo.Length; i++)
                if (correo[i] == '@')
                {
                    flagArroba = true;
                    break;
                }
                else if (correo[i] == ' ' || correo[i] == '$' || correo[i] == '#' || correo[i] == '&' || correo[i] == '(' || correo[i] == ')' || correo[i] == '/' || correo[i] == '%' || correo[i] == '=' || correo[i] == '?' || correo[i] == '¿' || correo[i] == '!' || correo[i] == '¡' || correo[i] == '*' || correo[i] == '~' || correo[i] == '*' || correo[i] == '+' || correo[i] == ',' || correo[i] == ';')
                    return false;

            for (int k = i; k < correo.Length; k++)
                if (correo[k] == '.')
                    flagPunto = true;
                else if (correo[k] == ' ' || correo[k] == '$' || correo[k] == '#' || correo[k] == '&' || correo[k] == '(' || correo[k] == ')' || correo[k] == '/' || correo[k] == '%' || correo[k] == '=' || correo[k] == '?' || correo[k] == '¿' || correo[k] == '!' || correo[k] == '¡' || correo[k] == '*' || correo[k] == '~' || correo[k] == '*' || correo[k] == '+' || correo[k] == ',' || correo[k] == ';')
                    return false;

            return flagArroba && flagPunto;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            int ed = DateTime.Today.AddTicks(-dtpFechaNacimiento.Value.Ticks).Year - 1;
            tbEdad.Text = "" + ed;
        }
    }
}
