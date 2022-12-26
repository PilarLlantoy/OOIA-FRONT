using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmRecuperarContra : Form
    {
        private PersonaWS.PersonaWSClient daoPersona;
        private PersonaWS.persona persona;
        private bool flagCorreo = false;
        public frmRecuperarContra()
        {
            InitializeComponent();
            daoPersona = new PersonaWS.PersonaWSClient();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            char tipo;
            bool confirmacion = false;

            flagCorreo = true;

            if (txtCodigo.Text.CompareTo("") == 0 || txtCorreo.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Debe completar los campos.", "Datos incompletos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!esBuenCorreo(txtCorreo.Text))
            {
                MessageBox.Show("Debe colocar un correo válido", "Datos erróneos.",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_persona = daoPersona.buscarIDPersonaPorCodigoCorreo(txtCodigo.Text, txtCorreo.Text);

            tipo = (char)(daoPersona.buscarTipoPersonaPorIDPersona(id_persona));

            if (tipo == 'A')
                persona = daoPersona.buscarAlumnoPorID(id_persona);
            else if (tipo == 'D')
                persona = daoPersona.buscarAdministrativoPorID(id_persona);
            else if (tipo == 'P')
                persona = daoPersona.buscarPsicologoPorID(id_persona);
            else if (tipo == 'T')
                persona = daoPersona.buscarTutorPorID(id_persona);
            else
            {
                MessageBox.Show("Los campos ingresados no son correctos\nNo se ha podido recuperar la contraseña.", "Error de recuperación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<MailAddress> cc = new List<MailAddress>();
                MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                BindingList<PersonaWS.persona> personas = new BindingList<PersonaWS.persona>();
                MailAddress to = new MailAddress(persona.correo, persona.nombreCompleto);
                persona.password = generarPassword();
                cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                confirmacion = SendEmail("Confirmacion de credenciales OOIA", from, to, cc);
            }
            catch (Exception ex) { }
            if (confirmacion == true)
            {
                daoPersona.modificarPersona(persona);
                MessageBox.Show("Se han actualizado sus credenciales y se han enviado por el correo de la cuenta, por favor revisar.", "Cuenta Actualizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            flagCorreo = false;
            this.Close();
        }

        protected bool SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "<p><strong>Estimado {0}:</strong></p><p> Usted acaba de recuperar sus credenciales del sistema de la OOIA:</p><p><strong>Usuario: </strong>{1}</p><p><strong>Contrasena: </strong>{2}</p><p>Esperamos que pueda tener una buena experiencia usando la aplicacion de escritorio.</p><p> Atentamente, el equipo administrativo de la OOIA.</p><p><span><em> El contenido de este correo electronico es confidencial y esta destinado unicamente al destinatario especificado en el mensaje.Esta estrictamente prohibido compartir cualquier parte de este mensaje con terceros, sin el consentimiento por escrito del remitente. Si recibio este mensaje por error, responda a este mensaje y continue con su eliminacion, para que podamos asegurarnos de que ese error no ocurra en el futuro.</em></span></p>";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new System.Net.NetworkCredential("lp2ooiasoft2021@gmail.com", "freddyCrack123+"); // llenar con contrasenia
            MailMessage msgMail;

            Text = String.Format(Text, persona.nombreCompleto, persona.usuario, persona.password);
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
            if (flagCorreo == true)
            {
                try
                {
                    mailClient.Send(msgMail);
                    msgMail.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo enviar el email", "Error de envío de email");
                    return false;
                }
                return true;

            }
            return false;

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

    }
}
