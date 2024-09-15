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
using System.Xml;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true) // (labelStatus.BackColor == Color.LightGreen)
            {
                chapter1a chapter1 = new chapter1a(textBoxFolderPath.Text);
                chapter1.ShowDialog();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    textBoxFolderPath.Text = selectedPath;
                    ValidateFolder(selectedPath);
                }
            }
        }

        private void ValidateFolder(string folderPath)
        {
            // Define required files
            string[] requiredFiles = { "aisle10.adx", "answer.adx", "baby_t.adx", "birthday.adx", "bokfresh.adx", "bounce.adx", "buttrfly.adx", "clear.adx", "clr_dj1.adx", "concept.adx", "dealer.adx", "dj_demo1.adx", "ending.adx", "ending_l.adx", "ending_s.adx", "future.adx", "grace.adx", "g_over.adx", "g_park.adx", "intent.adx", "koto.adx", "latchula.adx", "letmom.adx", "likeit.adx", "lovelove.adx", "mic.adx", "model.adx", "oldies.adx", "pathetic.adx", "poompoom.adx", "rockiton.adx", "scrappy.adx", "set_04.adx", "set_06.adx", "sneakman.adx", "sweet.adx", "s_set_01a.adx", "s_set_01b.adx", "s_set_02a.adx", "s_set_02b.adx", "s_set_03a.adx", "s_set_03b.adx", "s_set_05a.adx", "s_set_05b.adx", "s_set_06.adx", "s_set_07a.adx", "s_set_07b.adx", "s_set_08a.adx", "s_set_08b.adx", "s_set_09a.adx", "s_set_09b.adx", "thats.adx", "title.adx", "victory.adx", "whatbout.adx" };

            // Check if each required file exists in the folder
            bool isValid = true;
            foreach (string file in requiredFiles)
            {
                string filePath = Path.Combine(folderPath, file);
                if (!File.Exists(filePath))
                {
                    isValid = false;
                    break;
                }
            }

            // Update the panel and label based on the validation result
            if (isValid)
            {
                panelStatus.BackColor = System.Drawing.Color.LightGoldenrodYellow; // Indicate valid
                labelStatus.Text = "Folder Found and valid. Checking Xml...";
                labelStatus.ForeColor = System.Drawing.Color.Black;

                if(!File.Exists(Path.Combine(folderPath, "songsDONOTDELETE.xml")))
                {
                    string sourceFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "songs.xml");
                    string destinationFilePath = Path.Combine(folderPath, "songsDONOTDELETE.xml");
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    panelStatus.BackColor = System.Drawing.Color.LightGreen;
                    labelStatus.Text = "Xml Created. Folder is Valid";
                }
                else
                {
                    labelStatus.Text = "Xml Found. Folder is Valid";
                    panelStatus.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            else
            {
                panelStatus.BackColor = System.Drawing.Color.LightCoral; // Indicate invalid
                labelStatus.Text = "Folder is missing required files.";
                labelStatus.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

