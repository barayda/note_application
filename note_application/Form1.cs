using System;
using System.Drawing;
using System.Windows.Forms;

namespace note_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetinStiliAyarlama(FontStyle style)
        {
            if (richTextBoxNot.SelectionLength == 0)
                return;

            Font currentFont = richTextBoxNot.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ style;
            richTextBoxNot.SelectionFont = new Font(currentFont, newStyle);
            ToolStripMenuItem menuItem = null;
            if (style == FontStyle.Bold)
                menuItem = kalinToolStripMenuItem;
            else if (style == FontStyle.Italic)
                menuItem = italikToolStripMenuItem;
            else if (style == FontStyle.Underline)
                menuItem = altiCiziliToolStripMenuItem;

            if (menuItem != null)
            {
                menuItem.Checked = newStyle.HasFlag(style);
            }
        }
        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Zengin Metin Biçimi (*.rtf)|*.rtf|Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.Title = "Bir Not Dosyası Açın";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (openFileDialog.FileName.ToLower().EndsWith(".rtf"))
                        {
                            richTextBoxNot.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            richTextBoxNot.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Zengin Metin Biçimi (*.rtf)|*.rtf|Metin Dosyaları (*.txt)|*.txt";
                saveFileDialog.Title = "Notu Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveFileDialog.FilterIndex == 1) 
                        {
                            richTextBoxNot.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            richTextBoxNot.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farkliKaydetToolStripMenuItem_Click(sender, e);
        }
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNot.Clear();
        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void kalinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetinStiliAyarlama(FontStyle.Bold);
        }
        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetinStiliAyarlama(FontStyle.Italic);
        }
        private void altiCiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetinStiliAyarlama(FontStyle.Underline);
        }
    }
}