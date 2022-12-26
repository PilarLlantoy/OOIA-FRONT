using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmVerPerfil : Form
    {
        private PersonaWS.PersonaWSClient daoPersona;
        private PersonaWS.persona usuario;
        private Form formulario;
        public frmVerPerfil(PersonaWS.persona usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            daoPersona = new PersonaWS.PersonaWSClient();

            tbID.Text = usuario.idPersona.ToString();
            tbCodigoPUCP.Text = usuario.codigoPUCP;
            tbDNI.Text = usuario.DNI;
            tbNombre.Text = usuario.nombreCompleto;
            dtpFecha.Value = usuario.fechaNacimiento;
            if (Convert.ToChar(usuario.sexo) == 'M') rbHombre.Checked = true;
            else rbMujer.Checked = true;
            tbTelefono.Text = usuario.telefono;
            tbCorreo.Text = usuario.correo;
            //Si tiene foto entonces llenarla, sino dejarla como foto por defecto
            if (usuario.foto != null)
            {
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbFoto.Image = Image.FromStream(ms);
            }

            //Desactivar todas las ediciones
            pbFoto.Enabled = false;
            btnEditarFoto.Enabled = false;
            tbID.Enabled = false;
            tbCodigoPUCP.Enabled = false;
            tbDNI.Enabled = false;
            tbNombre.Enabled = false;
            dtpFecha.Enabled = false;
            tbCorreo.Enabled = false;
            tbTelefono.Enabled = false;
            rbHombre.Enabled = false;
            rbMujer.Enabled = false;
            btnGuardar.Enabled = false;

            btnAccion.Text = "Editar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (tbDNI.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Debe ingresar el DNI", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbDNI.Text, @"^\d+$"))
            {
                MessageBox.Show("El DNI debe contener solo números", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 cifras", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario.DNI = tbDNI.Text;

            //Es nombre valido
            if (tbNombre.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Debe ingresar el Nombre Completo", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbNombre.Text, "^[A-Za-zs]+"))
            {
                MessageBox.Show("El nombre debe contener solo letras del abecedario.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.nombreCompleto = tbNombre.Text;

            if(dtpFecha.Value.CompareTo(dtpFecha.Value) > 0)
            {
                MessageBox.Show("Error en la fecha, debe ser menor al día actual.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario.fechaNacimiento = dtpFecha.Value;
            usuario.fechaNacimientoSpecified = true;

            if (rbHombre.Checked) usuario.sexo = (ushort)Convert.ToInt32('M');
            else usuario.sexo = (ushort)Convert.ToInt32('F');

            if (tbTelefono.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Debe ingresar el telefono.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tbDNI.Text, @"^\d+$"))
            {
                MessageBox.Show("El telefono debe contener solo números.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDNI.Text.Length > 9)
            {
                MessageBox.Show("El telefono no puede tener más de 9 cifras.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario.telefono = tbTelefono.Text;
            try
            {
                MailAddress m = new MailAddress(tbCorreo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe ingresar un correo con formato apropiado.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario.correo = tbCorreo.Text;

            MemoryStream ms = new MemoryStream();
            pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
            usuario.foto = ms.ToArray();

            int resultado = daoPersona.modificarPersona(usuario);
            if(resultado != 0)
            {
                MessageBox.Show("Se ha modificado su información personal con éxito.", "Éxito en el registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la modificación de su información personal.", "Error en el Registro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            String ruta;
            try
            {
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido","Error en la carga de foto.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if(btnAccion.Text.CompareTo("Editar") == 0)
            {
                btnAccion.Text = "Cancelar";
                pbFoto.Enabled = true;
                btnEditarFoto.Enabled = true;
                tbCodigoPUCP.Enabled = true;
                tbDNI.Enabled = true;
                tbNombre.Enabled = true;
                dtpFecha.Enabled = true;
                tbCorreo.Enabled = true;
                tbTelefono.Enabled = true;
                rbHombre.Enabled = true;
                rbMujer.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnAccion.Text = "Editar";
                tbID.Text = usuario.idPersona.ToString();
                tbCodigoPUCP.Text = usuario.codigoPUCP;
                tbDNI.Text = usuario.DNI;
                tbNombre.Text = usuario.nombreCompleto;
                dtpFecha.Value = usuario.fechaNacimiento;
                if (Convert.ToChar(usuario.sexo) == 'M') rbHombre.Checked = true;
                else rbMujer.Checked = true;
                tbTelefono.Text = usuario.telefono;
                tbCorreo.Text = usuario.correo;
                //Si tiene foto entonces llenarla, sino dejarla como foto por defecto
                if (usuario.foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbFoto.Image = Image.FromStream(ms);
                }

                //Desactivar todas las ediciones
                pbFoto.Enabled = false;
                btnEditarFoto.Enabled = false;
                tbCodigoPUCP.Enabled = false;
                tbDNI.Enabled = false;
                tbNombre.Enabled = false;
                dtpFecha.Enabled = false;
                tbCorreo.Enabled = false;
                tbTelefono.Enabled = false;
                rbHombre.Enabled = false;
                rbMujer.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }
    }
}
