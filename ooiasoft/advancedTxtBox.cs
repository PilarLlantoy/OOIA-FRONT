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
    public partial class advancedTxtBox : UserControl
    {
        public advancedTxtBox()
        {
            InitializeComponent();
        }

        //private System.Drawing.FontStyle newFontStyle = FontStyle.Regular;

        private void btColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxtDescripcion.SelectionColor = colorDialog1.Color;
                txtColor.BackColor = colorDialog1.Color;
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            //newFontStyle |= FontStyle.Underline;
            //rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, newFontStyle);
            //rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, FontStyle.Underline);
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (rTxtDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (rTxtDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (!rTxtDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rTxtDescripcion.SelectionFont.Style)
            {
                rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, newFontStyle);
            }
        }

        private void btHigh_Click(object sender, EventArgs e)
        {
            //if (!rTxtDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            //else newFontStyle
            //rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, newFontStyle);
            // rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, FontStyle.Bold);
            //if (!rTxtDescripcion.SelectionFont.Bold) 
            //rTxtDescripcion.SelectionFont.Bold = rTxtDescripcion.SelectionFont.Bold
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (!rTxtDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (rTxtDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (rTxtDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rTxtDescripcion.SelectionFont.Style)
            {
                rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, newFontStyle);
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxtDescripcion.SelectionFont = fontDialog1.Font;
                txtFont.Text = rTxtDescripcion.SelectionFont.FontFamily.Name.ToString();
                txtSize.Text = rTxtDescripcion.SelectionFont.Size.ToString();
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (rTxtDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (!rTxtDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (rTxtDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (newFontStyle != rTxtDescripcion.SelectionFont.Style)
            {
                rTxtDescripcion.SelectionFont = new Font(rTxtDescripcion.SelectionFont, newFontStyle);
            }
        }
    }
}
