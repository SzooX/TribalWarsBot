namespace TribalWars
{
    partial class VillageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", "main.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", "barracks.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", "stable.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", "garage.png");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", "church.png");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", "watchtower.png");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", "snob.png");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", "smith.png");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", "place.png");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", "statue.png");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", "market.png");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", "wood.png");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("", "stone.png");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("", "iron.png");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("", "farm.png");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("", "storage.png");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("", "hide.png");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("", "wall.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillageForm));
            this.Buildingslist = new System.Windows.Forms.ListView();
            this.imageheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainImgs = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Queuelist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueueRemove = new System.Windows.Forms.Button();
            this.QueueMoveUp = new System.Windows.Forms.Button();
            this.QueueMoveDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Savebutt = new System.Windows.Forms.Button();
            this.Cancelbutt = new System.Windows.Forms.Button();
            this.Con1box = new System.Windows.Forms.CheckBox();
            this.Con2box = new System.Windows.Forms.CheckBox();
            this.Con2percent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Con3box = new System.Windows.Forms.CheckBox();
            this.Con4box = new System.Windows.Forms.CheckBox();
            this.Con5box = new System.Windows.Forms.CheckBox();
            this.SetActiveBox = new System.Windows.Forms.CheckBox();
            this.woodlabel = new System.Windows.Forms.Label();
            this.stonelabel = new System.Windows.Forms.Label();
            this.ironlabel = new System.Windows.Forms.Label();
            this.Resources = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PresetChooser = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buildingslist
            // 
            this.Buildingslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imageheader,
            this.levelheader});
            this.Buildingslist.GridLines = true;
            this.Buildingslist.HideSelection = false;
            this.Buildingslist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.Buildingslist.Location = new System.Drawing.Point(12, 40);
            this.Buildingslist.Name = "Buildingslist";
            this.Buildingslist.Size = new System.Drawing.Size(116, 381);
            this.Buildingslist.SmallImageList = this.MainImgs;
            this.Buildingslist.StateImageList = this.MainImgs;
            this.Buildingslist.TabIndex = 0;
            this.Buildingslist.UseCompatibleStateImageBehavior = false;
            this.Buildingslist.View = System.Windows.Forms.View.Details;
            this.Buildingslist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Buildingslist_MouseDoubleClick);
            // 
            // imageheader
            // 
            this.imageheader.Text = " ";
            this.imageheader.Width = 45;
            // 
            // levelheader
            // 
            this.levelheader.Text = "Lvl";
            // 
            // MainImgs
            // 
            this.MainImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImgs.ImageStream")));
            this.MainImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.MainImgs.Images.SetKeyName(0, "barracks.png");
            this.MainImgs.Images.SetKeyName(1, "church.png");
            this.MainImgs.Images.SetKeyName(2, "farm.png");
            this.MainImgs.Images.SetKeyName(3, "garage.png");
            this.MainImgs.Images.SetKeyName(4, "hide.png");
            this.MainImgs.Images.SetKeyName(5, "iron.png");
            this.MainImgs.Images.SetKeyName(6, "market.png");
            this.MainImgs.Images.SetKeyName(7, "place.png");
            this.MainImgs.Images.SetKeyName(8, "smith.png");
            this.MainImgs.Images.SetKeyName(9, "snob.png");
            this.MainImgs.Images.SetKeyName(10, "stable.png");
            this.MainImgs.Images.SetKeyName(11, "statue.png");
            this.MainImgs.Images.SetKeyName(12, "stone.png");
            this.MainImgs.Images.SetKeyName(13, "storage.png");
            this.MainImgs.Images.SetKeyName(14, "Village.png");
            this.MainImgs.Images.SetKeyName(15, "wall.png");
            this.MainImgs.Images.SetKeyName(16, "watchtower.png");
            this.MainImgs.Images.SetKeyName(17, "wood.png");
            this.MainImgs.Images.SetKeyName(18, "main.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buildings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Queue";
            // 
            // Queuelist
            // 
            this.Queuelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Queuelist.GridLines = true;
            this.Queuelist.HideSelection = false;
            this.Queuelist.Location = new System.Drawing.Point(137, 40);
            this.Queuelist.Name = "Queuelist";
            this.Queuelist.Size = new System.Drawing.Size(98, 343);
            this.Queuelist.SmallImageList = this.MainImgs;
            this.Queuelist.StateImageList = this.MainImgs;
            this.Queuelist.TabIndex = 3;
            this.Queuelist.UseCompatibleStateImageBehavior = false;
            this.Queuelist.View = System.Windows.Forms.View.SmallIcon;
            // 
            // QueueRemove
            // 
            this.QueueRemove.Location = new System.Drawing.Point(137, 389);
            this.QueueRemove.Name = "QueueRemove";
            this.QueueRemove.Size = new System.Drawing.Size(33, 32);
            this.QueueRemove.TabIndex = 4;
            this.QueueRemove.Text = "-";
            this.QueueRemove.UseVisualStyleBackColor = true;
            this.QueueRemove.Click += new System.EventHandler(this.QueueRemove_Click);
            // 
            // QueueMoveUp
            // 
            this.QueueMoveUp.Location = new System.Drawing.Point(170, 389);
            this.QueueMoveUp.Name = "QueueMoveUp";
            this.QueueMoveUp.Size = new System.Drawing.Size(33, 32);
            this.QueueMoveUp.TabIndex = 5;
            this.QueueMoveUp.Text = "↑";
            this.QueueMoveUp.UseVisualStyleBackColor = true;
            this.QueueMoveUp.Click += new System.EventHandler(this.QueueMoveUp_Click);
            // 
            // QueueMoveDown
            // 
            this.QueueMoveDown.Location = new System.Drawing.Point(202, 389);
            this.QueueMoveDown.Name = "QueueMoveDown";
            this.QueueMoveDown.Size = new System.Drawing.Size(33, 32);
            this.QueueMoveDown.TabIndex = 6;
            this.QueueMoveDown.Text = "↓";
            this.QueueMoveDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QueueMoveDown.UseVisualStyleBackColor = true;
            this.QueueMoveDown.Click += new System.EventHandler(this.QueueMoveDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.MainImgs;
            this.label3.Location = new System.Drawing.Point(252, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageKey = "storage.png";
            this.label4.ImageList = this.MainImgs;
            this.label4.Location = new System.Drawing.Point(126, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "   ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Savebutt
            // 
            this.Savebutt.Location = new System.Drawing.Point(305, 584);
            this.Savebutt.Name = "Savebutt";
            this.Savebutt.Size = new System.Drawing.Size(75, 23);
            this.Savebutt.TabIndex = 9;
            this.Savebutt.Text = "Save";
            this.Savebutt.UseVisualStyleBackColor = true;
            this.Savebutt.Click += new System.EventHandler(this.Savebutt_Click);
            // 
            // Cancelbutt
            // 
            this.Cancelbutt.Location = new System.Drawing.Point(224, 584);
            this.Cancelbutt.Name = "Cancelbutt";
            this.Cancelbutt.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutt.TabIndex = 10;
            this.Cancelbutt.Text = "Cancel";
            this.Cancelbutt.UseVisualStyleBackColor = true;
            // 
            // Con1box
            // 
            this.Con1box.AutoSize = true;
            this.Con1box.Location = new System.Drawing.Point(12, 433);
            this.Con1box.Name = "Con1box";
            this.Con1box.Size = new System.Drawing.Size(324, 21);
            this.Con1box.TabIndex = 11;
            this.Con1box.Text = "Build building requiments first if they\'re not met";
            this.Con1box.UseVisualStyleBackColor = true;
            this.Con1box.CheckedChanged += new System.EventHandler(this.Con1box_CheckedChanged);
            // 
            // Con2box
            // 
            this.Con2box.AutoSize = true;
            this.Con2box.Location = new System.Drawing.Point(12, 460);
            this.Con2box.Name = "Con2box";
            this.Con2box.Size = new System.Drawing.Size(278, 21);
            this.Con2box.TabIndex = 12;
            this.Con2box.Text = "Build farm if space left is lower than x %";
            this.Con2box.UseVisualStyleBackColor = true;
            this.Con2box.CheckedChanged += new System.EventHandler(this.Con2box_CheckedChanged);
            // 
            // Con2percent
            // 
            this.Con2percent.Location = new System.Drawing.Point(305, 460);
            this.Con2percent.Name = "Con2percent";
            this.Con2percent.Size = new System.Drawing.Size(40, 22);
            this.Con2percent.TabIndex = 13;
            this.Con2percent.Text = "0";
            this.Con2percent.TextChanged += new System.EventHandler(this.Con2percent_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // Con3box
            // 
            this.Con3box.AutoSize = true;
            this.Con3box.Location = new System.Drawing.Point(12, 487);
            this.Con3box.Name = "Con3box";
            this.Con3box.Size = new System.Drawing.Size(250, 21);
            this.Con3box.TabIndex = 15;
            this.Con3box.Text = "Build farm if not enough population";
            this.Con3box.UseVisualStyleBackColor = true;
            this.Con3box.CheckedChanged += new System.EventHandler(this.Con3box_CheckedChanged);
            // 
            // Con4box
            // 
            this.Con4box.AutoSize = true;
            this.Con4box.Location = new System.Drawing.Point(12, 514);
            this.Con4box.Name = "Con4box";
            this.Con4box.Size = new System.Drawing.Size(234, 21);
            this.Con4box.TabIndex = 16;
            this.Con4box.Text = "Build storage if bigger is needed";
            this.Con4box.UseVisualStyleBackColor = true;
            this.Con4box.CheckedChanged += new System.EventHandler(this.Con4box_CheckedChanged);
            // 
            // Con5box
            // 
            this.Con5box.AutoSize = true;
            this.Con5box.Location = new System.Drawing.Point(12, 541);
            this.Con5box.Name = "Con5box";
            this.Con5box.Size = new System.Drawing.Size(171, 21);
            this.Con5box.TabIndex = 17;
            this.Con5box.Text = "Build storage if it is full";
            this.Con5box.UseVisualStyleBackColor = true;
            this.Con5box.CheckedChanged += new System.EventHandler(this.Con5box_CheckedChanged);
            // 
            // SetActiveBox
            // 
            this.SetActiveBox.AutoSize = true;
            this.SetActiveBox.Location = new System.Drawing.Point(120, 586);
            this.SetActiveBox.Name = "SetActiveBox";
            this.SetActiveBox.Size = new System.Drawing.Size(89, 21);
            this.SetActiveBox.TabIndex = 18;
            this.SetActiveBox.Text = "SetActive";
            this.SetActiveBox.UseVisualStyleBackColor = true;
            this.SetActiveBox.CheckedChanged += new System.EventHandler(this.SetActiveBox_CheckedChanged);
            // 
            // woodlabel
            // 
            this.woodlabel.AutoSize = true;
            this.woodlabel.Location = new System.Drawing.Point(48, 25);
            this.woodlabel.Name = "woodlabel";
            this.woodlabel.Size = new System.Drawing.Size(41, 17);
            this.woodlabel.TabIndex = 19;
            this.woodlabel.Text = "wood";
            // 
            // stonelabel
            // 
            this.stonelabel.AutoSize = true;
            this.stonelabel.Location = new System.Drawing.Point(48, 57);
            this.stonelabel.Name = "stonelabel";
            this.stonelabel.Size = new System.Drawing.Size(43, 17);
            this.stonelabel.TabIndex = 20;
            this.stonelabel.Text = "stone";
            // 
            // ironlabel
            // 
            this.ironlabel.AutoSize = true;
            this.ironlabel.Location = new System.Drawing.Point(48, 90);
            this.ironlabel.Name = "ironlabel";
            this.ironlabel.Size = new System.Drawing.Size(32, 17);
            this.ironlabel.TabIndex = 21;
            this.ironlabel.Text = "iron";
            // 
            // Resources
            // 
            this.Resources.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Resources.ImageStream")));
            this.Resources.TransparentColor = System.Drawing.Color.Transparent;
            this.Resources.Images.SetKeyName(0, "stoner.png");
            this.Resources.Images.SetKeyName(1, "woodr.png");
            this.Resources.Images.SetKeyName(2, "ironr.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageIndex = 1;
            this.label6.ImageList = this.Resources;
            this.label6.Location = new System.Drawing.Point(11, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.Resources;
            this.label7.Location = new System.Drawing.Point(11, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageIndex = 2;
            this.label8.ImageList = this.Resources;
            this.label8.Location = new System.Drawing.Point(11, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Preset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.woodlabel);
            this.groupBox1.Controls.Add(this.stonelabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ironlabel);
            this.groupBox1.Location = new System.Drawing.Point(241, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 130);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // PresetChooser
            // 
            this.PresetChooser.FormattingEnabled = true;
            this.PresetChooser.Items.AddRange(new object[] {
            "Add preset"});
            this.PresetChooser.Location = new System.Drawing.Point(266, 10);
            this.PresetChooser.Name = "PresetChooser";
            this.PresetChooser.Size = new System.Drawing.Size(121, 24);
            this.PresetChooser.TabIndex = 27;
            this.PresetChooser.SelectedIndexChanged += new System.EventHandler(this.PresetChooser_SelectedIndexChanged);
            // 
            // VillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 619);
            this.Controls.Add(this.PresetChooser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SetActiveBox);
            this.Controls.Add(this.Con5box);
            this.Controls.Add(this.Con4box);
            this.Controls.Add(this.Con3box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Con2percent);
            this.Controls.Add(this.Con2box);
            this.Controls.Add(this.Con1box);
            this.Controls.Add(this.Cancelbutt);
            this.Controls.Add(this.Savebutt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QueueMoveDown);
            this.Controls.Add(this.QueueMoveUp);
            this.Controls.Add(this.QueueRemove);
            this.Controls.Add(this.Queuelist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buildingslist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VillageForm";
            this.Text = "VillageForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Buildingslist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Queuelist;
        private System.Windows.Forms.Button QueueRemove;
        private System.Windows.Forms.Button QueueMoveUp;
        private System.Windows.Forms.Button QueueMoveDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList MainImgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Savebutt;
        private System.Windows.Forms.Button Cancelbutt;
        private System.Windows.Forms.CheckBox Con1box;
        private System.Windows.Forms.CheckBox Con2box;
        private System.Windows.Forms.TextBox Con2percent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Con3box;
        private System.Windows.Forms.CheckBox Con4box;
        private System.Windows.Forms.CheckBox Con5box;
        private System.Windows.Forms.CheckBox SetActiveBox;
        private System.Windows.Forms.Label woodlabel;
        private System.Windows.Forms.Label stonelabel;
        private System.Windows.Forms.Label ironlabel;
        private System.Windows.Forms.ColumnHeader imageheader;
        private System.Windows.Forms.ColumnHeader levelheader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList Resources;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PresetChooser;
    }
}