using System;
using System.Drawing;
using System.Windows.Forms;

namespace ooiasoft
{
    public partial class editarEvento : UserControl
    {
        public editarEvento()
        {
            InitializeComponent();
        }

        public PictureBox PbImagen { get { return pbImagen; } }

        public RichTextBox RtbTitulo { get { return tbNombre; } }

        public RichTextBox RtbDescripcion { get { return tbDescripcion; } }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbNombre.SelectionLength > 0)
                {
                    tbNombre.SelectionFont = fontDialog1.Font;
                    textBox1.Text = tbNombre.SelectionFont.FontFamily.Name.ToString();
                    textBox2.Text = tbNombre.SelectionFont.Size.ToString();
                }
                if (tbDescripcion.SelectionLength > 0)
                {
                    tbDescripcion.SelectionFont = fontDialog1.Font;
                    textBox1.Text = tbDescripcion.SelectionFont.FontFamily.Name.ToString();
                    textBox2.Text = tbDescripcion.SelectionFont.Size.ToString();
                }
                tbNombre.SelectionLength = 0;
                tbDescripcion.SelectionLength = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbNombre.SelectionLength > 0)
                {
                    tbNombre.SelectionColor = colorDialog1.Color;
                    lbColor.BackColor = colorDialog1.Color;
                }
                if (tbDescripcion.SelectionLength > 0)
                {
                    tbDescripcion.SelectionColor = colorDialog1.Color;
                    lbColor.BackColor = colorDialog1.Color;
                }
                tbNombre.SelectionLength = 0;
                tbDescripcion.SelectionLength = 0;
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (tbNombre.SelectionLength > 0)
            {
                if (tbNombre.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (!tbNombre.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (tbNombre.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbNombre.SelectionFont.Style)
                {
                    tbNombre.SelectionFont = new Font(tbNombre.SelectionFont, newFontStyle);
                }
            }
            if (tbDescripcion.SelectionLength > 0)
            {
                if (tbDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (!tbDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (tbDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbDescripcion.SelectionFont.Style)
                {
                    tbDescripcion.SelectionFont = new Font(tbDescripcion.SelectionFont, newFontStyle);
                }
            }
            tbNombre.SelectionLength = 0;
            tbDescripcion.SelectionLength = 0;
        }

        private void btHigh_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (tbNombre.SelectionLength > 0)
            {
                if (!tbNombre.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (tbNombre.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (tbNombre.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbNombre.SelectionFont.Style)
                {
                    tbNombre.SelectionFont = new Font(tbNombre.SelectionFont, newFontStyle);
                }
            }
            if (tbDescripcion.SelectionLength > 0)
            {
                if (!tbDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (tbDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (tbDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbDescripcion.SelectionFont.Style)
                {
                    tbDescripcion.SelectionFont = new Font(tbDescripcion.SelectionFont, newFontStyle);
                }
            }
            tbNombre.SelectionLength = 0;
            tbDescripcion.SelectionLength = 0;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (tbNombre.SelectionLength > 0)
            {
                if (tbNombre.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (tbNombre.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (!tbNombre.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbNombre.SelectionFont.Style)
                {
                    tbNombre.SelectionFont = new Font(tbNombre.SelectionFont, newFontStyle);
                }
            }
            if (tbDescripcion.SelectionLength > 0)
            {
                if (tbDescripcion.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (tbDescripcion.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (!tbDescripcion.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != tbDescripcion.SelectionFont.Style)
                {
                    tbDescripcion.SelectionFont = new Font(tbDescripcion.SelectionFont, newFontStyle);
                }
            }
            tbNombre.SelectionLength = 0;
            tbDescripcion.SelectionLength = 0;
        }

        private void btImagen_Click(object sender, EventArgs e)
        {
            try
            {
                String ruta;
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;
                    pbImagen.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            lblCap.Text = "Cantidad de Caracteres (" + RtbDescripcion.Text.Length + "/2500)";
        }
    }
}
