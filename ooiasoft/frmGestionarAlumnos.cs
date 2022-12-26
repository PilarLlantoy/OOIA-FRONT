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
    public partial class frmGestionarAlumnos : Form
    {
        private PersonaWS.PersonaWSClient daoAlumno;
        private PersonaWS.alumno alumnoSeleccionado; // alumno de una fila
        private string rutaArchivo; // ruta del txt
        private BindingList<PersonaWS.alumno> lista; // lista para previsualizar la data cargada
        private EspecialidadWS.EspecialidadWSClient daoEspecialidad;

        private string nombreCompleto;
        private string usuario;
        private string password;

        public frmGestionarAlumnos()
        {
            InitializeComponent();

            daoAlumno = new PersonaWS.PersonaWSClient();
            alumnoSeleccionado = new PersonaWS.alumno(); // para modificar o eliminar
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno agregar = new frmAgregarAlumno();
            if(agregar.ShowDialog() == DialogResult.OK)
            {
                tbBuscar.Text = "";
                dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null) 
            { 
                alumnoSeleccionado = (PersonaWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                frmVerEditarAlumno modificar = new frmVerEditarAlumno(alumnoSeleccionado);
                modificar.ShowDialog();
                tbBuscar.Text = "";
                dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre(tbBuscar.Text); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este alumno?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    alumnoSeleccionado = (PersonaWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                    int resultado = daoAlumno.eliminarAlumno(alumnoSeleccionado.idPersona);
                    if (resultado != 0)
                    {
                        tbBuscar.Text = "";
                        dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
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

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PersonaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem as PersonaWS.alumno;
            if (data != null)
            {
                dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = data.codigoPUCP;
                dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = data.nombreCompleto;
                dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
                dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = data.telefono;
                dgvAlumnos.Rows[e.RowIndex].Cells[4].Value = data.correo;
            }
        }

        private BindingList<PersonaWS.alumno> leerArchivo()
        {
            BindingList<PersonaWS.alumno> listaPrevia = new BindingList<PersonaWS.alumno>();
            string[] lines = System.IO.File.ReadAllLines(rutaArchivo);
            foreach (string line in lines)
            {
                PersonaWS.alumno alumno = new PersonaWS.alumno();
                string[] cols = line.Split(';');
                alumno.DNI = cols[0];
                alumno.codigoPUCP = cols[1];
                alumno.nombreCompleto = cols[2];
                alumno.sexo = cols[3][0];
                alumno.fechaNacimiento = Convert.ToDateTime(cols[4]);
                alumno.fechaNacimientoSpecified = true;
                alumno.telefono = cols[5];
                alumno.escalaPago = Int32.Parse(cols[6]);
                alumno.usuario = "a" + cols[1];
                alumno.password = generarPassword();
                alumno.correo = "a" + cols[1] + "@pucp.edu.pe";
                alumno.fechaNacimientoSpecified = true;
                alumno.edad = DateTime.Today.AddTicks(-alumno.fechaNacimiento.Ticks).Year - 1;
                alumno.tipo = PersonaWS.tipoAlumno.Regular;
                alumno.tipoSpecified = true;
                alumno.especialidad = buscarEspecialidad(cols[7]);
                listaPrevia.Add(alumno);
            }
            return listaPrevia;
        }

        private string generarPassword()
        {
            string pass = "";
            Random rand = new Random();
            string alphanum = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j = 0; j < 10; j++) pass += alphanum[rand.Next(alphanum.Length)];
            return pass;
        }

        private PersonaWS.especialidad buscarEspecialidad(string nombreEsp)
        {
            daoEspecialidad = new EspecialidadWS.EspecialidadWSClient();
            BindingList<EspecialidadWS.especialidad> especialidades = new BindingList<EspecialidadWS.especialidad>(daoEspecialidad.listarEspecialidadesPorNombre(nombreEsp).ToList());
            PersonaWS.especialidad esp = new PersonaWS.especialidad();
            esp.idEspecialidad = especialidades[0].idEspecialidad;
            esp.nombre = especialidades[0].nombre;
            return esp;
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            lista = leerArchivo();
            previsualizarCargaAlumnos prev = new previsualizarCargaAlumnos(lista);
            prev.ShowDialog();
            if (prev.OpcionSeleccionada == 1)
            {
                BindingList<PersonaWS.alumno> lastList = prev.Alumnos;
                ProgressBarClase frm = new ProgressBarClase(lastList);
                frm.ShowDialog();               
                if (frm.Insertado == 1) MessageBox.Show("Se ha registrado la data con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBuscar.Text = "";
                dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
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

        private void TimerAlumnos_Tick(object sender, EventArgs e)
        {

        }
    }
}
