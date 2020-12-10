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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("fdsgsfdg");
            System.Windows.Forms.ColumnHeader noc;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.wbextended = new ExtendedWebBrowser();
            this.maintabcontrol = new System.Windows.Forms.TabControl();
            this.villagestab = new System.Windows.Forms.TabPage();
            this.addcitybutt = new System.Windows.Forms.Button();
            this.updatecitiesbutt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.villagedatelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bottime = new System.Windows.Forms.Label();
            this.villageslist = new System.Windows.Forms.ListView();
            this.pointsc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hqc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            noc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.wwwtab.SuspendLayout();
            this.maintabcontrol.SuspendLayout();
            this.villagestab.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(215, 21);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(100, 22);
            this.loginbox.TabIndex = 3;
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
            this.panelbox.Text = "plemiona.pl";
            // 
            // wwwtab
            // 
            this.wwwtab.Controls.Add(this.wbextended);
            this.wwwtab.Location = new System.Drawing.Point(4, 25);
            this.wwwtab.Name = "wwwtab";
            this.wwwtab.Padding = new System.Windows.Forms.Padding(3);
            this.wwwtab.Size = new System.Drawing.Size(1477, 703);
            this.wwwtab.TabIndex = 1;
            this.wwwtab.Text = "WWW";
            this.wwwtab.UseVisualStyleBackColor = true;
            // 
            // wbextended
            // 
            this.wbextended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbextended.Location = new System.Drawing.Point(3, 3);
            this.wbextended.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbextended.Name = "wbextended";
            this.wbextended.Size = new System.Drawing.Size(1471, 697);
            this.wbextended.TabIndex = 0;
            // 
            // maintabcontrol
            // 
            this.maintabcontrol.Controls.Add(this.wwwtab);
            this.maintabcontrol.Controls.Add(this.villagestab);
            this.maintabcontrol.Location = new System.Drawing.Point(12, 77);
            this.maintabcontrol.Name = "maintabcontrol";
            this.maintabcontrol.SelectedIndex = 0;
            this.maintabcontrol.Size = new System.Drawing.Size(1485, 732);
            this.maintabcontrol.TabIndex = 0;
            // 
            // villagestab
            // 
            this.villagestab.Controls.Add(this.villageslist);
            this.villagestab.Controls.Add(this.villagedatelabel);
            this.villagestab.Controls.Add(this.label4);
            this.villagestab.Controls.Add(this.updatecitiesbutt);
            this.villagestab.Controls.Add(this.addcitybutt);
            this.villagestab.Location = new System.Drawing.Point(4, 25);
            this.villagestab.Name = "villagestab";
            this.villagestab.Size = new System.Drawing.Size(1477, 703);
            this.villagestab.TabIndex = 2;
            this.villagestab.Text = "Villages";
            this.villagestab.UseVisualStyleBackColor = true;
            // 
            // addcitybutt
            // 
            this.addcitybutt.Location = new System.Drawing.Point(22, 35);
            this.addcitybutt.Name = "addcitybutt";
            this.addcitybutt.Size = new System.Drawing.Size(115, 23);
            this.addcitybutt.TabIndex = 0;
            this.addcitybutt.Text = "Add Cities";
            this.addcitybutt.UseVisualStyleBackColor = true;
            // 
            // updatecitiesbutt
            // 
            this.updatecitiesbutt.Location = new System.Drawing.Point(159, 35);
            this.updatecitiesbutt.Name = "updatecitiesbutt";
            this.updatecitiesbutt.Size = new System.Drawing.Size(115, 23);
            this.updatecitiesbutt.TabIndex = 1;
            this.updatecitiesbutt.Text = "Update Cities";
            this.updatecitiesbutt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last update:";
            // 
            // villagedatelabel
            // 
            this.villagedatelabel.AutoSize = true;
            this.villagedatelabel.Location = new System.Drawing.Point(1040, 41);
            this.villagedatelabel.Name = "villagedatelabel";
            this.villagedatelabel.Size = new System.Drawing.Size(114, 17);
            this.villagedatelabel.TabIndex = 3;
            this.villagedatelabel.Text = "xxxx-xx-xx xx:xx:xx";
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
            // villageslist
            // 
            this.villageslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            noc,
            this.pointsc,
            this.hqc});
            this.villageslist.GridLines = true;
            this.villageslist.HideSelection = false;
            this.villageslist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.villageslist.Location = new System.Drawing.Point(22, 81);
            this.villageslist.Name = "villageslist";
            this.villageslist.Size = new System.Drawing.Size(1433, 603);
            this.villageslist.TabIndex = 4;
            this.villageslist.UseCompatibleStateImageBehavior = false;
            this.villageslist.View = System.Windows.Forms.View.Details;
            // 
            // noc
            // 
            noc.Text = "NO.";
            // 
            // pointsc
            // 
            this.pointsc.Text = "Points";
            // 
            // hqc
            // 
            this.hqc.Text = "HQ";
            this.hqc.Width = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 821);
            this.Controls.Add(this.bottime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maintabcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.wwwtab.ResumeLayout(false);
            this.maintabcontrol.ResumeLayout(false);
            this.villagestab.ResumeLayout(false);
            this.villagestab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.TabPage villagestab;
        private System.Windows.Forms.Label villagedatelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updatecitiesbutt;
        private System.Windows.Forms.Button addcitybutt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bottime;
        private System.Windows.Forms.ListView villageslist;
        private System.Windows.Forms.ColumnHeader pointsc;
        private System.Windows.Forms.ColumnHeader hqc;
    }
}

