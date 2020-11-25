namespace WarspiteGame.AuthoringTools.Forms.Editors
{
    partial class ObjectContainerEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectContainerEditorForm));
            this.ObjectToolStrip = new System.Windows.Forms.ToolStrip();
            this.newObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dupObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ObjectView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ObjectViewer = new System.Windows.Forms.PropertyGrid();
            this.ObjectToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectToolStrip
            // 
            this.ObjectToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newObjectToolStripBtn,
            this.DeleteObjectToolStripBtn,
            this.toolStripSeparator1,
            this.dupObjectToolStripBtn});
            this.ObjectToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ObjectToolStrip.Name = "ObjectToolStrip";
            this.ObjectToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ObjectToolStrip.TabIndex = 13;
            this.ObjectToolStrip.Text = "toolStrip1";
            // 
            // newObjectToolStripBtn
            // 
            this.newObjectToolStripBtn.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.NewProperty_16x;
            this.newObjectToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newObjectToolStripBtn.Name = "newObjectToolStripBtn";
            this.newObjectToolStripBtn.Size = new System.Drawing.Size(51, 22);
            this.newObjectToolStripBtn.Text = "New";
            this.newObjectToolStripBtn.Click += new System.EventHandler(this.newObjectToolStripBtn_Click);
            // 
            // DeleteObjectToolStripBtn
            // 
            this.DeleteObjectToolStripBtn.Enabled = false;
            this.DeleteObjectToolStripBtn.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.DeleteProperty_16x;
            this.DeleteObjectToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteObjectToolStripBtn.Name = "DeleteObjectToolStripBtn";
            this.DeleteObjectToolStripBtn.Size = new System.Drawing.Size(60, 22);
            this.DeleteObjectToolStripBtn.Text = "Delete";
            this.DeleteObjectToolStripBtn.Click += new System.EventHandler(this.DeleteObjectToolStripBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dupObjectToolStripBtn
            // 
            this.dupObjectToolStripBtn.Enabled = false;
            this.dupObjectToolStripBtn.Image = global::WarspiteGame.AuthoringTools.Properties.Resources.Copy_16x;
            this.dupObjectToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dupObjectToolStripBtn.Name = "dupObjectToolStripBtn";
            this.dupObjectToolStripBtn.Size = new System.Drawing.Size(77, 22);
            this.dupObjectToolStripBtn.Text = "Duplicate";
            this.dupObjectToolStripBtn.Click += new System.EventHandler(this.dupObjectToolStripBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 14;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(627, 8);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(713, 8);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ObjectView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel3.Size = new System.Drawing.Size(200, 385);
            this.panel3.TabIndex = 16;
            // 
            // ObjectView
            // 
            this.ObjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectView.Location = new System.Drawing.Point(0, 0);
            this.ObjectView.Name = "ObjectView";
            this.ObjectView.Size = new System.Drawing.Size(199, 385);
            this.ObjectView.TabIndex = 0;
            this.ObjectView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stateView_NodeMouseClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 385);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // ObjectViewer
            // 
            this.ObjectViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ObjectViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectViewer.Location = new System.Drawing.Point(203, 25);
            this.ObjectViewer.Name = "ObjectViewer";
            this.ObjectViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ObjectViewer.Size = new System.Drawing.Size(597, 385);
            this.ObjectViewer.TabIndex = 18;
            this.ObjectViewer.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropGrids_PropertyValueChanged);
            // 
            // ObjectContainerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ObjectViewer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ObjectToolStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectContainerEditorForm";
            this.Text = "Object Editor";
            this.Load += new System.EventHandler(this.ObjectContainerEditor_Load);
            this.ObjectToolStrip.ResumeLayout(false);
            this.ObjectToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ObjectToolStrip;
        private System.Windows.Forms.ToolStripButton newObjectToolStripBtn;
        private System.Windows.Forms.ToolStripButton DeleteObjectToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton dupObjectToolStripBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView ObjectView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PropertyGrid ObjectViewer;
    }
}