using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Reflection;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms
{
    public partial class MainWindow : Form
    {
        private TreeNode _root;
        private WarspiteStateFile _ws;

        private readonly OpenFileDialog _op;
        private readonly SaveFileDialog _sd;

        public MainWindow()
        {
            InitializeComponent();

            this.Text = String.Format("Warspite Authoring Tools ({0}/{1})", ToolMetadata.BuildNumber,
                ToolMetadata.HeadDesc);

            MainControl.Appearance = TabAppearance.FlatButtons; 
            MainControl.ItemSize = new Size(0, 1); 
            MainControl.SizeMode = TabSizeMode.Fixed;

            _op = new OpenFileDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEngineJSON();
        }

        private void OpenEngineJSON()
        {
            _op.Title = "Open a Warspite JSON...";
            _op.FileName = "";
            _op.Filter = "JSON File|*.json|All Files |*.*";

            DialogResult res = _op.ShowDialog();

            if (res == DialogResult.OK && _op.FileName != string.Empty)
            {
                string sText = File.ReadAllText(_op.FileName);
                JObject t = JsonConvert.DeserializeObject<JObject>(sText);

                // Can't determine the type
                if (!t.ContainsKey("type"))
                {
                    MessageBox.Show("The selected file is not a valid Warspite Engine JSON", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (t["type"].ToString())
                {
                    case "StateFile":
                        StateFormSetup(sText);
                        break;
                    case "FontFile":
                        break;
                    default:
                        MessageBox.Show("Warspite Engine JSON not supported by this version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void StateFormSetup(string json)
        {
            _ws = JsonConvert.DeserializeObject<WarspiteStateFile>(json);

            stateView.Nodes.Clear();
            _root = stateView.Nodes.Add("States");

            for (int i = 0; i < _ws.States.Length; i++)
            {
                _root.Nodes.Add(_ws.States[i].ID);
            }

            MainControl.SelectedTab = MainControl.TabPages[1];

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                stateViewer.SelectedObject = _ws.States[e.Node.Index];
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();

            ab.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            startPageLabel.Text = AssemblyAccessors.AssemblyTitle;
        }

        private void startPageOpenBtn_Click(object sender, EventArgs e)
        {
            OpenEngineJSON();
        }
    }
}
