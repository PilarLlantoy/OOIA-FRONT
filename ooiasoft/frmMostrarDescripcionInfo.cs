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
    public partial class frmMostrarDescripcionInfo : UserControl
    {
        public frmMostrarDescripcionInfo(InformacionTemaCicloWS.informacionTemaCiclo subtema)
        {
            InitializeComponent();
            if (subtema.foto != null)
            {
                MemoryStream ms = new MemoryStream(subtema.foto);
                pbImagen.Image = new Bitmap(ms);
            }
            rtbDescripcion.Rtf = subtema.descripcionUTF;
        }
    }
}
