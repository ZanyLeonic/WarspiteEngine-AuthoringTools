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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputGBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.stdinPanel = new System.Windows.Forms.Panel();
            this.stdinBox = new System.Windows.Forms.TextBox();
            this.stdinEnter = new System.Windows.Forms.Button();
            this.stdinLabel = new System.Windows.Forms.Label();
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
            this.killProcessToolStripMenuItem});
            this.mainStrip.Location = new System.Drawing.Point(0, 0);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(800, 24);
            this.mainStrip.TabIndex = 0;
            this.mainStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
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
            this.outputGBox.Controls.Add(this.richTextBox1);
            this.outputGBox.Controls.Add(this.stdinPanel);
            this.outputGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGBox.Location = new System.Drawing.Point(0, 24);
            this.outputGBox.Name = "outputGBox";
            this.outputGBox.Size = new System.Drawing.Size(800, 426);
            this.outputGBox.TabIndex = 1;
            this.outputGBox.TabStop = false;
            this.outputGBox.Text = "stdout";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(794, 386);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // stdinPanel
            // 
            this.stdinPanel.Controls.Add(this.stdinBox);
            this.stdinPanel.Controls.Add(this.stdinEnter);
            this.stdinPanel.Controls.Add(this.stdinLabel);
            this.stdinPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stdinPanel.Enabled = false;
            this.stdinPanel.Location = new System.Drawing.Point(3, 402);
            this.stdinPanel.Name = "stdinPanel";
            this.stdinPanel.Size = new System.Drawing.Size(794, 21);
            this.stdinPanel.TabIndex = 1;
            // 
            // stdinBox
            // 
            this.stdinBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdinBox.Location = new System.Drawing.Point(32, 0);
            this.stdinBox.Name = "stdinBox";
            this.stdinBox.Size = new System.Drawing.Size(687, 20);
            this.stdinBox.TabIndex = 4;
            this.stdinBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stdinBox_KeyDown);
            // 
            // stdinEnter
            // 
            this.stdinEnter.Dock = System.Windows.Forms.DockStyle.Right;
            this.stdinEnter.Location = new System.Drawing.Point(719, 0);
            this.stdinEnter.Name = "stdinEnter";
            this.stdinEnter.Size = new System.Drawing.Size(75, 21);
            this.stdinEnter.TabIndex = 1;
            this.stdinEnter.Text = "Enter";
            this.stdinEnter.UseVisualStyleBackColor = true;
            this.stdinEnter.Click += new System.EventHandler(this.stdinEnter_Click);
            // 
            // stdinLabel
            // 
            this.stdinLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stdinLabel.Location = new System.Drawing.Point(0, 0);
            this.stdinLabel.Name = "stdinLabel";
            this.stdinLabel.Size = new System.Drawing.Size(32, 21);
            this.stdinLabel.TabIndex = 0;
            this.stdinLabel.Text = "stdin:";
            this.stdinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputGBox);
            this.Controls.Add(this.mainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel stdinPanel;
        private System.Windows.Forms.Label stdinLabel;
        private System.Windows.Forms.TextBox stdinBox;
        private System.Windows.Forms.Button stdinEnter;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
    }
}

