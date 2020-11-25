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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputGBox = new System.Windows.Forms.GroupBox();
            this.stdOutput = new System.Windows.Forms.RichTextBox();
            this.stdinPanel = new System.Windows.Forms.Panel();
            this.drawOntopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stdinLabel = new System.Windows.Forms.Label();
            this.stdinEnter = new System.Windows.Forms.Button();
            this.stdinBox = new System.Windows.Forms.TextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStrip.SuspendLayout();
            this.outputGBox.SuspendLayout();
            this.stdinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStrip
            // 
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.drawOntopToolStripMenuItem,
            this.killProcessToolStripMenuItem});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Visible = false;
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // outputGBox
            // 
            this.outputGBox.Controls.Add(this.stdOutput);
            this.outputGBox.Controls.Add(this.stdinPanel);
            this.outputGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGBox.Location = new System.Drawing.Point(0, 24);
            this.outputGBox.Name = "outputGBox";
            this.outputGBox.Size = new System.Drawing.Size(800, 436);
            this.outputGBox.TabIndex = 1;
            this.outputGBox.TabStop = false;
            this.outputGBox.Text = "Application output";
            // 
            // stdOutput
            // 
            this.stdOutput.BackColor = System.Drawing.Color.Black;
            this.stdOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stdOutput.Location = new System.Drawing.Point(3, 16);
            this.stdOutput.Name = "stdOutput";
            this.stdOutput.ReadOnly = true;
            this.stdOutput.Size = new System.Drawing.Size(794, 392);
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
            this.stdinPanel.Location = new System.Drawing.Point(3, 408);
            this.stdinPanel.Name = "stdinPanel";
            this.stdinPanel.Padding = new System.Windows.Forms.Padding(1);
            this.stdinPanel.Size = new System.Drawing.Size(794, 25);
            this.stdinPanel.TabIndex = 1;
            // 
            // drawOntopToolStripMenuItem
            // 
            this.drawOntopToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.drawOntopToolStripMenuItem.Name = "drawOntopToolStripMenuItem";
            this.drawOntopToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.drawOntopToolStripMenuItem.Text = "Draw Ontop";
            this.drawOntopToolStripMenuItem.Click += new System.EventHandler(this.drawOntopToolStripMenuItem_Click);
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
            // stdinEnter
            // 
            this.stdinEnter.Dock = System.Windows.Forms.DockStyle.Right;
            this.stdinEnter.Location = new System.Drawing.Point(718, 1);
            this.stdinEnter.Name = "stdinEnter";
            this.stdinEnter.Size = new System.Drawing.Size(75, 23);
            this.stdinEnter.TabIndex = 1;
            this.stdinEnter.Text = "Enter";
            this.stdinEnter.UseVisualStyleBackColor = true;
            this.stdinEnter.Click += new System.EventHandler(this.stdinEnter_Click);
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
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.OpenFolder_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Debugger.Properties.Resources.Save_16x;
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
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
            // MainForm
            // 
            this.AcceptButton = this.stdinEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.outputGBox);
            this.Controls.Add(this.mainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.outputGBox.ResumeLayout(false);
            this.stdinPanel.ResumeLayout(false);
            this.stdinPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawOntopToolStripMenuItem;
        private System.Windows.Forms.TextBox stdinBox;
        private System.Windows.Forms.Button stdinEnter;
        private System.Windows.Forms.Label stdinLabel;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
    }
}

