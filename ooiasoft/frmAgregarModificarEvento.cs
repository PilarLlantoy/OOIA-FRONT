using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmAgregarModificarEvento : Form
    {
        private int idCicloActual;
        private EventoCicloWS.eventoCiclo evento;
        private EventoCicloWS.EventoCicloWSClient daoEvento;
        // 0: registrar, 1: ver/modificar
        private int operacion;
        private int horaElegida = 10;
        public frmAgregarModificarEvento(int idCicloActual)
        {
            InitializeComponent();
            this.idCicloActual = idCicloActual;
            operacion = 0;
            daoEvento = new EventoCicloWS.EventoCicloWSClient();
            evento = new EventoCicloWS.eventoCiclo();
            btnEditar.Visible = false;
        }

        public frmAgregarModificarEvento(EventoCicloWS.eventoCiclo evento)
        {
            InitializeComponent();
            this.evento = evento;
            operacion = 1;
            btnVerInscritos.Visible = true;
            daoEvento = new EventoCicloWS.EventoCicloWSClient();
            btnEditar.Visible = true;
            llenarFormulario();
            bloquearComponentes();
            bCancelar.Text = "Volver";
            if (DateTime.Today.CompareTo(evento.fechaEvento) > 0) btnEditar.Visible = false;

            //Observacion de JP Nancy Espinoza, si ya hay inscritos al evento, no deberia poder modificarse la fecha
            if (evento.cantAsistentes > 0) 
            {
                mcFechaEvento.Enabled = false;
                lblObs.Visible = true;
            }
        }

        private void llenarFormulario()
        {
            editarEvento1.RtbTitulo.Rtf = evento.tituloUTF;
            editarEvento1.RtbDescripcion.Rtf = evento.descripcionUTF;
            //Mostrar la foto solo si tiene una
            if (evento.foto != null)
            {
                MemoryStream ms = new MemoryStream(evento.foto);
                editarEvento1.PbImagen.Image = new Bitmap(ms);
            }
            numUpCapacidad.Value = evento.capacidadMax;
            mcFechaEvento.SelectionStart = evento.fechaEvento;
            numUPHora.Text = "" + evento.horaIni;
            numUPDuracion.Text = "" + evento.duracionHoras;
            tbLugarEvento.Text = evento.aula;
            tbVideo.Text = evento.linkVideo;
            tbOrganizadores.Text = evento.organizadores;
        }

        private void bloquearComponentes()
        {
            lblObs.Enabled = false;
            editarEvento1.Enabled = false;
            numUpCapacidad.Enabled = false;
            mcFechaEvento.Enabled = false;
            numUPHora.Enabled = false;
            numUPDuracion.Enabled = false;
            tbLugarEvento.Enabled = false;
            tbVideo.Enabled = false;
            bAgregarVideo.Enabled = false;
            tbOrganizadores.Enabled = false;
            btnGuardar.Enabled = false;
            bCancelar.Enabled = true;
            btnEditar.Enabled = true;
            lblCapacidadMaxima.Enabled = false;
            lblPersonas.Enabled = false;
            lblFechaEvento.Enabled = false;
            lblHoraEvento.Enabled = false;
            lblFormatoHora.Enabled = false;
            lblLugarEvento.Enabled = false;
            lblVideo.Enabled = false;
            lblOrganizadores.Enabled = false;
            lblDuracionEvento.Enabled = false;
            lblHoras.Enabled = false;
        }

        private void bAgregarVideo_Click(object sender, EventArgs e)
        {
            frmVisualizarVideo formulario = new frmVisualizarVideo();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                tbVideo.Text = formulario.LinkVideo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            evento.tituloUTF = editarEvento1.RtbTitulo.Rtf;
            evento.titulo = editarEvento1.RtbTitulo.Text;
            evento.descripcionUTF = editarEvento1.RtbDescripcion.Rtf;
            evento.descripcion = editarEvento1.RtbDescripcion.Text;
            if (editarEvento1.PbImagen.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                editarEvento1.PbImagen.Image.Save(ms, editarEvento1.PbImagen.Image.RawFormat);
                evento.foto = ms.ToArray();
            }

            if((int)numUpCapacidad.Value < evento.cantAsistentes)
            {
                MessageBox.Show("No puede disminuir la cantidad de vacantes a un número menor a la cantidad de inscritos actualmente. Se sugiere volver a registrar el evento.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            evento.aula = tbLugarEvento.Text;
            evento.fechaEvento = mcFechaEvento.SelectionStart;
            evento.fechaEventoSpecified = true;
            evento.fechaRegistro = DateTime.Today;
            evento.fechaRegistroSpecified = true;
            evento.capacidadMax = (int)numUpCapacidad.Value;
            evento.horaIni = horaElegida;
            evento.duracionHoras = Int32.Parse(numUPDuracion.Text);
            evento.linkVideo = tbVideo.Text;
            evento.organizadores = tbOrganizadores.Text;

            int resultado;
            if(operacion == 0)
            {
                EventoCicloWS.ciclo ciclo = new EventoCicloWS.ciclo();
                ciclo.idCiclo = idCicloActual;
                evento.ciclo = ciclo;
                resultado = daoEvento.insertarEventoCiclo(evento);
                if(resultado != 0)
                {
                    evento.idEventoCiclo = resultado;
                    MessageBox.Show("Se ha registrado el evento con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bCancelar.Text = "Volver";
                    bloquearComponentes();
                }
                else MessageBox.Show("Ha ocurrido un error en el registro del evento.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultado = daoEvento.modificarEventoCiclo(evento);
                if (resultado != 0)
                {
                    evento.alumnosInscritos = new EventoCicloWS.alumno[0];
                    MessageBox.Show("Se ha modificado el evento con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bCancelar.Text = "Volver";
                    btnEditar.Enabled = true;
                    bloquearComponentes();
                }
                else MessageBox.Show("Ha ocurrido un error en la modificación del evento.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (operacion == 1 && bCancelar.Text.CompareTo("Cancelar") == 0)
            {
                llenarFormulario();
                bloquearComponentes();
                btnEditar.Enabled = true;
                bCancelar.Text = "Volver";
            }
            else this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            bCancelar.Text = "Cancelar";
            //Activar el formulario
            editarEvento1.Enabled = true;
            numUpCapacidad.Enabled = true;
            //Observacion Lab 10
            if (evento.cantAsistentes > 0) mcFechaEvento.Enabled = false;
            else mcFechaEvento.Enabled = true;
            lblObs.Enabled = true;
            numUPHora.Enabled = true;
            numUPDuracion.Enabled = true;
            tbLugarEvento.Enabled = true;
            bAgregarVideo.Enabled = true;
            tbOrganizadores.Enabled = true;
            btnGuardar.Enabled = true;
            bCancelar.Enabled = true;
            lblCapacidadMaxima.Enabled = true;
            lblPersonas.Enabled = true;
            lblFechaEvento.Enabled = true;
            lblHoraEvento.Enabled = true;
            lblFormatoHora.Enabled = true;
            lblLugarEvento.Enabled = true;
            lblVideo.Enabled = true;
            lblOrganizadores.Enabled = true;
            lblOrganizadores.Enabled = true;
            lblDuracionEvento.Enabled = true;
            lblHoras.Enabled = true;
        }

        private void btnVerInscritos_Click(object sender, EventArgs e)
        {
            frmVerInscritosEvento frm = new frmVerInscritosEvento(evento);
            frm.ShowDialog();
        }

        private void numUPHora_ValueChanged(object sender, EventArgs e)
        {
            //Calcular la hora cambiada actual
            horaElegida = (int)numUPHora.Value;
            if (horaElegida < 12 && lblFormatoHora.Text.CompareTo("p.m.") == 0) 
            { 
                if(horaElegida != 11) horaElegida += 12;
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
