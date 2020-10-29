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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 395);
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
            this.usernamebox.Text = "CrazyBot";
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(266, 65);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(125, 27);
            this.passwordbox.TabIndex = 3;
            this.passwordbox.Text = "Ranking123";
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
            this.WorldNumberBox.Text = "157";
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
            this.BuildingsManageBox.Location = new System.Drawing.Point(12, 135);
            this.BuildingsManageBox.Name = "BuildingsManageBox";
            this.BuildingsManageBox.Size = new System.Drawing.Size(150, 24);
            this.BuildingsManageBox.TabIndex = 8;
            this.BuildingsManageBox.Text = "Manage Buildings";
            this.BuildingsManageBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "BOT VARIABLES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(424, 452);
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
            this.Text = "Form1";
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
    }
}

