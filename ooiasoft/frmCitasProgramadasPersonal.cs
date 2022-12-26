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
    public partial class frmCitasProgramadasPersonal : Form
    {
        private int idPersonal;

        private CitaWS.CitaWSClient daoCita;
        private CicloWS.CicloWSClient daoCiclo;

        public frmCitasProgramadasPersonal(int idPersonal)
        {
            InitializeComponent();
            this.idPersonal = idPersonal;

            daoCiclo = new CicloWS.CicloWSClient();
            daoCita = new CitaWS.CitaWSClient();

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
            cbCiclo.DataSource = ciclos;
            cbCiclo.SelectedIndex = 0;

            //Llenar el data grid viewer con todos los eventos en los que el alumno se ha inscrito
            dgvCitas.AutoGenerateColumns = false;
            dgvCitas.DataSource = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idPersonal, "", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
        }

        private void btnVerDetalles_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null)
            {
                frmInformacionCitaPersonal info = new frmInformacionCitaPersonal(idPersonal, dgvCitas.CurrentRow.DataBoundItem as CitaWS.cita);
                info.ShowDialog();
                //Actualizar la busqueda
                cbCiclo.SelectedIndex = 0;
                txtNombreAlumno.Text = "";
                rbTodos.Checked = true;
                chbFecha.Checked = false;
                dgvCitas.DataSource = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idPersonal, "", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Realizar la busqueda
            DateTime fechaIni, fechaFin;
            CicloWS.ciclo cicloSelecionado = cbCiclo.SelectedItem as CicloWS.ciclo;
            String cicloCad = "";
            if (cicloSelecionado.idCiclo != -1) cicloCad += cicloSelecionado.anho + "-" + cicloSelecionado.periodo;

            if (chbFecha.Checked == true)
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
                if (fechaFin.CompareTo(DateTime.Today) > 0) fechaFin = DateTime.Today.AddDays(-1);
            }
            else if (rbPendiente.Checked == true)
            {
                if (fechaIni.CompareTo(DateTime.Today) < 0) fechaIni = DateTime.Today;
            }

            dgvCitas.DataSource = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idPersonal, cicloCad, fechaIni, fechaFin, txtNombreAlumno.Text);
        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CitaWS.cita data = dgvCitas.Rows[e.RowIndex].DataBoundItem as CitaWS.cita;
            dgvCitas.Rows[e.RowIndex].Cells[0].Value = data.ciclo.anho + "-" + data.ciclo.periodo;
            dgvCitas.Rows[e.RowIndex].Cells[1].Value = data.alumno.codigoPUCP;
            dgvCitas.Rows[e.RowIndex].Cells[2].Value = data.alumno.nombreCompleto;
            dgvCitas.Rows[e.RowIndex].Cells[3].Value = data.alumno.telefono;
            dgvCitas.Rows[e.RowIndex].Cells[4].Value = data.alumno.correo;
            dgvCitas.Rows[e.RowIndex].Cells[5].Value = data.fechaAtencion.ToShortDateString();
            int hora = data.hora;
            String horaString;
            if (hora > 12) horaString = (hora - 12).ToString();
            else horaString = hora.ToString();
            if (hora < 12) horaString += ":00 a.m.";
            else horaString += ":00 p.m.";
            dgvCitas.Rows[e.RowIndex].Cells[6].Value = horaString;
            String estado;
            if (DateTime.Today.CompareTo(data.fechaAtencion) > 0) estado = "Pasada";
            else estado = "Pendiente";
            dgvCitas.Rows[e.RowIndex].Cells[7].Value = estado;
        }

        private void cbCiclo_Format(object sender, ListControlConvertEventArgs e)
        {
            //Obtiene el objeto actual
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            //Setea el valor
            if (data.idCiclo == -1) e.Value = "Todos";
            else e.Value = data.anho + "-" + data.periodo;
        }

        private void chbFecha_CheckStateChanged(object sender, EventArgs e)
        {
            lblDesde.Enabled = !lblDesde.Enabled;
            lblHasta.Enabled = !lblHasta.Enabled;
            dtpFechaIni.Enabled = !dtpFechaIni.Enabled;
            dtpFechaFin.Enabled = !dtpFechaFin.Enabled;
        }
    }
}
