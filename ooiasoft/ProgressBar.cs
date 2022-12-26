using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class ProgressBarClase : Form
    {
        private PersonaWS.PersonaWSClient daoAlumno;
        private PersonaWS.PersonaWSClient daoPersonal;
        private int insertado = 0;
        private int inicio = 0;
        private BindingList<PersonaWS.alumno> lista;
        private BindingList<PersonaWS.persona> list;
        private string textoAnterior;
        private char opcion;
        public ProgressBarClase(BindingList<PersonaWS.alumno> lista)
        {
            InitializeComponent();
            daoAlumno = new PersonaWS.PersonaWSClient();
            this.lista = lista;
            textoAnterior = this.Text;
            opcion = 'A';
            progressBarAlumnos.Enabled = true;
            progressBarAlumnos.Maximum = lista.Count();
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        public ProgressBarClase(BindingList<PersonaWS.persona> lista)
        {
            InitializeComponent();
            daoPersonal = new PersonaWS.PersonaWSClient();
            this.list = lista;
            textoAnterior = this.Text;
            opcion = 'P';
            progressBarAlumnos.Enabled = true;
            progressBarAlumnos.Maximum = list.Count();
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        public Boolean TIMER { get => timer1.Enabled; set => timer1.Enabled = value; }

        private void llenarListaAlumnos (BindingList<PersonaWS.alumno> lista)
        {
            foreach (PersonaWS.alumno a in lista)
            {
                int resultado = daoAlumno.insertarAlumno(a);
                if (resultado == 0)
                {
                    MessageBox.Show("Ha ocurrido un error, no se ha podido cargar al alumno " + a.codigoPUCP + " - " + a.nombreCompleto, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (resultado > 0)
                {
                    progressBarAlumnos.Value++;
                    this.Text = textoAnterior;
                    textoAnterior = "Cargando ... " + (progressBarAlumnos.Value * 100 / progressBarAlumnos.Maximum).ToString() + " %";
                    //Console.WriteLine(progressBarAlumnos.Value + " - " + progressBarAlumnos.Maximum + " - ");
                    try
                    {
                        //this.nombreCompleto = a.nombreCompleto;
                        //this.usuario = a.usuario;
                        //this.password = a.password;
                        MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                        MailAddress to = new MailAddress(a.correo, a.nombreCompleto);
                        List<MailAddress> cc = new List<MailAddress>();
                        cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                        SendEmail("Confirmacion de credenciales OOIA", from, to, cc, a.nombreCompleto,a.usuario,a.password);

                        
                    }
                    catch (Exception ex) { }
                }
            }
            insertado = 1;
            progressBarAlumnos.Value = progressBarAlumnos.Maximum;
            this.Close();
        }

        private void llenarListaPersonal (BindingList<PersonaWS.persona> lista)
        {
            int resultado = 0;
            foreach (PersonaWS.persona p in lista)
            {
                
                if (p is PersonaWS.administrativo)
                {
                    resultado = daoPersonal.insertarAdministrativo((PersonaWS.administrativo)p);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Ha ocurrido un error, no se ha podido cargar al personal " + p.codigoPUCP + " - " + p.nombreCompleto, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (resultado == -1)
                    {
                        MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (p is PersonaWS.tutor)
                {
                    resultado = daoPersonal.insertarTutor((PersonaWS.tutor)p);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Ha ocurrido un error, no se ha podido cargar al personal " + p.codigoPUCP + " - " + p.nombreCompleto, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (resultado == -1)
                    {
                        MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (p is PersonaWS.psicologo)
                {
                    resultado = daoPersonal.insertarPsicologo((PersonaWS.psicologo)p);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Ha ocurrido un error, no se ha podido cargar al personal " + p.codigoPUCP + " - " + p.nombreCompleto, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (resultado == -1)
                    {
                        MessageBox.Show("Está ingresando un alumno con un código PUCP ya existente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (resultado > 0)
                {

                    progressBarAlumnos.Value++;
                    this.Text = textoAnterior;
                    textoAnterior = "Cargando ... " + (progressBarAlumnos.Value * 100 / progressBarAlumnos.Maximum).ToString() + " %";

                    try
                    {
                        ///this.nombreCompleto = p.nombreCompleto;
                        ///this.usuario = p.usuario;
                        ///this.password = p.password;
                        ///
                        

                        MailAddress from = new MailAddress("lp2ooiasoft2021@gmail.com", "OOIA - Admin");
                        MailAddress to = new MailAddress(p.correo, p.nombreCompleto);
                        List<MailAddress> cc = new List<MailAddress>();
                        cc.Add(new MailAddress("lp2ooiasoft2021@gmail.com", "ooiasoft"));
                        SendEmail("Confirmacion de credenciales OOIA", from, to, cc, p.nombreCompleto, p.usuario, p.password);
                    }
                    catch (Exception ex) { }
                }
            }
            resultado = 1;
            progressBarAlumnos.Value = progressBarAlumnos.Maximum;
            this.Close();
        }


        public int Insertado { get => insertado; set => insertado = value; }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, string nombreCompleto, string usuario, string password, List<MailAddress> _bcc = null)
        {
            string Text = "<p><strong>Estimado {0}:</strong></p><p> Usted acaba de ser registrado en el sistema de la OOIA con las siguientes credenciales:</p><p><strong>Usuario:</strong>{1}</p><p><strong>Contrasena: </strong>{2}</p><p>Esperamos que pueda tener una buena experiencia usando la aplicacion de escritorio.</p><p> Atentamente, el equipo administrativo de la OOIA.</p><p><span><em> El contenido de este correo electronico es confidencial y esta destinado unicamente al destinatario especificado en el mensaje.Esta estrictamente prohibido compartir cualquier parte de este mensaje con terceros, sin el consentimiento por escrito del remitente. Si recibio este mensaje por error, responda a este mensaje y continue con su eliminacion, para que podamos asegurarnos de que ese error no ocurra en el futuro.</em></span></p>";
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.Credentials = new System.Net.NetworkCredential("lp2ooiasoft2021@gmail.com", "freddyCrack123+"); // llenar con contrasenia
            MailMessage msgMail;

            //FALTA
            Text = String.Format(Text, nombreCompleto, usuario, password);

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
            }
            msgMail.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                inicio = 1;
                timer1.Enabled = false;
                if (opcion == 'A') llenarListaAlumnos(lista);
                else llenarListaPersonal(list);
            } else
            {
                timer1.Enabled = false;
            }
        }
    }
}
