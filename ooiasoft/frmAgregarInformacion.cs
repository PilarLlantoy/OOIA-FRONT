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
    public partial class frmAgregarInformacion : Form
    {
        private int nuevo = 0;
        private CicloWS.ciclo c;
        private InformacionTemaCicloWS.tema t;
        private InformacionTemaCicloWS.InformacionTemaCicloWSClient daoInfo;
        public frmAgregarInformacion(CicloWS.ciclo ciclo, InformacionTemaCicloWS.tema tema)
        {
            InitializeComponent();
            c = ciclo;
            t = tema;
            daoInfo = new InformacionTemaCicloWS.InformacionTemaCicloWSClient();
        }

        public int Nuevo { get => nuevo; set => nuevo = value; }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta;
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;
                    pbImagen.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            InformacionTemaCicloWS.informacionTemaCiclo subtema = new InformacionTemaCicloWS.informacionTemaCiclo();
            if (tbTitulo.Text == "")
            {
                MessageBox.Show("No ha ingresado el titulo de la informacion.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbDescripcion.RTF == "")
            {
                MessageBox.Show("No ha ingresado descripcion para la informacion.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            subtema.tema = t;
            subtema.ciclo = new InformacionTemaCicloWS.ciclo();
            subtema.ciclo.idCiclo = c.idCiclo;
            subtema.descripcion = tbDescripcion.RTF;
            subtema.descripcionUTF = tbDescripcion.RTF;
            subtema.titulo = tbTitulo.Text;
            subtema.fechaRegistro = DateTime.Today;
            subtema.fechaRegistroSpecified = true;
            subtema.fechaVisible = dtpVisible.Value;
            subtema.fechaVisibleSpecified = true;
            if (pbImagen.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                subtema.foto = ms.ToArray();
            }
            int resultado = daoInfo.insertarInformacionTemaCiclo(subtema);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado la informacion para el tema seleccionado con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevo = 1;
                btGuardar.Enabled = false;
                tbDescripcion.Enabled = false;
                tbTitulo.Enabled = false;
                btCancelar.Text = "Volver";
            }
            else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
