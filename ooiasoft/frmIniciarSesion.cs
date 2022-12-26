/* 
 * Archivo: frmIniciarSesion.cs
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
using System.Runtime.InteropServices;

namespace ooiasoft
{
    public partial class frmIniciarSesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private frmHome formularioHome;
        private Form frmRecuperarContra;
        private PersonaWS.PersonaWSClient daoPersona;
        public frmIniciarSesion()
        {
            InitializeComponent();
            daoPersona = new PersonaWS.PersonaWSClient();
        }

        private void pbCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmIniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            int id = daoPersona.buscarIDPersonaPorUsuarioPassword(txtUsuario.Text, txtContrasena.Text);
            if (id == -1) lblError.Visible = true;
            else
            {
                lblError.Visible = false;
                //Se oculta para lanzar el otro formulario como pantalla principal
                this.Hide();
                char tipo = Convert.ToChar(daoPersona.buscarTipoPersonaPorIDPersona(id));
                formularioHome = new frmHome(id, tipo);
                //Espera y luego vuelve a la zona de inicio de sesion
                if (formularioHome.ShowDialog() == DialogResult.OK)
                {
                    //Limpia los campos llenados
                    txtContrasena.Clear();
                    txtUsuario.Clear();
                    //Luego se vuelve a mostrar
                    this.Show();
                }
            }
        }

        private void lklblClickAqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContra = new frmRecuperarContra();
            frmRecuperarContra.ShowDialog();
        }
    }
}
