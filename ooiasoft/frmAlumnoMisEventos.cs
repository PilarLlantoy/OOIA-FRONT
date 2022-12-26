using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmAlumnoMisEventos : Form
    {
        private int idPersona;
        private EventoCicloWS.EventoCicloWSClient daoEventoCiclo;
        private CicloWS.CicloWSClient daoCiclo;
        public frmAlumnoMisEventos(int idPersona)
        {
            InitializeComponent();
            daoEventoCiclo = new EventoCicloWS.EventoCicloWSClient();
            daoCiclo = new CicloWS.CicloWSClient();
            this.idPersona = idPersona;

            //Llenar el comboBox con los ciclos
            BindingList<CicloWS.ciclo> ciclos;
            CicloWS.ciclo[] arr = daoCiclo.listarCiclos();
            if (arr == null) ciclos = new BindingList<CicloWS.ciclo>();
            else ciclos = new BindingList<CicloWS.ciclo>(arr.ToList());

            //Usar un auxiliar para el listado de todos los ciclos
            CicloWS.ciclo aux = new CicloWS.ciclo();
            aux.idCiclo = -1;
            ciclos.Insert(0, aux);

            //Asignar fuente de datos
            cbCiclos.DataSource = ciclos;
            cbCiclos.SelectedIndex = 0;

            //Llenar el data grid viewer con todos los eventos en los que el alumno se ha inscrito
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.DataSource = daoEventoCiclo.listarEventoCiclosInscritosParaAlumno(idPersona,"","", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"),"");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvEventos.CurrentRow != null)
            {
                frmInformacionEventoAlumno info = new frmInformacionEventoAlumno(idPersona, dgvEventos.CurrentRow.DataBoundItem as EventoCicloWS.eventoCiclo,0);
                info.ShowDialog();
                //Actualizar la busqueda
                cbCiclos.SelectedIndex = 0;
                txtNombre.Text = "";
                chbFechaEvento.Checked = false;
                rbTodos.Checked = true;
                dgvEventos.DataSource = daoEventoCiclo.listarEventoCiclosInscritosParaAlumno(idPersona, "", "", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
            }

        }

        private void chbFechaEvento_CheckStateChanged(object sender, EventArgs e)
        {
            dtpFechaIni.Enabled = !dtpFechaIni.Enabled;
            dtpFechaFin.Enabled = !dtpFechaFin.Enabled;
            lblFechaIni.Enabled = !lblFechaIni.Enabled;
            lblHasta.Enabled = !lblHasta.Enabled;
        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EventoCicloWS.eventoCiclo data = dgvEventos.Rows[e.RowIndex].DataBoundItem as EventoCicloWS.eventoCiclo;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = data.ciclo.anho + "-" + data.ciclo.periodo;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = data.titulo;
            dgvEventos.Rows[e.RowIndex].Cells[2].Value = data.fechaEvento.ToShortDateString();
            int hora = data.horaIni;
            String horaString;
            if (hora > 12) horaString = (hora - 12).ToString();
            else horaString = hora.ToString();
            if (hora < 12) horaString += ":00 a.m.";
            else horaString += ":00 p.m.";
            dgvEventos.Rows[e.RowIndex].Cells[3].Value = horaString;
            dgvEventos.Rows[e.RowIndex].Cells[4].Value = data.capacidadMax - data.cantAsistentes;
            String estado;
            if (DateTime.Today.CompareTo(data.fechaEvento) > 0) estado = "Pasado";
            else estado = "Pendiente";
            dgvEventos.Rows[e.RowIndex].Cells[5].Value = estado;
        }

        private void cbCiclos_Format(object sender, ListControlConvertEventArgs e)
        {
            //Obtiene el objeto actual
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            //Setea el valor
            if (data.idCiclo == -1) e.Value = "Todos";
            else e.Value = data.anho + "-" + data.periodo;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Realizar la busqueda
            DateTime fechaIni, fechaFin;
            CicloWS.ciclo cicloSelecionado = cbCiclos.SelectedItem as CicloWS.ciclo;
            String cicloCad = "";
            if (cicloSelecionado.idCiclo != -1) cicloCad += cicloSelecionado.anho + "-" + cicloSelecionado.periodo;

            if (chbFechaEvento.Checked == true)
            {
                fechaIni = dtpFechaIni.Value;
                fechaFin = dtpFechaFin.Value;

                //Validacion
                if (fechaFin.CompareTo(fechaIni) < 0)
                {
                    MessageBox.Show("Rango inválido de fechas. La fecha inicial no puede ser antes que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                fechaIni = Convert.ToDateTime("01-01-1000");
                fechaFin = Convert.ToDateTime("01-01-3000");
            }

            if (rbPasado.Checked == true)
            {
                if (fechaFin.CompareTo(DateTime.Today) > 0) fechaFin = DateTime.Today;
            }
            else if (rbPendiente.Checked == true)
            {
                if (fechaIni.CompareTo(DateTime.Today) < 0) fechaIni = DateTime.Today;
            }

            dgvEventos.DataSource = daoEventoCiclo.listarEventoCiclosInscritosParaAlumno(idPersona, cicloCad, txtNombre.Text, fechaIni, fechaFin, "");
        }
    }
}
