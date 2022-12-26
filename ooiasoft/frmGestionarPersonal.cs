using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace ooiasoft
{

    public partial class frmGestionarPersonal : Form
    {
        private frmNuevoPersonal formulario;
        private PersonaWS.PersonaWSClient daoPersonal;
        private PersonaWS.persona personaSeleccionada; // personal de una fila
        private string rutaArchivo; // ruta del txt
        private BindingList<PersonaWS.tutor> tutores; // lista de la tabla
        private BindingList<PersonaWS.administrativo> administrativos; // lista de la tabla
        private BindingList<PersonaWS.psicologo> psicologos; // lista de la tabla
        private BindingList<PersonaWS.persona> lista; // lista para previsualizar la data cargada
        private PersonaWS.tipoAdministrativo daoTipoAdministrativo;
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;
        BindingList<PersonaWS.persona> personal;

        private string nombreCompleto;
        private string correo;
        private string usuario;
        private string password;
        private int numCargados;

        public frmGestionarPersonal()
        {
            InitializeComponent();
            daoPersonal = new PersonaWS.PersonaWSClient();
            dgvPersonal.AutoGenerateColumns = false;
            personal = new BindingList<PersonaWS.persona>();
            funcionBusqueda();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            funcionBusqueda();

        }

        private void funcionBusqueda()
        {
            if (rbTutores.Checked == true) dgvPersonal.DataSource = daoPersonal.listarTutoresPorCodigoNombre(txtBuscar.Text);
            else if (rbPsic.Checked == true) dgvPersonal.DataSource = daoPersonal.listarPsicologosPorCodigoNombre(txtBuscar.Text);
            else if (rbAdmin.Checked == true) dgvPersonal.DataSource = daoPersonal.listarAdministrativosPorCodigoNombre(txtBuscar.Text);
            else
            {
                BindingList<PersonaWS.persona> personal = new BindingList<PersonaWS.persona>();
                PersonaWS.tutor[] arrTutores = daoPersonal.listarTutoresPorCodigoNombre(txtBuscar.Text);
                PersonaWS.administrativo[] arrAdministrativos = daoPersonal.listarAdministrativosPorCodigoNombre(txtBuscar.Text);
                PersonaWS.psicologo[] arrPsicologos = daoPersonal.listarPsicologosPorCodigoNombre(txtBuscar.Text);
                if (arrTutores != null)
                {
                    foreach (PersonaWS.tutor tutor in arrTutores)
                    {
                        personal.Add(tutor);
                    }
                }
                if (arrAdministrativos != null)
                {
                    foreach (PersonaWS.administrativo admin in arrAdministrativos)
                    {
                        personal.Add(admin);
                    }
                }
                if (arrPsicologos != null)
                {
                    foreach (PersonaWS.psicologo psic in arrPsicologos)
                    {
                        personal.Add(psic);
                    }
                }
                dgvPersonal.DataSource = personal;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow != null)
            {
                personaSeleccionada = (PersonaWS.persona)dgvPersonal.CurrentRow.DataBoundItem;
                Form frm = null;

                if (personaSeleccionada is PersonaWS.administrativo)
                {
                    PersonaWS.administrativo personalSeleccionado = new PersonaWS.administrativo();
                    personalSeleccionado = (PersonaWS.administrativo)dgvPersonal.CurrentRow.DataBoundItem;
                    frm = new frmAgregarModificarAdministrativo(personalSeleccionado);
                }

                if (personaSeleccionada is PersonaWS.tutor)
                {
                    PersonaWS.tutor personalSeleccionado = new PersonaWS.tutor();
                    personalSeleccionado = (PersonaWS.tutor)dgvPersonal.CurrentRow.DataBoundItem;
                    frm = new frmAgregarModificarTutor(personalSeleccionado);
                }

                if (personaSeleccionada is PersonaWS.psicologo)
                {
                    PersonaWS.psicologo personalSeleccionado = new PersonaWS.psicologo();
                    personalSeleccionado = (PersonaWS.psicologo)dgvPersonal.CurrentRow.DataBoundItem;
                    frm = new frmAgregarModificarPsicologo(personalSeleccionado);
                }
                if (frm != null) {
                    frm.ShowDialog();
                }
                txtBuscar.Text = "";
                funcionBusqueda();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow != null)
            {
                int resultado = 0;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este personal?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    personaSeleccionada = (PersonaWS.persona)dgvPersonal.CurrentRow.DataBoundItem;


                    if (personaSeleccionada is PersonaWS.administrativo)
                        resultado = daoPersonal.eliminarAdministrativo(personaSeleccionada.idPersona);

                    if (personaSeleccionada is PersonaWS.tutor)
                        resultado = daoPersonal.eliminarTutor(personaSeleccionada.idPersona);

                    if (personaSeleccionada is PersonaWS.psicologo)
                        resultado = daoPersonal.eliminarPsicologo(personaSeleccionada.idPersona);

                    if (resultado != 0)
                    {
                        txtBuscar.Text = "";
                        funcionBusqueda();
                        MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = buscador.FileName;
                    tbNombreArchivo.Text = rutaArchivo;
                    btnCargar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de archivo válido");
            }
        }

        private void dgvPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PersonaWS.persona data = dgvPersonal.Rows[e.RowIndex].DataBoundItem as PersonaWS.persona;
            if (data != null)
            {
                if (data is PersonaWS.tutor)
                    dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Tutor";
                else if (data is PersonaWS.administrativo)
                    dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Administrativo";
                else
                    dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Psicólogo";
                dgvPersonal.Rows[e.RowIndex].Cells[1].Value = data.codigoPUCP;
                dgvPersonal.Rows[e.RowIndex].Cells[2].Value = data.nombreCompleto;
                dgvPersonal.Rows[e.RowIndex].Cells[3].Value = data.edad;
                dgvPersonal.Rows[e.RowIndex].Cells[4].Value = data.telefono;
                dgvPersonal.Rows[e.RowIndex].Cells[5].Value = data.correo;
            }
        }

        private BindingList<PersonaWS.persona> leerArchivo()
        {
            BindingList<PersonaWS.persona> listaPrevia = new BindingList<PersonaWS.persona>();
            string[] lines = System.IO.File.ReadAllLines(rutaArchivo);
            foreach (string line in lines)
            {
                PersonaWS.persona persona = null;
                string[] cols = line.Split(';');

                if (cols[0][0] == 'D')
                {
                    PersonaWS.administrativo administrativo = new PersonaWS.administrativo();
                    administrativo.tipoSpecified = true;
                    administrativo.tipo = buscarTipoAdministrativo(cols[7]);
                    persona = administrativo;
                }
                else if (cols[0][0] == 'T')
                {
                    PersonaWS.tutor tutor = new PersonaWS.tutor();
                    tutor.horasSemanales = Int32.Parse(cols[7]);
                    tutor.fechaAsociacionSpecified = true;
                    tutor.fechaAsociacion = Convert.ToDateTime(cols[8]);
                    tutor.especialidad = new PersonaWS.especialidad();
                    tutor.especialidad.idEspecialidad = buscarEspecialidad(cols[9]);
                    tutor.rendimiento = 100.00;
                    persona = tutor;
                }
                else if (cols[0][0] == 'P') {
                    PersonaWS.psicologo psicologo = new PersonaWS.psicologo();
                    psicologo.colegiatura = cols[7];
                    psicologo.rendimiento = 100.00;
                    persona = psicologo;
                }
                persona.DNI = cols[1];
                persona.codigoPUCP = cols[2];
                persona.nombreCompleto = cols[3];
                persona.sexo = cols[4][0];
                persona.fechaNacimientoSpecified = true;
                persona.fechaNacimiento = Convert.ToDateTime(cols[5]);
                persona.edad = DateTime.Today.AddTicks(-persona.fechaNacimiento.Ticks).Year - 1;
                persona.telefono = cols[6];
                persona.usuario = "a" + cols[2];
                persona.password = generarPassword();
                persona.correo = "a" + cols[2] + "@pucp.edu.pe";
                persona.fechaNacimientoSpecified = true;
                persona.foto = null;
                listaPrevia.Add(persona);
            }
            return listaPrevia;
        }

        private PersonaWS.tipoAdministrativo buscarTipoAdministrativo(string nombreTipo)
        {
            if (nombreTipo.CompareTo("Apoyo") == 0)
                return PersonaWS.tipoAdministrativo.Apoyo;
            else if (nombreTipo.CompareTo("Coordinador") == 0)
                return PersonaWS.tipoAdministrativo.Coordinador;
            else if (nombreTipo.CompareTo("Practicante") == 0)
                return PersonaWS.tipoAdministrativo.Practicante;
            else if (nombreTipo.CompareTo("Secretario") == 0)
                return PersonaWS.tipoAdministrativo.Secretario;
            else return PersonaWS.tipoAdministrativo.SuperUsuario;                
        }

        private int buscarEspecialidad(string nombreEsp)
        {
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            BindingList<EspecialidadWS.especialidad> especialidades = new BindingList<EspecialidadWS.especialidad>(daoEspecialidad.listarEspecialidadesPorNombre(nombreEsp).ToList());
            PersonaWS.especialidad esp = new PersonaWS.especialidad();
            esp.idEspecialidad = especialidades[0].idEspecialidad;
            esp.nombre = especialidades[0].nombre;
            return esp.idEspecialidad;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lista = leerArchivo();
            previsualizarCargaPersonal prev = new previsualizarCargaPersonal(lista);
            prev.ShowDialog();
            if (prev.OpcionSeleccionada == 1)
            {
                BindingList<PersonaWS.persona> lastList = prev.Personal;
                ProgressBarClase frm = new ProgressBarClase(lastList);
                frm.ShowDialog();
                txtBuscar.Text = "";
                PersonaWS.administrativo[] arrAdministrativos = daoPersonal.listarAdministrativosPorCodigoNombre("");
                PersonaWS.psicologo[] arrPsicologos = daoPersonal.listarPsicologosPorCodigoNombre("");
                PersonaWS.tutor[] arrTutores = daoPersonal.listarTutoresPorCodigoNombre("");
                if (arrTutores != null)
                {
                    foreach (PersonaWS.tutor tutor in arrTutores)
                    {
                        if(tutor != null)
                            personal.Add(tutor);
                    }
                }
                if (arrAdministrativos != null)
                {
                    foreach (PersonaWS.administrativo admin in arrAdministrativos)
                    {
                        if (admin != null)
                            personal.Add(admin);
                    }
                }
                if (arrPsicologos != null)
                {
                    foreach (PersonaWS.psicologo psic in arrPsicologos)
                    {
                        if (psic != null)
                            personal.Add(psic);
                    }
                }
                dgvPersonal.DataSource = personal;
            }
            tbNombreArchivo.Text = "";
        }
        private string generarPassword()
        {
            string pass = "";
            Random rand = new Random();
            string alphanum = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j = 0; j < 10; j++) pass += alphanum[rand.Next(alphanum.Length)];
            return pass;
        }
        
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            formulario = new frmNuevoPersonal();
            formulario.ShowDialog();
            //De acuerdo a la seleccion de tipo
            Form frm = null;
            if (formulario.Tipo == 'D') frm = new frmAgregarModificarAdministrativo();
            else if (formulario.Tipo == 'T') frm = new frmAgregarModificarTutor();
            else if (formulario.Tipo == 'P') frm = new frmAgregarModificarPsicologo();
            if (frm != null)
            {
                frm.ShowDialog();
                rbTodos.Checked = true;
                txtBuscar.Text = "";
                funcionBusqueda();
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
    }
}
