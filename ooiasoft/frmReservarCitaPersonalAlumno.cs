using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmReservarCitaPersonalAlumno : Form
    {
        private int idPersonal;
        private int idCiclo;
        private int horaElegida = 10;

        private PersonaWS.PersonaWSClient daoAlumno;
        private CitaWS.CitaWSClient daoCita;
       
        public frmReservarCitaPersonalAlumno(int idPersonal, int idCiclo)
        {
            InitializeComponent();
            this.idPersonal = idPersonal;
            this.idCiclo = idCiclo;
            daoCita = new CitaWS.CitaWSClient();
            daoAlumno = new PersonaWS.PersonaWSClient();

            //Llenar el comboBox de motivos de cita
            cbMotivoCita.DataSource = daoCita.listarMotivosCita();
            cbMotivoCita.DisplayMember = "descripcion";
            cbMotivoCita.ValueMember = "idMotivo";
            cbMotivoCita.SelectedIndex = -1;
            cbMotivoCita.Text = "Seleccionar";

            dgvAlumnos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Si ingresa alguna cadena extrana, simplemente la busqueda no devuelve lo querido
            dgvAlumnos.DataSource = daoAlumno.listarAlumnosPorCodigoONombre(txtCodigoNombre.Text);
        }

        private void btnReservarCita_Click(object sender, EventArgs e)
        {
            //Validaciones

            //Si la fecha de la cita es antes del dia actual, es invalido
            if(DateTime.Today.CompareTo(dtpFechaCita.Value) > 0)
            {
                MessageBox.Show("La fecha no puede ser menor al día actual.","Error en el Registro.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Verificar que eligio un motivo de cita
            if(cbMotivoCita.Text.CompareTo("Seleccionar") == 0)
            {
                MessageBox.Show("Debe elegir un motivo para la cita a reservar.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificar que selecciono a un alumno
            if(dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Debe elegir un alumno para la cita a reservar.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si llega hasta aqui, puede reservar la cita
            CitaWS.cita cita = new CitaWS.cita();
            CitaWS.motivoCita motivo = new CitaWS.motivoCita();
            //Solo importa el ID
            motivo.idMotivo = ((CitaWS.motivoCita)cbMotivoCita.SelectedItem).idMotivo;
            cita.motivoCita = motivo;
            //Del personal solo importa el ID tambien
            CitaWS.personalCitas personal = new CitaWS.personalCitas();
            personal.idPersona = idPersonal;
            cita.personalCitas = personal;
            //Asociar el ciclo
            CitaWS.ciclo ciclo = new CitaWS.ciclo();
            ciclo.idCiclo = idCiclo;
            cita.ciclo = ciclo;
            //Asociar el alumno
            CitaWS.alumno alum = new CitaWS.alumno();
            alum.idPersona = ((PersonaWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem).idPersona;
            cita.alumno = alum;

            //Setear fechas
            cita.fechaRegistro = DateTime.Today;
            cita.fechaRegistroSpecified = true;
            cita.fechaAtencion = dtpFechaCita.Value;
            cita.fechaAtencionSpecified = true;
            cita.hora = horaElegida;

            //Agendar
            int resultado = daoCita.insertarCita(cita);
            if (resultado == 0)
            {
                MessageBox.Show("Ha ocurrido un error. No se ha podido agendar la cita.", "Error en el Registro de Cita.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(resultado == -1)
            {
                MessageBox.Show("Usted tiene una cita programada para la misma hora en la misma fecha.", "Error en el Registro de Cita.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La cita ha sido agendada con éxito. Puede ver los detalles de la cita en la sección de 'Citas Programadas'", "Registro de Cita Exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMotivoCita.SelectedIndex = -1;
                cbMotivoCita.Text = "Seleccionar";
                dtpFechaCita.Value = DateTime.Today;
                dgvAlumnos.DataSource = null;
                lblFormatoHora.Text = "a.m.";
                numUPHora.Value = 10;
            }
        }

        private void numUPHora_ValueChanged(object sender, EventArgs e)
        {
            //Calcular la hora cambiada actual
            horaElegida = (int)numUPHora.Value;
            if (horaElegida < 12 && lblFormatoHora.Text.CompareTo("p.m.") == 0)
            {
                if (horaElegida != 11) horaElegida += 12;
            }

            //Limitar
            if (horaElegida < 10) horaElegida = 10;
            else if (horaElegida > 19) horaElegida = 19;

            //Colocar hora y formato correcto
            if (horaElegida < 12) lblFormatoHora.Text = "a.m.";
            else lblFormatoHora.Text = "p.m.";

            if (horaElegida > 12) numUPHora.Value = horaElegida - 12;
            else numUPHora.Value = horaElegida;
        }
    }
}
