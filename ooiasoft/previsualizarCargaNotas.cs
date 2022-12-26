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
    public partial class previsualizarCargaNotas : Form
    {
        private int operacion=0;
        public previsualizarCargaNotas(BindingList<PersonaWS.alumno> lista, int opcion)
        {
            InitializeComponent();
            if (opcion == 1) cargarLabel1(lista);
            else if (opcion == 2) cargarLabel2(lista);
            else cargarLabel3(lista);
        }

        public int Operacion { get => operacion; set => operacion = value; }

        private void cargarLabel1(BindingList<PersonaWS.alumno> list)
        {
            string reporte = "";
            foreach (PersonaWS.alumno a in list)
            {
                reporte += "================================================================================================@";
                reporte += ("Codigo PUCP: " + a.codigoPUCP.ToString()).PadRight(60);
                reporte += "Nombre: " + a.nombreCompleto.ToString() + "@";
                reporte += "------------------------------------------------------------------------------------------------@";
                reporte += ("CRAEST ponderado: " + a.CRAEST.ToString()).PadRight(60);
                reporte += "Promedio ponderado: " + a.promedioPonderado.ToString() + "@";
                reporte += ("Cantidad de ciclos: " + a.cantCiclos.ToString()).PadRight(60);
                reporte += "Cant. cursos aprob. " + a.cantCursosAprobados.ToString() + "@";
                reporte += ("Cant. cred. aprob. " + a.cantidadCreditosAprobados.ToString()).PadRight(60);
                reporte += "Cant. cred. totales. " + a.totalCreditos.ToString() + "@";
                List<PersonaWS.alumnoCiclo> ac = a.ciclos.ToList();
                foreach (PersonaWS.alumnoCiclo c in ac)
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
                        reporte += "-----------------------------------------------------------------------@";
                        reporte += ("Curso: " + cl.curso.codigo + " - " + cl.curso.nombre).PadRight(100);
                        reporte += "Nota: " + cl.notaFinal.ToString() + " - " + cl.escala.ToString() + "@";
                        reporte += "-----------------------------------------------------------------------@";
                    }
                }
            }
            reporte = reporte.Replace("@", Environment.NewLine);
            rtbReporte.Text = reporte;
        }

        private void cargarLabel2(BindingList<PersonaWS.alumno> list)
        {
            string reporte = "";
            foreach (PersonaWS.alumno a in list)
            {
                reporte += "================================================================================================@";
                reporte += ("Codigo PUCP: " + a.codigoPUCP.ToString()).PadRight(60);
                reporte += "Nombre: " + a.nombreCompleto.ToString() + "@";
                reporte += "------------------------------------------------------------------------------------------------@";
                reporte += ("CRAEST ponderado: " + a.CRAEST.ToString()).PadRight(60);
                reporte += "Promedio ponderado: " + a.promedioPonderado.ToString() + "@";
                reporte += ("Cantidad de ciclos: " + a.cantCiclos.ToString()).PadRight(60);
                reporte += "Cant. cursos aprob. " + a.cantCursosAprobados.ToString() + "@";
                reporte += ("Cant. cred. aprob. " + a.cantidadCreditosAprobados.ToString()).PadRight(60);
                reporte += "Cant. cred. totales. " + a.totalCreditos.ToString() + "@";
                List<PersonaWS.alumnoCiclo> ac = a.ciclos.ToList();
                foreach (PersonaWS.alumnoCiclo c in ac)
                {
                    reporte += "================================================================================================@";
                    reporte += ("Ciclo: " + c.ciclo.anho.ToString() + "-" + c.ciclo.periodo.ToString()).PadRight(60);
                    reporte += "CRAEST: " + c.CRAEST.ToString() + "@";
                    reporte += ("Promedio ponderado: " + c.promedioPonderado.ToString()).PadRight(60);
                    reporte += "Cant. cursos aprob. " + c.cantidadCursosAprobados.ToString() + "@";
                    reporte += ("Cant. cred. aprob. " + c.creditosAprobados.ToString()).PadRight(60);
                    reporte += "Cant. cred. totales. " + c.creditosTotales.ToString() + "@";
                }
            }
            reporte = reporte.Replace("@", Environment.NewLine);
            rtbReporte.Text = reporte;
        }

        private void cargarLabel3(BindingList<PersonaWS.alumno> list)
        {
            string reporte = "";
            string tipo;
            foreach (PersonaWS.alumno a in list)
            {
                reporte += "================================================================================================@"; reporte += ("Codigo PUCP: " + a.codigoPUCP.ToString()).PadRight(60);
                reporte += "Nombre: " + a.nombreCompleto.ToString() + "@";
                reporte += "------------------------------------------------------------------------------------------------@";
                reporte += ("CRAEST ponderado: " + a.CRAEST.ToString()).PadRight(60);
                reporte += "Promedio ponderado: " + a.promedioPonderado.ToString() + "@";
                reporte += ("Cantidad de ciclos: " + a.cantCiclos.ToString()).PadRight(60);
                reporte += "Cant. cursos aprob. " + a.cantCursosAprobados.ToString() + "@";
                reporte += ("Cant. cred. aprob. " + a.cantidadCreditosAprobados.ToString()).PadRight(60);
                reporte += "Cant. cred. totales. " + a.totalCreditos.ToString() + "@";
                List<PersonaWS.alumnoCiclo> ac = a.ciclos.ToList();
                foreach (PersonaWS.alumnoCiclo c in ac)
                {
                    reporte += "=================================================================================@";
                    reporte += ("Ciclo: " + c.ciclo.anho.ToString() + "-" + c.ciclo.periodo.ToString()).PadRight(60);
                    reporte += "CRAEST: " + c.CRAEST.ToString() + "@";
                    reporte += ("Promedio ponderado: " + c.promedioPonderado.ToString()).PadRight(60);
                    reporte += "Cant. cursos aprob. " + c.cantidadCursosAprobados.ToString() + "@";
                    reporte += ("Cant. cred. aprob. " + c.creditosAprobados.ToString()).PadRight(60);
                    reporte += "Cant. cred. totales. " + c.creditosTotales.ToString() + "@";
                    List<PersonaWS.alumnoCursoCiclo> acc = c.cursos.ToList();
                    foreach (PersonaWS.alumnoCursoCiclo cl in acc)
                    {
                        reporte += "---------------------------------------------------------------------------------@";
                        reporte += ("Curso: " + cl.curso.codigo + " - " + cl.curso.nombre).PadRight(60);
                        reporte += "Nota: " + cl.notaFinal.ToString() + " - " + cl.escala.ToString() + "@";
                        reporte += "---------------------------------------------------------------------------------@";
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
            rtbReporte.Text = reporte;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            operacion = 1;
            btnGuardar.Enabled = false;
            button1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
