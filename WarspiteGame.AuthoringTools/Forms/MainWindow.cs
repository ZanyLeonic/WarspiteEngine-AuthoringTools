using System;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
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

        // Original loaded from disk
        private WarspiteStateFile _Ows;
        private FontFile _Off;

        // Modified values
        private WarspiteStateFile _ws;
        private FontFile _ff;

        private readonly OpenFileDialog _op;
        private readonly SaveFileDialog _sd;

        private MainWindowState _state = MainWindowState.StateNone;

        private string _workingFilePath = "";
        private string _baseTitle = String.Format("Warspite Authoring Tools ({0}/{1})", ToolMetadata.BuildNumber,
            ToolMetadata.HeadDesc);

        public MainWindow()
        {
            InitializeComponent();

            this.Text = _baseTitle;

            // Make the tabs invisible
            MainControl.Appearance = TabAppearance.FlatButtons; 
            MainControl.ItemSize = new Size(0, 1); 
            MainControl.SizeMode = TabSizeMode.Fixed;

            _op = new OpenFileDialog();
            _op.Title = "Open";
            _op.FileName = "";
            _op.Filter = "JSON Files|*.json|All Files |*.*";

            _sd = new SaveFileDialog();
            _sd.Title = "Save";
            _sd.FileName = "";
            _sd.Filter = "JSON Files|*.json|All Files |*.*";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEngineJson();
        }

        private void OpenEngineJson()
        {
            DialogResult res = _op.ShowDialog();

            if (res == DialogResult.OK && _op.FileName != string.Empty)
            {
                string sText = File.ReadAllText(_op.FileName);
                JObject t = JsonConvert.DeserializeObject<JObject>(sText);

                // Can't determine the type - give up.
                if (!t.ContainsKey("type"))
                {
                    MessageBox.Show("The selected file is not a valid Warspite Engine JSON", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Show the correct page determining on what we are viewing
                try
                {
                    switch (t["type"].ToString())
                    {
                        case "StateFile":
                            _workingFilePath = _op.FileName;
                            StateFormSetup(sText);
                            break;
                        case "FontFile":
                            _workingFilePath = _op.FileName;
                            FontFormSetup(sText);
                            break;
                        default:
                            MessageBox.Show("Warspite Engine JSON not supported by this version", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show(string.Format("Something went wrong while loading the JSON - please verify the validity of the JSON.{0}Error:{0}{1}", Environment.NewLine, e.Message), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveEngineJson(string savePath)
        {
            try
            {
                switch (_state)
                {
                    case MainWindowState.StateStatePage:
                        File.WriteAllText(savePath, JsonConvert.SerializeObject(_ws, Formatting.Indented));
                        break;
                    case MainWindowState.StateFontPage:
                        File.WriteAllText(savePath, JsonConvert.SerializeObject(_ff, Formatting.Indented));
                        break;
                    default:
                        MessageBox.Show(string.Format("No supported save method for type \"{0}\"", _state.ToString()),"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error while saving file.{0}Error:{0}{1}", Environment.NewLine, e.Message), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StateFormSetup(string json)
        {
            _Ows = JsonConvert.DeserializeObject<WarspiteStateFile>(json);
            _ws = JsonConvert.DeserializeObject<WarspiteStateFile>(json);

            stateView.Nodes.Clear();
            _root = stateView.Nodes.Add("States");

            for (int i = 0; i < _ws.states.Length; i++)
            {
                _root.Nodes.Add(_ws.states[i].id);
            }

            _state = MainWindowState.StateStatePage;

            SetupEditForm();
        }

        private void FontFormSetup(string json)
        {
            _Off = JsonConvert.DeserializeObject<FontFile>(json);
            _ff = JsonConvert.DeserializeObject<FontFile>(json);

            propertyGrid1.SelectedObject = _ff;

            _state = MainWindowState.StateFontPage;

            SetupEditForm();
        }

        private void SetupEditForm()
        {
            Text = string.Format("[{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle);
            MainControl.SelectedTab = MainControl.TabPages[(int)_state];

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
        }

        private void CheckForChanges()
        {
            bool bChanged = false;

            switch (_state)
            {
                case MainWindowState.StateStatePage:
                    bChanged = !_ws.Equals(_Ows);
                    break;
                case MainWindowState.StateFontPage:
                    bChanged = !_ff.Equals(_Off);
                    break;
            }

            Text = bChanged ? string.Format("[*{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle) : string.Format("[{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle); ;
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                stateViewer.SelectedObject = _ws.states[e.Node.Index];
            }

            CheckForChanges();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();

            ab.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _state = MainWindowState.StateStartPage;
            startPageLabel.Text = AssemblyAccessors.AssemblyTitle;
        }

        private void startPageOpenBtn_Click(object sender, EventArgs e)
        {
            OpenEngineJson();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_state == MainWindowState.StateStartPage || _state == MainWindowState.StateNone)
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
            }
            else
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_workingFilePath == string.Empty)
            {
                _sd.FileName = "untitled.json";

                // Don't try to save if OK was not pressed
                if (_sd.ShowDialog() != DialogResult.OK) return;
                _workingFilePath = _sd.FileName;
            }
            SaveEngineJson(_workingFilePath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sd.FileName = Path.GetFileName(_workingFilePath);

            // Don't try to save if OK was not pressed
            if (_sd.ShowDialog() != DialogResult.OK) return;
            _workingFilePath = _sd.FileName;

            SaveEngineJson(_workingFilePath);
        }

        private void stateViewer_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            CheckForChanges();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            CheckForChanges();
        }
    }
}
