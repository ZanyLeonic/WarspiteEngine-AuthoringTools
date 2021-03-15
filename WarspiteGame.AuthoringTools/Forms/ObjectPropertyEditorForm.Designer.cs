
namespace WarspiteGame.AuthoringTools.Forms
{
    partial class ObjectPropertyEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectPropertyEditorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.PropertyBox = new System.Windows.Forms.GroupBox();
            this.boolProp = new System.Windows.Forms.CheckBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectToolStrip = new System.Windows.Forms.ToolStrip();
            this.newObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dupObjectToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.ObjectView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.PropertyBox.SuspendLayout();
            this.ObjectToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 40);
            this.panel1.TabIndex = 15;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(448, 11);
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
            this.OkBtn.Location = new System.Drawing.Point(362, 11);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "&OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // PropertyBox
            // 
            this.PropertyBox.Controls.Add(this.boolProp);
            this.PropertyBox.Controls.Add(this.valueBox);
            this.PropertyBox.Controls.Add(this.nameBox);
            this.PropertyBox.Controls.Add(this.typeBox);
            this.PropertyBox.Controls.Add(this.label3);
            this.PropertyBox.Controls.Add(this.label2);
            this.PropertyBox.Controls.Add(this.label1);
            this.PropertyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyBox.Enabled = false;
            this.PropertyBox.Location = new System.Drawing.Point(202, 28);
            this.PropertyBox.Name = "PropertyBox";
            this.PropertyBox.Size = new System.Drawing.Size(331, 116);
            this.PropertyBox.TabIndex = 16;
            this.PropertyBox.TabStop = false;
            this.PropertyBox.Text = "Property";
            // 
            // boolProp
            // 
            this.boolProp.AutoSize = true;
            this.boolProp.Location = new System.Drawing.Point(55, 72);
            this.boolProp.Name = "boolProp";
            this.boolProp.Size = new System.Drawing.Size(15, 14);
            this.boolProp.TabIndex = 6;
            this.boolProp.UseVisualStyleBackColor = true;
            this.boolProp.Visible = false;
            this.boolProp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boolProp_MouseDown);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(51, 70);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(243, 20);
            this.valueBox.TabIndex = 5;
            this.valueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(51, 17);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(243, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(51, 43);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(243, 21);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged_1);
            this.typeBox.MouseEnter += new System.EventHandler(this.typeBox_MouseEnter);
            this.typeBox.MouseLeave += new System.EventHandler(this.typeBox_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
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
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // ObjectToolStrip
            // 
            this.ObjectToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newObjectToolStripBtn,
            this.DeleteObjectToolStripBtn,
            this.toolStripSeparator1,
            this.dupObjectToolStripBtn});
            this.ObjectToolStrip.Location = new System.Drawing.Point(3, 3);
            this.ObjectToolStrip.Name = "ObjectToolStrip";
            this.ObjectToolStrip.Size = new System.Drawing.Size(530, 25);
            this.ObjectToolStrip.TabIndex = 18;
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
            // ObjectView
            // 
            this.ObjectView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ObjectView.Location = new System.Drawing.Point(3, 28);
            this.ObjectView.Name = "ObjectView";
            this.ObjectView.Size = new System.Drawing.Size(199, 116);
            this.ObjectView.TabIndex = 17;
            this.ObjectView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stateView_NodeMouseClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(202, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 116);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // ObjectPropertyEditorForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(536, 187);
            this.ControlBox = false;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PropertyBox);
            this.Controls.Add(this.ObjectView);
            this.Controls.Add(this.ObjectToolStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectPropertyEditorForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Property Editor";
            this.Load += new System.EventHandler(this.ObjectPropertyEditorForm_Load);
            this.panel1.ResumeLayout(false);
            this.PropertyBox.ResumeLayout(false);
            this.PropertyBox.PerformLayout();
            this.ObjectToolStrip.ResumeLayout(false);
            this.ObjectToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox PropertyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.CheckBox boolProp;
        private System.Windows.Forms.ToolStrip ObjectToolStrip;
        private System.Windows.Forms.ToolStripButton newObjectToolStripBtn;
        private System.Windows.Forms.ToolStripButton DeleteObjectToolStripBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton dupObjectToolStripBtn;
        private System.Windows.Forms.TreeView ObjectView;
        private System.Windows.Forms.Splitter splitter1;
    }
}