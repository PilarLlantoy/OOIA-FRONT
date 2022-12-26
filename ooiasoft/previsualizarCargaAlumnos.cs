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
    public partial class previsualizarCargaAlumnos : Form
    {
        private int opcionSeleccionada=0;
        private BindingList<PersonaWS.alumno> alumnos;
        public previsualizarCargaAlumnos(BindingList<PersonaWS.alumno> lista)
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            alumnos = lista;
            label2.Text = alumnos.Count.ToString();
            dgvAlumnos.DataSource = alumnos;
        }
        public int OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
        public BindingList<PersonaWS.alumno> Alumnos { get => alumnos; set => alumnos = value; }
        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                PersonaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem as PersonaWS.alumno;
                if (data != null)
                {
                    dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = data.codigoPUCP;
                    dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = data.nombreCompleto;
                    dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
                    dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = data.telefono;
                    dgvAlumnos.Rows[e.RowIndex].Cells[4].Value = data.correo;
                }
            }
            catch (Exception ex) { };
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea insertar todas las filas?", "Carga de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                opcionSeleccionada = 1;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                alumnos.RemoveAt(dgvAlumnos.CurrentRow.Index);
                label2.Text = alumnos.Count.ToString();
            }
        }

    }
}
