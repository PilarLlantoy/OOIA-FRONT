/* 
 * Archivo: frmCitasTutor.cs
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmCitas : Form
    {
        private int idPersona;
        private int idCiclo;
        private char tipo;
        private ReporteWS.ReporteWSClient daoReporte;


        private Estado estado = Estado.Asesoria;
        private Form formularioActivo = null;
        public frmCitas(int idPersona, int idCiclo, char tipo)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.idCiclo = idCiclo;
            this.tipo = tipo;
            this.daoReporte = new ReporteWS.ReporteWSClient();

            //Abrir por defecto dependiendo del tipo
            if (tipo == 'A') abrirFormulario(new frmCitasProgramadasAlumno(idPersona));
            else
            {
                btnDescargarReporte.Visible = true;
                btnHorario.Visible = true;
                abrirFormulario(new frmCitasProgramadasPersonal(idPersona));
            }
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formularioMostrar);
            panelContenido.Tag = formularioMostrar;
            formularioMostrar.Show();
        }

        private void lblCitasProg_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Asesoria)
            {
                lblAgendar.BackColor = Color.FromArgb(255, 255, 255);
                lblAgendar.ForeColor = Color.FromArgb(0, 0, 0);
                lblCitasProg.BackColor = Color.FromArgb(128, 128, 128);
                lblCitasProg.ForeColor = Color.FromArgb(255, 255, 255);

                //Abrir el formulario
                if (tipo == 'A') abrirFormulario(new frmCitasProgramadasAlumno(idPersona));
                else abrirFormulario(new frmCitasProgramadasPersonal(idPersona));
                estado = Estado.Asesoria;
            }
        }

        private void lblAgendar_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Cachimbos)
            {
                lblCitasProg.BackColor = Color.FromArgb(255, 255, 255);
                lblCitasProg.ForeColor = Color.FromArgb(0, 0, 0);
                lblAgendar.BackColor = Color.FromArgb(128, 128, 128);
                lblAgendar.ForeColor = Color.FromArgb(255, 255, 255);

                //Abrir el formulario
                if (tipo == 'A') abrirFormulario(new frmReservarCitaAlumno(idPersona, idCiclo));
                else abrirFormulario(new frmReservarCitaPersonalAlumno(idPersona, idCiclo));
                estado = Estado.Cachimbos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDisponibilidad frm = new frmDisponibilidad(idPersona,idCiclo);
            frm.ShowDialog();
        }

        private void btnDescargarReporte_Click(object sender, EventArgs e)
        {          
            saveFileDialog.Filter = "Archivos .pdf (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.AddExtension = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] arreglo = daoReporte.generarReporteCitasxPersonal(idPersona);
                File.WriteAllBytes(saveFileDialog.FileName, arreglo);
            }
           
        }
    }
}
