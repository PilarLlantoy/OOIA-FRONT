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
    public partial class frmInformacionEventoAlumno : Form
    {
        private EventoCicloWS.eventoCiclo evento;
        private EventoCicloWS.EventoCicloWSClient daoEventoCiclo;
        private int idAlumno;
        public frmInformacionEventoAlumno(int idAlumno, EventoCicloWS.eventoCiclo evento, int padre)
        {
            InitializeComponent();
            this.evento = evento;
            this.idAlumno = idAlumno;
            daoEventoCiclo = new EventoCicloWS.EventoCicloWSClient();

            lblTitulo.Rtf = evento.tituloUTF;
            rtbDescripcion.Rtf = evento.descripcionUTF;

            //Llenar los datos del formulario
            if (evento.foto != null)
            {
                MemoryStream ms = new MemoryStream(evento.foto);
                pbEvento.Image = Image.FromStream(ms);
            }

            lblInscritosEvento.Text = evento.cantAsistentes.ToString();
            lblLugar.Text = evento.aula;
            lblFecha.Text = evento.fechaEvento.ToLongDateString();
            int hora = evento.horaIni;
            String horaString;
            if (hora > 12) horaString = (hora - 12).ToString();
            else horaString = hora.ToString();
            if (hora < 12) horaString += ":00 a.m.";
            else horaString += ":00 p.m.";
            lblHora.Text = horaString;
            lblVacantes.Text = (evento.capacidadMax - evento.cantAsistentes).ToString();
            lblOrganizadores.Text = evento.organizadores;

            //Validar la accion con respecto al boton de accion
            if (DateTime.Today.CompareTo(evento.fechaEvento) > 0) btnAccion.Visible = false;
            else if (padre == 0) btnAccion.Text = "Desinscribirme";
            else {
                if (evento.capacidadMax - evento.cantAsistentes == 0) btnAccion.Visible = false;
                else btnAccion.Text = "Inscribirme";
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            int resultado;
            //Tomar la decision
            if (btnAccion.Text.CompareTo("Inscribirme") == 0)
            {
                resultado = daoEventoCiclo.inscribirAlumnoEventoCiclo(idAlumno, evento.idEventoCiclo);
                if (resultado != -1)
                {
                    MessageBox.Show("Se ha inscrito al evento " + evento.titulo + " con éxito.", "Éxito en la inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. No se ha podido inscribir en el evento  " + evento.titulo + ".", "Error en la inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea cancelar su inscripción al evento?", "Mensaje de Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    resultado = daoEventoCiclo.desinscribirAlumnoEventoCiclo(idAlumno, evento.idEventoCiclo);
                    if (resultado != -1)
                    {
                        MessageBox.Show("Usted se ha desinscrito del evento  " + evento.titulo + ".", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. No se ha podido desinscribir del evento  " + evento.titulo + ".", "Error en la desinscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
