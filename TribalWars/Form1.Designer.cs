namespace TribalWars
{
    partial class Form1
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
            System.Windows.Forms.ColumnHeader noc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CityReader = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botstopbtt = new System.Windows.Forms.Button();
            this.botstartbtt = new System.Windows.Forms.Button();
            this.worldbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelbox = new System.Windows.Forms.TextBox();
            this.wwwtab = new System.Windows.Forms.TabPage();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.WWWtabnew = new System.Windows.Forms.TabPage();
            this.Villagestab = new System.Windows.Forms.TabPage();
            this.Updatecitybutt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Buildintervalbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Buildingcheck = new System.Windows.Forms.CheckBox();
            this.villageslist = new System.Windows.Forms.ListView();
            this.Namec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointsc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mainc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barracksc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stablec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Garagec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Churchc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Watchtowerc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Snobc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Smithc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Placec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statuec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marketc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Woodc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stonec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ironc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Farmc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Storagec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hidec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wallc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VillagesListImgs = new System.Windows.Forms.ImageList(this.components);
            this.villagedatelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addcitybutt = new System.Windows.Forms.Button();
            this.MainTabImages = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.bottime = new System.Windows.Forms.Label();
            this.ContextMenuImgs = new System.Windows.Forms.ImageList(this.components);
            this.buildtest = new System.Windows.Forms.Button();
            noc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.maintabcontrol.SuspendLayout();
            this.Villagestab.SuspendLayout();
            this.SuspendLayout();
            // 
            // noc
            // 
            noc.Text = "NO.";
            // 
            // CityReader
            // 
            this.CityReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerReadDetailCities);
            this.CityReader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerReadDetailCitiesProgress);
            this.CityReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerReadDetailCitiesFinished);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botstopbtt);
            this.groupBox1.Controls.Add(this.botstartbtt);
            this.groupBox1.Controls.Add(this.worldbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordbox);
            this.groupBox1.Controls.Add(this.loginbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panelbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login site";
            // 
            // botstopbtt
            // 
            this.botstopbtt.Location = new System.Drawing.Point(714, 17);
            this.botstopbtt.Name = "botstopbtt";
            this.botstopbtt.Size = new System.Drawing.Size(75, 23);
            this.botstopbtt.TabIndex = 9;
            this.botstopbtt.Text = "STOP";
            this.botstopbtt.UseVisualStyleBackColor = true;
            // 
            // botstartbtt
            // 
            this.botstartbtt.Location = new System.Drawing.Point(633, 17);
            this.botstartbtt.Name = "botstartbtt";
            this.botstartbtt.Size = new System.Drawing.Size(75, 23);
            this.botstartbtt.TabIndex = 7;
            this.botstartbtt.Text = "START";
            this.botstartbtt.UseVisualStyleBackColor = true;
            this.botstartbtt.Click += new System.EventHandler(this.botstartbtt_Click);
            // 
            // worldbox
            // 
            this.worldbox.Location = new System.Drawing.Point(456, 20);
            this.worldbox.Name = "worldbox";
            this.worldbox.Size = new System.Drawing.Size(100, 22);
            this.worldbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "World";
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(335, 20);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(100, 22);
            this.passwordbox.TabIndex = 4;
            this.passwordbox.Text = "Crazy123";
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(215, 21);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(100, 22);
            this.loginbox.TabIndex = 3;
            this.loginbox.Text = "CrazyUser001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // panelbox
            // 
            this.panelbox.Location = new System.Drawing.Point(6, 22);
            this.panelbox.Name = "panelbox";
            this.panelbox.Size = new System.Drawing.Size(145, 22);
            this.panelbox.TabIndex = 0;
            this.panelbox.Text = "TribalWars.net";
            // 
            // wwwtab
            // 
            this.wwwtab.ImageIndex = 0;
            this.wwwtab.Location = new System.Drawing.Point(4, 25);
            this.wwwtab.Name = "wwwtab";
            this.wwwtab.Padding = new System.Windows.Forms.Padding(3);
            this.wwwtab.Size = new System.Drawing.Size(1477, 703);
            this.wwwtab.TabIndex = 1;
            this.wwwtab.Text = "WWW";
            this.wwwtab.UseVisualStyleBackColor = true;
            // 
            // maintabcontrol
            // 
            this.maintabcontrol.Controls.Add(this.WWWtabnew);
            this.maintabcontrol.Controls.Add(this.Villagestab);
            this.maintabcontrol.Controls.Add(this.wwwtab);
            this.maintabcontrol.ImageList = this.MainTabImages;
            this.maintabcontrol.Location = new System.Drawing.Point(12, 77);
            this.maintabcontrol.Name = "maintabcontrol";
            this.maintabcontrol.SelectedIndex = 0;
            this.maintabcontrol.Size = new System.Drawing.Size(1485, 732);
            this.maintabcontrol.TabIndex = 0;
            // 
            // WWWtabnew
            // 
            this.WWWtabnew.ImageIndex = 0;
            this.WWWtabnew.Location = new System.Drawing.Point(4, 25);
            this.WWWtabnew.Name = "WWWtabnew";
            this.WWWtabnew.Padding = new System.Windows.Forms.Padding(3);
            this.WWWtabnew.Size = new System.Drawing.Size(1477, 703);
            this.WWWtabnew.TabIndex = 3;
            this.WWWtabnew.Text = "WWW";
            this.WWWtabnew.UseVisualStyleBackColor = true;
            this.WWWtabnew.Click += new System.EventHandler(this.WWWtabnew_Click);
            // 
            // Villagestab
            // 
            this.Villagestab.Controls.Add(this.buildtest);
            this.Villagestab.Controls.Add(this.Updatecitybutt);
            this.Villagestab.Controls.Add(this.label7);
            this.Villagestab.Controls.Add(this.Buildintervalbox);
            this.Villagestab.Controls.Add(this.label6);
            this.Villagestab.Controls.Add(this.Buildingcheck);
            this.Villagestab.Controls.Add(this.villageslist);
            this.Villagestab.Controls.Add(this.villagedatelabel);
            this.Villagestab.Controls.Add(this.label4);
            this.Villagestab.Controls.Add(this.addcitybutt);
            this.Villagestab.ImageIndex = 1;
            this.Villagestab.Location = new System.Drawing.Point(4, 25);
            this.Villagestab.Name = "Villagestab";
            this.Villagestab.Size = new System.Drawing.Size(1477, 703);
            this.Villagestab.TabIndex = 2;
            this.Villagestab.Text = "Villages";
            this.Villagestab.UseVisualStyleBackColor = true;
            // 
            // Updatecitybutt
            // 
            this.Updatecitybutt.Location = new System.Drawing.Point(152, 35);
            this.Updatecitybutt.Name = "Updatecitybutt";
            this.Updatecitybutt.Size = new System.Drawing.Size(115, 23);
            this.Updatecitybutt.TabIndex = 9;
            this.Updatecitybutt.Text = "Update Cities";
            this.Updatecitybutt.UseVisualStyleBackColor = true;
            this.Updatecitybutt.Click += new System.EventHandler(this.Updatecitybutt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(227, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "(sec)";
            // 
            // Buildintervalbox
            // 
            this.Buildintervalbox.Location = new System.Drawing.Point(121, 114);
            this.Buildintervalbox.Name = "Buildintervalbox";
            this.Buildintervalbox.Size = new System.Drawing.Size(100, 22);
            this.Buildintervalbox.TabIndex = 7;
            this.Buildintervalbox.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(22, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Build interval:";
            // 
            // Buildingcheck
            // 
            this.Buildingcheck.AutoSize = true;
            this.Buildingcheck.Location = new System.Drawing.Point(22, 79);
            this.Buildingcheck.Name = "Buildingcheck";
            this.Buildingcheck.Size = new System.Drawing.Size(127, 21);
            this.Buildingcheck.TabIndex = 5;
            this.Buildingcheck.Text = "Enable building";
            this.Buildingcheck.UseVisualStyleBackColor = true;
            this.Buildingcheck.CheckedChanged += new System.EventHandler(this.Buildingcheck_CheckedChanged);
            // 
            // villageslist
            // 
            this.villageslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            noc,
            this.Namec,
            this.pointsc,
            this.Mainc,
            this.Barracksc,
            this.Stablec,
            this.Garagec,
            this.Churchc,
            this.Watchtowerc,
            this.Snobc,
            this.Smithc,
            this.Placec,
            this.Statuec,
            this.Marketc,
            this.Woodc,
            this.Stonec,
            this.Ironc,
            this.Farmc,
            this.Storagec,
            this.Hidec,
            this.Wallc});
            this.villageslist.GridLines = true;
            this.villageslist.HideSelection = false;
            this.villageslist.Location = new System.Drawing.Point(22, 217);
            this.villageslist.Name = "villageslist";
            this.villageslist.Size = new System.Drawing.Size(1433, 490);
            this.villageslist.SmallImageList = this.VillagesListImgs;
            this.villageslist.StateImageList = this.VillagesListImgs;
            this.villageslist.TabIndex = 4;
            this.villageslist.UseCompatibleStateImageBehavior = false;
            this.villageslist.View = System.Windows.Forms.View.Details;
            this.villageslist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.villageslist_MouseDown);
            // 
            // Namec
            // 
            this.Namec.Text = "Name";
            this.Namec.Width = 204;
            // 
            // pointsc
            // 
            this.pointsc.Text = "Points";
            // 
            // Mainc
            // 
            this.Mainc.Text = "Main";
            // 
            // Barracksc
            // 
            this.Barracksc.Text = "Barracks";
            // 
            // Stablec
            // 
            this.Stablec.Text = "Stable";
            // 
            // Garagec
            // 
            this.Garagec.Text = "Garage";
            // 
            // Churchc
            // 
            this.Churchc.Text = "Church";
            // 
            // Watchtowerc
            // 
            this.Watchtowerc.Text = "Watchtower";
            // 
            // Snobc
            // 
            this.Snobc.Text = "Snob";
            // 
            // Smithc
            // 
            this.Smithc.Text = "Smith";
            // 
            // Placec
            // 
            this.Placec.Text = "Place";
            // 
            // Statuec
            // 
            this.Statuec.Text = "Statue";
            // 
            // Marketc
            // 
            this.Marketc.Text = "Market";
            // 
            // Woodc
            // 
            this.Woodc.Text = "Wood";
            // 
            // Stonec
            // 
            this.Stonec.Text = "Stone";
            // 
            // Ironc
            // 
            this.Ironc.Text = "Iron";
            // 
            // Farmc
            // 
            this.Farmc.Text = "Farm";
            // 
            // Storagec
            // 
            this.Storagec.Text = "Storage";
            // 
            // Hidec
            // 
            this.Hidec.Text = "Hide";
            // 
            // Wallc
            // 
            this.Wallc.Text = "Wall";
            // 
            // VillagesListImgs
            // 
            this.VillagesListImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("VillagesListImgs.ImageStream")));
            this.VillagesListImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.VillagesListImgs.Images.SetKeyName(0, "main.png");
            this.VillagesListImgs.Images.SetKeyName(1, "barracks.png");
            this.VillagesListImgs.Images.SetKeyName(2, "stable.png");
            this.VillagesListImgs.Images.SetKeyName(3, "garage.png");
            this.VillagesListImgs.Images.SetKeyName(4, "church.png");
            this.VillagesListImgs.Images.SetKeyName(5, "watchtower.png");
            this.VillagesListImgs.Images.SetKeyName(6, "snob.png");
            this.VillagesListImgs.Images.SetKeyName(7, "smith.png");
            this.VillagesListImgs.Images.SetKeyName(8, "place.png");
            this.VillagesListImgs.Images.SetKeyName(9, "statue.png");
            this.VillagesListImgs.Images.SetKeyName(10, "market.png");
            this.VillagesListImgs.Images.SetKeyName(11, "wood.png");
            this.VillagesListImgs.Images.SetKeyName(12, "stone.png");
            this.VillagesListImgs.Images.SetKeyName(13, "iron.png");
            this.VillagesListImgs.Images.SetKeyName(14, "farm.png");
            this.VillagesListImgs.Images.SetKeyName(15, "storage.png");
            this.VillagesListImgs.Images.SetKeyName(16, "hide.png");
            this.VillagesListImgs.Images.SetKeyName(17, "wall.png");
            // 
            // villagedatelabel
            // 
            this.villagedatelabel.AutoSize = true;
            this.villagedatelabel.Location = new System.Drawing.Point(1120, 35);
            this.villagedatelabel.Name = "villagedatelabel";
            this.villagedatelabel.Size = new System.Drawing.Size(114, 17);
            this.villagedatelabel.TabIndex = 3;
            this.villagedatelabel.Text = "xxxx-xx-xx xx:xx:xx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1027, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last update:";
            // 
            // addcitybutt
            // 
            this.addcitybutt.Location = new System.Drawing.Point(22, 35);
            this.addcitybutt.Name = "addcitybutt";
            this.addcitybutt.Size = new System.Drawing.Size(115, 23);
            this.addcitybutt.TabIndex = 0;
            this.addcitybutt.Text = "Add Cities";
            this.addcitybutt.UseVisualStyleBackColor = true;
            this.addcitybutt.Click += new System.EventHandler(this.addcitybutt_Click);
            // 
            // MainTabImages
            // 
            this.MainTabImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainTabImages.ImageStream")));
            this.MainTabImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MainTabImages.Images.SetKeyName(0, "fdb01354a7f787c8d3191c8759c7d428.png");
            this.MainTabImages.Images.SetKeyName(1, "Village.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bot time:";
            // 
            // bottime
            // 
            this.bottime.AutoSize = true;
            this.bottime.Location = new System.Drawing.Point(1108, 32);
            this.bottime.Name = "bottime";
            this.bottime.Size = new System.Drawing.Size(142, 17);
            this.bottime.TabIndex = 4;
            this.bottime.Text = "xxxx-xx-xx xx:xx:xx:xxxx";
            // 
            // ContextMenuImgs
            // 
            this.ContextMenuImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ContextMenuImgs.ImageStream")));
            this.ContextMenuImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.ContextMenuImgs.Images.SetKeyName(0, "plus-flat.png");
            this.ContextMenuImgs.Images.SetKeyName(1, "delet.png");
            this.ContextMenuImgs.Images.SetKeyName(2, "kisspng-computer-icons-gear-symbol-engine-5ac2deffe81947.8885772615227205119507.j" +
        "pg");
            this.ContextMenuImgs.Images.SetKeyName(3, "150_check_no_delete_error_remove-512.png");
            // 
            // buildtest
            // 
            this.buildtest.Location = new System.Drawing.Point(273, 35);
            this.buildtest.Name = "buildtest";
            this.buildtest.Size = new System.Drawing.Size(147, 23);
            this.buildtest.TabIndex = 10;
            this.buildtest.Text = "test building";
            this.buildtest.UseVisualStyleBackColor = true;
            this.buildtest.Click += new System.EventHandler(this.buildtest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1498, 821);
            this.Controls.Add(this.bottime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maintabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crazy TribalWars Bot v0.13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.maintabcontrol.ResumeLayout(false);
            this.Villagestab.ResumeLayout(false);
            this.Villagestab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker CityReader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox panelbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button botstartbtt;
        private System.Windows.Forms.TextBox worldbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botstopbtt;
        private System.Windows.Forms.TabPage wwwtab;
        private ExtendedWebBrowser wbextended;
        private System.Windows.Forms.TabControl maintabcontrol;
        private System.Windows.Forms.TabPage Villagestab;
        private System.Windows.Forms.Label villagedatelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addcitybutt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bottime;
        private System.Windows.Forms.ListView villageslist;
        private System.Windows.Forms.ColumnHeader pointsc;
        private System.Windows.Forms.ColumnHeader Mainc;
        private System.Windows.Forms.ColumnHeader Stablec;
        private System.Windows.Forms.ColumnHeader Garagec;
        private System.Windows.Forms.ColumnHeader Churchc;
        private System.Windows.Forms.ColumnHeader Watchtowerc;
        private System.Windows.Forms.ColumnHeader Snobc;
        private System.Windows.Forms.ColumnHeader Smithc;
        private System.Windows.Forms.ColumnHeader Placec;
        private System.Windows.Forms.ColumnHeader Statuec;
        private System.Windows.Forms.ColumnHeader Marketc;
        private System.Windows.Forms.ColumnHeader Woodc;
        private System.Windows.Forms.ColumnHeader Stonec;
        private System.Windows.Forms.ColumnHeader Ironc;
        private System.Windows.Forms.ColumnHeader Farmc;
        private System.Windows.Forms.ColumnHeader Storagec;
        private System.Windows.Forms.ColumnHeader Hidec;
        private System.Windows.Forms.ColumnHeader Wallc;
        private System.Windows.Forms.ColumnHeader Namec;
        private System.Windows.Forms.ImageList MainTabImages;
        private System.Windows.Forms.ColumnHeader Barracksc;
        private System.Windows.Forms.ImageList VillagesListImgs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Buildintervalbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Buildingcheck;
        private System.Windows.Forms.ImageList ContextMenuImgs;
        private System.Windows.Forms.Button Updatecitybutt;
        private System.Windows.Forms.TabPage WWWtabnew;
        private System.Windows.Forms.Button buildtest;
    }
}

