using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms.Editors
{
    public partial class ObjectContainerEditorForm : Form
    {
        public List<ObjectContainer> CurrentObject;
        private List<ObjectContainer> OldObject;

        private TreeNode _root;
        private const string _baseNewObject = "New Object {0}";

        private bool _CancelClose = false;

        public ObjectContainerEditorForm()
        {
            InitializeComponent();
        }

        private void RefreshObjectTree()
        {
            ObjectView.Nodes.Clear();
            _root = ObjectView.Nodes.Add(string.Format("Objects ({0})", CurrentObject.Count));

            for (int i = 0; i < CurrentObject.Count; i++)
            {
                _root.Nodes.Add(string.Format("{0} ({1})", CurrentObject[i].name != string.Empty ? CurrentObject[i].name : "<not defined>", 
                    CurrentObject[i].type != string.Empty ? CurrentObject[i].type : "<not defined>"));
            }

            _root.Expand();
        }

        private void ChangeTitle()
        {
            if (ObjectViewer.SelectedObject == null)
            {
                Text = string.Format("Object Editor");
            }
            else
            {
                Text = string.Format("Object Editor [{0}]", ((ObjectContainer)ObjectViewer.SelectedObject).name);
            }
        }

        private void PropGrids_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // Check if the caller is the PropertyGrid
            if ((PropertyGrid)s == ObjectViewer)
            {
                RefreshObjectTree();
            }
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                ObjectViewer.SelectedObject = CurrentObject[e.Node.Index];

                DeleteObjectToolStripBtn.Enabled = true;
                dupObjectToolStripBtn.Enabled = true;
            }
            else
            {
                ObjectViewer.SelectedObject = null;

                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
            }
            ChangeTitle();
        }

        private void ObjectContainerEditor_Load(object sender, EventArgs e)
        {
            RefreshObjectTree();
            ChangeTitle();

            string json = JsonConvert.SerializeObject(CurrentObject);
            OldObject = JsonConvert.DeserializeObject<List<ObjectContainer>>(json);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _CancelClose = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (!CurrentObject.SequenceEqual(OldObject))
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

        private void newObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            ObjectContainer oc = new ObjectContainer();

            oc.name = string.Format(_baseNewObject, "");
            oc = checkForDuplicateObject(oc, CurrentObject, _baseNewObject);

            CurrentObject.Add(oc);
            RefreshObjectTree();
            ChangeTitle();
        }

        // Old code I dug up
        private ObjectContainer checkForDuplicateObject(ObjectContainer newObj, List<ObjectContainer> objects, string baseName,
            List<ObjectContainer> working = null, int iter = 0)
        {
            bool flag = false;

            if (working == null)
                working = new List<ObjectContainer>(objects);

            if (CurrentObject != null)
            {
                foreach (ObjectContainer i in working)
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

        private void DeleteObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (ObjectViewer.SelectedObject != null)
            {
                ObjectContainer delObj = (ObjectContainer)ObjectViewer.SelectedObject;

                if (delObj == null) return;

                ObjectViewer.SelectedObject = null;
                CurrentObject.Remove(delObj);

                DeleteObjectToolStripBtn.Enabled = false;
                dupObjectToolStripBtn.Enabled = false;
                RefreshObjectTree();

                ChangeTitle();
            }
        }

        private void dupObjectToolStripBtn_Click(object sender, EventArgs e)
        {
            if (ObjectViewer.SelectedObject != null)
            {
                ObjectContainer sOC = (ObjectContainer)ObjectViewer.SelectedObject;

                string json = JsonConvert.SerializeObject(sOC);
                ObjectContainer oc = JsonConvert.DeserializeObject<ObjectContainer>(json);

                oc = checkForDuplicateObject(oc, CurrentObject, oc.name + " {0}");

                CurrentObject.Add(oc);
                RefreshObjectTree();

                ChangeTitle();
            }
        }

        private void ObjectContainerEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _CancelClose;
        }
    }
}
