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
    public partial class previsualizarCargaPersonal : Form
    {
        private int opcionSeleccionada = 0;
        private BindingList<PersonaWS.persona> personal;

        public previsualizarCargaPersonal(BindingList<PersonaWS.persona> lista)
        {
            InitializeComponent();
            dgvPersonal.AutoGenerateColumns = false;
            personal = lista;
            label2.Text = personal.Count.ToString();
            dgvPersonal.DataSource = personal;
        }

        public int OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
        public BindingList<PersonaWS.persona> Personal { get => personal; set => personal = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea insertar todas las filas?", "Carga de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                opcionSeleccionada = 1;
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow != null)
            {
                personal.RemoveAt(dgvPersonal.CurrentRow.Index);
                label2.Text = personal.Count.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try {
                PersonaWS.persona data = dgvPersonal.Rows[e.RowIndex].DataBoundItem as PersonaWS.persona;
                if (data != null)
                {
                    if (data is PersonaWS.administrativo)
                        dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Administrativo";
                    else if (data is PersonaWS.tutor)
                        dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Tutor";
                    else if (data is PersonaWS.psicologo)
                        dgvPersonal.Rows[e.RowIndex].Cells[0].Value = "Psicólogo";
                    dgvPersonal.Rows[e.RowIndex].Cells[1].Value = data.codigoPUCP;
                    dgvPersonal.Rows[e.RowIndex].Cells[2].Value = data.nombreCompleto;
                    dgvPersonal.Rows[e.RowIndex].Cells[3].Value = data.edad;
                    dgvPersonal.Rows[e.RowIndex].Cells[4].Value = data.telefono;
                    dgvPersonal.Rows[e.RowIndex].Cells[5].Value = data.correo;
                }
            } catch (Exception ex) { }
        }
    }
}
