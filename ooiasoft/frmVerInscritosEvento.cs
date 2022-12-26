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
    public partial class frmVerInscritosEvento : Form
    {
        public frmVerInscritosEvento(EventoCicloWS.eventoCiclo evento)
        {
            InitializeComponent();
            dgvEventosAdmin.AutoGenerateColumns = false;
            dgvEventosAdmin.DataSource = evento.alumnosInscritos;
            lblFechaEvento.Text = evento.fechaEvento.ToShortDateString();
            lblCapEvento.Text = evento.capacidadMax.ToString();
            int cantInscritos;
            if (evento.alumnosInscritos == null) cantInscritos = 0;
            else cantInscritos = evento.alumnosInscritos.Length;
            lblInscritosEvento.Text = cantInscritos.ToString();
            lblTitulo.Text = evento.titulo + " " + evento.ciclo.anho + "-" + evento.ciclo.periodo;
        }

        private void dgvEventosAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EventoCicloWS.alumno data = dgvEventosAdmin.Rows[e.RowIndex].DataBoundItem as EventoCicloWS.alumno;
            if (data == null) return;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[0].Value = data.codigoPUCP;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[1].Value = data.nombreCompleto;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[3].Value = data.correo;
            dgvEventosAdmin.Rows[e.RowIndex].Cells[4].Value = data.telefono;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

