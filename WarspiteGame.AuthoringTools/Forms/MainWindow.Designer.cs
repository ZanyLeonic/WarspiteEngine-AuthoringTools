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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewControlsScroll = new System.Windows.Forms.HScrollBar();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.NewtoolButton = new System.Windows.Forms.ToolStripButton();
            this.OpentoolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SavetoolButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAstoolButton = new System.Windows.Forms.ToolStripButton();
            this.MainControl = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.startPageVersionDesc = new System.Windows.Forms.Label();
            this.startPageLabel = new System.Windows.Forms.Label();
            this.StartPagePaddingPanel = new System.Windows.Forms.Panel();
            this.StartPageControlPanel = new System.Windows.Forms.Panel();
            this.startPageOpenBtn = new System.Windows.Forms.Button();
            this.startPageNewBtn = new System.Windows.Forms.Button();
            this.StatePage = new System.Windows.Forms.TabPage();
            this.stateViewer = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeViewPanel = new System.Windows.Forms.Panel();
            this.stateView = new System.Windows.Forms.TreeView();
            this.treeViewControls = new System.Windows.Forms.Panel();
            this.deleteStateBtn = new System.Windows.Forms.Button();
            this.newStateBtn = new System.Windows.Forms.Button();
            this.FontPage = new System.Windows.Forms.TabPage();
            this.fontViewer = new System.Windows.Forms.PropertyGrid();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAssetsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.MainControl.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.StartPageControlPanel.SuspendLayout();
            this.StatePage.SuspendLayout();
            this.treeViewPanel.SuspendLayout();
            this.treeViewControls.SuspendLayout();
            this.FontPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
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
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.NewFile_16x;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.startPageNewBtn_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.OpenFolder_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.Save_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.WindowsForm_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // treeViewControlsScroll
            // 
            this.treeViewControlsScroll.Location = new System.Drawing.Point(0, 0);
            this.treeViewControlsScroll.Name = "treeViewControlsScroll";
            this.treeViewControlsScroll.Size = new System.Drawing.Size(80, 17);
            this.treeViewControlsScroll.TabIndex = 0;
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewtoolButton,
            this.OpentoolButton,
            this.toolStripSeparator3,
            this.SavetoolButton,
            this.SaveAstoolButton});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // NewtoolButton
            // 
            this.NewtoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewtoolButton.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.NewFile_16x;
            this.NewtoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewtoolButton.Name = "NewtoolButton";
            this.NewtoolButton.Size = new System.Drawing.Size(23, 22);
            this.NewtoolButton.Text = "New";
            this.NewtoolButton.Click += new System.EventHandler(this.NewtoolButton_Click);
            // 
            // OpentoolButton
            // 
            this.OpentoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpentoolButton.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.OpenFolder_16x;
            this.OpentoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpentoolButton.Name = "OpentoolButton";
            this.OpentoolButton.Size = new System.Drawing.Size(23, 22);
            this.OpentoolButton.Text = "Open";
            this.OpentoolButton.Click += new System.EventHandler(this.OpentoolButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SavetoolButton
            // 
            this.SavetoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavetoolButton.Enabled = false;
            this.SavetoolButton.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.Save_16x;
            this.SavetoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavetoolButton.Name = "SavetoolButton";
            this.SavetoolButton.Size = new System.Drawing.Size(23, 22);
            this.SavetoolButton.Text = "Save";
            this.SavetoolButton.Click += new System.EventHandler(this.SavetoolButton_Click);
            // 
            // SaveAstoolButton
            // 
            this.SaveAstoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAstoolButton.Enabled = false;
            this.SaveAstoolButton.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.SaveAs_16x;
            this.SaveAstoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAstoolButton.Name = "SaveAstoolButton";
            this.SaveAstoolButton.Size = new System.Drawing.Size(23, 22);
            this.SaveAstoolButton.Text = "Save As";
            this.SaveAstoolButton.Click += new System.EventHandler(this.SaveAstoolButton_Click);
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.StartPage);
            this.MainControl.Controls.Add(this.StatePage);
            this.MainControl.Controls.Add(this.FontPage);
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControl.Location = new System.Drawing.Point(0, 49);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(800, 401);
            this.MainControl.TabIndex = 5;
            // 
            // StartPage
            // 
            this.StartPage.BackColor = System.Drawing.SystemColors.Control;
            this.StartPage.Controls.Add(this.startPageVersionDesc);
            this.StartPage.Controls.Add(this.startPageLabel);
            this.StartPage.Controls.Add(this.StartPagePaddingPanel);
            this.StartPage.Controls.Add(this.StartPageControlPanel);
            this.StartPage.Location = new System.Drawing.Point(4, 22);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(792, 375);
            this.StartPage.TabIndex = 2;
            this.StartPage.Text = "StartPage";
            // 
            // startPageVersionDesc
            // 
            this.startPageVersionDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPageVersionDesc.Location = new System.Drawing.Point(3, 168);
            this.startPageVersionDesc.Name = "startPageVersionDesc";
            this.startPageVersionDesc.Size = new System.Drawing.Size(786, 41);
            this.startPageVersionDesc.TabIndex = 3;
            this.startPageVersionDesc.Text = "[Version]";
            this.startPageVersionDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startPageLabel
            // 
            this.startPageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPageLabel.Location = new System.Drawing.Point(3, 79);
            this.startPageLabel.Name = "startPageLabel";
            this.startPageLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.startPageLabel.Size = new System.Drawing.Size(786, 89);
            this.startPageLabel.TabIndex = 2;
            this.startPageLabel.Text = "[Product Info goes here]";
            this.startPageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // StartPagePaddingPanel
            // 
            this.StartPagePaddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartPagePaddingPanel.Location = new System.Drawing.Point(3, 3);
            this.StartPagePaddingPanel.Name = "StartPagePaddingPanel";
            this.StartPagePaddingPanel.Size = new System.Drawing.Size(786, 76);
            this.StartPagePaddingPanel.TabIndex = 1;
            // 
            // StartPageControlPanel
            // 
            this.StartPageControlPanel.Controls.Add(this.startPageOpenBtn);
            this.StartPageControlPanel.Controls.Add(this.startPageNewBtn);
            this.StartPageControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartPageControlPanel.Location = new System.Drawing.Point(3, 209);
            this.StartPageControlPanel.Name = "StartPageControlPanel";
            this.StartPageControlPanel.Padding = new System.Windows.Forms.Padding(60);
            this.StartPageControlPanel.Size = new System.Drawing.Size(786, 163);
            this.StartPageControlPanel.TabIndex = 0;
            // 
            // startPageOpenBtn
            // 
            this.startPageOpenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPageOpenBtn.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.OpenFolder_16x;
            this.startPageOpenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startPageOpenBtn.Location = new System.Drawing.Point(393, 60);
            this.startPageOpenBtn.Name = "startPageOpenBtn";
            this.startPageOpenBtn.Size = new System.Drawing.Size(333, 43);
            this.startPageOpenBtn.TabIndex = 3;
            this.startPageOpenBtn.Text = "Open";
            this.startPageOpenBtn.UseVisualStyleBackColor = true;
            this.startPageOpenBtn.Click += new System.EventHandler(this.startPageOpenBtn_Click);
            // 
            // startPageNewBtn
            // 
            this.startPageNewBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.startPageNewBtn.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.NewFile_16x;
            this.startPageNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startPageNewBtn.Location = new System.Drawing.Point(60, 60);
            this.startPageNewBtn.Name = "startPageNewBtn";
            this.startPageNewBtn.Size = new System.Drawing.Size(333, 43);
            this.startPageNewBtn.TabIndex = 2;
            this.startPageNewBtn.Text = "New";
            this.startPageNewBtn.UseVisualStyleBackColor = true;
            this.startPageNewBtn.Click += new System.EventHandler(this.startPageNewBtn_Click);
            // 
            // StatePage
            // 
            this.StatePage.Controls.Add(this.stateViewer);
            this.StatePage.Controls.Add(this.splitter1);
            this.StatePage.Controls.Add(this.treeViewPanel);
            this.StatePage.Location = new System.Drawing.Point(4, 22);
            this.StatePage.Name = "StatePage";
            this.StatePage.Padding = new System.Windows.Forms.Padding(3);
            this.StatePage.Size = new System.Drawing.Size(792, 375);
            this.StatePage.TabIndex = 0;
            this.StatePage.Text = "StatePage";
            this.StatePage.UseVisualStyleBackColor = true;
            // 
            // stateViewer
            // 
            this.stateViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.stateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateViewer.Location = new System.Drawing.Point(186, 3);
            this.stateViewer.Name = "stateViewer";
            this.stateViewer.Size = new System.Drawing.Size(603, 369);
            this.stateViewer.TabIndex = 8;
            this.stateViewer.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropGrids_PropertyValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.splitter1.Location = new System.Drawing.Point(183, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 369);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // treeViewPanel
            // 
            this.treeViewPanel.Controls.Add(this.stateView);
            this.treeViewPanel.Controls.Add(this.treeViewControls);
            this.treeViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewPanel.Location = new System.Drawing.Point(3, 3);
            this.treeViewPanel.Name = "treeViewPanel";
            this.treeViewPanel.Size = new System.Drawing.Size(180, 369);
            this.treeViewPanel.TabIndex = 0;
            // 
            // stateView
            // 
            this.stateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateView.Location = new System.Drawing.Point(0, 35);
            this.stateView.Name = "stateView";
            this.stateView.Size = new System.Drawing.Size(180, 334);
            this.stateView.TabIndex = 10;
            this.stateView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stateView_NodeMouseClick);
            // 
            // treeViewControls
            // 
            this.treeViewControls.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewControls.Controls.Add(this.deleteStateBtn);
            this.treeViewControls.Controls.Add(this.newStateBtn);
            this.treeViewControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeViewControls.Location = new System.Drawing.Point(0, 0);
            this.treeViewControls.Name = "treeViewControls";
            this.treeViewControls.Size = new System.Drawing.Size(180, 35);
            this.treeViewControls.TabIndex = 9;
            // 
            // deleteStateBtn
            // 
            this.deleteStateBtn.Enabled = false;
            this.deleteStateBtn.Location = new System.Drawing.Point(93, 6);
            this.deleteStateBtn.Name = "deleteStateBtn";
            this.deleteStateBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteStateBtn.TabIndex = 1;
            this.deleteStateBtn.Text = "Delete";
            this.deleteStateBtn.UseVisualStyleBackColor = true;
            this.deleteStateBtn.Click += new System.EventHandler(this.deleteStateBtn_Click);
            // 
            // newStateBtn
            // 
            this.newStateBtn.Location = new System.Drawing.Point(8, 6);
            this.newStateBtn.Name = "newStateBtn";
            this.newStateBtn.Size = new System.Drawing.Size(75, 23);
            this.newStateBtn.TabIndex = 0;
            this.newStateBtn.Text = "New";
            this.newStateBtn.UseVisualStyleBackColor = true;
            this.newStateBtn.Click += new System.EventHandler(this.newStateBtn_Click);
            // 
            // FontPage
            // 
            this.FontPage.Controls.Add(this.fontViewer);
            this.FontPage.Location = new System.Drawing.Point(4, 22);
            this.FontPage.Name = "FontPage";
            this.FontPage.Padding = new System.Windows.Forms.Padding(3);
            this.FontPage.Size = new System.Drawing.Size(792, 375);
            this.FontPage.TabIndex = 1;
            this.FontPage.Text = "FontPage";
            this.FontPage.UseVisualStyleBackColor = true;
            // 
            // fontViewer
            // 
            this.fontViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontViewer.Location = new System.Drawing.Point(3, 3);
            this.fontViewer.Name = "fontViewer";
            this.fontViewer.Size = new System.Drawing.Size(786, 369);
            this.fontViewer.TabIndex = 0;
            this.fontViewer.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropGrids_PropertyValueChanged);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAssetsFolderToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // setAssetsFolderToolStripMenuItem
            // 
            this.setAssetsFolderToolStripMenuItem.Name = "setAssetsFolderToolStripMenuItem";
            this.setAssetsFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setAssetsFolderToolStripMenuItem.Text = "Set Assets folder";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainControl);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Warspite Authoring Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.MainControl.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPageControlPanel.ResumeLayout(false);
            this.StatePage.ResumeLayout(false);
            this.treeViewPanel.ResumeLayout(false);
            this.treeViewControls.ResumeLayout(false);
            this.FontPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.HScrollBar treeViewControlsScroll;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton NewtoolButton;
        private System.Windows.Forms.ToolStripButton OpentoolButton;
        private System.Windows.Forms.ToolStripButton SavetoolButton;
        private System.Windows.Forms.ToolStripButton SaveAstoolButton;
        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Label startPageVersionDesc;
        private System.Windows.Forms.Label startPageLabel;
        private System.Windows.Forms.Panel StartPagePaddingPanel;
        private System.Windows.Forms.Panel StartPageControlPanel;
        private System.Windows.Forms.Button startPageOpenBtn;
        private System.Windows.Forms.Button startPageNewBtn;
        private System.Windows.Forms.TabPage StatePage;
        private System.Windows.Forms.PropertyGrid stateViewer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel treeViewPanel;
        private System.Windows.Forms.TreeView stateView;
        private System.Windows.Forms.Panel treeViewControls;
        private System.Windows.Forms.Button deleteStateBtn;
        private System.Windows.Forms.Button newStateBtn;
        private System.Windows.Forms.TabPage FontPage;
        private System.Windows.Forms.PropertyGrid fontViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAssetsFolderToolStripMenuItem;
    }
}

