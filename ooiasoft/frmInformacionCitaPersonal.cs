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
    public partial class frmInformacionCitaPersonal : Form
    {
        private CitaWS.cita cita;
        private int idPersonal;
        private CitaWS.CitaWSClient daoCita;
        private int operacion;
        private int estado; //0: Pendiente, 1: Pasado
        private int horaElegida;

        public frmInformacionCitaPersonal(int idPersonal, CitaWS.cita cita)
        {
            InitializeComponent();
            this.cita = cita;
            this.idPersonal = idPersonal;
            this.operacion = 0;
            daoCita = new CitaWS.CitaWSClient();

            cbMotivoCita.DataSource = daoCita.listarMotivosCita();
            cbMotivoCita.DisplayMember = "descripcion";
            cbMotivoCita.ValueMember = "idMotivo";

            llenarCampos();
            
            txtBoxNombreAlumno.Text = cita.alumno.nombreCompleto;
            txtBoxCodPUCP.Text = cita.alumno.codigoPUCP;
            txtBoxCelular.Text = cita.alumno.telefono;
            txtBoxCorreo.Text = cita.alumno.correo;

            if (cita.alumno.foto != null)
            {
                MemoryStream ms = new MemoryStream(cita.alumno.foto);
                pbIconoUser.Image = Image.FromStream(ms);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cancelar la cita con el asesor?", "Mensaje de Advertencia.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoCita.eliminarCita(cita.idCita);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha anulado su reserva de la cita.", "Mensaje de Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Ha ocurrido un error. No se ha podido cancelar su reserva de la cita.", "Error en la Operación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacion = 1;
            btnCancelarCambiosVolver.Text = "Cancelar Edición";
            btnEditar.Enabled = false;
            btnGuardarCambios.Enabled = true;
            habilitarCampos();
        }

        private void habilitarCampos()
        {
            cbMotivoCita.Enabled = true;
            if (this.estado == 1)
            {
                rbAsistio.Enabled = true;
                rbFalto.Enabled = true;
            }
            else
            {
                dateTimeFechaCita.Enabled = true;
                numUPHora.Enabled = true;
            }
        }

        private void btnCancelarCambiosVolver_Click(object sender, EventArgs e)
        {
            if (operacion == 1 && btnCancelarCambiosVolver.Text.CompareTo("Cancelar Edición") == 0)
            {
                llenarCampos();
                bloquearComponentes();
                btnEditar.Enabled = true;
                btnGuardarCambios.Enabled = false;
                operacion = 0;
                btnCancelarCambiosVolver.Text = "Volver";
            }
            else this.Close();
        }

        private void llenarCampos()
        {
            cbMotivoCita.SelectedValue = cita.motivoCita.idMotivo;

            if (DateTime.Today.CompareTo(cita.fechaAtencion) > 0)
            {
                lblEstado.Text = "Pasada";
                this.estado = 1;
                if (cita.asistio)
                {
                    rbAsistio.Checked = true;
                }
                else
                {
                    rbFalto.Checked = true;
                }
            }
            else
            {
                this.estado = 0;
                lblEstado.Text = "Pendiente";
                btnCancelar.Visible = true;
            }

            dateTimeFechaCita.Value = cita.fechaAtencion;
            dateTimeFechaRegistro.Value = cita.fechaRegistro;
            numUPHora.Text = cita.hora.ToString();
            txtBoxCiclo.Text = cita.ciclo.anho + " - " + cita.ciclo.periodo;
        }

        private void bloquearComponentes()
        {
            dateTimeFechaCita.Enabled = false;
            numUPHora.Enabled = false;
            rbAsistio.Enabled = false;
            rbFalto.Enabled = false;
            cbMotivoCita.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CitaWS.cita nueva_cita = new CitaWS.cita();
            nueva_cita.idCita = this.cita.idCita;
            nueva_cita.personalCitas = this.cita.personalCitas;
            nueva_cita.alumno = this.cita.alumno;
            nueva_cita.ciclo = this.cita.ciclo;
            nueva_cita.fechaRegistro = this.cita.fechaRegistro;
            nueva_cita.fechaRegistroSpecified = true;
            nueva_cita.motivoCita = (CitaWS.motivoCita)cbMotivoCita.SelectedItem;

            if (rbAsistio.Checked)
            {
                nueva_cita.asistio = true;
            }
            if (rbFalto.Checked)
            {
                nueva_cita.asistio = false;
            }

            int hora = horaElegida;

            if (10 <= hora && hora <= 19)
            {
                CitaWS.cita[] citas_dia = null;
                citas_dia = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idPersonal, "", dateTimeFechaCita.Value, dateTimeFechaCita.Value, "");
                bool es_disponible = true;
                if (citas_dia != null && DateTime.Today.CompareTo(cita.fechaAtencion) <= 0)
                {
                    foreach (CitaWS.cita cita_aux in citas_dia)
                    {
                        if (cita_aux.idCita != cita.idCita)
                        {
                            if (cita_aux.hora == hora)
                            {
                                es_disponible = false;
                                break;
                            }
                        }
                    }
                }
                if (es_disponible)
                {
                    nueva_cita.hora = hora;
                    nueva_cita.fechaAtencion = dateTimeFechaCita.Value;
                    nueva_cita.fechaAtencionSpecified = true;
                    int resultado = daoCita.modificarCita(nueva_cita);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Se ha editado la cita satisfactoriamente", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bloquearComponentes();
                        btnCancelarCambiosVolver.Text = "Volver";
                        this.operacion = 0;
                        btnGuardarCambios.Enabled = false;
                    } else
                    {
                        MessageBox.Show("Lo sentimos, no pudo editarse la cita", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Usted ya tiene una cita reservada en ese horario", "Horario no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("El horario disponible es en un rango de 10am a 7pm", "Hora no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numUDHora_ValueChanged(object sender, EventArgs e)
        {
            //Calcular la hora cambiada actual
            horaElegida = (int)numUPHora.Value;
            if (horaElegida < 12 && lblFormatoHora.Text.CompareTo("p.m.") == 0)
            {
                if (horaElegida != 11) horaElegida += 12;
            }

            //Limitar
            if (horaElegida < 10) horaElegida = 10;
            else if (horaElegida > 19) horaElegida = 19;

            //Colocar hora y formato correcto
            if (horaElegida < 12) lblFormatoHora.Text = "a.m.";
            else lblFormatoHora.Text = "p.m.";

            if (horaElegida > 12) numUPHora.Value = horaElegida - 12;
            else numUPHora.Value = horaElegida;
        }
    }
}
