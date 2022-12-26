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
    public partial class frmDisponibilidad : Form
    {
        private HorarioCicloWS.HorarioCicloWSClient daoHorario;
        private HorarioCicloWS.horarioCiclo horarioCiclo = null;
        private int idPersonal;
        private int idCiclo;

        public frmDisponibilidad(int idPersonal, int idCiclo)
        {
            InitializeComponent();
            this.idPersonal = idPersonal;
            this.idCiclo = idCiclo;
            daoHorario = new HorarioCicloWS.HorarioCicloWSClient();
            HorarioCicloWS.horarioCiclo[] horarios = daoHorario.listarHorarioCiclos(idPersonal);
            estadoCeldas(false);

            //Si es un ciclo sin horario
            if (horarios == null || horarios[0].ciclo.idCiclo != idCiclo)
            {
                btnEditar.Text = "Registrar";
                horarioCiclo = new HorarioCicloWS.horarioCiclo();
            }
            else
            {
                //Editar horario, debe primero llenarse
                this.horarioCiclo = horarios[0];
                llenarHorario();
            }

        }

        private void llenarHorario()
        {
            limpiarCeldas();
            if(btnEditar.Text.CompareTo("Editar") == 0)
            {
                foreach(HorarioCicloWS.detalleHorario dh in horarioCiclo.horario)
                {
                    if(dh.dia == 1)
                    {
                        if (dh.horaInicio == 10) panelL10.BackColor = Color.FromArgb(0,255,0);
                        else if (dh.horaInicio == 11) panelL11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelL12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelL13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelL14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelL15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelL16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelL17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelL18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelL19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else if (dh.dia == 2)
                    {
                        if (dh.horaInicio == 10) panelM10.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 11) panelM11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelM12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelM13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelM14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelM15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelM16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelM17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelM18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelM19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else if (dh.dia == 3)
                    {
                        if (dh.horaInicio == 10) panelX10.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 11) panelX11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelX12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelX13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelX14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelX15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelX16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelX17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelX18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelX19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else if (dh.dia == 4)
                    {
                        if (dh.horaInicio == 10) panelJ10.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 11) panelJ11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelJ12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelJ13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelJ14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelJ15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelJ16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelJ17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelJ18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelJ19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else if (dh.dia == 5)
                    {
                        if (dh.horaInicio == 10) panelV10.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 11) panelV11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelV12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelV13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelV14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelV15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelV16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelV17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelV18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelV19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                    else
                    {
                        if (dh.horaInicio == 10) panelS10.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 11) panelS11.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 12) panelS12.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 13) panelS13.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 14) panelS14.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 15) panelS15.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 16) panelS16.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 17) panelS17.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 18) panelS18.BackColor = Color.FromArgb(0, 255, 0);
                        else if (dh.horaInicio == 19) panelS19.BackColor = Color.FromArgb(0, 255, 0);
                    }
                }
            }
        }

        private void limpiarCeldas()
        {
            //Poner en blanco las celdas
            panelL10.BackColor = Color.FromArgb(255, 255, 255);
            panelL11.BackColor = Color.FromArgb(255, 255, 255);
            panelL12.BackColor = Color.FromArgb(255, 255, 255);
            panelL13.BackColor = Color.FromArgb(255, 255, 255);
            panelL14.BackColor = Color.FromArgb(255, 255, 255);
            panelL15.BackColor = Color.FromArgb(255, 255, 255);
            panelL16.BackColor = Color.FromArgb(255, 255, 255);
            panelL17.BackColor = Color.FromArgb(255, 255, 255);
            panelL18.BackColor = Color.FromArgb(255, 255, 255);
            panelL19.BackColor = Color.FromArgb(255, 255, 255);

            panelM10.BackColor = Color.FromArgb(255, 255, 255);
            panelM11.BackColor = Color.FromArgb(255, 255, 255);
            panelM12.BackColor = Color.FromArgb(255, 255, 255);
            panelM13.BackColor = Color.FromArgb(255, 255, 255);
            panelM14.BackColor = Color.FromArgb(255, 255, 255);
            panelM15.BackColor = Color.FromArgb(255, 255, 255);
            panelM16.BackColor = Color.FromArgb(255, 255, 255);
            panelM17.BackColor = Color.FromArgb(255, 255, 255);
            panelM18.BackColor = Color.FromArgb(255, 255, 255);
            panelM19.BackColor = Color.FromArgb(255, 255, 255);

            panelX10.BackColor = Color.FromArgb(255, 255, 255);
            panelX11.BackColor = Color.FromArgb(255, 255, 255);
            panelX12.BackColor = Color.FromArgb(255, 255, 255);
            panelX13.BackColor = Color.FromArgb(255, 255, 255);
            panelX14.BackColor = Color.FromArgb(255, 255, 255);
            panelX15.BackColor = Color.FromArgb(255, 255, 255);
            panelX16.BackColor = Color.FromArgb(255, 255, 255);
            panelX17.BackColor = Color.FromArgb(255, 255, 255);
            panelX18.BackColor = Color.FromArgb(255, 255, 255);
            panelX19.BackColor = Color.FromArgb(255, 255, 255);

            panelJ10.BackColor = Color.FromArgb(255, 255, 255);
            panelJ11.BackColor = Color.FromArgb(255, 255, 255);
            panelJ12.BackColor = Color.FromArgb(255, 255, 255);
            panelJ13.BackColor = Color.FromArgb(255, 255, 255);
            panelJ14.BackColor = Color.FromArgb(255, 255, 255);
            panelJ15.BackColor = Color.FromArgb(255, 255, 255);
            panelJ16.BackColor = Color.FromArgb(255, 255, 255);
            panelJ17.BackColor = Color.FromArgb(255, 255, 255);
            panelJ18.BackColor = Color.FromArgb(255, 255, 255);
            panelJ19.BackColor = Color.FromArgb(255, 255, 255);

            panelV10.BackColor = Color.FromArgb(255, 255, 255);
            panelV11.BackColor = Color.FromArgb(255, 255, 255);
            panelV12.BackColor = Color.FromArgb(255, 255, 255);
            panelV13.BackColor = Color.FromArgb(255, 255, 255);
            panelV14.BackColor = Color.FromArgb(255, 255, 255);
            panelV15.BackColor = Color.FromArgb(255, 255, 255);
            panelV16.BackColor = Color.FromArgb(255, 255, 255);
            panelV17.BackColor = Color.FromArgb(255, 255, 255);
            panelV18.BackColor = Color.FromArgb(255, 255, 255);
            panelV19.BackColor = Color.FromArgb(255, 255, 255);

            panelS10.BackColor = Color.FromArgb(255, 255, 255);
            panelS11.BackColor = Color.FromArgb(255, 255, 255);
            panelS12.BackColor = Color.FromArgb(255, 255, 255);
            panelS13.BackColor = Color.FromArgb(255, 255, 255);
            panelS14.BackColor = Color.FromArgb(255, 255, 255);
            panelS15.BackColor = Color.FromArgb(255, 255, 255);
            panelS16.BackColor = Color.FromArgb(255, 255, 255);
            panelS17.BackColor = Color.FromArgb(255, 255, 255);
            panelS18.BackColor = Color.FromArgb(255, 255, 255);
            panelS19.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void agregarDetalle(BindingList<HorarioCicloWS.detalleHorario> detalles, Panel panel, int dia, int hora)
        {
            if(estaSeleccionado(panel) == true)
            {
                HorarioCicloWS.detalleHorario aux = new HorarioCicloWS.detalleHorario();
                aux.horaInicio = hora;
                aux.horaFin = hora;
                aux.dia = dia;
                detalles.Add(aux);
            }
        }

        private bool estaSeleccionado(Panel panel)
        {
            if (panel.BackColor.R == 0 && panel.BackColor.G == 255 && panel.BackColor.B == 0) return true;
            else return false;
        }

        private void estadoCeldas(bool estado)
        {
            panelL10.Enabled = estado;
            panelL11.Enabled = estado;
            panelL12.Enabled = estado;
            panelL13.Enabled = estado;
            panelL14.Enabled = estado;
            panelL15.Enabled = estado;
            panelL16.Enabled = estado;
            panelL17.Enabled = estado;
            panelL18.Enabled = estado;
            panelL19.Enabled = estado;

            panelM10.Enabled = estado;
            panelM11.Enabled = estado;
            panelM12.Enabled = estado;
            panelM13.Enabled = estado;
            panelM14.Enabled = estado;
            panelM15.Enabled = estado;
            panelM16.Enabled = estado;
            panelM17.Enabled = estado;
            panelM18.Enabled = estado;
            panelM19.Enabled = estado;

            panelX10.Enabled = estado;
            panelX11.Enabled = estado;
            panelX12.Enabled = estado;
            panelX13.Enabled = estado;
            panelX14.Enabled = estado;
            panelX15.Enabled = estado;
            panelX16.Enabled = estado;
            panelX17.Enabled = estado;
            panelX18.Enabled = estado;
            panelX19.Enabled = estado;

            panelJ10.Enabled = estado;
            panelJ11.Enabled = estado;
            panelJ12.Enabled = estado;
            panelJ13.Enabled = estado;
            panelJ14.Enabled = estado;
            panelJ15.Enabled = estado;
            panelJ16.Enabled = estado;
            panelJ17.Enabled = estado;
            panelJ18.Enabled = estado;
            panelJ19.Enabled = estado;

            panelV10.Enabled = estado;
            panelV11.Enabled = estado;
            panelV12.Enabled = estado;
            panelV13.Enabled = estado;
            panelV14.Enabled = estado;
            panelV15.Enabled = estado;
            panelV16.Enabled = estado;
            panelV17.Enabled = estado;
            panelV18.Enabled = estado;
            panelV19.Enabled = estado;

            panelS10.Enabled = estado;
            panelS11.Enabled = estado;
            panelS12.Enabled = estado;
            panelS13.Enabled = estado;
            panelS14.Enabled = estado;
            panelS15.Enabled = estado;
            panelS16.Enabled = estado;
            panelS17.Enabled = estado;
            panelS18.Enabled = estado;
            panelS19.Enabled = estado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Primero llenar el ciclo y personal
            HorarioCicloWS.personalCitas personal = new HorarioCicloWS.personalCitas();
            personal.idPersona = idPersonal;
            HorarioCicloWS.ciclo ciclo = new HorarioCicloWS.ciclo();
            ciclo.idCiclo = idCiclo;
            //Asociar
            horarioCiclo.personal = personal;
            horarioCiclo.ciclo = ciclo;

            //Llenar el detalle
            BindingList<HorarioCicloWS.detalleHorario> detalles = new BindingList<HorarioCicloWS.detalleHorario>();
            agregarDetalle(detalles, panelL10, 1, 10);
            agregarDetalle(detalles, panelM10, 2, 10);
            agregarDetalle(detalles, panelX10, 3, 10);
            agregarDetalle(detalles, panelJ10, 4, 10);
            agregarDetalle(detalles, panelV10, 5, 10);
            agregarDetalle(detalles, panelS10, 6, 10);

            agregarDetalle(detalles, panelL11, 1, 11);
            agregarDetalle(detalles, panelM11, 2, 11);
            agregarDetalle(detalles, panelX11, 3, 11);
            agregarDetalle(detalles, panelJ11, 4, 11);
            agregarDetalle(detalles, panelV11, 5, 11);
            agregarDetalle(detalles, panelS11, 6, 11);

            agregarDetalle(detalles, panelL12, 1, 12);
            agregarDetalle(detalles, panelM12, 2, 12);
            agregarDetalle(detalles, panelX12, 3, 12);
            agregarDetalle(detalles, panelJ12, 4, 12);
            agregarDetalle(detalles, panelV12, 5, 12);
            agregarDetalle(detalles, panelS12, 6, 12);

            agregarDetalle(detalles, panelL13, 1, 13);
            agregarDetalle(detalles, panelM13, 2, 13);
            agregarDetalle(detalles, panelX13, 3, 13);
            agregarDetalle(detalles, panelJ13, 4, 13);
            agregarDetalle(detalles, panelV13, 5, 13);
            agregarDetalle(detalles, panelS13, 6, 13);

            agregarDetalle(detalles, panelL14, 1, 14);
            agregarDetalle(detalles, panelM14, 2, 14);
            agregarDetalle(detalles, panelX14, 3, 14);
            agregarDetalle(detalles, panelJ14, 4, 14);
            agregarDetalle(detalles, panelV14, 5, 14);
            agregarDetalle(detalles, panelS14, 6, 14);

            agregarDetalle(detalles, panelL15, 1, 15);
            agregarDetalle(detalles, panelM15, 2, 15);
            agregarDetalle(detalles, panelX15, 3, 15);
            agregarDetalle(detalles, panelJ15, 4, 15);
            agregarDetalle(detalles, panelV15, 5, 15);
            agregarDetalle(detalles, panelS15, 6, 15);

            agregarDetalle(detalles, panelL16, 1, 16);
            agregarDetalle(detalles, panelM16, 2, 16);
            agregarDetalle(detalles, panelX16, 3, 16);
            agregarDetalle(detalles, panelJ16, 4, 16);
            agregarDetalle(detalles, panelV16, 5, 16);
            agregarDetalle(detalles, panelS16, 6, 16);

            agregarDetalle(detalles, panelL17, 1, 17);
            agregarDetalle(detalles, panelM17, 2, 17);
            agregarDetalle(detalles, panelX17, 3, 17);
            agregarDetalle(detalles, panelJ17, 4, 17);
            agregarDetalle(detalles, panelV17, 5, 17);
            agregarDetalle(detalles, panelS17, 6, 17);

            agregarDetalle(detalles, panelL18, 1, 18);
            agregarDetalle(detalles, panelM18, 2, 18);
            agregarDetalle(detalles, panelX18, 3, 18);
            agregarDetalle(detalles, panelJ18, 4, 18);
            agregarDetalle(detalles, panelV18, 5, 18);
            agregarDetalle(detalles, panelS18, 6, 18);

            agregarDetalle(detalles, panelL19, 1, 19);
            agregarDetalle(detalles, panelM19, 2, 19);
            agregarDetalle(detalles, panelX19, 3, 19);
            agregarDetalle(detalles, panelJ19, 4, 19);
            agregarDetalle(detalles, panelV19, 5, 19);
            agregarDetalle(detalles, panelS19, 6, 19);

            //Validar que se ingrese al menos una hora disponible
            if(detalles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una hora disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Una vez llenado el detalle, asignar e insertar o modificar
            horarioCiclo.horario = detalles.ToArray();

            int resultado;
            if (btnEditar.Text.CompareTo("Editar") == 0)
            {
                resultado = daoHorario.modificarHorarioCiclo(horarioCiclo);
                if (resultado == 0) MessageBox.Show("Ha ocurrido un error. No se ha podido editar el horario de disponibilidad.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Se ha modificado el horario de disponibilidad con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEditar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Text = "Volver";
                    estadoCeldas(false);
                }
            }
            else
            {
                resultado = daoHorario.insertarHorarioCiclo(horarioCiclo);
                if (resultado == 0) MessageBox.Show("Ha ocurrido un error. No se ha podido registrar el horario de disponibilidad.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Se ha registrado el horario de disponibilidad con éxito.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    horarioCiclo.idHorarioCiclo = resultado;
                    btnEditar.Text = "Editar";
                    btnEditar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Text = "Volver";
                    estadoCeldas(false);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoCeldas(true);
            btnEditar.Enabled = false;
            btnCancelar.Text = "Cancelar";
            btnAceptar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text.CompareTo("Cancelar") == 0)
            {
                llenarHorario();
                estadoCeldas(false);
                btnEditar.Enabled = true;
                btnAceptar.Enabled = false;
                btnCancelar.Text = "Volver";
            }
            else this.Close();
        }

        private void panelDiaHora_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            //Si esta seleccionado
            if(estaSeleccionado(panel) == true)
            {
                //Quitar seleccion
                panel.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                panel.BackColor = Color.FromArgb(0,255,0);
            }
        }
    }
}
