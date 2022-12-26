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
    public partial class frmAlumnosAdministrativo : Form
    {
        private Estado estado = Estado.AlumnoDatos;
        private Form formularioActivo = null;
        public frmAlumnosAdministrativo()
        {
            InitializeComponent();
            abrirFormulario(new frmGestionarAlumnos());
            
        }

        private void lblRegistroDatos_Click(object sender, EventArgs e)
        {
            if(estado != Estado.AlumnoDatos)
            {
                //Seleccionar el nuevo
                lblRegistroNotas.BackColor = Color.FromArgb(255, 255, 255);
                lblRegistroNotas.ForeColor = Color.FromArgb(0, 0, 0);
                lblRegistroDatos.BackColor = Color.FromArgb(128, 128, 128);
                lblRegistroDatos.ForeColor = Color.FromArgb(255, 255, 255);
                estado = Estado.AlumnoDatos;
                abrirFormulario(new frmGestionarAlumnos());
            }
        }

        private void lblRegistroNotas_Click(object sender, EventArgs e)
        {
            if(estado != Estado.AlumnoNotas)
            {
                //Seleccionar el nuevo
                lblRegistroDatos.BackColor = Color.FromArgb(255, 255, 255);
                lblRegistroDatos.ForeColor = Color.FromArgb(0, 0, 0);
                lblRegistroNotas.BackColor = Color.FromArgb(128, 128, 128);
                lblRegistroNotas.ForeColor = Color.FromArgb(255, 255, 255);
                estado = Estado.AlumnoNotas;
                abrirFormulario(new frmRegistroNotas());
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
            panelFondo.Controls.Add(formularioMostrar);
            panelFondo.Tag = formularioMostrar;
            formularioMostrar.Show();
        }
    }
}
