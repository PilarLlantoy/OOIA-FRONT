/* 
 * Archivo: frmEventoAlumno.cs
 * Grupo:   Grave Error de Proyecto
 * Integrantes: Oscar Dueñas
                Christian Carhuancho
                Franccesco Jaimes
                Pilar Llantoy
                Cesar Rafael
 * Fecha:   19/05/2021
 */

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
    public partial class frmEventosAlumno : Form
    {
        private int idPersona;
        private int idCicloActual;
        private EventoCicloWS.EventoCicloWSClient daoEventoCiclo;
        private EventoCicloWS.eventoCiclo[] eventos;
        public frmEventosAlumno(int idPersona, int idCicloActual)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.idCicloActual = idCicloActual;
            daoEventoCiclo = new EventoCicloWS.EventoCicloWSClient();

            //Llenar los proximos eventos
            eventos = daoEventoCiclo.listarEventoCiclosNoInscritosParaAlumno(idPersona, idCicloActual, "", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"));
            llenarEventos();
        }

        public void llenarEventos() {
            //Limpiar los componentes
            panelEventos.Controls.Clear();

            //Verificar que hay eventos
            if (eventos == null) lblNoHayEventos.Visible = true;
            else
            {
                lblNoHayEventos.Visible = false;
                foreach(EventoCicloWS.eventoCiclo evento in eventos)
                {
                    frmDescripcionEventoAlumno frm = new frmDescripcionEventoAlumno();
                    frm.llenarDatos(idPersona,evento);
                    frm.BringToFront();
                    panelEventos.Controls.Add(frm);
                    frm.Dock = DockStyle.Top;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Realizar la busqueda
            DateTime fechaIni, fechaFin;
            if(chbFechaEvento.Checked == true)
            {
                fechaIni = dtpFechaIni.Value;
                fechaFin = dtpFechaFin.Value;

                //Validacion
                if(fechaFin.CompareTo(fechaIni) < 0)
                {
                    MessageBox.Show("Rango inválido de fechas. La fecha inicial no puede ser antes que la fecha final.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                fechaIni = Convert.ToDateTime("01-01-1000");
                fechaFin = Convert.ToDateTime("01-01-3000");
            }
            eventos = daoEventoCiclo.listarEventoCiclosNoInscritosParaAlumno(idPersona,idCicloActual,txtNombre.Text,fechaIni,fechaFin);
            llenarEventos();
        }

        private void chbFechaEvento_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaIni.Enabled = !dtpFechaIni.Enabled;
            dtpFechaFin.Enabled = !dtpFechaFin.Enabled;
            lblFechaIni.Enabled = !lblFechaIni.Enabled;
            lblHasta.Enabled = !lblHasta.Enabled;
        }
    }
}
