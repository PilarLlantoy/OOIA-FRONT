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
    public partial class frmSeleccionarDisponibilidad : Form
    {
        private HorarioCicloWS.HorarioCicloWSClient daoHorario;
        private CitaWS.CitaWSClient daoCita;

        private int idCiclo;
        private int idPersonal;
        private DateTime fecha;
        private int cantSeleccionados = 0;
        private int horaSeleccionada;

        public int HoraSeleccionada { get => horaSeleccionada; set => horaSeleccionada = value; }

        public frmSeleccionarDisponibilidad(int idCiclo, int idPersonal, DateTime fecha)
        {
            InitializeComponent();
            daoHorario = new HorarioCicloWS.HorarioCicloWSClient();
            daoCita = new CitaWS.CitaWSClient();
            this.idCiclo = idCiclo;
            this.idPersonal = idPersonal;
            this.fecha = fecha;

            llenarDisponibilidad();
            llenarCitasReservadas();
        }

        private void llenarDisponibilidad()
        {
            HorarioCicloWS.horarioCiclo[] horarios = daoHorario.listarHorarioCiclos(idPersonal);
            //Si no tiene horarios registrados
            if (horarios == null || horarios[0].ciclo.idCiclo != idCiclo) return;
            llenarHorarioPersonal(horarios[0]);

        }

        private void llenarHorarioPersonal(HorarioCicloWS.horarioCiclo horario)
        {
            //Se recorre el detalle horario y se va habilitando los paneles en base al dia
            int diaSeleccionado;
            if (fecha.DayOfWeek == DayOfWeek.Monday) diaSeleccionado = 1;
            else if (fecha.DayOfWeek == DayOfWeek.Tuesday) diaSeleccionado = 2;
            else if (fecha.DayOfWeek == DayOfWeek.Wednesday) diaSeleccionado = 3;
            else if (fecha.DayOfWeek == DayOfWeek.Thursday) diaSeleccionado = 4;
            else if (fecha.DayOfWeek == DayOfWeek.Friday) diaSeleccionado = 5;
            else if (fecha.DayOfWeek == DayOfWeek.Saturday) diaSeleccionado = 6;
            else return;
            foreach (HorarioCicloWS.detalleHorario dh in horario.horario)
            {
                if (dh.dia == diaSeleccionado)
                    colorearPanel(dh.horaInicio, 255, 255, 255);
            }
        }

        private void colorearPanel(int hora, int R, int G, int B)
        {
            if (hora == 10) panelHora10.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 11) panelHora11.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 12) panelHora12.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 13) panelHora13.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 14) panelHora14.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 15) panelHora15.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 16) panelHora16.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 17) panelHora17.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 18) panelHora18.BackColor = Color.FromArgb(R, G, B);
            else if (hora == 19) panelHora19.BackColor = Color.FromArgb(R, G, B);
        }

        private void llenarCitasReservadas()
        {
            CitaWS.cita[] citas = daoCita.listarCitasDePersonalPorCicloFechaAlumno(idPersonal, "",fecha, fecha, "");

            //Si tiene citas para ese dia
            if (citas != null)
            {
                foreach (CitaWS.cita cita in citas)
                    colorearPanel(cita.hora, 125, 125, 125);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(cantSeleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar una hora para la cita.", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Encontrar la hora seleccionada
            HoraSeleccionada = encontrarHora();

            this.DialogResult = DialogResult.OK;
        }

        private int encontrarHora()
        {
            if (estaSeleccionado(panelHora10)) return 10;
            if (estaSeleccionado(panelHora11)) return 11;
            if (estaSeleccionado(panelHora12)) return 12;
            if (estaSeleccionado(panelHora13)) return 13;
            if (estaSeleccionado(panelHora14)) return 14;
            if (estaSeleccionado(panelHora15)) return 15;
            if (estaSeleccionado(panelHora16)) return 16;
            if (estaSeleccionado(panelHora17)) return 17;
            if (estaSeleccionado(panelHora18)) return 18;
            if (estaSeleccionado(panelHora19)) return 19;
            return -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelGenerico_Click(object sender, EventArgs e)
        {          
            Panel panel = (Panel)sender;

            //Si esta disponible
            if (estaDisponible(panel) == false) return;

            //Si esta seleccionado
            if (estaSeleccionado(panel) == true)
            {
                //Quitar seleccion
                panel.BackColor = Color.FromArgb(255, 255, 255);
                cantSeleccionados--;
            }
            else
            {
                //No permite seleccionar mas de un panel
                if (cantSeleccionados >= 1) return;
                cantSeleccionados++;
                panel.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        private bool estaDisponible(Panel panel)
        {
            return !(panel.BackColor.R == 125 && panel.BackColor.G == 125 && panel.BackColor.B == 125);
        }

        private bool estaSeleccionado(Panel panel)
        {
            //Si es verde, esta seleccionado
            return panel.BackColor.R == 0 && panel.BackColor.G == 255 && panel.BackColor.B == 0;
        }

    }
}
