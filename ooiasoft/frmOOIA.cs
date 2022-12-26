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
    public partial class frmOOIA : Form
    {
        public frmOOIA()
        {
            InitializeComponent();
            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang3082{\fonttbl{\f0\fnil\fcharset0 Bauhaus 93;}{\f1\fnil\fcharset0 Calibri;}{\f2\fnil\fcharset0 Bahnschrift Light SemiCondensed;}}" +
            @"{\colortbl;\red0\green77\blue187;\red0\green176\blue80;\red255\green192\blue0; }" +
            @"{\*\generator Riched20 10.0.19041}\viewkind4\uc1" +
            @"\pard\sa200\sl276\slmult1\f0\fs28\lang9 Oficina de Orientaci\'f3n, Informaci\'f3n y Apoyo al Estudiante - OOIA\f1\fs22\par" +
            @"\par" +
            @"\f2\fs24 La OOIA es la unidad responsable de dise\'f1ar y poner en marcha los programas de orientaci\'f3n y apoyo acad\'e9mico, vocacional e integraci\'f3n universitaria. Esta labor la realiza mediante el desarrollo de talleres de capacitaci\'f3n, charlas informativas, publicaci\'f3n de boletines y servicio de consejer\'eda universitaria.\par" +
            @"\par" +
            @"\cf1 EQUIPO HUMANO\cf0\par" +
            @"\par" +
            @"La conducci\'f3n de la OOIA se encuentra a cargo de la coordinadora general, quien es la persona responsable del planeamiento, dise\'f1o y supervisi\'f3n de los programas de apoyo que se ofrecen a los estudiantes, as\'ed como de la administraci\'f3n de los recursos.\par" +
            @"\par" +
            @"Por otro lado, la puesta en pr\'e1ctica de la labor de tutor\'eda y el desarrollo de los talleres son responsabilidad de un equipo tutorial, conformado por docentes de las especialidades de ciencias, ingenier\'eda y humanidades, as\'ed como de psic\'f3logos educacionales y alumnos gu\'edas de la unidad acad\'e9mica de Estudios Generales Ciencias y de la Facultad de Ciencias e Ingenier\'eda.\par" +
            @"\par" +
            @"\cf2 Tipo de servicio: Asesorias, Orientacion, Aulas y Casilleros, Matricula\cf0\par" +
            @"\par" +
            @"\cf3 Tel\'e9fono: 626-2000 anexos 5206, 5240\par" +
            @"Correo: ooia @pucp.edu.pe\par" +
            "}";
            //richTextBox1.Rtf = File.ReadAllText(@"C:\Users\oskar\Downloads\dcrtf.rtf");
        }
    }
}
