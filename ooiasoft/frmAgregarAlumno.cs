using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class frmAgregarAlumno : Form
    {
        private PersonaWS.alumno alumno;
        private PersonaWS.PersonaWSClient daoAlumno;
        int escala;

        public frmAgregarAlumno()
        {
            InitializeComponent();
            alumno = new PersonaWS.alumno();
            daoAlumno = new PersonaWS.PersonaWSClient();
            EspecialidadWS.EspecialidadWSClient daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            
            //Llenar el comboBox del tipo de alumno con cadenas, luego se manejara por indices
            cbTipoAlumno.Items.Add("Seleccionar");
            cbTipoAlumno.Items.Add("Regular");
            cbTipoAlumno.Items.Add("No Regular");
            cbTipoAlumno.SelectedIndex = 0;

            //Llenar el comboBox de especialidades y agregar la opcion de "Seleccionar"
            BindingList<EspecialidadWS.especialidad> especialidades = new BindingList<EspecialidadWS.especialidad>(daoEspecialidad.listarEspecialidadesPorNombre("").ToList());
            EspecialidadWS.especialidad auxEsp = new EspecialidadWS.especialidad();
            auxEsp.idEspecialidad = -1;
            auxEsp.nombre = "Seleccionar";
            especialidades.Insert(0,auxEsp);

            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "idEspecialidad";
            cbEspecialidad.SelectedIndex = 0;

            //numero máximo de la escala
            nudEscala.Maximum = 9;

        }

        //Metodo que permite autogenerar un password, no es necesario llenarlo
        public string generarPassword()
        {
            string pass = "";
            Random rand = new Random();
            string alphanum = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j=0; j<10; j++) pass += alphanum[rand.Next(alphanum.Length)];
            return pass;
        }

        public void disabledAll()
        {
            tbCorreo.Enabled = false;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Enabled = false;
            nudEscala.Enabled = false;
            tbNombres.Enabled = false;
            tbApellidos.Enabled = false;
            tbTelefono.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            btFoto.Enabled = false;
            btGenerar.Enabled = false;
            cbEspecialidad.Enabled = false;
            cbTipoAlumno.Enabled = false;
            rbHombre.Enabled = false;
            rbMujer.Enabled = false;
            btGuardar.Enabled = false;
        }

        public string obtener_nombre_alumno(string cadena)
        {
            string nombre;
            int pos;
            for (pos = 0; pos < cadena.Length; pos++)
                if (cadena.ElementAt(pos) == ',')
                    break;

            nombre = cadena.Substring(pos + 2, cadena.Length - pos - 2);
            return nombre;
        }

        public string obtener_apellido_alumno(string cadena)
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

            //Para la escala de pago

            if (!Int32.TryParse(nudEscala.Text, out this.escala) )
            {
                MessageBox.Show("La escala debe ser un número", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Int32.Parse(nudEscala.Text)<0 || Int32.Parse(nudEscala.Text)>9)
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

            // Selección de Alumno
            if (cbTipoAlumno.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de alumno", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //No se ha generado credenciales
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("No ha generado credenciales para el usuario", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //para el correo

            if (!esBuenCorreo(tbCorreo.Text))
            {
                MessageBox.Show("Debe colocar un correo válido", "Datos erróneos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            alumno.codigoPUCP = tbCodigoPUCP.Text;
            alumno.DNI = tbDNI.Text;
            alumno.nombreCompleto = tbApellidos.Text.ToUpper() + ", " + tbNombres.Text.ToUpper();
            alumno.usuario = "a" + tbCodigoPUCP.Text;
            alumno.password = tbPassword.Text;
            alumno.correo = tbCorreo.Text;          
            alumno.fechaNacimiento = dtpFechaNacimiento.Value;
            alumno.fechaNacimientoSpecified = true;

            alumno.edad = DateTime.Today.AddTicks(-alumno.fechaNacimiento.Ticks).Year - 1;
            tbEdad.Text = "" + alumno.edad;

            if (alumno.edad <= 0)
            {
                MessageBox.Show("La fecha de nacimiento tiene que ser menor a la fecha actual.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            alumno.edad = DateTime.Today.AddTicks(-dtpFechaNacimiento.Value.Ticks).Year - 1;
            alumno.telefono = tbTelefono.Text;
            if (rbHombre.Checked) alumno.sexo = 'M';
            else alumno.sexo = 'F';
            alumno.escalaPago = Int32.Parse(nudEscala.Text);
            PersonaWS.especialidad esp = new PersonaWS.especialidad();
            esp.idEspecialidad = (int)cbEspecialidad.SelectedValue;
            alumno.especialidad = esp;
            if (cbTipoAlumno.SelectedIndex == 1) alumno.tipo = PersonaWS.tipoAlumno.Regular;
            else alumno.tipo = PersonaWS.tipoAlumno.NoRegular;
            alumno.tipoSpecified = true;

            if(pbFoto.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                alumno.foto = ms.ToArray();
            }
            
            //Insertar usando el DAO
            int resultado = daoAlumno.insertarAlumno(alumno);
            if (resultado > 0)
            {
                MessageBox.Show("Se ha registrado con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Actualizar los campos
                tbID.Text = resultado.ToString();
                tbCorreo.Text = alumno.correo;
                tbUsuario.Text = alumno.usuario;
                disabledAll();
                btCancelar.Text = "Volver";
                try
                {
                    MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                    MailAddress to = new MailAddress(alumno.correo, alumno.nombreCompleto);
                    List<MailAddress> cc = new List<MailAddress>();
                    cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                    SendEmail("Confirmacion de credenciales OOIA", from, to, cc);
                }
                catch (Exception ex) { }
            }
            else if (resultado == -1)
            {
                MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            if (tbCodigoPUCP.Text != "")
            {
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
            else
            {
                MessageBox.Show("Debe completar su código PUCP para generar las credenciales", "Código PUCP faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Se verifica que solo se genere una vez los credenciales
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (btCancelar.Text.CompareTo("Volver") == 0) this.DialogResult = DialogResult.OK;
            else this.Close();
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
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "<p><strong>Estimado {0}:</strong></p><p> Usted acaba de ser registrado en el sistema de la OOIA con las siguientes credenciales:</p><p><strong>Usuario:</strong>{1}</p><p><strong>Contrasena: </strong>{2}</p><p>Esperamos que pueda tener una buena experiencia usando la aplicacion de escritorio.</p><p> Atentamente, el equipo administrativo de la OOIA.</p><p><span><em> El contenido de este correo electronico es confidencial y esta destinado unicamente al destinatario especificado en el mensaje.Esta estrictamente prohibido compartir cualquier parte de este mensaje con terceros, sin el consentimiento por escrito del remitente. Si recibio este mensaje por error, responda a este mensaje y continue con su eliminacion, para que podamos asegurarnos de que ese error no ocurra en el futuro.</em></span></p>";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new System.Net.NetworkCredential("lp2ooiasoft2021@gmail.com", "freddyCrack123+"); // llenar con contrasenia
            MailMessage msgMail;

            //FALTA
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
