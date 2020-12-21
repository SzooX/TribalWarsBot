using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TribalWars
{
    public partial class PresetForm : Form
    {
        Form1 mform;
        VillageForm vform;
        BuildPreset preset;
        public PresetForm(Form1 mainform, VillageForm vf)
        {
            mform = mainform;
            vform = vf;
            InitializeComponent();
            preset = new BuildPreset();
            preset.buildSettings = new BuildSettings();
            preset.Queue = new List<string>(); // move it to classs itself when initialize it
            mform = mainform;
            for (int i = 0; i < Buildingslist.Items.Count; i++)
            {
                Buildingslist.Items[i].SubItems.Add(new ListViewItem.ListViewSubItem(Buildingslist.Items[i], "0"));
            }
            //Load queue
            UpdateView(preset.Queue);
        }
        public void UpdateView(List<string> Queue) // optimize this method
        {
            Queuelist.Items.Clear();
            for (int c = 0; c < Buildingslist.Items.Count; c++)  // making every item 0
            {
                Buildingslist.Items[c].SubItems[1].Text = "0";
            }
            for (int i = 0; i < Queue.Count; i++)
            {
                var lvi = new ListViewItem();
                lvi.ImageKey = $"{char.ToLower(Queue[i][0])}{Queue[i].Substring(1, Queue[i].Length - 1)}.png";
                Queuelist.Items.Add(lvi);
                lvi.UseItemStyleForSubItems = false;
                for (int o = 0; o < Buildingslist.Items.Count; o++)
                {
                    if (Buildingslist.Items[o].ImageKey == lvi.ImageKey)
                    {
                        Buildingslist.Items[o].SubItems[1].Text = (int.Parse(Buildingslist.Items[o].SubItems[1].Text) + 1).ToString();
                        break;
                    }
                }
            }
        }
        private void Buildingslist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            preset.Queue.Add(Buildingslist.FocusedItem.ImageKey.Replace(".png", ""));
            UpdateView(preset.Queue);
        }
        private void QueueRemove_Click(object sender, EventArgs e)
        {
            preset.Queue.Remove(Queuelist.FocusedItem.ImageKey.Replace(".png", ""));
            UpdateView(preset.Queue);
        }

        private void QueueMoveUp_Click(object sender, EventArgs e)
        {
            if (Queuelist.FocusedItem == null) return;
            string itmup = Queuelist.FocusedItem.ImageKey.Replace(".png", "");
            int idx = preset.Queue.IndexOf(itmup);
            if (idx == 0) return;
            string tmp = preset.Queue[idx - 1];
            preset.Queue[idx - 1] = preset.Queue[idx];
            preset.Queue[idx] = tmp;
            UpdateView(preset.Queue);
        }

        private void QueueMoveDown_Click(object sender, EventArgs e)
        {
            if (Queuelist.FocusedItem == null) return;
            string itmup = Queuelist.FocusedItem.ImageKey.Replace(".png", "");
            int idx = preset.Queue.IndexOf(itmup);
            if (idx > preset.Queue.Count - 1) return;
            string tmp = preset.Queue[idx + 1];
            preset.Queue[idx + 1] = preset.Queue[idx];
            preset.Queue[idx] = tmp;
            UpdateView(preset.Queue);
        }

        //BuildSettings settings
        #region CheckBoxes
        private void Con1box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            preset.buildSettings.BuildRequiments = cond.Checked;
        }

        private void Con2box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            preset.buildSettings.BuildFarmIfLowSpace = cond.Checked;
        }
        private void Con3box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            preset.buildSettings.BuildFarmIfNotEnoughCap = cond.Checked;
        }
        private void Con4box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            preset.buildSettings.BuildStorageForRequiments = cond.Checked;
        }
        private void Con5box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            preset.buildSettings.BuildStorageIfNoSpace = cond.Checked;
        }
        #endregion
        private void Con2percent_TextChanged(object sender, EventArgs e)
        {
            int percent;
            if (int.TryParse(Con2percent.Text, out percent))
            {
                preset.buildSettings.LowSpacePercent = percent;
            }
            else
            {
                Con2percent.Text = "0";
            }
        }

        private void SaveButt_Click(object sender, EventArgs e)
        {
            preset.Name = PresetNameBox.Text;
            mform.BuildPresets.Add(preset);
            vform.UpdatePresets();
            this.Close();
        }
        //

    }
    public class BuildPreset
    {
        public string Name;
        public List<string> Queue;
        public BuildSettings buildSettings;
    }
}
