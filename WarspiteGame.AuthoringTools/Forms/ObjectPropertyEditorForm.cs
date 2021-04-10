using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms
{
    public partial class ObjectPropertyEditorForm : Form
    {
        public List<ObjectProperty> CurrentProperties;
        private List<ObjectProperty> OldProperties;

        ObjectProperty SelectedProperty;

        private TreeNode _root;
        private const string _baseNewObject = "newProperty{0}";

        private bool _inDropDown = false;
        private bool _CancelClose = false;

        public ObjectPropertyEditorForm()
        {
            InitializeComponent();
        }

        private void RefreshObjectTree()
        {
            ObjectView.Nodes.Clear();
            _root = ObjectView.Nodes.Add(string.Format("Properties ({0})", CurrentProperties.Count));

            for (int i = 0; i < CurrentProperties.Count; i++)
            {
                _root.Nodes.Add(string.Format("{0} ({1})", CurrentProperties[i].name != string.Empty ? CurrentProperties[i].name : "<not defined>",
                    CurrentProperties[i].type != string.Empty ? CurrentProperties[i].type : "<not defined>"));
            }

            _root.Expand();
        }

        private void ChangeTitle()
        {
            if (SelectedProperty == null)
            {
                Text = string.Format("Property Editor");
            }
            else
            {
                Text = string.Format("Property Editor [{0}]", SelectedProperty.name);
            }
        }

        private void UpdateFields()
        {
            if (SelectedProperty != null)
            {
                if (EnumTools.GetPropEnum(SelectedProperty.type) == PropertyType.Bool)
                {
                    boolProp.Visible = true;
                    valueBox.Visible = false;
                }
                else
                {
                    boolProp.Visible = false;
                    valueBox.Visible = true;
                }

                nameBox.Text = SelectedProperty.name;
                typeBox.SelectedIndex = (int)EnumTools.GetPropEnum(SelectedProperty.type);
                valueBox.Text = SelectedProperty.value.ToString();
            }
        }

        private void SaveFields()
        {
            if (SelectedProperty != null)
            {
                SelectedProperty.name = nameBox.Text;
                SelectedProperty.type = EnumTools.GetEnumProp((PropertyType)typeBox.SelectedIndex);

                switch ((PropertyType)typeBox.SelectedIndex)
                {
                    case PropertyType.Object:
                    case PropertyType.Int:
                        try
                        {
                            SelectedProperty.value = int.Parse(valueBox.Text);
                        }
                        catch (Exception)
                        {
                            SelectedProperty.value = 0;
                        }
                        break;
                    case PropertyType.Float:
                        try
                        {
                            SelectedProperty.value = float.Parse(valueBox.Text);
                        }
                        catch (Exception)
                        {
                            SelectedProperty.value = 0.0;
                        }
                        break;
                    case PropertyType.Bool:
                        try
                        {
                            SelectedProperty.value = boolProp.Checked;
                        }
                        catch (Exception)
                        {
                            SelectedProperty.value = false;
                        }
                        break;
                    case PropertyType.String:
                    case PropertyType.File:
                    case PropertyType.Color:
                    default:
                        SelectedProperty.value = valueBox.Text;
                        break;
                };
            }
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                SelectedProperty = CurrentProperties[e.Node.Index];

                DeleteObjectToolStripBtn.Enabled = true;
                dupObjectToolStripBtn.Enabled = true;
                PropertyBox.Enabled = true;

                UpdateFields();
            }
            else
            {
                SelectedProperty = null;

                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
                PropertyBox.Enabled = false;
            }
            ChangeTitle();
        }

        private void ObjectPropertyEditorForm_Load(object sender, EventArgs e)
        {
            typeBox.Items.AddRange(Enum.GetNames(typeof(PropertyType)));

            RefreshObjectTree();
            ChangeTitle();

            string json = JsonConvert.SerializeObject(CurrentProperties);
            OldProperties = JsonConvert.DeserializeObject<List<ObjectProperty>>(json);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _CancelClose = false;
        }

        private void newObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            ObjectProperty op = new ObjectProperty();

            op.name = string.Format(_baseNewObject, "");
            op = checkForDuplicateObject(op, CurrentProperties, _baseNewObject);

            CurrentProperties.Add(op);
            RefreshObjectTree();
            ChangeTitle();
        }

        // Old code I dug up
        private ObjectProperty checkForDuplicateObject(ObjectProperty newObj, List<ObjectProperty> objects, string baseName,
            List<ObjectProperty> working = null, int iter = 0)
        {
            bool flag = false;

            if (working == null)
                working = new List<ObjectProperty>(objects);

            if (CurrentProperties != null)
            {
                foreach (ObjectProperty i in working)
                {
                    if (i.name == newObj.name)
                    {
                        // If we have found a duplicate, increment our name by one.
                        newObj.name = string.Format(baseName, string.Format("({0})", iter + 1));

                        // increment our counter remove the item checked from the list.
                        iter++;
                        working.Remove(i);
                        flag = true;
                    }

                    if (flag)
                    {
                        // Check again.
                        return checkForDuplicateObject(newObj, objects, baseName, working, iter);
                    }
                }
            }
            return newObj;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveFields();
        }

        private void DeleteObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProperty != null)
            {
                CurrentProperties.Remove(SelectedProperty);

                SelectedProperty = null;
                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
                PropertyBox.Enabled = false;

                RefreshObjectTree();

                ChangeTitle();
            }
        }

        private void dupObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (SelectedProperty != null)
            {
                string json = JsonConvert.SerializeObject(SelectedProperty);
                ObjectProperty op = JsonConvert.DeserializeObject<ObjectProperty>(json);

                op = checkForDuplicateObject(op, CurrentProperties, op.name + "-{0}");

                CurrentProperties.Add(op);
                RefreshObjectTree();

                ChangeTitle();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (!CurrentProperties.SequenceEqual(OldProperties))
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
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            SaveFields();
            RefreshObjectTree();
            UpdateFields();
        }

        private void boolProp_MouseDown(object sender, MouseEventArgs e)
        {
            SaveFields();
            RefreshObjectTree();
            UpdateFields();
        }

        private void typeBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void typeBox_MouseEnter(object sender, EventArgs e)
        {
            _inDropDown = true;
        }

        private void typeBox_MouseLeave(object sender, EventArgs e)
        {
            _inDropDown = false;
        }

        private void typeBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(_inDropDown)
            {
                SaveFields();
                RefreshObjectTree();
                UpdateFields();
            }
        }

        private void ObjectPropertyEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _CancelClose;
        }
    }
}