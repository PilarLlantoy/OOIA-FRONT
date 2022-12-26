/* 
 * Archivo: frmCitasTutorCachimbos.cs
 * Grupo:   Grave Error de Proyecto
 * Integrantes: Oscar Dueñas
                Christian Carhuancho
                Franccesco Jaimes
                Pilar Llantoy
                Cesar Rafael
 * Fecha:   18/05/2021
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
    public partial class frmTutorAlumnosAsignados : Form
    {
        private Form formularioHijo = null;
        private PersonaWS.PersonaWSClient daoAsignados;
        private int idTutor;
        private int idCiclo;
        private PersonaWS.alumno alumnoSeleccionado; // alumno de una fila
        public frmTutorAlumnosAsignados(int idTutor, int idCiclo)
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            this.idTutor = idTutor;
            this.idCiclo = idCiclo;
            daoAsignados = new PersonaWS.PersonaWSClient();
            PersonaWS.asignadosCiclo[] asignados = daoAsignados.listarAsignadosPorIDTutor(idTutor);
            if(asignados == null || asignados[0].ciclo.idCiclo != idCiclo)
            {
                lblNoHayDatos.Visible = true;
                dgvAlumnos.Visible = false;
                btnAsignar.Visible = true;
                dgvAlumnos.DataSource = null;
            }
            else
                dgvAlumnos.DataSource = asignados[0].asignados;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                alumnoSeleccionado = (PersonaWS.alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                formularioHijo = new frmInspeccionarAlumno(alumnoSeleccionado,idTutor,idCiclo);
                formularioHijo.ShowDialog();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int cantidadAsignados = 5, indice;
            PersonaWS.alumno[] alumnos = daoAsignados.listarAlumnosPorCodigoONombre("");
            if(alumnos != null)
            {
                Random rand = new Random();
                if (alumnos.Length <= cantidadAsignados)
                    cantidadAsignados = alumnos.Length;
                while (true)
                {
                    indice = rand.Next(0, alumnos.Length);
                    if (indice < alumnos.Length - cantidadAsignados) break;
                }

                PersonaWS.asignadosCiclo asignadosCiclo = new PersonaWS.asignadosCiclo();
                BindingList<PersonaWS.alumno> arr = new BindingList<PersonaWS.alumno>();
                for (int i = indice; i< indice + cantidadAsignados; i++)
                    arr.Add(alumnos[i]);

                asignadosCiclo.asignados = arr.ToArray();
                PersonaWS.ciclo ciclo = new PersonaWS.ciclo();
                ciclo.idCiclo = idCiclo;
                asignadosCiclo.ciclo = ciclo;
                PersonaWS.tutor tutor = new PersonaWS.tutor();
                tutor.idPersona = idTutor;
                asignadosCiclo.tutor = tutor;
                asignadosCiclo.cantidadAsignados = arr.Count();

                int resultado = daoAsignados.insertarAsignadosCiclo(asignadosCiclo);
                if(resultado == 0)
                {
                    //Error en la operacion
                    MessageBox.Show("Ha ocurrido un error. No se ha podido asignar alumnos al tutor.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Exito en la operacion
                    MessageBox.Show("Se han asociado " + arr.Count + " alumnos al tutor con éxito.", "Éxito en el registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    asignadosCiclo.idAsignadosCiclo = resultado;
                    lblNoHayDatos.Visible = false;
                    dgvAlumnos.Visible = true;
                    dgvAlumnos.DataSource = arr.ToArray();
                    btnAsignar.Visible = false;
                }
            }
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PersonaWS.alumno data = dgvAlumnos.Rows[e.RowIndex].DataBoundItem as PersonaWS.alumno;
            if (data != null)
            {
                dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = data.nombreCompleto;
                dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = data.codigoPUCP;
                dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = data.especialidad.nombre;
                dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = data.tipo;
            }
        }
    }
}
