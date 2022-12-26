using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmEventosAdmin : Form
    {
        private int idCicloActual;
        private Form formulario;
        private EventoCicloWS.EventoCicloWSClient daoEventoCiclo;
        private CicloWS.CicloWSClient daoCiclo;
        private ReporteWS.ReporteWSClient daoReporte;

        public frmEventosAdmin(int idCicloActual)
        {
            InitializeComponent();
            this.idCicloActual = idCicloActual;
            daoEventoCiclo = new EventoCicloWS.EventoCicloWSClient();
            daoCiclo = new CicloWS.CicloWSClient();
            daoReporte = new ReporteWS.ReporteWSClient();
            // Llenar el ComboBox con los ciclos

            BindingList<CicloWS.ciclo> ciclos;
            CicloWS.ciclo[] arr = daoCiclo.listarCiclos();
            if (arr == null) ciclos = new BindingList<CicloWS.ciclo>();
            else ciclos = new BindingList<CicloWS.ciclo>(arr.ToList());

            // Instanciar un ciclo para agregarlo al BindingList
            CicloWS.ciclo ciclo = new CicloWS.ciclo();
            ciclo.idCiclo = -1;
            ciclos.Insert(0, ciclo);

            // Asignar al ComboBox
            cbCiclos.DataSource = ciclos;
            cbCiclos.SelectedItem = 0;
            BindingList<CicloWS.ciclo> ciclosAux = new BindingList<CicloWS.ciclo>(ciclos);
            ciclosAux.RemoveAt(0);
            cbCicloReporte.DataSource = ciclosAux;
            cbCicloReporte.Text = "Seleccionar";
            
            // Llenar el DataGridView
            dgvEventosAdmin.AutoGenerateColumns = false;
            dgvEventosAdmin.DataSource = 
                daoEventoCiclo.listarEventoCiclosParaAdministrativo("", txtNombre.Text, Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
        }

        private void chbFechaEvento_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFechaEvento.Checked == true)
            {
                dtpFechaIni.Enabled = true;
                dtpFechaFin.Enabled = true;
                lblFechaIni.Enabled = true;
                lblHasta.Enabled = true;
            }
            else
            {
                dtpFechaIni.Enabled = false;
                dtpFechaFin.Enabled = false;
                lblFechaIni.Enabled = false;
                lblHasta.Enabled = false;
            }
        }

        private void btnNuevoEvento_Click(object sender, EventArgs e)
        {
            formulario = new frmAgregarModificarEvento(idCicloActual);
            formulario.ShowDialog();
            txtNombre.Text = "";
            rbTodos.Checked = true;
            cbCiclos.SelectedIndex = 0;
            chbFechaEvento.Checked = false;
            dgvEventosAdmin.DataSource = daoEventoCiclo.listarEventoCiclosParaAdministrativo("", txtNombre.Text, Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvEventosAdmin.CurrentRow != null)
            {
                frmAgregarModificarEvento registrar = new frmAgregarModificarEvento((EventoCicloWS.eventoCiclo)dgvEventosAdmin.CurrentRow.DataBoundItem);
                registrar.ShowDialog();
                txtNombre.Text = "";
                rbTodos.Checked = true;
                cbCiclos.SelectedIndex = 0;
                chbFechaEvento.Checked = false;
                dgvEventosAdmin.DataSource = daoEventoCiclo.listarEventoCiclosParaAdministrativo("", txtNombre.Text, Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Realizar la búsqueda
            DateTime fechaInicio, fechaFin;
            CicloWS.ciclo cicloSeleccionado = cbCiclos.SelectedItem as CicloWS.ciclo;
            String cicloCad = "";
            if (cicloSeleccionado.idCiclo != -1)
                cicloCad += cicloSeleccionado.anho + "-" + cicloSeleccionado.periodo;

            if (chbFechaEvento.Checked == true)
            {
                fechaInicio = dtpFechaIni.Value;
                fechaFin = dtpFechaFin.Value;

                // Validación
                if (fechaFin.CompareTo(fechaInicio) < 0)
                {
                    MessageBox.Show("Rango inválido de fechas. La fecha inicial no puede ser mayor que la fecha fin.");
                    return;
                }
            }
            else {
                fechaInicio = Convert.ToDateTime("01-01-1000");
                fechaFin = Convert.ToDateTime("01-01-3000");
            }

            if (rbPasado.Checked == true)
            {
                if (fechaFin.CompareTo(DateTime.Today) > 0) fechaFin = DateTime.Today.AddDays(-1);
            }
            else if (rbPendiente.Checked == true)
            {
                if (fechaInicio.CompareTo(DateTime.Today) < 0) fechaInicio = DateTime.Today;
            }
            dgvEventosAdmin.DataSource = daoEventoCiclo.listarEventoCiclosParaAdministrativo(cicloCad, txtNombre.Text, fechaInicio, fechaFin, "");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEventosAdmin.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este evento?", "Mensaje de Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    EventoCicloWS.eventoCiclo eventoSeleccionado = (EventoCicloWS.eventoCiclo)dgvEventosAdmin.CurrentRow.DataBoundItem;
                    int resultado = daoEventoCiclo.eliminarEventoCiclo(eventoSeleccionado.idEventoCiclo);
                    if (resultado != 0)
                    {
                        txtNombre.Text = "";
                        rbTodos.Checked = true;
                        cbCiclos.SelectedIndex = 0;
                        chbFechaEvento.Checked = false;
                        dgvEventosAdmin.DataSource = daoEventoCiclo.listarEventoCiclosParaAdministrativo("", txtNombre.Text, Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), "");
                        MessageBox.Show("Se ha eliminado el evento.", "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Ha ocurrido un error. No se ha podido eliminar el evento.", "Error en la Operación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbCiclos_Format(object sender, ListControlConvertEventArgs e)
        {
            //Obtiene el objeto actual
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            //Setea el valor
            if (data.idCiclo == -1) e.Value = "Todos";
            else e.Value = data.anho + "-" + data.periodo;
        }

        private void dgvEventosAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EventoCicloWS.eventoCiclo data = dgvEventosAdmin.Rows[e.RowIndex].DataBoundItem as EventoCicloWS.eventoCiclo;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[0].Value = data.ciclo.anho + "-" + data.ciclo.periodo;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[1].Value = data.titulo;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[2].Value = data.fechaRegistro.ToShortDateString();
            dgvEventosAdmin.Rows[e.RowIndex].Cells[3].Value = data.fechaEvento.ToShortDateString();
            int hora = data.horaIni;
            String horaString;
            if (hora > 12) horaString = (hora - 12).ToString();
            else horaString = hora.ToString();
            if(hora < 12) horaString += ":00 a.m.";
            else horaString += ":00 p.m.";
            dgvEventosAdmin.Rows[e.RowIndex].Cells[4].Value = horaString;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[5].Value = data.duracionHoras.ToString() + " horas";
            dgvEventosAdmin.Rows[e.RowIndex].Cells[6].Value = data.cantAsistentes;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[7].Value = data.capacidadMax;
            String estado;
            if (DateTime.Today.CompareTo(data.fechaEvento) > 0) estado = "Pasado";
            else estado = "Pendiente";
            dgvEventosAdmin.Rows[e.RowIndex].Cells[8].Value = estado;
        }
        private void cbCicloReporte_Format(object sender, ListControlConvertEventArgs e)
        {
            //Obtiene el objeto actual
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            e.Value = data.anho + "-" + data.periodo;
        }

        private void btnDescargarReporte_Click_1(object sender, EventArgs e)
        {
            if (cbCicloReporte.Text.CompareTo("Seleccionar") == 0)
            {
                MessageBox.Show("Por favor seleccione un ciclo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CicloWS.ciclo cicloSeleccionado = cbCicloReporte.SelectedItem as CicloWS.ciclo;
            saveFileDialog.Filter = "Archivos .pdf (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] arreglo = daoReporte.generarReporteEventosxCiclo(cicloSeleccionado.idCiclo);
                File.WriteAllBytes(saveFileDialog.FileName, arreglo);
            }
        }
    }
}
