namespace WarspiteGame.AuthoringTools.Debugger.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputGBox = new System.Windows.Forms.GroupBox();
            this.stdOutput = new System.Windows.Forms.RichTextBox();
            this.stdinPanel = new System.Windows.Forms.Panel();
            this.stdinBox = new System.Windows.Forms.TextBox();
            this.stdinEnter = new System.Windows.Forms.Button();
            this.stdinLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolButton = new System.Windows.Forms.ToolStripButton();
            this.SaveLogButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.drawOnTopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.killProcessButton = new System.Windows.Forms.ToolStripButton();
            this.reOpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearOutputBtn = new System.Windows.Forms.ToolStripButton();
            this.mainStrip.SuspendLayout();
            this.outputGBox.SuspendLayout();
            this.stdinPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStrip
            // 
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainStrip.Location = new System.Drawing.Point(0, 0);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(800, 24);
            this.mainStrip.TabIndex = 0;
            this.mainStrip.Text = "menuStrip1";
            this.mainStrip.Click += new System.EventHandler(this.mainStrip_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveOutputToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.OpenFolder_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.Save_16x;
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.ConfigurationFile_16x;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.WindowsForm_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // outputGBox
            // 
            this.outputGBox.Controls.Add(this.stdOutput);
            this.outputGBox.Controls.Add(this.stdinPanel);
            this.outputGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGBox.Location = new System.Drawing.Point(0, 49);
            this.outputGBox.Name = "outputGBox";
            this.outputGBox.Size = new System.Drawing.Size(800, 411);
            this.outputGBox.TabIndex = 1;
            this.outputGBox.TabStop = false;
            this.outputGBox.Text = "Application output";
            // 
            // stdOutput
            // 
            this.stdOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdOutput.Location = new System.Drawing.Point(3, 16);
            this.stdOutput.Name = "stdOutput";
            this.stdOutput.ReadOnly = true;
            this.stdOutput.Size = new System.Drawing.Size(794, 367);
            this.stdOutput.TabIndex = 2;
            this.stdOutput.Text = "";
            // 
            // stdinPanel
            // 
            this.stdinPanel.Controls.Add(this.stdinBox);
            this.stdinPanel.Controls.Add(this.stdinEnter);
            this.stdinPanel.Controls.Add(this.stdinLabel);
            this.stdinPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stdinPanel.Enabled = false;
            this.stdinPanel.Location = new System.Drawing.Point(3, 383);
            this.stdinPanel.Name = "stdinPanel";
            this.stdinPanel.Padding = new System.Windows.Forms.Padding(1);
            this.stdinPanel.Size = new System.Drawing.Size(794, 25);
            this.stdinPanel.TabIndex = 1;
            // 
            // stdinBox
            // 
            this.stdinBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdinBox.Location = new System.Drawing.Point(36, 3);
            this.stdinBox.Name = "stdinBox";
            this.stdinBox.Size = new System.Drawing.Size(682, 20);
            this.stdinBox.TabIndex = 4;
            this.stdinBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stdinBox_KeyDown);
            // 
            // stdinEnter
            // 
            this.stdinEnter.Dock = System.Windows.Forms.DockStyle.Right;
            this.stdinEnter.Location = new System.Drawing.Point(718, 1);
            this.stdinEnter.Name = "stdinEnter";
            this.stdinEnter.Size = new System.Drawing.Size(75, 23);
            this.stdinEnter.TabIndex = 1;
            this.stdinEnter.Text = "&Enter";
            this.stdinEnter.UseVisualStyleBackColor = true;
            this.stdinEnter.Click += new System.EventHandler(this.stdinEnter_Click);
            // 
            // stdinLabel
            // 
            this.stdinLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stdinLabel.Location = new System.Drawing.Point(1, 1);
            this.stdinLabel.Name = "stdinLabel";
            this.stdinLabel.Size = new System.Drawing.Size(40, 23);
            this.stdinLabel.TabIndex = 0;
            this.stdinLabel.Text = "Input:";
            this.stdinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolButton,
            this.SaveLogButton,
            this.toolStripSeparator3,
            this.drawOnTopButton,
            this.toolStripSeparator2,
            this.killProcessButton,
            this.reOpenButton,
            this.toolStripSeparator5,
            this.clearOutputBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolButton
            // 
            this.OpenToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolButton.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.OpenFolder_16x;
            this.OpenToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolButton.Name = "OpenToolButton";
            this.OpenToolButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolButton.Text = "Open";
            this.OpenToolButton.Click += new System.EventHandler(this.OpenToolButton_Click);
            // 
            // SaveLogButton
            // 
            this.SaveLogButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveLogButton.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.Save_16x;
            this.SaveLogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveLogButton.Name = "SaveLogButton";
            this.SaveLogButton.Size = new System.Drawing.Size(23, 22);
            this.SaveLogButton.Text = "Save Log";
            this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // drawOnTopButton
            // 
            this.drawOnTopButton.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.Win32Project_16x;
            this.drawOnTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawOnTopButton.Name = "drawOnTopButton";
            this.drawOnTopButton.Size = new System.Drawing.Size(91, 22);
            this.drawOnTopButton.Text = "Draw Ontop";
            this.drawOnTopButton.Click += new System.EventHandler(this.drawOnTopButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // killProcessButton
            // 
            this.killProcessButton.Enabled = false;
            this.killProcessButton.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.DeleteEvent_16x;
            this.killProcessButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.killProcessButton.Name = "killProcessButton";
            this.killProcessButton.Size = new System.Drawing.Size(86, 22);
            this.killProcessButton.Text = "Kill Process";
            this.killProcessButton.Click += new System.EventHandler(this.killProcessButton_Click);
            // 
            // reOpenButton
            // 
            this.reOpenButton.Enabled = false;
            this.reOpenButton.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.Rerun_16x;
            this.reOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reOpenButton.Name = "reOpenButton";
            this.reOpenButton.Size = new System.Drawing.Size(148, 22);
            this.reOpenButton.Text = "Reopen last executable";
            this.reOpenButton.Click += new System.EventHandler(this.reOpenButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // clearOutputBtn
            // 
            this.clearOutputBtn.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.ClearWindowContent_16x;
            this.clearOutputBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearOutputBtn.Name = "clearOutputBtn";
            this.clearOutputBtn.Size = new System.Drawing.Size(77, 22);
            this.clearOutputBtn.Text = "Clear Log";
            this.clearOutputBtn.Click += new System.EventHandler(this.clearOutputBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.stdinEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.outputGBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainStrip;
            this.Name = "MainForm";
            this.Text = "Debugger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.outputGBox.ResumeLayout(false);
            this.stdinPanel.ResumeLayout(false);
            this.stdinPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox outputGBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox stdOutput;
        private System.Windows.Forms.Panel stdinPanel;
        private System.Windows.Forms.TextBox stdinBox;
        private System.Windows.Forms.Button stdinEnter;
        private System.Windows.Forms.Label stdinLabel;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton drawOnTopButton;
        private System.Windows.Forms.ToolStripButton killProcessButton;
        private System.Windows.Forms.ToolStripButton OpenToolButton;
        private System.Windows.Forms.ToolStripButton SaveLogButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton reOpenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton clearOutputBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

