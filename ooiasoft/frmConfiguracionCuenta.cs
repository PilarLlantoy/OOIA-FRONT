/* 
 * Archivo: frmConfiguracionCuenta.cs
 * Grupo:   Grave Error de Proyecto
 * Integrantes: Oscar Dueñas
                Christian Carhuancho
                Franccesco Jaimes
                Pilar Llantoy
                Cesar Rafael
 * Fecha:   19/05/2021
 */

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
    public partial class frmConfiguracionCuenta : Form
    {
        private PersonaWS.PersonaWSClient daoPersona;
        private PersonaWS.persona usersystem;
        public frmConfiguracionCuenta(PersonaWS.persona usuario)
        {
            InitializeComponent();
            daoPersona = new PersonaWS.PersonaWSClient();
            usersystem = usuario;
            tbUser.Text = usuario.usuario;
            if (usuario.foto != null)
            {
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbFoto.Image = Image.FromStream(ms);
            }
        }

        private void btnConfirm_MouseClick(object sender, MouseEventArgs e)
        {
            //PersonaWS.persona user = buscarPersona();
            if (tbOldPass.Text == "" || tbNewPass.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbOldPass.Text != usersystem.password)
            {
                MessageBox.Show("La contrasena no es correcta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbOldPass.Text == tbNewPass.Text)
            {
                MessageBox.Show("Debe ser una contraseña distinta a la anterior.", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usersystem.password = tbNewPass.Text;
            int resultado = daoPersona.modificarPersona(usersystem);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha actualizado los datos de su cuenta de usuario.", "Cuenta actualizada");
                this.DialogResult = DialogResult.OK;
                tbOldPass.Enabled = false;
                tbNewPass.Enabled = false;
            } else
            {
                MessageBox.Show("Ha ocurrido un error al modificar los datos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

       /* private PersonaWS.persona buscarPersona()
        {
            PersonaWS.persona user;
            int id = daoPersona.buscarIDPersonaPorUsuarioPassword(usersystem.usuario.ToString(),usersystem.password.ToString();
            ushort tipo = daoPersona.buscarTipoPersonaPorIDPersona(id);
            if (tipo == 'A') user = daoPersona.buscarAlumnoPorID(id);
            else if (tipo == 'P') user = daoPersona.buscarPsicologoPorID(id);
            else if (tipo == 'T') user = daoPersona.buscarTutorPorID(id);
            else user = daoPersona.buscarAdministrativoPorID(id);
            return user;
        }*/
    }
}
