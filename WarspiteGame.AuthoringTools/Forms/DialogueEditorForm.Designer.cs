
namespace WarspiteGame.AuthoringTools.Forms
{
    partial class DialogueEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueEditorForm));
            this.ObjectToolStrip = new System.Windows.Forms.ToolStrip();
            this.newObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dupObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shiftUpBtn = new System.Windows.Forms.ToolStripButton();
            this.shiftDownBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NodeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PropertyBox = new System.Windows.Forms.GroupBox();
            this.nextNodeBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PropertyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectToolStrip
            // 
            this.ObjectToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newObjectToolStripBtn,
            this.DeleteObjectToolStripBtn,
            this.toolStripSeparator1,
            this.dupObjectToolStripBtn,
            this.toolStripSeparator2,
            this.shiftUpBtn,
            this.shiftDownBtn});
            this.ObjectToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ObjectToolStrip.Name = "ObjectToolStrip";
            this.ObjectToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ObjectToolStrip.TabIndex = 19;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shiftUpBtn
            // 
            this.shiftUpBtn.Enabled = false;
            this.shiftUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("shiftUpBtn.Image")));
            this.shiftUpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shiftUpBtn.Name = "shiftUpBtn";
            this.shiftUpBtn.Size = new System.Drawing.Size(69, 22);
            this.shiftUpBtn.Text = "Shift Up";
            this.shiftUpBtn.Click += new System.EventHandler(this.shiftUpBtn_Click);
            // 
            // shiftDownBtn
            // 
            this.shiftDownBtn.Enabled = false;
            this.shiftDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("shiftDownBtn.Image")));
            this.shiftDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shiftDownBtn.Name = "shiftDownBtn";
            this.shiftDownBtn.Size = new System.Drawing.Size(85, 22);
            this.shiftDownBtn.Text = "Shift Down";
            this.shiftDownBtn.Click += new System.EventHandler(this.shiftDownBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 20;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(714, 8);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.Location = new System.Drawing.Point(628, 8);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "&OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NodeView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel3.Size = new System.Drawing.Size(200, 391);
            this.panel3.TabIndex = 21;
            // 
            // NodeView
            // 
            this.NodeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NodeView.Location = new System.Drawing.Point(0, 0);
            this.NodeView.Name = "NodeView";
            this.NodeView.Size = new System.Drawing.Size(199, 391);
            this.NodeView.TabIndex = 0;
            this.NodeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stateView_NodeMouseClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 391);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PropertyBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(600, 391);
            this.panel2.TabIndex = 23;
            // 
            // PropertyBox
            // 
            this.PropertyBox.Controls.Add(this.nextNodeBox);
            this.PropertyBox.Controls.Add(this.nameBox);
            this.PropertyBox.Controls.Add(this.typeBox);
            this.PropertyBox.Controls.Add(this.label3);
            this.PropertyBox.Controls.Add(this.label2);
            this.PropertyBox.Controls.Add(this.label1);
            this.PropertyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyBox.Enabled = false;
            this.PropertyBox.Location = new System.Drawing.Point(3, 3);
            this.PropertyBox.Name = "PropertyBox";
            this.PropertyBox.Size = new System.Drawing.Size(594, 385);
            this.PropertyBox.TabIndex = 25;
            this.PropertyBox.TabStop = false;
            this.PropertyBox.Text = "Property";
            // 
            // nextNodeBox
            // 
            this.nextNodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextNodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nextNodeBox.FormattingEnabled = true;
            this.nextNodeBox.Location = new System.Drawing.Point(78, 355);
            this.nextNodeBox.Name = "nextNodeBox";
            this.nextNodeBox.Size = new System.Drawing.Size(505, 21);
            this.nextNodeBox.TabIndex = 5;
            this.nextNodeBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.nextNodeBox_DrawItem);
            this.nextNodeBox.SelectedIndexChanged += new System.EventHandler(this.nextNodeBox_SelectedIndexChanged);
            this.nextNodeBox.MouseEnter += new System.EventHandler(this.nextNodeBox_MouseEnter);
            this.nextNodeBox.MouseLeave += new System.EventHandler(this.nextNodeBox_MouseLeave);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(78, 17);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(505, 305);
            this.nameBox.TabIndex = 4;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(78, 328);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(505, 21);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            this.typeBox.MouseEnter += new System.EventHandler(this.typeBox_MouseEnter);
            this.typeBox.MouseLeave += new System.EventHandler(this.typeBox_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Next Node:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // DialogueEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.ControlBox = false;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ObjectToolStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DialogueEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialogue Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogueEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.DialogueEditorForm_Load);
            this.ObjectToolStrip.ResumeLayout(false);
            this.ObjectToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PropertyBox.ResumeLayout(false);
            this.PropertyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ObjectToolStrip;
        private System.Windows.Forms.ToolStripButton newObjectToolStripBtn;
        private System.Windows.Forms.ToolStripButton DeleteObjectToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton dupObjectToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton shiftUpBtn;
        private System.Windows.Forms.ToolStripButton shiftDownBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView NodeView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox PropertyBox;
        private System.Windows.Forms.ComboBox nextNodeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}