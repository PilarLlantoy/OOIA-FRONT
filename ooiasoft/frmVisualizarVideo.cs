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
    public partial class frmVisualizarVideo : Form
    {
        private String linkVideo;

        public frmVisualizarVideo()
        {
            InitializeComponent();
        }

        public string LinkVideo { get => linkVideo; set => linkVideo = value; }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textLink.Text.CompareTo("") != 0)
                {
                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='571' height='250' frameborder='0' allowfullscreen></iframe>";
                    html += "</body></html>";
                    this.wbVideo.DocumentText = string.Format(html, textLink.Text.Split('=')[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El link no es un enlace de video válido.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            LinkVideo = textLink.Text;
            if (LinkVideo.CompareTo("") == 0)
            {
                MessageBox.Show("Debe ingresar un enlace de YouTube.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else this.DialogResult = DialogResult.OK;
        }
    }
}
