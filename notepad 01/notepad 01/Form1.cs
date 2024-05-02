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

namespace notepad_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

            Font font = richTextBox1.SelectionFont;
            font = new Font(font.FontFamily ,font.Size,FontStyle.Bold);
                richTextBox1.SelectionFont= font;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog clrdilg = new ColorDialog();
            if (clrdilg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = clrdilg.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svfildilg = new SaveFileDialog();
            svfildilg.Filter = "*.rtf|Rich Text Format";
            svfildilg.DefaultExt = "rtf";
            if (svfildilg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(svfildilg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Format|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(ofd.FileName);
                richTextBox1.Rtf = File.ReadAllText(ofd.FileName);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            {
             richTextBox1.Clear();
            }
        }
    }
}
