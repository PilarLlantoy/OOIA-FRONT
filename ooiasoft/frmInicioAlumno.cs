/* 
 * Archivo: frmInicioAlumno.cs
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
    public partial class frmInicioAlumno : Form
    {
        private int idAlumno;
        private PersonaWS.PersonaWSClient daoPersona;
        private EventoCicloWS.EventoCicloWSClient daoEventoCiclo;
        private CicloWS.ciclo cicloActual;
        public frmInicioAlumno(PersonaWS.persona usuario, CicloWS.ciclo cicloActual)
        {
            InitializeComponent();
            idAlumno = usuario.idPersona;
            daoPersona = new PersonaWS.PersonaWSClient();
            daoEventoCiclo = new EventoCicloWS.EventoCicloWSClient();
            this.cicloActual = cicloActual;

            //Llenar a los miembros de la ooia que brindan asesorias
            llenarMiembrosOOIA();

            //Llenar el panel de ultimos eventos
            llenarPanelEventos(usuario,cicloActual);

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='230' height='230' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            wbOOIA.DocumentText = string.Format(html, "fKcdsazGjRI");

        }

        public void llenarMiembrosOOIA()
        {
            BindingList<PersonaWS.persona> personalCitas = new BindingList<PersonaWS.persona>();

            //Primero tutores
            PersonaWS.persona[] aux = daoPersona.listarTutoresPorCodigoNombre("");
            if (aux != null)
                foreach (PersonaWS.persona persona in aux) personalCitas.Add(persona);

            //Luego psicologos
            aux = daoPersona.listarPsicologosPorCodigoNombre("");
            if (aux != null)
                foreach (PersonaWS.persona persona in aux) personalCitas.Add(persona);

            //Llenar los miembros en los user controls
            foreach (PersonaWS.persona persona in personalCitas)
            {
                frmPersonalCitas frm = new frmPersonalCitas(persona);
                flPanelPersonal.Controls.Add(frm);
                frm.Dock = DockStyle.Top;
            }
        }

        public void llenarPanelEventos(PersonaWS.persona usuario, CicloWS.ciclo cicloActual)
        {
            EventoCicloWS.eventoCiclo[] eventos = daoEventoCiclo.listarEventoCiclosNoInscritosParaAlumno(usuario.idPersona,cicloActual.idCiclo,"",Convert.ToDateTime("01-01-1000"),Convert.ToDateTime("01-01-3000"));
            if(eventos == null)
            {
                frmDescripcionEventoAlumno1.Visible = false;
                frmDescripcionEventoAlumno2.Visible = false;
                lblNoHayEventos.Visible = true;
            }
            else if(eventos.Length == 1)
            {
                frmDescripcionEventoAlumno1.llenarDatos(idAlumno,eventos[0]);
                frmDescripcionEventoAlumno2.Visible = false;
            }
            else
            {
                frmDescripcionEventoAlumno1.llenarDatos(idAlumno,eventos[0]);
                frmDescripcionEventoAlumno2.llenarDatos(idAlumno,eventos[1]);
            }
        }

        private void btVerMas_Click(object sender, EventArgs e)
        {
            frmOOIA frm = new frmOOIA();
            frm.ShowDialog();
        }
    }
}
