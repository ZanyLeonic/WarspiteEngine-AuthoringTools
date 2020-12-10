namespace WarspiteGame.AuthoringTools.Forms
{
    partial class ConfigWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.OkayButton = new System.Windows.Forms.Button();
            this.GroupPanel = new System.Windows.Forms.Panel();
            this.executableBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseExecutable = new System.Windows.Forms.Button();
            this.gameBox = new System.Windows.Forms.TextBox();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.buttonPanel.SuspendLayout();
            this.GroupPanel.SuspendLayout();
            this.executableBox.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.OkayButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 150);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(414, 35);
            this.buttonPanel.TabIndex = 0;
            // 
            // OkayButton
            // 
            this.OkayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkayButton.Location = new System.Drawing.Point(170, 6);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 0;
            this.OkayButton.Text = "&OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // GroupPanel
            // 
            this.GroupPanel.Controls.Add(this.executableBox);
            this.GroupPanel.Controls.Add(this.MainGroup);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Padding = new System.Windows.Forms.Padding(5);
            this.GroupPanel.Size = new System.Drawing.Size(414, 150);
            this.GroupPanel.TabIndex = 1;
            // 
            // executableBox
            // 
            this.executableBox.Controls.Add(this.label2);
            this.executableBox.Controls.Add(this.browseExecutable);
            this.executableBox.Controls.Add(this.gameBox);
            this.executableBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.executableBox.Location = new System.Drawing.Point(5, 76);
            this.executableBox.Name = "executableBox";
            this.executableBox.Size = new System.Drawing.Size(404, 69);
            this.executableBox.TabIndex = 3;
            this.executableBox.TabStop = false;
            this.executableBox.Text = "Game Executable location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "This location should be pointing to the ws.exe of your Engine install";
            // 
            // browseExecutable
            // 
            this.browseExecutable.Location = new System.Drawing.Point(375, 35);
            this.browseExecutable.Name = "browseExecutable";
            this.browseExecutable.Size = new System.Drawing.Size(25, 20);
            this.browseExecutable.TabIndex = 1;
            this.browseExecutable.Text = "...";
            this.browseExecutable.UseVisualStyleBackColor = true;
            this.browseExecutable.Click += new System.EventHandler(this.browseExecutable_Click);
            // 
            // gameBox
            // 
            this.gameBox.Location = new System.Drawing.Point(5, 35);
            this.gameBox.Name = "gameBox";
            this.gameBox.ReadOnly = true;
            this.gameBox.Size = new System.Drawing.Size(364, 20);
            this.gameBox.TabIndex = 0;
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Controls.Add(this.browseButton);
            this.MainGroup.Controls.Add(this.pathBox);
            this.MainGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainGroup.Location = new System.Drawing.Point(5, 5);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(404, 71);
            this.MainGroup.TabIndex = 2;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Asset folder location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This location should be pointing to the assets folder of your Engine install";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(375, 35);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 20);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(5, 35);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(364, 20);
            this.pathBox.TabIndex = 0;
            // 
            // ConfigWindow
            // 
            this.AcceptButton = this.OkayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 185);
            this.Controls.Add(this.GroupPanel);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authoring Tools Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigWindow_FormClosing);
            this.Load += new System.EventHandler(this.ConfigWindow_Load);
            this.buttonPanel.ResumeLayout(false);
            this.GroupPanel.ResumeLayout(false);
            this.executableBox.ResumeLayout(false);
            this.executableBox.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Panel GroupPanel;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox executableBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseExecutable;
        private System.Windows.Forms.TextBox gameBox;
    }
}