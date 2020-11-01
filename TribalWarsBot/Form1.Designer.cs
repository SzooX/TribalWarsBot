namespace TribalWarsBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.autologin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorldNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuildingsManageBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotStatusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FarmCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MissingLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run BOT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(266, 21);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(125, 27);
            this.usernamebox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(266, 65);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(125, 27);
            this.passwordbox.TabIndex = 3;
            // 
            // autologin
            // 
            this.autologin.AutoSize = true;
            this.autologin.Checked = true;
            this.autologin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autologin.Location = new System.Drawing.Point(287, 116);
            this.autologin.Name = "autologin";
            this.autologin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autologin.Size = new System.Drawing.Size(104, 24);
            this.autologin.TabIndex = 4;
            this.autologin.Text = "Auto LogIn";
            this.autologin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // WorldNumberBox
            // 
            this.WorldNumberBox.Location = new System.Drawing.Point(54, 25);
            this.WorldNumberBox.Name = "WorldNumberBox";
            this.WorldNumberBox.Size = new System.Drawing.Size(125, 27);
            this.WorldNumberBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "World";
            // 
            // BuildingsManageBox
            // 
            this.BuildingsManageBox.AutoSize = true;
            this.BuildingsManageBox.Location = new System.Drawing.Point(12, 197);
            this.BuildingsManageBox.Name = "BuildingsManageBox";
            this.BuildingsManageBox.Size = new System.Drawing.Size(150, 24);
            this.BuildingsManageBox.TabIndex = 8;
            this.BuildingsManageBox.Text = "Manage Buildings";
            this.BuildingsManageBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "BOT VARIABLES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "BOT STATUS";
            // 
            // BotStatusLabel
            // 
            this.BotStatusLabel.AutoSize = true;
            this.BotStatusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.BotStatusLabel.Location = new System.Drawing.Point(287, 159);
            this.BotStatusLabel.Name = "BotStatusLabel";
            this.BotStatusLabel.Size = new System.Drawing.Size(64, 20);
            this.BotStatusLabel.TabIndex = 11;
            this.BotStatusLabel.Text = "OFFLINE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "TASK";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.ForeColor = System.Drawing.Color.White;
            this.TaskLabel.Location = new System.Drawing.Point(287, 201);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(69, 20);
            this.TaskLabel.TabIndex = 11;
            this.TaskLabel.Text = "NO TASK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "OVERVIEW";
            // 
            // FarmCheckBox
            // 
            this.FarmCheckBox.AutoSize = true;
            this.FarmCheckBox.Location = new System.Drawing.Point(12, 240);
            this.FarmCheckBox.Name = "FarmCheckBox";
            this.FarmCheckBox.Size = new System.Drawing.Size(146, 24);
            this.FarmCheckBox.TabIndex = 8;
            this.FarmCheckBox.Text = "Auto Farm(alpha)";
            this.FarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "BUILDING";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(93, 333);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(63, 20);
            this.BuildingLabel.TabIndex = 10;
            this.BuildingLabel.Text = "Nothing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "MISSING";
            // 
            // MissingLabel
            // 
            this.MissingLabel.AutoSize = true;
            this.MissingLabel.Location = new System.Drawing.Point(93, 369);
            this.MissingLabel.Name = "MissingLabel";
            this.MissingLabel.Size = new System.Drawing.Size(63, 20);
            this.MissingLabel.TabIndex = 10;
            this.MissingLabel.Text = "Nothing";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Configure\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(424, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MissingLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FarmCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BotStatusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuildingsManageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorldNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autologin);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BUILDING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.CheckBox autologin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WorldNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox BuildingsManageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BotStatusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox FarmCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MissingLabel;
        private System.Windows.Forms.Button button2;
    }
}

