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
    public partial class frmMostrarDetalleNotas : Form
    {
        private CicloWS.CicloWSClient daoCiclo;
        private PersonaWS.alumno alum;
        public frmMostrarDetalleNotas(PersonaWS.alumno alumno)
        {
            InitializeComponent();
            daoCiclo = new CicloWS.CicloWSClient();
            alum = alumno;

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

            cargarReporte(alumno);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarReporte (PersonaWS.alumno alumno)
        {
            CicloWS.ciclo cicloSelecionado = cbCiclos.SelectedItem as CicloWS.ciclo;
            string reporte = "";
            string tipo;
            reporte += "================================================================================================@";
            reporte += ("Codigo PUCP: " + alumno.codigoPUCP.ToString()).PadRight(60);
            reporte += "Nombre: " + alumno.nombreCompleto.ToString() + "@";
            reporte += "------------------------------------------------------------------------------------------------@";
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
                    if (cicloSelecionado.idCiclo == -1 || (cicloSelecionado.idCiclo == c.ciclo.idCiclo))
                    {
                        reporte += "================================================================================================@";
                        reporte += ("Ciclo: " + c.ciclo.anho.ToString() + "-" + c.ciclo.periodo.ToString()).PadRight(60);
                        reporte += "CRAEST: " + c.CRAEST.ToString() + "@";
                        reporte += ("Promedio ponderado: " + c.promedioPonderado.ToString()).PadRight(60);
                        reporte += "Cant. cursos aprob. " + c.cantidadCursosAprobados.ToString() + "@";
                        reporte += ("Cant. cred. aprob. " + c.creditosAprobados.ToString()).PadRight(60);
                        reporte += "Cant. cred. totales. " + c.creditosTotales.ToString() + "@";
                        List<PersonaWS.alumnoCursoCiclo> acc = c.cursos.ToList();
                        foreach (PersonaWS.alumnoCursoCiclo cl in acc)
                        {
                            reporte += "--------------------------------------------------------------------------------------------@";
                            reporte += ("Curso: " + cl.curso.codigo + " - " + cl.curso.nombre).PadRight(60);
                            reporte += "Nota: " + cl.notaFinal.ToString() + " - " + cl.escala.ToString() + "@";
                            reporte += "--------------------------------------------------------------------------------------------@";
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
            }

            reporte = reporte.Replace("@", Environment.NewLine);
            rtbReporte.Text = reporte;
        }

        private void cbCiclos_Format(object sender, ListControlConvertEventArgs e)
        {
            //Obtiene el objeto actual
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            //Setea el valor
            if (data.idCiclo == -1) e.Value = "Todos";
            else e.Value = data.anho + "-" + data.periodo;
        }

        private void cbCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarReporte(alum);
        }
    }
}
