using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms
{
    public partial class DialogueEditorForm : Form
    {
        public List<SpeechNode> CurrentNodes;
        private List<SpeechNode> OldNodes;

        private Dictionary<SpeechNode, int> _currentNodes = new Dictionary<SpeechNode, int>();
        private int _currentNodeIndex = -1;
        private SpeechNode _currentNode;
        private TreeNode _root;

        private bool _inTypeDropDown = false;
        private bool _inNextDropDown = false;

        private bool _CancelClose = false;

        public DialogueEditorForm()
        {
            InitializeComponent();
        }

        private void RefreshObjectTree()
        {
            NodeView.Nodes.Clear();
            _currentNodes.Clear();

            _root = NodeView.Nodes.Add(string.Format("Nodes ({0})", CurrentNodes.Count));

            for (int i = 0; i < CurrentNodes.Count; i++)
            {
                _root.Nodes.Add(i.ToString());
                _currentNodes[CurrentNodes[i]] = i;
            }

            _root.Expand();
        }

        private void UpdateFields()
        {
            if (_currentNode != null)
            {
                nextNodeBox.Items.Clear();

                for (int i = 0; i < CurrentNodes.Count; i++)
                {
                    nextNodeBox.Items.Add(i);

                    if (CurrentNodes[i] == _currentNode)
                    {
                        _currentNodeIndex = i;
                    }
                }

                nameBox.Text = Regex.Replace(_currentNode.text, @"\n", "\r\n");
                typeBox.SelectedIndex = (int)EnumTools.GetNodeEnum(_currentNode.type);
                nextNodeBox.SelectedIndex = _currentNode.nextid;

            }
        }

        private void SaveFields()
        {
            if (_currentNode != null)
            {
                _currentNode.text = Regex.Replace(nameBox.Text, @"\r\n", "\n");
                _currentNode.type = EnumTools.GetEnumNode((SpeechNodeType)typeBox.SelectedIndex);
                _currentNode.nextid = nextNodeBox.SelectedIndex;
            }
        }

        private void UpdateToolbarButtons()
        {
            if (CurrentNodes.Count == 1 || _currentNodeIndex == -1)
            {
                shiftUpBtn.Enabled = false;
                shiftDownBtn.Enabled = false;
            }
            else if (_currentNodeIndex < 1)
            {
                shiftUpBtn.Enabled = false;
                shiftDownBtn.Enabled = true;
            }
            else if (_currentNodeIndex > CurrentNodes.Count - 2)
            {
                shiftUpBtn.Enabled = true;
                shiftDownBtn.Enabled = false;
            }
            else
            {
                shiftUpBtn.Enabled = true;
                shiftDownBtn.Enabled = true;
            }
        }

        private void newObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            SpeechNode sn = new SpeechNode();

            CurrentNodes.Add(sn);
            RefreshObjectTree();
            ChangeTitle();
        }

        private void DeleteObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (_currentNode != null)
            {
                CurrentNodes.Remove(_currentNode);

                _currentNode = null;
                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
                nameBox.Enabled = false;
                nextNodeBox.Enabled = false;
                PropertyBox.Enabled = false;

                UpdateToolbarButtons();
                RefreshObjectTree();

                ChangeTitle();
            }
        }

        private void dupObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (_currentNode != null)
            {
                string json = JsonConvert.SerializeObject(_currentNode);
                SpeechNode sn = JsonConvert.DeserializeObject<SpeechNode>(json);

                CurrentNodes.Add(sn);
                RefreshObjectTree();

                ChangeTitle();

                if (_currentNodeIndex == -1)
                    NodeView.SelectedNode = _root;
                else
                    NodeView.SelectedNode = _root.Nodes[_currentNodeIndex];
            }
        }

        private void shiftUpBtn_Click(object sender, EventArgs e)
        {
            CurrentNodes = ToolUtil.ShiftElement(CurrentNodes.ToArray(), _currentNodeIndex, _currentNodeIndex - 1).ToList();
            
            for (int i = 0; i < CurrentNodes.Count; i++)
            {
                if (CurrentNodes[i].nextid == _currentNodeIndex)
                {
                    CurrentNodes[i].nextid = _currentNodeIndex - 1;
                }
            }

            SaveFields();
            RefreshObjectTree();
            UpdateFields();
            UpdateToolbarButtons();
            ChangeTitle();

            if (_currentNodeIndex == -1)
                NodeView.SelectedNode = _root;
            else
                NodeView.SelectedNode = _root.Nodes[_currentNodeIndex];
        }

        private void shiftDownBtn_Click(object sender, EventArgs e)
        {
            CurrentNodes = ToolUtil.ShiftElement(CurrentNodes.ToArray(), _currentNodeIndex, _currentNodeIndex + 1).ToList();

            for (int i = 0; i < CurrentNodes.Count; i++)
            {
                if (CurrentNodes[i].nextid == _currentNodeIndex)
                {
                    CurrentNodes[i].nextid = _currentNodeIndex + 1;
                }
            }

            SaveFields();
            RefreshObjectTree();
            UpdateFields();
            UpdateToolbarButtons();
            ChangeTitle();

            if (_currentNodeIndex == -1) 
                NodeView.SelectedNode = _root;
            else
                NodeView.SelectedNode = _root.Nodes[_currentNodeIndex];
        }

        private void ChangeTitle()
        {
            if (_currentNode == null)
            {
                Text = string.Format("Dialogue Editor");
            }
            else
            {
                Text = string.Format("Dialogue Editor [{0}]", _currentNodes[_currentNode].ToString());
            }
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                _currentNode = CurrentNodes[e.Node.Index];

                DeleteObjectToolStripBtn.Enabled = true;
                dupObjectToolStripBtn.Enabled = true;
                PropertyBox.Enabled = true;

                UpdateFields();
            }
            else
            {
                _currentNode = null;
                _currentNodeIndex = -1;

                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
                PropertyBox.Enabled = false;
            }

            ChangeTitle();
            UpdateToolbarButtons();
        }

        private void nextNodeBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == _currentNodeIndex) //We are disabling item based on Index, you can have your logic here
            {
                e.Graphics.DrawString(nextNodeBox.Items[e.Index].ToString(), nextNodeBox.Font, Brushes.LightGray, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString(nextNodeBox.Items[e.Index].ToString(), nextNodeBox.Font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void nextNodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nextNodeBox.SelectedIndex == _currentNodeIndex)
                nextNodeBox.SelectedIndex = -1;

            if (_inNextDropDown)
            {
                SaveFields();
            }
        }

        private void DialogueEditorForm_Load(object sender, EventArgs e)
        {
            typeBox.Items.AddRange(Enum.GetNames(typeof(SpeechNodeType)));

            RefreshObjectTree();
            ChangeTitle();

            string json = JsonConvert.SerializeObject(CurrentNodes);
            OldNodes = JsonConvert.DeserializeObject<List<SpeechNode>>(json);
        }

        private void typeBox_MouseEnter(object sender, EventArgs e)
        {
            _inTypeDropDown = true;
        }

        private void typeBox_MouseLeave(object sender, EventArgs e)
        {
            _inTypeDropDown = false;
        }

        private void nextNodeBox_MouseEnter(object sender, EventArgs e)
        {
            _inNextDropDown = true;
        }

        private void nextNodeBox_MouseLeave(object sender, EventArgs e)
        {
            _inNextDropDown = false;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_inTypeDropDown)
            {
                SaveFields();
            }

            if (typeBox.SelectedIndex == 2)
            {
                nextNodeBox.Enabled = false;
                _currentNode.nextid = -1;
            }
            else
            {
                nextNodeBox.Enabled = true;
            }
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveFields();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _CancelClose = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (!CurrentNodes.SequenceEqual(OldNodes))
            {
                DialogResult result = MessageBox.Show(string.Format("Changes have been made!{0}Do you want to discard?", Environment.NewLine), AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;

                    _CancelClose = false;
                }
                else
                {
                    _CancelClose = true;
                }
            }
            else
            {
                _CancelClose = false;
            }
        }

        private void DialogueEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _CancelClose;
        }
    }
}
