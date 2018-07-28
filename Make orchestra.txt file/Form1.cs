using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

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
                "(you might need to manually create this folder)" + Environment.NewLine +
                "" + Environment.NewLine +
                "Add Ambient music, then victory/defeat music if you want" + Environment.NewLine +
                "Everything will be randomized. If no victory/defeat, it will be randomized with ambient";
        }

        private void removeCurrentItem(ListBox listbox)
        {
            labelDone.Visible = false;
            buttonExport.Enabled = true;
            listbox.Items.Remove(listbox.SelectedItem);            
        }

        private void addItems(ListBox listbox)
        {
            labelDone.Visible = false;
            buttonExport.Enabled = true;
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
                            listbox.Items.Add(str);
                        }
                    }
                }
            }
        }

        private void shuffleListBox(ListBox listbox)
        {
            ListBox.ObjectCollection list = listbox.Items;
            Random rng = new Random();
            int n = list.Count;
            listbox.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            listbox.EndUpdate();
            listbox.Invalidate();
        }

        private void Export()
        {
            List<string> VictorySongs = listBoxSongListVictory.Items.Cast<String>().ToList<String>();
            List<string> DefeatSongs = listBoxSongListDefeat.Items.Cast<String>().ToList<String>();
            List<string> AmbientSongs = listBoxSongListAmbient.Items.Cast<String>().ToList<String>();
            int howManyAmbientSongs = AmbientSongs.Count;
            int howManyVictorySongs = VictorySongs.Count;
            int howManyDefeatSongs = DefeatSongs.Count;
            Random random = new Random();
            List<string> fileContent = new List<string>();
            int i = 0;
            int j = 0;
            int k = 0;
            foreach (string str in AmbientSongs)
            {
                string AmbientFileName = str.Split('\\')[str.Split('\\').Length - 1];
                string VictoryFilename;
                if (VictorySongs.Count > 0)
                {
                    int lastElement = VictorySongs[j].Split('\\').Length - 1;
                    VictoryFilename = VictorySongs[j].Split('\\')[lastElement];
                    j++;
                    if (j == VictorySongs.Count)
                    {
                        j = 0;
                    }
                }
                else
                {
                    VictoryFilename = AmbientFileName;
                }
                string DefeatFilename;
                if (DefeatSongs.Count > 0)
                {
                    int lastElement = DefeatSongs[k].Split('\\').Length - 1;
                    DefeatFilename = DefeatSongs[k].Split('\\')[lastElement];
                    k++;
                    if (k == DefeatSongs.Count)
                    {
                        k = 0;
                    }
                }
                else
                {
                    DefeatFilename = AmbientFileName;
                }
                fileContent.Add("Arrangement: Track #" + i);
                fileContent.Add("Movement: Victory");
                fileContent.Add("\t\tTrack: data/music/" + VictoryFilename);
                fileContent.Add("\t\tLoop: True");
                fileContent.Add("\t\tVolume: Ambient.playing * 0.15 * (ships_destroyed.acc / (4 + ships_destroyed.acc))");
                fileContent.Add("");
                fileContent.Add("Movement: Defeat");
                fileContent.Add("\t\tTrack: data/music/" + DefeatFilename);
                fileContent.Add("\t\tLoop: True");
                fileContent.Add("\t\tVolume: Ambient.playing * 0.25 * (ships_lost.acc / (4 + ships_lost.acc))");
                fileContent.Add("");
                fileContent.Add("\tMovement: Ambient");
                fileContent.Add("\t\tTrack: data/music/" + AmbientFileName);
                fileContent.Add("\t\tmin(0.25, 1.0 - (Victory.volume + Defeat.volume) * 0.5)");
                fileContent.Add("");
                i++;
            }
            File.Delete("orchestra.txt");
            File.WriteAllLines("orchestra.txt", fileContent);
            labelDone.Visible = true;
            buttonExport.Enabled = false;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void linkLabelProtip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Double click an item to remove it", "PROTIP");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addItems(listBoxSongListAmbient);
        }

        private void buttonAddVictory_Click(object sender, EventArgs e)
        {
            addItems(listBoxSongListVictory);
        }

        private void buttonAddDefeat_Click(object sender, EventArgs e)
        {
            addItems(listBoxSongListDefeat);
        }

        private void listBoxSongList_DoubleClick(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListAmbient);
        }

        private void listBoxSongListVictory_DoubleClick(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListVictory);
        }

        private void listBoxSongListDefeat_DoubleClick(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListDefeat);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListAmbient);
        }

        private void buttonRemoveVictory_Click(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListVictory);
        }

        private void buttonRemoveDefeat_Click(object sender, EventArgs e)
        {
            removeCurrentItem(listBoxSongListDefeat);
        }

        private void buttonShuffleAmbient_Click(object sender, EventArgs e)
        {
            shuffleListBox(listBoxSongListAmbient);
        }

        private void buttonShuffleVictory_Click(object sender, EventArgs e)
        {
            shuffleListBox(listBoxSongListVictory);
        }

        private void buttonShuffleDefeat_Click(object sender, EventArgs e)
        {
            shuffleListBox(listBoxSongListDefeat);
        }
    }
}
