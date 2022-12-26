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
    public partial class frmFormatoArchivoCursos : Form
    {
        private int opcionSeleccionada=0;
       
        public frmFormatoArchivoCursos()
        {
            InitializeComponent();
        }

        public int OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (!rb1.Checked && !rb2.Checked && !rb3.Checked)
            {
                MessageBox.Show("No ha seleccionado una opcion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rb1.Checked) opcionSeleccionada = 1;
            else if (rb2.Checked) opcionSeleccionada = 2;
            else opcionSeleccionada = 3;
            this.DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
