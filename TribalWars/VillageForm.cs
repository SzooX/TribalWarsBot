﻿using System;
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
    public partial class VillageForm : Form
    {
        Form1 mform;
        Village village;
        public VillageForm(Form1 mainform , Village village)
        {
            mform = mainform;
            InitializeComponent();
            this.village = village;
            //Initialize UI
            this.Text += village.Name;

            woodlabel.Text = village.resources.Wood.ToString();
            stonelabel.Text = village.resources.Stone.ToString();
            ironlabel.Text = village.resources.Iron.ToString();
            //Load buildings
            var model = village.buildings.GetType();
            var properties = model.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            dynamic dynvillage = village.buildings;
            for (int i = 0; i < Buildingslist.Items.Count; i++)
            {
                Buildingslist.Items[i].SubItems.Add(new ListViewItem.ListViewSubItem(Buildingslist.Items[i], properties[i].GetValue(village.buildings, null).ToString()));
            }
            //Load queue
            if (village.BuildQueue == null) village.BuildQueue = new List<string>();
            if (village.buildSettings == null) village.buildSettings = new BuildSettings();
            UpdateQueueView(village.BuildQueue);
        }
        public void UpdateQueueView(List<string> Queue)
        {
            Queuelist.Items.Clear();
            for (int i = 0; i < Queue.Count; i++)
            {
                var lvi = new ListViewItem();
                lvi.ImageKey = $"{char.ToLower(Queue[i][0])}{Queue[i].Substring(1, Queue[i].Length - 1)}.png";
                Queuelist.Items.Add(lvi);
                lvi.UseItemStyleForSubItems = false;
            }
        }

        private void Buildingslist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            village.BuildQueue.Add(Buildingslist.FocusedItem.ImageKey.Replace(".png", ""));
            UpdateQueueView(village.BuildQueue) ;
        }
        
        private void QueueRemove_Click(object sender, EventArgs e)
        {
            village.BuildQueue.Remove(Queuelist.FocusedItem.ImageKey.Replace(".png", ""));
            UpdateQueueView(village.BuildQueue);
        }

        private void QueueMoveUp_Click(object sender, EventArgs e)
        {
            if (Queuelist.FocusedItem == null) return;
            string itmup = Queuelist.FocusedItem.ImageKey.Replace(".png", "");
            int idx = village.BuildQueue.IndexOf(itmup);
            if( idx == 0) return;
            string tmp = village.BuildQueue[idx-1];
            village.BuildQueue[idx - 1] = village.BuildQueue[idx];
            village.BuildQueue[idx] = tmp;
            UpdateQueueView(village.BuildQueue);
        }

        private void QueueMoveDown_Click(object sender, EventArgs e)
        {
            if (Queuelist.FocusedItem == null) return;
            string itmup = Queuelist.FocusedItem.ImageKey.Replace(".png", "");
            int idx = village.BuildQueue.IndexOf(itmup);
            if (idx > village.BuildQueue.Count-1) return;
            string tmp = village.BuildQueue[idx + 1];
            village.BuildQueue[idx + 1] = village.BuildQueue[idx];
            village.BuildQueue[idx] = tmp;
            UpdateQueueView(village.BuildQueue);
        }

        //BuildSettings settings
        #region CheckBoxes
        private void Con1box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.buildSettings.BuildRequiments = cond.Checked;
        }

        private void Con2box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.buildSettings.BuildFarmIfLowSpace = cond.Checked;
        }
        private void Con3box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.buildSettings.BuildFarmIfNotEnoughCap = cond.Checked;
        }
        private void Con4box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.buildSettings.BuildStorageForRequiments = cond.Checked;
        }
        private void Con5box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.buildSettings.BuildStorageIfNoSpace = cond.Checked;
        }
        #endregion
        private void Con2percent_TextChanged(object sender, EventArgs e)
        {
            int percent;
            if(int.TryParse(Con2percent.Text, out percent))
            {
                village.buildSettings.LowSpacePercent = percent;
            }
            else
            {
                Con2percent.Text = "0";
            }
        }
        //
        private void SetActiveBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cond = sender as CheckBox;
            village.villageSettings.Active = cond.Checked;
            
        }
        private void Savebutt_Click(object sender, EventArgs e)
        {
            if (village.villageSettings.Active == true) //TODO - 
            {
                //if (village.BuildQueue != null)
                //{
                //    if (village.buildSettings.AnyOption() == false) {
                //        village.villageSettings.Active = ;
                //    else MessageBox.Show("Cannot set active village without queue or buildsettings");
                //    } 
                //}else if (village.)
                //else MessageBox.Show("Cannot set active village without queue or buildsettings");
            }
            mform.UpdateVillageList(mform.Villages);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e) //r,m
        {

        }
    }
}
