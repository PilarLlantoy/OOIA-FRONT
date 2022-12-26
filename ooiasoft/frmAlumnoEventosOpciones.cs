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
    public partial class frmAlumnoEventosOpciones : Form
    {
        private int idPersona;
        private int idCicloActual;
        private Estado estado = Estado.EventosInscritos;
        private Form formularioActivo = null;
        public frmAlumnoEventosOpciones(int idPersona, int idCicloActual)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.idCicloActual = idCicloActual;
            abrirFormulario(new frmAlumnoMisEventos(idPersona));
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

        private void lblEventosInscritos_Click(object sender, EventArgs e)
        {
            if(estado != Estado.EventosInscritos)
            {
                lblInscribirse.BackColor = Color.FromArgb(255, 255, 255);
                lblInscribirse.ForeColor = Color.FromArgb(0, 0, 0);
                lblEventosInscritos.BackColor = Color.FromArgb(128, 128, 128);
                lblEventosInscritos.ForeColor = Color.FromArgb(255, 255, 255);
                estado = Estado.EventosInscritos;
                abrirFormulario(new frmAlumnoMisEventos(idPersona));
            }
        }

        private void lblInscribirse_Click(object sender, EventArgs e)
        {
            if (estado != Estado.EventosPorInscribir)
            {
                lblEventosInscritos.BackColor = Color.FromArgb(255, 255, 255);
                lblEventosInscritos.ForeColor = Color.FromArgb(0, 0, 0);
                lblInscribirse.BackColor = Color.FromArgb(128, 128, 128);
                lblInscribirse.ForeColor = Color.FromArgb(255, 255, 255);
                estado = Estado.EventosPorInscribir;
                abrirFormulario(new frmEventosAlumno(idPersona,idCicloActual));
            }
        }
    }
}
