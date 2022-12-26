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
    public partial class BeautyTextBox : UserControl
    {
        public BeautyTextBox()
        {
            InitializeComponent();
        }
        public string RTF { get => rtBox.Rtf; set => rtBox.Rtf = value; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtBox.SelectionColor = colorDialog1.Color;
                lbColor.BackColor = colorDialog1.Color;
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (rtBox.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (!rtBox.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (rtBox.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rtBox.SelectionFont.Style)
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, newFontStyle);
            }
            String s = rtBox.Rtf;
        }

        private void btHigh_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (!rtBox.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (rtBox.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (rtBox.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rtBox.SelectionFont.Style)
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, newFontStyle);
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (rtBox.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (rtBox.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (!rtBox.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rtBox.SelectionFont.Style)
            {
                rtBox.SelectionFont = new Font(rtBox.SelectionFont, newFontStyle);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtBox.SelectionFont = fontDialog1.Font;
                txtFuente.Text = rtBox.SelectionFont.FontFamily.Name.ToString();
                txtSize.Text = rtBox.SelectionFont.Size.ToString();
            }
        }

        private void rtBox_TextChanged(object sender, EventArgs e)
        {
            lblCap.Text = "Cantidad de Caracteres (" + rtBox.Text.Length + "/1500)";
        }
    }
}
