using System;

namespace WarspiteGame.AuthoringTools.Forms
{
    partial class MainWindow
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainControl = new System.Windows.Forms.TabControl();
            this.StatePage = new System.Windows.Forms.TabPage();
            this.stateViewer = new System.Windows.Forms.PropertyGrid();
            this.stateView = new System.Windows.Forms.TreeView();
            this.FontPage = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startPageLabel = new System.Windows.Forms.Label();
            this.startPageNewBtn = new System.Windows.Forms.Button();
            this.startPageOpenBtn = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.MainControl.SuspendLayout();
            this.StatePage.SuspendLayout();
            this.FontPage.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.StartPage);
            this.MainControl.Controls.Add(this.StatePage);
            this.MainControl.Controls.Add(this.FontPage);
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControl.Location = new System.Drawing.Point(0, 24);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(800, 426);
            this.MainControl.TabIndex = 4;
            // 
            // StatePage
            // 
            this.StatePage.Controls.Add(this.stateViewer);
            this.StatePage.Controls.Add(this.stateView);
            this.StatePage.Location = new System.Drawing.Point(4, 22);
            this.StatePage.Name = "StatePage";
            this.StatePage.Padding = new System.Windows.Forms.Padding(3);
            this.StatePage.Size = new System.Drawing.Size(792, 400);
            this.StatePage.TabIndex = 0;
            this.StatePage.Text = "StatePage";
            this.StatePage.UseVisualStyleBackColor = true;
            // 
            // stateViewer
            // 
            this.stateViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.stateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateViewer.Location = new System.Drawing.Point(194, 3);
            this.stateViewer.Name = "stateViewer";
            this.stateViewer.Size = new System.Drawing.Size(595, 394);
            this.stateViewer.TabIndex = 5;
            // 
            // stateView
            // 
            this.stateView.Dock = System.Windows.Forms.DockStyle.Left;
            this.stateView.Location = new System.Drawing.Point(3, 3);
            this.stateView.Name = "stateView";
            this.stateView.Size = new System.Drawing.Size(191, 394);
            this.stateView.TabIndex = 4;
            this.stateView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stateView_NodeMouseClick);
            // 
            // FontPage
            // 
            this.FontPage.Controls.Add(this.propertyGrid1);
            this.FontPage.Location = new System.Drawing.Point(4, 22);
            this.FontPage.Name = "FontPage";
            this.FontPage.Padding = new System.Windows.Forms.Padding(3);
            this.FontPage.Size = new System.Drawing.Size(792, 400);
            this.FontPage.TabIndex = 1;
            this.FontPage.Text = "FontPage";
            this.FontPage.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(786, 394);
            this.propertyGrid1.TabIndex = 0;
            // 
            // StartPage
            // 
            this.StartPage.BackColor = System.Drawing.SystemColors.Control;
            this.StartPage.Controls.Add(this.startPageLabel);
            this.StartPage.Controls.Add(this.panel2);
            this.StartPage.Controls.Add(this.panel1);
            this.StartPage.Location = new System.Drawing.Point(4, 22);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(792, 400);
            this.StartPage.TabIndex = 2;
            this.StartPage.Text = "StartPage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startPageOpenBtn);
            this.panel1.Controls.Add(this.startPageNewBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 234);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(60);
            this.panel1.Size = new System.Drawing.Size(786, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 76);
            this.panel2.TabIndex = 1;
            // 
            // startPageLabel
            // 
            this.startPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPageLabel.Location = new System.Drawing.Point(3, 79);
            this.startPageLabel.Name = "startPageLabel";
            this.startPageLabel.Size = new System.Drawing.Size(786, 155);
            this.startPageLabel.TabIndex = 2;
            this.startPageLabel.Text = "[Product Info goes here]";
            this.startPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startPageNewBtn
            // 
            this.startPageNewBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.startPageNewBtn.Location = new System.Drawing.Point(60, 60);
            this.startPageNewBtn.Name = "startPageNewBtn";
            this.startPageNewBtn.Size = new System.Drawing.Size(345, 43);
            this.startPageNewBtn.TabIndex = 2;
            this.startPageNewBtn.Text = "New";
            this.startPageNewBtn.UseVisualStyleBackColor = true;
            // 
            // startPageOpenBtn
            // 
            this.startPageOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPageOpenBtn.Location = new System.Drawing.Point(405, 60);
            this.startPageOpenBtn.Name = "startPageOpenBtn";
            this.startPageOpenBtn.Size = new System.Drawing.Size(321, 43);
            this.startPageOpenBtn.TabIndex = 3;
            this.startPageOpenBtn.Text = "Open";
            this.startPageOpenBtn.UseVisualStyleBackColor = true;
            this.startPageOpenBtn.Click += new System.EventHandler(this.startPageOpenBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Warspite Authoring Tools";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.MainControl.ResumeLayout(false);
            this.StatePage.ResumeLayout(false);
            this.FontPage.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage StatePage;
        private System.Windows.Forms.TabPage FontPage;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid stateViewer;
        private System.Windows.Forms.TreeView stateView;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label startPageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startPageOpenBtn;
        private System.Windows.Forms.Button startPageNewBtn;
    }
}

