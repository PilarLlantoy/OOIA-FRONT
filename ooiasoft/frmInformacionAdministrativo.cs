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
    public partial class frmInformacionAdministrativo : Form
    {
        private CicloWS.CicloWSClient daoCiclo;
        private InformacionTemaCicloWS.InformacionTemaCicloWSClient daoInfo;
        private BindingList<InformacionTemaCicloWS.tema> temas;
        private BindingList<InformacionTemaCicloWS.informacionTemaCiclo> subtemas;
        private int opc;
        private int longTemas;
        private int longSubTemas;
        private BindingList<Label> labelsT;
        private BindingList<Label> labelsS;
        private BindingList<frmMostrarDescripcionInfo> frmsMostrar; 
        private BindingList<frmEditarDescripcionInfo> frmsEditar; 
        private CicloWS.ciclo cicloSelecionado;
        private InformacionTemaCicloWS.tema TemaActual;
        private InformacionTemaCicloWS.informacionTemaCiclo SubTemaActual;
        private int inicio = 0;
        private Button creado;
        private Label currTema;
        public frmInformacionAdministrativo(char opcion)
        {
            InitializeComponent();
            opc = opcion;
            daoCiclo = new CicloWS.CicloWSClient();
            daoInfo = new InformacionTemaCicloWS.InformacionTemaCicloWSClient();
            labelsT = new BindingList<Label>();
            labelsS = new BindingList<Label>();
            frmsMostrar = new BindingList<frmMostrarDescripcionInfo>();
            frmsEditar = new BindingList<frmEditarDescripcionInfo>();
            //Llenar el comboBox con los ciclos
            cbCiclos.DataSource = daoCiclo.listarCiclos();
            cbCiclos.ValueMember = "idCiclo";
            //Si es alumno ocultamos opciones de configuracion

            if (opc == 'A')
            {
                btAgregarTema.Visible = false;
                cbCiclos.Visible = false;
                lblCiclo.Visible = false;
                lblI.Visible = false;
            }

            longTemas = 0;
            longSubTemas = 0;
            ListarTemas();
        }

        public void ListarTemas()
        {

            if (daoInfo.listarTemas() != null)
            {
                temas = new BindingList<InformacionTemaCicloWS.tema>(daoInfo.listarTemas().ToList());
                longTemas = temas.Count();
            } else temas = null;

            for (int i = 0; i < longTemas; i++)
            {
                Label newAux = new System.Windows.Forms.Label();
                newAux.BorderStyle = BorderStyle.FixedSingle;
                newAux.AutoSize = false;
                newAux.Size = new System.Drawing.Size(330, 45);
                newAux.Text = temas[i].nombre;
                newAux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                newAux.BackColor = Color.FromArgb(252, 205, 92);
                panelTemas.Controls.Add(newAux);
                labelsT.Add(newAux);
                newAux.BringToFront();
                newAux.Dock = DockStyle.Top;
                newAux.Click += new System.EventHandler(this.lbTema_Click);
                newAux.DoubleClick += new System.EventHandler(this.lbTema_DoubleClick);
            }  
        }

        public void BorrarTemas()
        {
            for (int i = longTemas-1; i >= 0; i--)
            {
                panelTemas.Controls.Remove(labelsT[i]);
                labelsT.Remove(labelsT[i]);     
            }
            longTemas = 0;
        }

        public void BorrarSubTemas()
        {
            panelInformacion.Controls.Clear();
            longSubTemas = 0;
        }

        public void ListarSubtemas()
        {
            if (daoInfo.listarInformacionesTemaCiclo(cicloSelecionado.idCiclo,TemaActual.idTema) != null)
            {
                subtemas = new BindingList<InformacionTemaCicloWS.informacionTemaCiclo>(daoInfo.listarInformacionesTemaCiclo(cicloSelecionado.idCiclo, TemaActual.idTema).ToList());
                longSubTemas = subtemas.Count();
            } else subtemas = null;

            for (int i = 0; i < longSubTemas; i++)
            {
                //Si es alumno y la fecha aun no es visible
                if (opc == 'A' && DateTime.Today.CompareTo(subtemas[i].fechaVisible) < 0) continue;
                
                Label aux = new System.Windows.Forms.Label();
                aux.BorderStyle = BorderStyle.FixedSingle;
                aux.AutoSize = false;
                aux.Size = new System.Drawing.Size(330, 45);
                aux.BackColor = Color.FromArgb(252, 205, 92);
                aux.Text = subtemas[i].titulo;
                aux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                panelInformacion.Controls.Add(aux);
                aux.Dock = DockStyle.Top;
                aux.BringToFront();
                labelsS.Add(aux);

                if (opc == 'A')
                {
                    frmMostrarDescripcionInfo auxFrm = new frmMostrarDescripcionInfo(subtemas[i]);
                    auxFrm.Visible = false;
                    auxFrm.Size = new System.Drawing.Size(330, 450);
                    panelInformacion.Controls.Add(auxFrm);
                    auxFrm.Dock = DockStyle.Top;
                    auxFrm.BringToFront();
                    frmsMostrar.Add(auxFrm);
                }
                else
                {
                    frmEditarDescripcionInfo auxFrm;
                    auxFrm = new frmEditarDescripcionInfo(subtemas[i], this);
                    auxFrm.Visible = false;
                    auxFrm.Size = new System.Drawing.Size(330, 450);
                    panelInformacion.Controls.Add(auxFrm);
                    auxFrm.Dock = DockStyle.Top;
                    auxFrm.BringToFront();
                    frmsEditar.Add(auxFrm);
                }
                aux.Click += new System.EventHandler(this.lbSubtema_Click);
            }
            Button bt = new System.Windows.Forms.Button();
            bt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            bt.BackColor = Color.FromArgb(252, 205, 92);
            bt.Size = new System.Drawing.Size(839, 46);
            //bt.TabIndex = 1;
            bt.Text = "Agregar Subtema (+)";
            //bt.UseVisualStyleBackColor = true;           
            panelInformacion.Controls.Add(bt);
            bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            bt.Click += new System.EventHandler(btAgregarInfo_Click);
            if (opc == 'D') bt.Visible = true;
            else bt.Visible = false;
            creado = bt;
        }

        private void lbTema_DoubleClick(object sender, EventArgs e)
        {
            if (opc == 'A') return;
            foreach (Control ctrl in panelTemas.Controls)
            {
                if (ctrl == sender)
                {
                    InformacionTemaCicloWS.tema t = buscarTema(ctrl.Text);
                    TemaActual = t;
                }
            }
            frmEditarEliminarTema frm = new frmEditarEliminarTema(TemaActual,this);
            frm.ShowDialog();
        }

        private void lbSubtema_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control ctrl in panelInformacion.Controls)
            {
                if (ctrl == sender)
                {
                    SubTemaActual = buscarSubtema(ctrl.Text);
                    if (panelInformacion.Controls[i - 1].Visible == true)
                    {
                        if (opc == 'D')
                        {
                            frmEditarDescripcionInfo auxfrm;
                            auxfrm = panelInformacion.Controls[i - 1] as frmEditarDescripcionInfo;
                            auxfrm.llenarDatos(SubTemaActual);
                        }
                    }
                    panelInformacion.Controls[i - 1].Visible = !panelInformacion.Controls[i - 1].Visible;

                    return;
                }
                i++;
            }
        }

        private void btAgregarInfo_Click(object sender, EventArgs e)
        {
            frmAgregarInformacion agregar = new frmAgregarInformacion(cicloSelecionado, TemaActual); ;
            agregar.ShowDialog();
            if (agregar.Nuevo == 1)
            {
                BorrarSubTemas();
                ListarSubtemas(); 
            }
        }

        private void lbTema_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control ctrl in panelTemas.Controls)
            {
                if (ctrl == sender)
                {
                    if (currTema != null) currTema.BackColor = Color.FromArgb(252, 205, 92);
                    ctrl.BackColor = Color.Yellow;
                    InformacionTemaCicloWS.tema t = buscarTema(ctrl.Text);
                    TemaActual = t;
                    currTema = (Label)ctrl;
                    BorrarSubTemas();
                    ListarSubtemas();
                    
                    return;
                }
                i++;
            }
        }

        private InformacionTemaCicloWS.tema buscarTema(string texto)
        {
            InformacionTemaCicloWS.tema t = new InformacionTemaCicloWS.tema();
            for (int i = 0; i < longTemas; i++)
            {
                if (temas[i].nombre == texto)
                {
                    t = temas[i];
                    break;
                }
            }
            return t;
        }

        private InformacionTemaCicloWS.informacionTemaCiclo buscarSubtema(string texto)
        {
            InformacionTemaCicloWS.informacionTemaCiclo s = new InformacionTemaCicloWS.informacionTemaCiclo();
            for (int i = 0; i < longSubTemas; i++)
            {
                if (subtemas[i].titulo == texto)
                {
                    s = subtemas[i];
                    break;
                }
            }
            return s;
        }

        private void btAgregarTema_Click(object sender, EventArgs e)
        {
            frmAgregarTema addTema = new frmAgregarTema();
            if (addTema.ShowDialog() == DialogResult.OK)
            {
                BorrarSubTemas();
                BorrarTemas();
                ListarTemas();
            }
        }

        private void cbCiclos_Format(object sender, ListControlConvertEventArgs e)
        {
            CicloWS.ciclo data = (CicloWS.ciclo)e.ListItem;
            e.Value = data.anho + "-" + data.periodo;
        }

        private void cbCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cicloSelecionado = cbCiclos.SelectedItem as CicloWS.ciclo;
            if (inicio == 0)
            {
                BorrarTemas();
                inicio = 1;
            } else
            {
                BorrarSubTemas();
                BorrarTemas();
                ListarTemas();
            }
        }

    }
}
