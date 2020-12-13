namespace TribalWarsBot
{
    partial class Form2
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
            this.FarmList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Xcorr = new System.Windows.Forms.TextBox();
            this.Ycorr = new System.Windows.Forms.TextBox();
            this.AddFarm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RemoveFarm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SendKnight = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PikemanBox = new System.Windows.Forms.TextBox();
            this.SwordmanBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ItemToRemoveLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FarmList
            // 
            this.FarmList.HideSelection = false;
            this.FarmList.Location = new System.Drawing.Point(28, 28);
            this.FarmList.Name = "FarmList";
            this.FarmList.Size = new System.Drawing.Size(285, 213);
            this.FarmList.TabIndex = 0;
            this.FarmList.UseCompatibleStateImageBehavior = false;
            this.FarmList.SelectedIndexChanged += new System.EventHandler(this.FarmList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "VillagesToFarm";
            // 
            // Xcorr
            // 
            this.Xcorr.Location = new System.Drawing.Point(28, 289);
            this.Xcorr.Name = "Xcorr";
            this.Xcorr.Size = new System.Drawing.Size(64, 27);
            this.Xcorr.TabIndex = 2;
            // 
            // Ycorr
            // 
            this.Ycorr.Location = new System.Drawing.Point(98, 289);
            this.Ycorr.Name = "Ycorr";
            this.Ycorr.Size = new System.Drawing.Size(64, 27);
            this.Ycorr.TabIndex = 2;
            // 
            // AddFarm
            // 
            this.AddFarm.Location = new System.Drawing.Point(263, 287);
            this.AddFarm.Name = "AddFarm";
            this.AddFarm.Size = new System.Drawing.Size(94, 29);
            this.AddFarm.TabIndex = 3;
            this.AddFarm.Text = "ADD";
            this.AddFarm.UseVisualStyleBackColor = true;
            this.AddFarm.Click += new System.EventHandler(this.AddFarm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveFarm
            // 
            this.RemoveFarm.Location = new System.Drawing.Point(321, 212);
            this.RemoveFarm.Name = "RemoveFarm";
            this.RemoveFarm.Size = new System.Drawing.Size(94, 29);
            this.RemoveFarm.TabIndex = 3;
            this.RemoveFarm.Text = "REMOVE";
            this.RemoveFarm.UseVisualStyleBackColor = true;
            this.RemoveFarm.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Farm Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pikeman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Swordman";
            // 
            // SendKnight
            // 
            this.SendKnight.AutoSize = true;
            this.SendKnight.Location = new System.Drawing.Point(350, 127);
            this.SendKnight.Name = "SendKnight";
            this.SendKnight.Size = new System.Drawing.Size(107, 24);
            this.SendKnight.TabIndex = 6;
            this.SendKnight.Text = "SendKnight";
            this.SendKnight.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PikemanBox
            // 
            this.PikemanBox.Location = new System.Drawing.Point(469, 42);
            this.PikemanBox.Name = "PikemanBox";
            this.PikemanBox.Size = new System.Drawing.Size(60, 27);
            this.PikemanBox.TabIndex = 8;
            this.PikemanBox.Text = "5";
            // 
            // SwordmanBox
            // 
            this.SwordmanBox.Location = new System.Drawing.Point(469, 79);
            this.SwordmanBox.Name = "SwordmanBox";
            this.SwordmanBox.Size = new System.Drawing.Size(60, 27);
            this.SwordmanBox.TabIndex = 8;
            this.SwordmanBox.Text = "5";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(28, 385);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(98, 20);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "ExampleError";
            // 
            // ItemToRemoveLabel
            // 
            this.ItemToRemoveLabel.AutoSize = true;
            this.ItemToRemoveLabel.Location = new System.Drawing.Point(332, 244);
            this.ItemToRemoveLabel.Name = "ItemToRemoveLabel";
            this.ItemToRemoveLabel.Size = new System.Drawing.Size(83, 20);
            this.ItemToRemoveLabel.TabIndex = 10;
            this.ItemToRemoveLabel.Text = "(Target 1,1)";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(168, 289);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(89, 27);
            this.NameBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "NAME";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ItemToRemoveLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SwordmanBox);
            this.Controls.Add(this.PikemanBox);
            this.Controls.Add(this.SendKnight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveFarm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddFarm);
            this.Controls.Add(this.Ycorr);
            this.Controls.Add(this.Xcorr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FarmList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FarmList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Xcorr;
        private System.Windows.Forms.TextBox Ycorr;
        private System.Windows.Forms.Button AddFarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RemoveFarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox SendKnight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PikemanBox;
        private System.Windows.Forms.TextBox SwordmanBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ItemToRemoveLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label7;
    }
}