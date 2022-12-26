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
    public partial class frmEditarEliminarTema : Form
    {
        private int eliminado = 0;
        private frmInformacionAdministrativo padre;
        private InformacionTemaCicloWS.tema t;
        private InformacionTemaCicloWS.InformacionTemaCicloWSClient daoTema;
        public frmEditarEliminarTema(InformacionTemaCicloWS.tema tema, frmInformacionAdministrativo frm)
        {
            InitializeComponent();
            padre = frm;
            t = tema;
            tbTema.Text = tema.nombre;
            daoTema = new InformacionTemaCicloWS.InformacionTemaCicloWSClient();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (btEditar.Text == "Editar")
            {
                tbTema.Enabled = true;
                btEditar.Text = "Guardar";
            } else
            {
                t.nombre = tbTema.Text;
                
                int resultado = daoTema.modificarTema(t);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado con exito el tema actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    padre.BorrarSubTemas();
                    padre.BorrarTemas();
                    padre.ListarTemas();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este tema?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoTema.eliminarTema(t.idTema);
                if (resultado != 0)
                {
                    eliminado = 1;
                    MessageBox.Show("Se ha eliminado con exito el tema actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    padre.BorrarSubTemas();
                    padre.BorrarTemas();
                    padre.ListarTemas();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

    }
}
