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
    public partial class frmAgregarTema : Form
    {
        private int nuevo = 0;
        public frmAgregarTema()
        {
            InitializeComponent();
        }
        public int Nuevo { get => nuevo; set => nuevo = value; }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("No ha ingresado el tema.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InformacionTemaCicloWS.tema tema = new InformacionTemaCicloWS.tema();
            tema.nombre = tbNombre.Text;
            InformacionTemaCicloWS.InformacionTemaCicloWSClient daoTema = new InformacionTemaCicloWS.InformacionTemaCicloWSClient();
            int resultado = daoTema.insertarTema(tema);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado el tema con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevo = 1;
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
