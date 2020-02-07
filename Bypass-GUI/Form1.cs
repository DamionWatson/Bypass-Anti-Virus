using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bypass_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Executable Program (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            textBox3.Text = saveFileDialog1.FileName;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem.ToString();
            if (selected == "Specify Injection")
            {
                textBox1.Visible = true;
            }
            else {
                textBox1.Visible = false;
                
            }
        }
    }
}
