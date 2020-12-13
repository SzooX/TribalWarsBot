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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillageForm));
            this.Buildingslist = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Queuelist = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MainImgs = new System.Windows.Forms.ImageList(this.components);
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
            this.SuspendLayout();
            // 
            // Buildingslist
            // 
            this.Buildingslist.HideSelection = false;
            this.Buildingslist.Location = new System.Drawing.Point(12, 40);
            this.Buildingslist.Name = "Buildingslist";
            this.Buildingslist.Size = new System.Drawing.Size(98, 343);
            this.Buildingslist.TabIndex = 0;
            this.Buildingslist.UseCompatibleStateImageBehavior = false;
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
            this.Queuelist.HideSelection = false;
            this.Queuelist.Location = new System.Drawing.Point(137, 40);
            this.Queuelist.Name = "Queuelist";
            this.Queuelist.Size = new System.Drawing.Size(98, 343);
            this.Queuelist.TabIndex = 3;
            this.Queuelist.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "↓";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageKey = "storage.png";
            this.label4.ImageList = this.MainImgs;
            this.label4.Location = new System.Drawing.Point(258, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "   ";
            // 
            // Savebutt
            // 
            this.Savebutt.Location = new System.Drawing.Point(305, 584);
            this.Savebutt.Name = "Savebutt";
            this.Savebutt.Size = new System.Drawing.Size(75, 23);
            this.Savebutt.TabIndex = 9;
            this.Savebutt.Text = "Save";
            this.Savebutt.UseVisualStyleBackColor = true;
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
            // 
            // Con2percent
            // 
            this.Con2percent.Location = new System.Drawing.Point(305, 460);
            this.Con2percent.Name = "Con2percent";
            this.Con2percent.Size = new System.Drawing.Size(40, 22);
            this.Con2percent.TabIndex = 13;
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
            // 
            // VillageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 619);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Queuelist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buildingslist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VillageForm";
            this.Text = "VillageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Buildingslist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Queuelist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
    }
}