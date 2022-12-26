/* 
 * Archivo: frmPersonalCitas.cs
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class frmPersonalCitas : UserControl
    {
        public frmPersonalCitas() {
            InitializeComponent();
        }

        //Se pasa la persona para llenar los campos con sus datos
        public frmPersonalCitas(PersonaWS.persona persona) {
            InitializeComponent();
            llenarDatos(persona);
        }

        public void llenarDatos(PersonaWS.persona persona)
        {
            lblNombrePersonal.Text = persona.nombreCompleto;
            if (persona is PersonaWS.tutor) lblTipoPersonal.Text = "Tutor - OOIA";
            else lblTipoPersonal.Text = "Psicólogo - OOIA";
            //Setear la foto solo si tiene foto
            if (persona.foto != null)
            {
                MemoryStream ms = new MemoryStream(persona.foto);
                pbPersonal.Image = Image.FromStream(ms);
            }
            lklblCorreo.Text = persona.correo;
        }

    }
}
