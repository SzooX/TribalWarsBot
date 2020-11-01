using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TribalWarsBot
{
    public partial class Form2 : Form
    {
        ListViewItem selecteditemfarm;
        public Form2()
        {
            InitializeComponent();
            ErrorLabel.Text = "";
            //LIST view setup

            FarmList.Columns.Add("Name");
            FarmList.Columns.Add("X cord");
            FarmList.Columns.Add("Y cord");
            FarmList.View = View.Details;
            FarmList.GridLines = true;

            //
            RemoveFarm.Enabled = false;
            ItemToRemoveLabel.Text = "Select farm to delete";
        }

        //Public methods
        public ListView GetFarmList()
        {
            return FarmList;
        }
        public string[,] GetFarmGroups()
        {
            string[,] array = new string[,] {
                {"spear", PikemanBox.Text }, 
                {"sword", SwordmanBox.Text } 
            };
            return array;
        }


        //Buttons private
        private void button3_Click(object sender, EventArgs e) //Remove button
        {
            FarmList.Items.Remove(selecteditemfarm);
            RemoveFarm.Enabled = false;
            ItemToRemoveLabel.Text = "";
        }
        private void AddFarm_Click(object sender, EventArgs e)
        {
            try
            {
                int resultd = 0;

                int xcorr = int.Parse(Xcorr.Text);
                int ycorr = int.Parse(Ycorr.Text);
                string name = NameBox.Text;
                bool IsNameNumber = int.TryParse(name, out resultd);
                if (IsNameNumber) throw new Exception("Bad name");
                FarmList.Items.Add(new ListViewItem(new string[] { name,  xcorr.ToString(), ycorr.ToString() }));
                ErrorLabel.Text = "";
            }
            catch(Exception ex)
            {
                ErrorLabel.Text = "Bad cords (check for words, there sould be only numbers) / bad name";
            }
        }

        private void button2_Click(object sender, EventArgs e)//Close
        {
            this.Hide();
        }

        private void FarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultd = 0;
            ListView s = sender as ListView;
            if (s.SelectedItems.Count == 0)
            {
                return;
            }
            string selcteditem = s.SelectedItems[0].Text;
            bool IsSelectedNumber = int.TryParse(selcteditem, out resultd);
            if (IsSelectedNumber) return;
            //
            
            RemoveFarm.Enabled = true;
            ItemToRemoveLabel.Text = selcteditem;
            selecteditemfarm = s.SelectedItems[0];
            //ItemToRemoveLabel.Text = s.SelectedItems
            s.SelectedItems.Clear();
        }

    }
}
