using System;
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
    public partial class frmVerEditarAlumno : Form
    {

        private PersonaWS.alumno alumno;
        private PersonaWS.PersonaWSClient daoAlumno;
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        private BindingList<EspecialidadWS.especialidad> especialidades;
        private int escala;
        private bool flagCorreo = false;

        public frmVerEditarAlumno(PersonaWS.alumno alumnoSeleccionado)
        {
            InitializeComponent();

            //Instanciar DAOs
            alumno = new PersonaWS.alumno();
            daoAlumno = new PersonaWS.PersonaWSClient();
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            this.alumno = alumnoSeleccionado;

            //Llenar los combos
            especialidades = new BindingList<EspecialidadWS.especialidad>(daoEspecialidad.listarEspecialidadesPorNombre("").ToList());
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "idEspecialidad";

            cbTipoAlumno.Items.Add("Regular");
            cbTipoAlumno.Items.Add("No Regular");

            //Llenar los campos con los datos del objeto
            llenarFormulario();

            //Desactivar todo para visualizacion de datos
            desactivarFormulario();

            //numero máximo de la escala
            nudEscala.Maximum = 9;
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

        private void llenarFormulario()
        {
            //Completar campos de texto
            tbID.Text = "" + alumno.idPersona;
            tbCodigoPUCP.Text = alumno.codigoPUCP;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Text = alumno.DNI;

            tbNombres.Text = obtener_nombre(alumno.nombreCompleto);
            tbApellidos.Text = obtener_apellido(alumno.nombreCompleto);

            dtpFecha.Value = alumno.fechaNacimiento.Date;
            int ed = DateTime.Today.AddTicks(-dtpFecha.Value.Ticks).Year - 1;
            tbEdad.Text = "" + ed;
            if (alumno.sexo == 'M')
                rbHombre.Checked = true;
            else rbMujer.Checked = true;
            tbTelefono.Text = alumno.telefono;
            tbCorreo.Text = alumno.correo;
            tbUsuario.Text = alumno.usuario;
            tbPassword.Text = alumno.password;
            nudEscala.Text = alumno.escalaPago.ToString();

            // Completar ComboBox de Especialidad
            int i = 0;
            foreach(EspecialidadWS.especialidad aux in especialidades)
            {
                if(alumno.especialidad.nombre.CompareTo(aux.nombre) == 0)
                {
                    cbEspecialidad.SelectedIndex = i;
                    break;
                }
                i++;
            }

            // Completar ComboBox de tipoAlumno
            if (alumno.tipo == PersonaWS.tipoAlumno.Regular)
                cbTipoAlumno.SelectedIndex = 0;
            else
                cbTipoAlumno.SelectedIndex = 1;

            //Mostrar la foto solo si tiene una
            if (alumno.foto != null)
            {
                MemoryStream ms = new MemoryStream(alumno.foto);
                pbFoto.Image = new Bitmap(ms);
            }
        }

        public void desactivarFormulario()
        {
            tbCorreo.Enabled = false;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Enabled = false;
            nudEscala.Enabled = false;
            tbNombres.Enabled = false;
            tbApellidos.Enabled = false;
            tbTelefono.Enabled = false;
            dtpFecha.Enabled = false;
            btFoto.Enabled = false;
            btGenerar.Enabled = false;
            cbEspecialidad.Enabled = false;
            cbTipoAlumno.Enabled = false;
            rbHombre.Enabled = false;
            rbMujer.Enabled = false;
            btGuardar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (btCancelar.Text.CompareTo("Cancelar") == 0)
            {
                btCancelar.Text = "Volver";
                //Cancelar vuelve al estado de ver detalles con los datos originales
                llenarFormulario();
                desactivarFormulario();
            }
            else this.Close();
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
                MessageBox.Show("No ha ingresado el nombre.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (nudEscala.Text == "")
            {
                MessageBox.Show("No ha ingresado la escala de pago.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (Int32.Parse(tbCodigoPUCP.Text) < 10000000 || Int32.Parse(tbCodigoPUCP.Text) > 29999999)
            {
                MessageBox.Show("El código es invalido", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //para el DNI 

            if (!Regex.IsMatch(tbDNI.Text, @"^\d+$"))
            {
                MessageBox.Show("El DNI debe contener solo números", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El telefono debe tener 9 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Int32.Parse(tbTelefono.Text) < 900000000 || Int32.Parse(tbTelefono.Text) > 999999999)
            {
                MessageBox.Show("El telefono celular debe iniciar con 9", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Son validas las fechas

            if (dtpFecha.Value >= DateTime.Now.Date)
            {
                MessageBox.Show("Fecha de nacimiento inválida.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //nombres y apellidos validos 

            if (!Regex.IsMatch(tbNombres.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre debe contener solo letras del abecedario.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(tbApellidos.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Los apellidos deben contener solo letras del abecedario.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Para la escala de pago

            if (!Int32.TryParse(nudEscala.Text, out this.escala))
            {
                MessageBox.Show("La escala debe ser un número", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(nudEscala.Text) < 0 || Int32.Parse(nudEscala.Text) > 9)
            {
                MessageBox.Show("La escala debe ser un número entre 0 a 9.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Selección de Especialidad
            if (cbEspecialidad.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            alumno.idPersona = Int32.Parse(tbID.Text);
            alumno.codigoPUCP = tbCodigoPUCP.Text;
            alumno.DNI = tbDNI.Text;
            alumno.nombreCompleto = tbApellidos.Text.ToUpper() + ", " + tbNombres.Text.ToUpper();
            alumno.usuario = "a" + tbCodigoPUCP.Text;
            alumno.password = tbPassword.Text;
            alumno.correo = tbCorreo.Text;
            alumno.fechaNacimiento = dtpFecha.Value;
            alumno.fechaNacimientoSpecified = true;
            alumno.edad = DateTime.Today.AddTicks(-dtpFecha.Value.Ticks).Year - 1;
            alumno.telefono = tbTelefono.Text;
            if (rbHombre.Checked) alumno.sexo = 'M';
            else alumno.sexo = 'F';
            alumno.escalaPago = Int32.Parse(nudEscala.Text);
            EspecialidadWS.especialidad esp = (EspecialidadWS.especialidad)cbEspecialidad.SelectedItem;
            PersonaWS.especialidad espAlum = new PersonaWS.especialidad();
            espAlum.idEspecialidad = esp.idEspecialidad;
            espAlum.nombre = esp.nombre;
            alumno.especialidad = espAlum;
            if (cbTipoAlumno.SelectedIndex == 0) alumno.tipo = PersonaWS.tipoAlumno.Regular;
            else alumno.tipo = PersonaWS.tipoAlumno.NoRegular;
            alumno.tipoSpecified = true;
            MemoryStream ms = new MemoryStream();
            if (pbFoto.Image != null)
            {
                pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                alumno.foto = ms.ToArray();
            }

            int resultado = daoAlumno.modificarDatosPersonales(alumno);
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado al alumno con exito, asimismo el usuario ha sido notificado", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desactivarFormulario();
                MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                MailAddress to = new MailAddress(alumno.correo, alumno.nombreCompleto);
                List<MailAddress> cc = new List<MailAddress>();
                cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                SendEmail("Confirmacion de credenciales OOIA", from, to, cc);
                btCancelar.Text = "Volver";
                btCancelar.Enabled = true;
            }
            else if (resultado == -1)
            {
                MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            activarEdicion();
            btCancelar.Text = "Cancelar";
            btnEditar.Enabled = false;
        }

        private void activarEdicion()
        {
            tbCorreo.Enabled = true;
            tbDNI.Enabled = true;
            nudEscala.Enabled = true;
            tbNombres.Enabled = true;
            tbApellidos.Enabled = true;
            tbTelefono.Enabled = true;
            dtpFecha.Enabled = true;
            btFoto.Enabled = true;
            btGenerar.Enabled = true;
            cbEspecialidad.Enabled = true;
            cbTipoAlumno.Enabled = true;
            rbHombre.Enabled = true;
            rbMujer.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btFoto_Click(object sender, EventArgs e)
        {
            try
            {
                String ruta;
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido.");
            }
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            flagCorreo = true;
            if (!Regex.IsMatch(tbCodigoPUCP.Text, @"^\d+$") ||
                    (Int32.Parse(tbCodigoPUCP.Text) < 19000000 || Int32.Parse(tbCodigoPUCP.Text) > 29999999) ||
                    tbCodigoPUCP.Text == "")
            {
                MessageBox.Show("El código debe ser correcto para generar las credenciales", "Error en la generación de las credenciales.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                tbUsuario.Text = "a" + tbCodigoPUCP.Text;
                tbPassword.Text = generarPassword();
                btGenerar.Enabled = false;
                lblConfirmacionCredenciales.Visible = true;
            }
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "<p><strong>Estimado {0}:</strong></p><p> Usted acaba de ser registrado en el sistema de la OOIA con las siguientes credenciales:</p><p><strong>Usuario: </strong>{1}</p><p><strong>Contrasena: </strong>{2}</p><p>Esperamos que pueda tener una buena experiencia usando la aplicacion de escritorio.</p><p> Atentamente, el equipo administrativo de la OOIA.</p><p><span><em> El contenido de este correo electronico es confidencial y esta destinado unicamente al destinatario especificado en el mensaje.Esta estrictamente prohibido compartir cualquier parte de este mensaje con terceros, sin el consentimiento por escrito del remitente. Si recibio este mensaje por error, responda a este mensaje y continue con su eliminacion, para que podamos asegurarnos de que ese error no ocurra en el futuro.</em></span></p>";
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
            if (flagCorreo == true) {
                try
                {
                    mailClient.Send(msgMail);
                    msgMail.Dispose();
                }
                catch (Exception ex) {
                    MessageBox.Show("No se pudo enviar el email", "Error de envío de email");
                }
                
            }

        }

        public string generarPassword()
        {
            string pass = "";
            Random rand = new Random();
            string alphanum = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j = 0; j < 10; j++) pass += alphanum[rand.Next(alphanum.Length)];
            return pass;
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

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            int ed = DateTime.Today.AddTicks(-dtpFecha.Value.Ticks).Year - 1;
            tbEdad.Text = "" + ed;
        }
    }
}
