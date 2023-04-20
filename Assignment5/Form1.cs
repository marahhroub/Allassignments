using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class texteditor : Form
    {
        public texteditor()
        {
            InitializeComponent();
        }
        

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorRichTextBox.SelectAll();

        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorRichTextBox.Cut();

        }

        private void copyToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            editorRichTextBox.Copy();

        }

        private void pasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorRichTextBox.Paste();

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editorRichTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                editorRichTextBox.SelectionFont = fontDialog.Font;
            }
        }
    }
}
