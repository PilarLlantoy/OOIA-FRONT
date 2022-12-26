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
    public partial class frmNuevoPersonal : Form
    {
        private char tipo = 'N';
        public frmNuevoPersonal()
        {
            InitializeComponent();
        }

        public char Tipo { get => tipo; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbAdministrativo.Checked == true) tipo = 'D';
            else if (rbPsicologo.Checked == true) tipo = 'P';
            else if (rbTutor.Checked == true) tipo = 'T';
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de personal.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
