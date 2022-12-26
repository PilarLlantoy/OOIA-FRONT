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
    public partial class frmInspeccionarAlumno : Form
    {
        private BindingList<CicloWS.ciclo> cicloss;
        private CicloWS.CicloWSClient daoCiclo;
        private CitaWS.CitaWSClient daoCita;
        public frmInspeccionarAlumno(PersonaWS.alumno alumno, int idTutor, int idCiclo)
        {
            InitializeComponent();
            CompletarData(alumno);
            mostrarNotasHistorico(alumno);
            mostrarNotasPresente(alumno,idCiclo);
            daoCita = new CitaWS.CitaWSClient();
            dgvCitas.AutoGenerateColumns = false;
            dgvCitas.DataSource = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idTutor, "", Convert.ToDateTime("01-01-1000"), Convert.ToDateTime("01-01-3000"), alumno.nombreCompleto);
        }

        private void CompletarData(PersonaWS.alumno alumno)
        {
            tbCodigoPUCP.Text = alumno.codigoPUCP;
            tbNombre.Text = alumno.nombreCompleto;
            tbCorreo.Text = alumno.correo;
            tbEspecialidad.Text = alumno.especialidad.nombre;
            tbTelefono.Text = alumno.telefono;
            tbEdad.Text = alumno.edad.ToString();
            tbTipoAlumno.Text = alumno.tipo.ToString();
            if (alumno.foto != null)
            {
                MemoryStream ms = new MemoryStream(alumno.foto);
                pbPerfil.Image = Image.FromStream(ms);
            }
        }

        private void mostrarNotasHistorico(PersonaWS.alumno alumno)
        {
            string reporte = "";
            string tipo;
            reporte += "=======================================================================@";
            //reporte += ("Codigo PUCP: " + alumno.codigoPUCP.ToString()).PadRight(60);
            //reporte += "Nombre: " + alumno.nombreCompleto.ToString() + "@";
            //reporte += "-----------------------------------------------------------------------@";
            reporte += ("CRAEST ponderado: " + alumno.CRAEST.ToString()).PadRight(60);
            reporte += "Promedio ponderado: " + alumno.promedioPonderado.ToString() + "@";
            reporte += ("Cantidad de ciclos: " + alumno.cantCiclos.ToString()).PadRight(60);
            reporte += "Cant. cursos aprob. " + alumno.cantCursosAprobados.ToString() + "@";
            reporte += ("Cant. cred. aprob. " + alumno.cantidadCreditosAprobados.ToString()).PadRight(60);
            reporte += "Cant. cred. totales. " + alumno.totalCreditos.ToString() + "@";

            if (alumno.ciclos != null)
            {
                List<PersonaWS.alumnoCiclo> ac = alumno.ciclos.ToList();
                foreach (PersonaWS.alumnoCiclo c in ac)
                {
                    reporte += "=======================================================================@";
                    reporte += ("Ciclo: " + c.ciclo.anho.ToString() + "-" + c.ciclo.periodo.ToString()).PadRight(60);
                    reporte += "CRAEST: " + c.CRAEST.ToString() + "@";
                    reporte += ("Promedio ponderado: " + c.promedioPonderado.ToString()).PadRight(60);
                    reporte += "Cant. cursos aprob. " + c.cantidadCursosAprobados.ToString() + "@";
                    reporte += ("Cant. cred. aprob. " + c.creditosAprobados.ToString()).PadRight(60);
                    reporte += "Cant. cred. totales. " + c.creditosTotales.ToString() + "@";
                    List<PersonaWS.alumnoCursoCiclo> acc = c.cursos.ToList();
                    foreach (PersonaWS.alumnoCursoCiclo cl in acc)
                    {
                        reporte += "-----------------------------------------------------------------------@";
                        reporte += ("Curso: " + cl.curso.codigo + " - " + cl.curso.nombre).PadRight(60);
                        reporte += "Nota: " + cl.notaFinal.ToString() + " - " + cl.escala.ToString() + "@";
                        reporte += "-----------------------------------------------------------------------@";
                        List<PersonaWS.evaluacion> ev = cl.evaluaciones.ToList();
                        foreach (PersonaWS.evaluacion e in ev)
                        {
                            if (e.tipo.ToString() == "PA") tipo = "PC";
                            else if (e.tipo.ToString() == "PB") tipo = "L";
                            else tipo = "EX";
                            reporte += tipo + e.numEvaluacion.ToString() + " - " + e.nota + "@";
                        }
                    }
                }
            }

            reporte = reporte.Replace("@", Environment.NewLine);
            rtbNotas.Text = reporte;
        }

        private void mostrarNotasPresente(PersonaWS.alumno alumno, int idCiclo)
        {
            string reporte = "", tipo = "";
            if (alumno.ciclos != null)
            {
                List<PersonaWS.alumnoCiclo> ac = alumno.ciclos.ToList();
                foreach (PersonaWS.alumnoCiclo c in ac)
                {                  
                    if (buscarCiclo(idCiclo).idCiclo == c.ciclo.idCiclo)
                    {
                        List<PersonaWS.alumnoCursoCiclo> acc = alumno.ciclos[5].cursos.ToList();
                        foreach (PersonaWS.alumnoCursoCiclo cl in acc)
                        {
                            reporte += "-----------------------------------------------------------------------@";
                            reporte += ("Curso: " + cl.curso.codigo + " - " + cl.curso.nombre).PadRight(60);
                            reporte += "Nota: " + cl.notaFinal.ToString() + " - " + cl.escala.ToString() + "@";
                            reporte += "-----------------------------------------------------------------------@";
                            List<PersonaWS.evaluacion> ev = cl.evaluaciones.ToList();
                            foreach (PersonaWS.evaluacion e in ev)
                            {
                                if (e.tipo.ToString() == "PA") tipo = "PC";
                                else if (e.tipo.ToString() == "PB") tipo = "L";
                                else tipo = "EX";
                                reporte += tipo + e.numEvaluacion.ToString() + " - " + e.nota + "@";
                            }
                        }                       
                    }
                }
                reporte = reporte.Replace("@", Environment.NewLine);
                rtbPresente.Text = reporte;
            }            
        }

        private PersonaWS.ciclo buscarCiclo(int id)
        {
            daoCiclo = new CicloWS.CicloWSClient();
            cicloss = new BindingList<CicloWS.ciclo>(daoCiclo.listarCiclos().ToList());
            foreach (CicloWS.ciclo C in cicloss)
            {
                if (id == C.idCiclo)
                {
                    PersonaWS.ciclo cicloAl = new PersonaWS.ciclo();
                    cicloAl.idCiclo = C.idCiclo;
                    cicloAl.periodo = C.periodo;
                    cicloAl.anho = C.anho;
                    return cicloAl;
                }
            }
            return null;
        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CitaWS.cita data = dgvCitas.Rows[e.RowIndex].DataBoundItem as CitaWS.cita;
            dgvCitas.Rows[e.RowIndex].Cells[0].Value = data.ciclo.anho + "-" + data.ciclo.periodo;
            dgvCitas.Rows[e.RowIndex].Cells[1].Value = data.fechaAtencion.ToShortDateString();
            dgvCitas.Rows[e.RowIndex].Cells[2].Value = data.hora + ":00";
            string estado;
            if (DateTime.Today.CompareTo(data.fechaAtencion) > 0) estado = "Pasada";
            else estado = "Pendiente";
            dgvCitas.Rows[e.RowIndex].Cells[3].Value = estado;
        }
    }
}
