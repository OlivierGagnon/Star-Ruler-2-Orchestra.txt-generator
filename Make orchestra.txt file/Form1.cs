using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_orchestra.txt_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelWelcome.Text =
                "Welcome to Star Ruler 2 music playlist generator!" + Environment.NewLine +
                "To begin, build your playlist and export the orchestra.txt file" + Environment.NewLine +
                "The file will be created in the current directory" + Environment.NewLine +
                "After it is generated, move it along with the ogg files to the music folder:" + Environment.NewLine +
                "ie: C:\\Star Ruler 2\\data\\music" + Environment.NewLine +
                "(you might need to manually create this folder)";
        }

        private void removeCurrentItem()
        {
            listBoxSongList.Items.Remove(listBoxSongList.SelectedItem);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "ogg files|*.ogg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string str in dialog.FileNames)
                    {
                        if (str.Substring(str.Length - 3).Equals("ogg"))
                        {
                            listBoxSongList.Items.Add(str);
                        }
                    }
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            removeCurrentItem();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
        //Arrangement: Exploration1
        //  Era: Exploration
        //
        //  Movement: Ambient
        //      Track: data/music/exploration/drones.ogg
        //      Volume: 1.0

            List<string> fileContent = new List<string>();
            int i = 0;
            foreach (string str in listBoxSongList.Items.Cast<String>().ToArray())
            {
                int lastElement = str.Split('\\').Length-1;
                string filename = str.Split('\\')[lastElement];
                fileContent.Add("Arrangement: Track #" + i);
                //fileContent.Add("\tEra: Exploration");
                fileContent.Add("\tMovement: Ambient");
                fileContent.Add("\t\tTrack: data/music/" + filename);
                fileContent.Add("\t\tVolume: 0.5");
                fileContent.Add("");
                i++;
            }
            System.IO.File.WriteAllLines("orchestra.txt", fileContent);
            labelDone.Visible = true;
            buttonExport.Enabled = false;
        }

        private void listBoxSongList_DoubleClick(object sender, EventArgs e)
        {
            removeCurrentItem();
        }

        private void linkLabelProtip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Double click an item to remove it", "PROTIP");
        }
    }
}
