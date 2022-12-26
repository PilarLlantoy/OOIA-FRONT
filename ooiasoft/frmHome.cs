/* 
 * Archivo: frmHome.cs
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Observaciones de desarrollador:
 * - El software esta pensado para ser ejecutado siempre en pantalla completa,
 *   las coordenadas en la vista previa de "Design" no corresponden a las 
 *   posiciones finales en ejecucion pantalla completa.
 */

namespace ooiasoft
{
    public partial class frmHome : Form
    {

        //Este atributo decidira que caminos seguir, T para tutor, A para Alumno y
        //D para administrativo (no implementado aun pero lo sera a futuro)
        private char tipo;
        private PersonaWS.persona usuario;
        private PersonaWS.PersonaWSClient daoPersona;
        private CicloWS.CicloWSClient daoCiclo;
        private CicloWS.ciclo cicloActual;
        private Estado estado = Estado.Inicio;
        private Form formularioActivo = null;

        public frmHome(int id, char tipo)
        {
            InitializeComponent();
            daoPersona = new PersonaWS.PersonaWSClient();
            daoCiclo = new CicloWS.CicloWSClient();
            this.tipo = tipo;

            //Obtener el objeto de usuario se el tipo que sea
            if (tipo == 'A') usuario = daoPersona.buscarAlumnoPorID(id);
            else if (tipo == 'P') usuario = daoPersona.buscarPsicologoPorID(id);
            else if (tipo == 'T') usuario = daoPersona.buscarTutorPorID(id);
            else usuario = daoPersona.buscarAdministrativoPorID(id);

            //Llenar el nombre y foto
            lblNombre.Text = usuario.nombreCompleto;
            //Si tiene foto entonces llenarla, sino dejarla como foto por defecto
            if (usuario.foto != null)
            {
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbIconoUser.Image = Image.FromStream(ms);
            }

            //Obtener el ciclo actual invariante en las consultas
            cicloActual = obtenerCicloActual();

            //Ocultar las opciones que no correspondan
            configurarSecciones(tipo);
            
            //Abrir el formulario de home que corresponde al tipo
            abrirFormulario(obtenerFormularioInicio(tipo));
        }

        public void configurarSecciones(char tipo)
        {
            if (tipo == 'A')
            {
                panelFill1.Width += 50;
                panelFill2.Width += 50;
                panelFill3.Width += 50;
                panelOpcionAlumnos.Visible = false;
                panelOpcionPersonal.Visible = false;

            }
            else if (tipo == 'D')
            {
                panelOpcionCitas.Visible = false;
                panelFill2.Visible = false;
                panelFill1.Width += 50;
                panelFill3.Width += 50;
                panelFill4.Width += 50;
                panelFill5.Width += 50;
            }
            else
            {
                if (tipo == 'P') panelOpcionAlumnos.Visible = false;
                panelOpcionEventos.Visible = false;
                panelOpcionInfo.Visible = false;
                panelOpcionPersonal.Visible = false;
                panelFill3.Visible = false;
                panelFill4.Visible = false;
                panelFill1.Width += 50;
                panelFill2.Width += 50;
            }
        }

        public CicloWS.ciclo obtenerCicloActual()
        {
            CicloWS.ciclo[] ciclos = daoCiclo.listarCiclos();
            return ciclos[0];
        }
        private Form obtenerFormularioInicio(char tipo)
        {
            switch (tipo)
            {
                case 'A': return new frmInicioAlumno(usuario,cicloActual);
                case 'P':
                case 'T': return new InicioPersonal(cicloActual,usuario);
                case 'D': return new InicioAdmin(cicloActual,usuario);//new frmInicioAdministrativo(cicloActual,usuario);
                default: return null;
            }
        }

        private Form obtenerFormularioCitas(char tipo)
        {
            return new frmCitas(usuario.idPersona, cicloActual.idCiclo, tipo);
        }

        private Form obtenerFormularioEvento(char tipo)
        {
            switch (tipo)
            {
                case 'A': return new frmAlumnoEventosOpciones(usuario.idPersona,cicloActual.idCiclo);
                case 'D': return new frmEventosAdmin(cicloActual.idCiclo);
                default: return null;
            }
        }

        private Form obtenerFormularioInformacion(char tipo)
        {
            switch (tipo)
            {
                case 'A': return new frmInformacionAdministrativo('A');
                case 'D': return new frmInformacionAdministrativo('D');
                default: return null;
            }
        }

        private void pbCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Apoyandome de la funcion de clase
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formularioMostrar);
            panelContenido.Tag = formularioMostrar;
            formularioMostrar.Show();
        }
         
        private void pbIconoUser_Click(object sender, EventArgs e)
        {
            panelOpcionesSesion.Visible = !panelOpcionesSesion.Visible;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Inicio)
            {
                //Seleccionar
                lblHome.Font = new Font(lblHome.Font.Name, lblHome.Font.SizeInPoints, FontStyle.Underline| FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Inicio;
                abrirFormulario(obtenerFormularioInicio(tipo));
            }
        }

        private void quitarSeleccionOpcion(Estado estado)
        {
            if(estado == Estado.Inicio)
            {
                lblHome.Font = new Font(lblHome.Font.Name, lblHome.Font.SizeInPoints, FontStyle.Regular|FontStyle.Bold);
            }
            else if (estado == Estado.Citas)
            {
                lblCitas.Font = new Font(lblCitas.Font.Name, lblCitas.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
            }
            else if (estado == Estado.Eventos)
            {
                lblEventos.Font = new Font(lblEventos.Font.Name, lblEventos.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
            }
            else if (estado == Estado.Informacion)
            {
                lblInformacion.Font = new Font(lblInformacion.Font.Name, lblInformacion.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
            }
            else if(estado == Estado.Alumnos)
            {
                lblAlumnos.Font = new Font(lblAlumnos.Font.Name, lblAlumnos.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
            }
            else lblPersonal.Font = new Font(lblPersonal.Font.Name, lblPersonal.Font.SizeInPoints, FontStyle.Regular | FontStyle.Bold);
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            lblHome_Click(sender, e);
        }

        private void panelOpcionInicio_Click(object sender, EventArgs e)
        {
            lblHome_Click(sender, e);
        }

        private void lblCitas_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Citas)
            {
                //Seleccionar
                lblCitas.Font = new Font(lblCitas.Font.Name, lblCitas.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Citas;
                abrirFormulario(obtenerFormularioCitas(tipo));
            }
        }

        private void pbCitas_Click(object sender, EventArgs e)
        {
            lblCitas_Click(sender, e);
        }

        private void panelOpcionCitas_Click(object sender, EventArgs e)
        {
            lblCitas_Click(sender, e);
        }

        private void lblEventos_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Eventos)
            {
                //Seleccionar
                lblEventos.Font = new Font(lblEventos.Font.Name, lblEventos.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Eventos;
                abrirFormulario(obtenerFormularioEvento(tipo));
            }
        }

        private void pbEventos_Click(object sender, EventArgs e)
        {
            lblEventos_Click(sender, e);
        }

        private void panelOpcionEventos_Click(object sender, EventArgs e)
        {
            lblEventos_Click(sender, e);
        }

        private void lblInformacion_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Informacion)
            {
                //Seleccionar
                lblInformacion.Font = new Font(lblInformacion.Name, lblInformacion.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Informacion;
                abrirFormulario(obtenerFormularioInformacion(tipo));
            }
        }

        private void pbInformacion_Click(object sender, EventArgs e)
        {
            lblInformacion_Click(sender, e);
        }

        private void panelOpcionInfo_Click(object sender, EventArgs e)
        {
            lblInformacion_Click(sender, e);
        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Alumnos)
            {
                //Seleccionar
                lblAlumnos.Font = new Font(lblAlumnos.Name, lblAlumnos.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Alumnos;
                if(tipo == 'D')  abrirFormulario(new frmAlumnosAdministrativo());
                else abrirFormulario(new frmTutorAlumnosAsignados(usuario.idPersona,cicloActual.idCiclo));
            }
        }

        private void pbAlumnos_Click(object sender, EventArgs e)
        {
            lblAlumnos_Click(sender, e);
        }

        private void panelOpcionAlumnos_Click(object sender, EventArgs e)
        {
            lblAlumnos_Click(sender, e);
        }

        private void lblPersonal_Click(object sender, EventArgs e)
        {
            if (estado != Estado.Personal)
            {
                //Seleccionar
                lblPersonal.Font = new Font(lblPersonal.Name, lblPersonal.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
                //Quitar el delineado al anterior
                quitarSeleccionOpcion(estado);
                estado = Estado.Personal;
                abrirFormulario(new frmGestionarPersonal());
            }
        }

        private void pbPersonal_Click(object sender, EventArgs e)
        {
            lblPersonal_Click(sender, e);
        }

        private void lblVerPerfil_Click(object sender, EventArgs e)
        {
            Form frm = new frmVerPerfil(usuario);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                //Actualizar la foto de perfil y el nombre en caso se realicen cambios
                lblNombre.Text = usuario.nombreCompleto;
                if (usuario.foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    pbIconoUser.Image = Image.FromStream(ms);
                }

                //Obtener la referencia del picture box si es un formulario de inicio
                PictureBox foto = null;
                if (usuario.foto != null && foto != null)
                {
                    MemoryStream ms = new MemoryStream(usuario.foto);
                    foto.Image = Image.FromStream(ms);
                }
            }
        }

        private void lblConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracionCuenta config = new frmConfiguracionCuenta(usuario);
            config.ShowDialog();
        }
    }
}
