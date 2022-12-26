using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmInformacionCitaAlumno : Form
    {
        private CitaWS.cita cita;
        private int idAlumno;
        private CitaWS.CitaWSClient daoCita;

        public frmInformacionCitaAlumno(int idAlumno, CitaWS.cita cita)
        {
            InitializeComponent();
            this.cita = cita;
            this.idAlumno = idAlumno;
            daoCita = new CitaWS.CitaWSClient();

            if (DateTime.Today.CompareTo(cita.fechaAtencion) > 0)
            {
                lblEstado.Text = "Pasada";
                txtBoxAsistencia.Text = cita.asistio ? "Asistió" : "Faltó";
            }
            else
            {
                txtBoxAsistencia.Text = "";
                lblEstado.Text = "Pendiente";
                btnCancelar.Visible = true;
            }

            dateTimeFechaCita.Value = cita.fechaAtencion;
            dateTimeFechaRegistro.Value = cita.fechaRegistro;
            int hora = cita.hora;
            String horaString;
            if (hora > 12) horaString = (hora - 12).ToString();
            else horaString = hora.ToString();
            if (hora < 12) horaString += ":00 a.m.";
            else horaString += ":00 p.m.";
            txtBoxHora.Text = horaString;
            txtBoxTipoCita.Text = cita.motivoCita.tipoCita.ToString();
            txtBoxMotivoCita.Text = cita.motivoCita.descripcion;
            txtBoxCiclo.Text = cita.ciclo.anho + " - " + cita.ciclo.periodo;
            txtBoxNombreAsesor.Text = cita.personalCitas.nombreCompleto;
            txtBoxCodPUCP.Text = cita.personalCitas.codigoPUCP;
            txtBoxCelular.Text = cita.personalCitas.telefono;
            txtBoxCorreo.Text = cita.personalCitas.correo;
            txtBoxRendimiento.Text = cita.personalCitas.rendimiento.ToString();

            if (cita.personalCitas.foto != null)
            {
                MemoryStream ms = new MemoryStream(cita.personalCitas.foto);
                pbIconoUser.Image = Image.FromStream(ms);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cancelar la cita con el asesor?", "Mensaje de Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoCita.eliminarCita(cita.idCita);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha anulado su reserva de la cita.", "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Ha ocurrido un error. No se ha podido cancelar su reserva de la cita.", "Error en la Operación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
