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
    public partial class frmDescripcionEventoAlumno : UserControl
    {
        private EventoCicloWS.eventoCiclo evento;
        private int idAlumno;

        public frmDescripcionEventoAlumno()
        {
            InitializeComponent();
        }

        public void llenarDatos(int idAlumno, EventoCicloWS.eventoCiclo evento)
        {
            this.evento = evento;
            this.idAlumno = idAlumno;

            lblTitulo.Text = evento.titulo;
            rtbDescripcion.Rtf = evento.descripcionUTF;

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='" + (wbVideoEvento.Size.Width - 50) + "' height='" + (wbVideoEvento.Size.Height - 50) + "' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            try
            {
                this.wbVideoEvento.DocumentText = string.Format(html, evento.linkVideo.Split('=')[1]);
            }
            catch (Exception ex)
            {
                wbVideoEvento.Visible = false;
                scTxtYT.SplitterDistance = 1000;
            }

            if (evento.foto != null)
            {
                MemoryStream ms = new MemoryStream(evento.foto);
                pbEvento.Image = Image.FromStream(ms);
            }
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            frmInformacionEventoAlumno formulario = new frmInformacionEventoAlumno(idAlumno, evento, 1);
            if (formulario.ShowDialog() == DialogResult.OK);
        }

        private void wbVideoEvento_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wbVideoEvento.Size = wbVideoEvento.Document.Body.ScrollRectangle.Size;
        }
    }
}
