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
    public partial class frmRegistroNotas : Form
    {

        private PersonaWS.PersonaWSClient daoAlumno;
        private PersonaWS.alumno alumnoSeleccionado; // alumno de fila seleccionada
        private BindingList<PersonaWS.alumno> alumnos; // lista de la tabla
        private string rutaArchivo; // ruta del archivo
        private int opcionArchivo; // opcion del formato
        private BindingList<CursoWS.curso> cursoss;
        private BindingList<CicloWS.ciclo> cicloss;
        private CicloWS.CicloWSClient daoCiclo;
        private CursoWS.CursoWSClient daoCurso;

        public frmRegistroNotas()
        {
            InitializeComponent();
            daoAlumno = new PersonaWS.PersonaWSClient();
            alumnoSeleccionado = new PersonaWS.alumno();
            dgvNotas.AutoGenerateColumns = false;
            //alumnos = new BindingList<PersonaWS.alumno>(daoAlumno.listarAlumnosPorCodigoONombre("").ToList());
            dgvNotas.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
        }

        private void btnFormato_Click(object sender, EventArgs e)
        {
            frmFormatoArchivoCursos formato = new frmFormatoArchivoCursos();
            formato.ShowDialog();
            opcionArchivo = formato.OpcionSeleccionada;
            if (opcionArchivo != 0) btnSeleccionar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvNotas.AutoGenerateColumns = false;
            //alumnos = new BindingList<PersonaWS.alumno>(daoAlumno.listarAlumnosPorCodigoONombre(tbBuscar.Text).ToList());
            dgvNotas.DataSource = daoAlumno.listarAlumnosPorCodigoONombre(tbBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {           
            try
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = buscador.FileName;
                    tbRuta.Text = rutaArchivo;
                }
                btnCargar.Enabled = true;
            }
            catch (Exception ex)
            {
                    MessageBox.Show("El archivo seleccionado no es un tipo de archivo válido");
            }
        }

        private void dgvNotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PersonaWS.alumno data = dgvNotas.Rows[e.RowIndex].DataBoundItem as PersonaWS.alumno;
            if (data != null)
            {
                dgvNotas.Rows[e.RowIndex].Cells[0].Value = data.codigoPUCP;
                dgvNotas.Rows[e.RowIndex].Cells[1].Value = data.nombreCompleto;
                dgvNotas.Rows[e.RowIndex].Cells[2].Value = data.CRAEST;
                dgvNotas.Rows[e.RowIndex].Cells[3].Value = data.promedioPonderado;
                dgvNotas.Rows[e.RowIndex].Cells[4].Value = data.cantCursosAprobados;
                dgvNotas.Rows[e.RowIndex].Cells[5].Value = data.cantidadCreditosAprobados;
                dgvNotas.Rows[e.RowIndex].Cells[6].Value = data.totalCreditos;
                dgvNotas.Rows[e.RowIndex].Cells[7].Value = data.cantCiclos;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {           
            if (opcionArchivo == 1)
            {
                previsualizarCargaNotas prev = new previsualizarCargaNotas(leerArchivoOpcion1(),1);
                prev.ShowDialog();
                if (prev.Operacion == 1) modificarAlumno(leerArchivoOpcion1());
            } else if (opcionArchivo == 2)
            {
                previsualizarCargaNotas prev = new previsualizarCargaNotas(leerArchivoOpcion2(), 2);
                prev.ShowDialog();
                if (prev.Operacion == 1) modificarAlumno(leerArchivoOpcion2());
            } else
            {
                previsualizarCargaNotas prev = new previsualizarCargaNotas(leerArchivoOpcion3(), 3);
                prev.ShowDialog();
                if (prev.Operacion == 1) modificarAlumno(leerArchivoOpcion3());
            }
        }

        private void modificarAlumno(BindingList<PersonaWS.alumno> listaOficial)
        {
            int resultado=0;
            foreach(PersonaWS.alumno a in listaOficial)
            {
                int resultado1 = daoAlumno.modificarCiclosCursosNotas(a);
                int resultado2 = daoAlumno.modificarDatosPersonales(a);
                if (resultado1 != 0 && resultado2 != 0) resultado = 1;
                else
                {
                    MessageBox.Show("Ha ocurrido un error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = 0;
                    return;
                }
            }
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado la data con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al finalizar la carga", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvNotas.DataSource = daoAlumno.listarAlumnosPorCodigoONombre("");
        }

        private PersonaWS.alumno buscarAlumno(string codigoPUCP)
        {
            BindingList<PersonaWS.alumno> alumnos = new BindingList<PersonaWS.alumno>(daoAlumno.listarAlumnosPorCodigoONombre(codigoPUCP).ToList());
            //Console.WriteLine(alumnos[0].codigoPUCP);
            return alumnos[0];
        }

        private BindingList<PersonaWS.alumno> leerArchivoOpcion1()
        {

            BindingList<PersonaWS.alumno> listaPrevia = new BindingList<PersonaWS.alumno>();
            int index1 = 0, index2 = 0, index3 = 0;
            string[] lines = System.IO.File.ReadAllLines(rutaArchivo);
            int fila = 1;
            BindingList<PersonaWS.alumnoCiclo> ciclos=null;
            BindingList<PersonaWS.alumnoCursoCiclo> cursos=null;
            foreach (string line in lines)
            {              
                string[] cols = line.Split(';');
                if (fila == 1)
                {
                    listaPrevia.Add(buscarAlumno(cols[0]));
                    listaPrevia[index1].CRAEST = Double.Parse(cols[1]);
                    listaPrevia[index1].promedioPonderado = Double.Parse(cols[2]);
                    listaPrevia[index1].cantCiclos = Int32.Parse(cols[3]);
                    listaPrevia[index1].cantCursosAprobados = Int32.Parse(cols[4]);
                    listaPrevia[index1].cantidadCreditosAprobados = Double.Parse(cols[5]);
                    listaPrevia[index1].totalCreditos = Double.Parse(cols[6]);
                    ciclos = new BindingList<PersonaWS.alumnoCiclo>();
                    fila = 2;
                    index2 = 0;
                    
                } else if (fila == 2)
                {
                    PersonaWS.alumnoCiclo ac = new PersonaWS.alumnoCiclo();                   
                    ac.ciclo = buscarCiclo(cols[0]);
                    ac.CRAEST = Double.Parse(cols[1]);
                    ac.promedioPonderado = Double.Parse(cols[2]);
                    ac.cantidadCursosAprobados = Int32.Parse(cols[3]);
                    ac.creditosAprobados = Double.Parse(cols[4]);
                    ac.creditosTotales = Double.Parse(cols[5]);                   
                    ciclos.Add(ac);
                    cursos = new BindingList<PersonaWS.alumnoCursoCiclo>();
                    fila = 3;
                    index3 = 0;
                } else if (fila == 3)
                {
                    if (cols[0][0] == '>')
                    {
                        fila = 2;
                        ciclos[index2].cursos = cursos.ToArray();
                        index2 += 1;
                    } else if (cols[0][0] == '<')
                    {
                        fila = 1;
                        ciclos[index2].cursos = cursos.ToArray();
                        listaPrevia[index1].ciclos = ciclos.ToArray();
                        index1 += 1;
                    } else
                    {
                        PersonaWS.alumnoCursoCiclo acc = new PersonaWS.alumnoCursoCiclo();
                        BindingList<PersonaWS.evaluacion> evs = new BindingList<PersonaWS.evaluacion>();
                        acc.evaluaciones = evs.ToArray();
                        acc.curso = buscarCurso(cols[0]);
                        acc.notaFinal = Double.Parse(cols[1]);
                        acc.escala = buscarECTS(cols[2][0]);
                        acc.escalaSpecified = true;
                        cursos.Add(acc);
                        index3 += 1;
                    }                    
                }
                
            }
            return listaPrevia;
        }

        private BindingList<PersonaWS.alumno> leerArchivoOpcion2()
        {
            BindingList<PersonaWS.alumno> listaPrevia = new BindingList<PersonaWS.alumno>();
            int index1 = 0, index2 = 0;
            string[] lines = System.IO.File.ReadAllLines(rutaArchivo);
            int fila = 1;
            BindingList<PersonaWS.alumnoCiclo> ciclos = null;
            foreach (string line in lines)
            {
                string[] cols = line.Split(';');
                if (fila == 1)
                {
                    listaPrevia.Add(buscarAlumno(cols[0]));
                    listaPrevia[index1].CRAEST = Double.Parse(cols[1]);
                    listaPrevia[index1].promedioPonderado = Double.Parse(cols[2]);
                    listaPrevia[index1].cantCiclos = Int32.Parse(cols[3]);
                    listaPrevia[index1].cantCursosAprobados = Int32.Parse(cols[4]);
                    listaPrevia[index1].cantidadCreditosAprobados = Double.Parse(cols[5]);
                    listaPrevia[index1].totalCreditos = Double.Parse(cols[6]);
                    ciclos = new BindingList<PersonaWS.alumnoCiclo>();
                    fila = 2;
                    index2 = 0;
                } else
                {
                    if (cols[0][0] == '>')
                    {
                        fila = 1;
                        listaPrevia[index1].ciclos = ciclos.ToArray();
                        index1 += 1;
                    } else
                    {
                        PersonaWS.alumnoCiclo ac = new PersonaWS.alumnoCiclo();
                        ac.ciclo = buscarCiclo(cols[0]);
                        ac.CRAEST = Double.Parse(cols[1]);
                        ac.promedioPonderado = Double.Parse(cols[2]);
                        ac.cantidadCursosAprobados = Int32.Parse(cols[3]);
                        ac.creditosAprobados = Double.Parse(cols[4]);
                        ac.creditosTotales = Double.Parse(cols[5]);
                        BindingList<PersonaWS.alumnoCursoCiclo> acc = new BindingList<PersonaWS.alumnoCursoCiclo>();
                        ac.cursos = acc.ToArray();
                        ciclos.Add(ac);
                        index2 += 1;
                    }
                }
            }
            return listaPrevia;
        }

        private BindingList<PersonaWS.alumno> leerArchivoOpcion3()
        {
            BindingList<PersonaWS.alumno> listaPrevia = new BindingList<PersonaWS.alumno>();
            int index1 = 0, index2 = 0, index3 = 0, index4 = 0;
            string[] lines = System.IO.File.ReadAllLines(rutaArchivo);
            int fila = 1;
            BindingList<PersonaWS.alumnoCiclo> ciclos = null;
            BindingList<PersonaWS.alumnoCursoCiclo> cursos = null;
            BindingList<PersonaWS.evaluacion> evaluaciones = null;
            foreach (string line in lines)
            {
                string[] cols = line.Split(';');
                Console.WriteLine(index1 + " - " + index2 + " - " + index3 + " - " + index4);
                if (fila == 1)
                {
                    listaPrevia.Add(buscarAlumno(cols[0]));
                    ciclos = new BindingList<PersonaWS.alumnoCiclo>();
                    listaPrevia[index1].CRAEST = Double.Parse(cols[1]);
                    listaPrevia[index1].promedioPonderado = Double.Parse(cols[2]);
                    listaPrevia[index1].cantCiclos = Int32.Parse(cols[3]);
                    listaPrevia[index1].cantCursosAprobados = Int32.Parse(cols[4]);
                    listaPrevia[index1].cantidadCreditosAprobados = Double.Parse(cols[5]);
                    listaPrevia[index1].totalCreditos = Double.Parse(cols[6]);      
                    fila = 2;
                    index2 = 0;

                }
                else if (fila == 2)
                {
                    PersonaWS.alumnoCiclo ac = new PersonaWS.alumnoCiclo();
                    cursos = new BindingList<PersonaWS.alumnoCursoCiclo>();
                    ac.ciclo = buscarCiclo(cols[0]);
                    ac.CRAEST = Double.Parse(cols[1]);
                    ac.promedioPonderado = Double.Parse(cols[2]);
                    ac.cantidadCursosAprobados = Int32.Parse(cols[3]);
                    ac.creditosAprobados = Double.Parse(cols[4]);
                    ac.creditosTotales = Double.Parse(cols[5]);
                    ciclos.Add(ac); 
                    fila = 3;
                    index3 = 0;
                } 
                else if (fila == 3) {
                    PersonaWS.alumnoCursoCiclo acc = new PersonaWS.alumnoCursoCiclo();
                    evaluaciones = new BindingList<PersonaWS.evaluacion>();
                    acc.curso = buscarCurso(cols[0]);
                    acc.notaFinal = Double.Parse(cols[1]);
                    acc.escala = buscarECTS(cols[2][0]);
                    acc.escalaSpecified = true;
                    cursos.Add(acc);
                    fila = 4;
                    index4 = 0;
                }
                else if (fila == 4)
                {
                    if (cols[0][0] == '>')
                    {
                        fila = 2;
                        cursos[index3].evaluaciones = evaluaciones.ToArray();
                        ciclos[index2].cursos = cursos.ToArray();
                        index2 += 1;
                    }
                    else if (cols[0][0] == '<')
                    {
                        fila = 1;
                        cursos[index3].evaluaciones = evaluaciones.ToArray();
                        ciclos[index2].cursos = cursos.ToArray();
                        listaPrevia[index1].ciclos = ciclos.ToArray();
                        index1 += 1;
                    }
                    else if (cols[0][0] == '*')
                    {
                        fila = 3;
                        cursos[index3].evaluaciones = evaluaciones.ToArray();
                        index3 += 1;
                    }
                    else
                    {
                        PersonaWS.evaluacion ev = new PersonaWS.evaluacion();
                        ev.tipo = buscarEvaluacion(cols[0]);
                        ev.tipoSpecified = true;
                        ev.numEvaluacion = Int32.Parse(cols[1]);
                        ev.nota = Int32.Parse(cols[2]);
                        evaluaciones.Add(ev);
                        index4 += 1;
                    }
                }
                
            }
            return listaPrevia;
        }

        private PersonaWS.ciclo buscarCiclo(string c)
        {
            string[] cl = c.Split('-');
            daoCiclo = new CicloWS.CicloWSClient();
            cicloss = new BindingList<CicloWS.ciclo>(daoCiclo.listarCiclos().ToList());
            foreach(CicloWS.ciclo C in cicloss)
            {
                if (C.anho.ToString() == cl[0] && C.periodo.ToString() == cl[1])
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
        private PersonaWS.curso buscarCurso(string c)
        {
            daoCurso = new CursoWS.CursoWSClient();
            cursoss = new BindingList<CursoWS.curso>(daoCurso.listarCursosPorCodigoNombre(c).ToList());
            PersonaWS.curso cu = new PersonaWS.curso();
            cu.idCurso = cursoss[0].idCurso;
            cu.codigo = cursoss[0].codigo;
            cu.nombre = cursoss[0].nombre;
            return cu;
        }
        private PersonaWS.tipoECTS buscarECTS(char t)
        {
            if (t == 'A') return PersonaWS.tipoECTS.A;
            else if (t == 'B') return PersonaWS.tipoECTS.B;
            else if (t == 'C') return PersonaWS.tipoECTS.C;
            else if (t == 'D') return PersonaWS.tipoECTS.D;
            else if (t == 'E') return PersonaWS.tipoECTS.E;
            else if (t == 'F') return PersonaWS.tipoECTS.F;
            else return PersonaWS.tipoECTS.FX;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvNotas.CurrentRow != null)
            {
                alumnoSeleccionado = (PersonaWS.alumno)dgvNotas.CurrentRow.DataBoundItem;
                frmMostrarDetalleNotas vista = new frmMostrarDetalleNotas(alumnoSeleccionado);
                vista.ShowDialog();
            }
        }

        private PersonaWS.tipoEvaluacion buscarEvaluacion(string ev)
        {
            if (ev == "PC") return PersonaWS.tipoEvaluacion.PA;
            else if (ev == "L") return PersonaWS.tipoEvaluacion.PB;
            else return PersonaWS.tipoEvaluacion.EX;
        }
    }
}
