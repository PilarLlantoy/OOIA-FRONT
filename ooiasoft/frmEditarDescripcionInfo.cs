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
    public partial class frmEditarDescripcionInfo : UserControl
    {
        private int eliminado = 0;
        private InformacionTemaCicloWS.informacionTemaCiclo subTema;
        private InformacionTemaCicloWS.InformacionTemaCicloWSClient daoInfo;
        private frmInformacionAdministrativo padre;
        public frmEditarDescripcionInfo(InformacionTemaCicloWS.informacionTemaCiclo subtema, frmInformacionAdministrativo padre)
        {
            InitializeComponent();

            daoInfo = new InformacionTemaCicloWS.InformacionTemaCicloWSClient();
            this.padre = padre;

            subTema = subtema;
            llenarDatos(subTema);
        }
        public void llenarDatos(InformacionTemaCicloWS.informacionTemaCiclo subtema)
        {
            if (subtema.foto != null)
            {
                MemoryStream ms = new MemoryStream(subtema.foto);
                pbImagen.Image = new Bitmap(ms);
            }
            tbDescripcion.RTF = subtema.descripcionUTF;
            dtpVisible.Value = subtema.fechaVisible.Date;
        }
        private void btImagen_Click(object sender, EventArgs e)
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

            subTema.fechaVisible = dtpVisible.Value;
            subTema.fechaVisibleSpecified = true;
            subTema.descripcionUTF = tbDescripcion.RTF;
            subTema.descripcion = tbDescripcion.RTF;
            
            if (pbImagen.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
                subTema.foto = ms.ToArray();
            }

            if (tbDescripcion.RTF == "")
            {
                MessageBox.Show("No ha ingresado una descripcion para la informacion seleccionada.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resultado = daoInfo.modificarInformacionTemaCiclo(subTema);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha modificado la informacion seleccionada con exito.", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta informacion?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoInfo.eliminarInformacionTemaCiclo(subTema.idInformacionTemaCiclo);
                if (resultado != 0)
                {
                    eliminado = 1;
                    MessageBox.Show("Se ha eliminado con exito la informacion actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    padre.BorrarSubTemas();
                    padre.ListarSubtemas();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
