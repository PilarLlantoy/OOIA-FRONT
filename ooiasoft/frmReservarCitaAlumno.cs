using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmReservarCitaAlumno : Form
    {
        private frmSeleccionarDisponibilidad frm;
        private int idCiclo;
        private int idAlumno;

        private PersonaWS.PersonaWSClient daoPersonal;
        private CitaWS.CitaWSClient daoCita;


        public frmReservarCitaAlumno(int idAlumno, int idCiclo)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
            this.idCiclo = idCiclo;
            daoCita = new CitaWS.CitaWSClient();
            daoPersonal = new PersonaWS.PersonaWSClient();

            //Llenar el comboBox de motivos de cita
            cbMotivoCita.DataSource = daoCita.listarMotivosCita();
            cbMotivoCita.DisplayMember = "descripcion";
            cbMotivoCita.ValueMember = "idMotivo";
            cbMotivoCita.SelectedIndex = -1;
            cbMotivoCita.Text = "Seleccionar";

            dgvTutores.AutoGenerateColumns = false;

            BindingList<PersonaWS.persona> personal = new BindingList<PersonaWS.persona>();
            PersonaWS.tutor[] arrTutores = daoPersonal.listarTutoresPorCodigoNombre("");
            PersonaWS.psicologo[] arrPsicologos = daoPersonal.listarPsicologosPorCodigoNombre("");
            if (arrTutores != null)
            {
                foreach (PersonaWS.tutor tutor in arrTutores)
                {
                    personal.Add(tutor);
                }
            }
            if (arrPsicologos != null)
            {
                foreach (PersonaWS.psicologo psic in arrPsicologos)
                {
                    personal.Add(psic);
                }
            }
            dgvTutores.DataSource = personal;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Si ingresa alguna cadena extrana, simplemente la busqueda no devuelve lo querido
            BindingList<PersonaWS.persona> personal = new BindingList<PersonaWS.persona>();
            PersonaWS.tutor[] arrTutores = daoPersonal.listarTutoresPorCodigoNombre(txtCodigoNombre.Text);
            PersonaWS.psicologo[] arrPsicologos = daoPersonal.listarPsicologosPorCodigoNombre(txtCodigoNombre.Text);
            if (arrTutores != null)
            {
                foreach (PersonaWS.tutor tutor in arrTutores)
                {
                    personal.Add(tutor);
                }
            }
            if (arrPsicologos != null)
            {
                foreach (PersonaWS.psicologo psic in arrPsicologos)
                {
                    personal.Add(psic);
                }
            }
            dgvTutores.DataSource = personal;
        }

        private void btnReservarCita_Click(object sender, EventArgs e)
        {
            //Validaciones

            //Si la fecha de la cita es antes del dia actual, es invalido
            if(DateTime.Today.CompareTo(dtpFechaCita.Value) > 0)
            {
                MessageBox.Show("No puede reservar una cita para una fecha pasada.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Debe haber seleccionado una hora
            if(lblHoraSeleccionada.Text.CompareTo("--:--") == 0)
            {
                MessageBox.Show("Debe seleccionar una hora para la cita.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar que selecciono a un personal de citas
            if(pbFotoTutor.Visible == false)
            {
                MessageBox.Show("Debe seleccionar un asesor para ver su disponibilidad.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Verificar que eligio un motivo de cita
            if (cbMotivoCita.Text.CompareTo("Seleccionar") == 0)
            {
                MessageBox.Show("Debe elegir un motivo para la cita a reservar.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Si llega hasta aqui, puede reservar la cita
            CitaWS.cita cita = new CitaWS.cita();
            //Llenar el motivo
            cita.motivoCita = (CitaWS.motivoCita)cbMotivoCita.SelectedItem;

            //Del personal solo importa el ID tambien
            CitaWS.personalCitas personal = new CitaWS.personalCitas();
            personal.idPersona = ((PersonaWS.persona)dgvTutores.CurrentRow.DataBoundItem).idPersona;
            cita.personalCitas = personal;
            //Asociar el ciclo
            CitaWS.ciclo ciclo = new CitaWS.ciclo();
            ciclo.idCiclo = idCiclo;
            cita.ciclo = ciclo;
            //Asociar el alumno
            CitaWS.alumno alum = new CitaWS.alumno();
            alum.idPersona = idAlumno;
            cita.alumno = alum;

            //Setear fechas
            cita.fechaRegistro = DateTime.Today;
            cita.fechaRegistroSpecified = true;
            cita.fechaAtencion = dtpFechaCita.Value;
            cita.fechaAtencionSpecified = true;
            cita.hora = frm.HoraSeleccionada;

            //Agendar
            int resultado = daoCita.insertarCita(cita);
            if (resultado == 0)
            {
                MessageBox.Show("Ha ocurrido un error. No se ha podido agendar la cita.", "Error en el Registro de Cita.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La cita ha sido agendada con éxito. Puede ver los detalles de la cita en la sección de 'Citas Programadas'", "Registro de Cita Exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblHoraSeleccionada.Text = "--:--";
                txtCodigoNombre.Text = "";
                dgvTutores.DataSource = null;

                cbMotivoCita.SelectedIndex = -1;
                cbMotivoCita.Text = "Seleccionar";
                dtpFechaCita.Value = DateTime.Today;

                lblTutorSeleccionado.Text = "";
                lblNombreTutor.Text = "";
                lblCorreo.Text = "";
                lblEspecialidadColegiatura.Text = "";
                pbFotoTutor.Visible = false;
            }
        }

        private void btnVerHorarioDisponibilidad_Click(object sender, EventArgs e)
        {
            DateTime fecha_seleccionada = dtpFechaCita.Value;
            if (pbFotoTutor.Visible == false)
            {
                MessageBox.Show("Debe seleccionar un asesor para ver su disponibilidad.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fecha_seleccionada < DateTime.Today)
            {
                MessageBox.Show("No puede reservar una cita para una fecha pasada.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frm = new frmSeleccionarDisponibilidad(idCiclo,((PersonaWS.persona)dgvTutores.CurrentRow.DataBoundItem).idPersona,fecha_seleccionada);
            if (frm.ShowDialog() == DialogResult.OK) lblHoraSeleccionada.Text = frm.HoraSeleccionada + ":00" + " - " + (frm.HoraSeleccionada+1) + ":00";
        }

        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PersonaWS.persona data = dgvTutores.Rows[e.RowIndex].DataBoundItem as PersonaWS.persona;
            dgvTutores.Rows[e.RowIndex].Cells[0].Value = data.codigoPUCP;
            dgvTutores.Rows[e.RowIndex].Cells[1].Value = data.nombreCompleto;
            dgvTutores.Rows[e.RowIndex].Cells[2].Value = data.correo;
            if (data is PersonaWS.tutor)
                dgvTutores.Rows[e.RowIndex].Cells[3].Value = "Tutor";
            else
                dgvTutores.Rows[e.RowIndex].Cells[3].Value = "Psicólogo";
        }

        private void dgvTutores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(dgvTutores.Rows.Count > 0) dgvTutores.Rows[0].Selected = false;
            lblTutorSeleccionado.Text = "";
            lblNombreTutor.Text = "";
            lblCorreo.Text = "";
            lblEspecialidadColegiatura.Text = "";
            pbFotoTutor.Visible = false;
        }

        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTutores.CurrentRow != null)
            {
                PersonaWS.personalCitas data = dgvTutores.CurrentRow.DataBoundItem as PersonaWS.personalCitas;
                if (data is PersonaWS.tutor)
                {
                    lblTutorSeleccionado.Text = "Tutor Seleccionado";
                    lblEspecialidadColegiatura.Text = "Especialidad: " + ((PersonaWS.tutor)data).especialidad.nombre;
                }
                else
                {
                    lblTutorSeleccionado.Text = "Psicólogo Seleccionado";
                    lblEspecialidadColegiatura.Text = "Colegiatura: " + ((PersonaWS.psicologo)data).colegiatura;
                }
                lblNombreTutor.Text = "Nombre: " + data.nombreCompleto;
                lblCorreo.Text = "Correo: " + data.correo;
                pbFotoTutor.Visible = true;
                if (data.foto != null)
                {
                    MemoryStream ms = new MemoryStream(data.foto);
                    pbFotoTutor.Image = Image.FromStream(ms);
                }
            }
            lblHoraSeleccionada.Text = "--:--";
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            lblHoraSeleccionada.Text = "--:--";
        }
    }
}
