using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private DialogueFile _Odf;

        // Modified values
        private WarspiteStateFile _ws;
        private FontFile _ff;
        private DialogueFile _df;

        private readonly OpenFileDialog _op;
        private readonly SaveFileDialog _sd;

        private MainWindowState _state = MainWindowState.StateNone;

        private string _workingFilePath = "";
        private string _baseTitle = String.Format("Warspite Authoring Tools ({0}/{1}/{2})", ToolMetadata.BuildNumber,
            ToolMetadata.HeadDesc, AssemblyAccessors.AssemblyVersion);

        private const string _baseNewState = "New State {0}";

        private bool newFile = false;

        public MainWindowState GetWindowState()
        {
            return _state;
        }

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

        private int GetEditorPage()
        {
            switch(_state)
            {
                case MainWindowState.StateStartPage:
                    return 0;
                case MainWindowState.StateStatePage:
                    return 1;
                case MainWindowState.StateFontPage:
                case MainWindowState.StateDialoguePage:
                    return 2;
                default:
                    return -1;
            }
        }

        public void CheckLaunchParams()
        {
            string[] arguments = Environment.GetCommandLineArgs();

            // If we just have the exe, ignore.
            if (arguments.Length <= 1) return;

            // We are being called by the setup!
            if (arguments[1] == "/setup")
            {
                // assume this
                string exe = arguments[2];
                string assets = arguments[3];

                if (!File.Exists(exe))
                {
                    File.WriteAllText(@"C:\Users\Kurisu\Desktop\exe doesnt exist.txt", exe + Environment.NewLine + assets);
                    Environment.Exit(-1);
                }
                if (!Directory.Exists(assets))
                {
                    File.WriteAllText(@"C:\Users\Kurisu\Desktop\assets doesnt exist.txt", exe + Environment.NewLine + assets);
                    Environment.Exit(-1);
                }

                // Save these and exit.
                Properties.Settings.Default.GameExecutable = exe;
                Properties.Settings.Default.AssetsPath = assets;
                Properties.Settings.Default.Save();

                Environment.Exit(0);
            }

            string fileName = arguments[1];

            // Check if the path given exists
            if (!File.Exists(fileName))
            {
                // If not, display an error.
                MessageBox.Show("The specified file does not exist.", AssemblyAccessors.AssemblyTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sText = File.ReadAllText(fileName);
            JObject t = JsonConvert.DeserializeObject<JObject>(sText);

            // Can't determine the type - give up.
            if (!t.ContainsKey("type"))
            {
                MessageBox.Show("The selected file is not a valid Warspite Engine JSON", AssemblyAccessors.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the correct page determining on what we are viewing
            try
            {
                switch (t["type"].ToString())
                {
                    case "StateFile":
                        _workingFilePath = fileName;
                        StateFormSetup(sText);
                        break;
                    case "FontFile":
                        _workingFilePath = fileName;
                        FontFormSetup(sText);
                        break;
                    default:
                        MessageBox.Show("Warspite Engine JSON not supported by this version", AssemblyAccessors.AssemblyTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(string.Format("Something went wrong while loading the JSON - please verify the validity of the JSON.{0}Error:{0}{1}", Environment.NewLine, e.Message), AssemblyAccessors.AssemblyTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateButtons();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEngineJson();
        }

        private void ChangeTitle()
        {
            bool bChanged = CheckForChanges();
            Text = bChanged ? string.Format("[*{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle)
                : string.Format("[{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle);
        }

        private void UpdateButtons()
        {
            if (_state == MainWindowState.StateStartPage || _state == MainWindowState.StateNone)
            {
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                SavetoolButton.Enabled = false;
                SaveAstoolButton.Enabled = false;
            }
            else
            {
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                SavetoolButton.Enabled = true;
                SaveAstoolButton.Enabled = true;
            }
        }

        private void NewEngineJson()
        {
            bool bChanged = CheckForChanges();

            if (bChanged)
            {
                DialogResult dr = MessageBox.Show(String.Format("Do you want to save changes to \"{0}\"?",
                        Path.GetFileName(_workingFilePath)),
                    AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveCommand();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            NewFileSelector nfs = new NewFileSelector();
            if(nfs.ShowDialog() == DialogResult.Cancel) return;

            switch (nfs.ChosenType)
            {
                case EngineJsonType.State:
                    _Ows = new WarspiteStateFile();
                    _ws = new WarspiteStateFile();
                    _state = MainWindowState.StateStatePage;
                    stateViewer.SelectedObject = null;
                    deleteStateBtn.Enabled = false;

                    RefreshStateTree();
                    break;
                case EngineJsonType.Font:
                    _Off = new FontFile();
                    _ff = new FontFile();
                    _state = MainWindowState.StateFontPage;
                    dataViewer.SelectedObject = _ff;
                
                    break;
                case EngineJsonType.Dialogue:
                    _Odf = new DialogueFile();
                    _df = new DialogueFile();

                    _state = MainWindowState.StateDialoguePage;
                    dataViewer.SelectedObject = _df;

                    break;
            }

            if (_state != MainWindowState.StateNone || _state != MainWindowState.StateStartPage)
            {
                newFile = true;

                if (_state == MainWindowState.StateDialoguePage)
                    _workingFilePath = Path.Combine(ToolUtil.GetWorkingDirectory(), "untitled.diag").ToString();
                else
                    _workingFilePath = Path.Combine(ToolUtil.GetWorkingDirectory(), "untitled.json").ToString();

                SetupEditForm();
            }
            UpdateButtons();
        }

        private void OpenEngineJson()
        {
            bool bChanged = CheckForChanges();

            if (bChanged)
            {
                DialogResult dr = MessageBox.Show(String.Format("Do you want to save changes to \"{0}\"?",
                        Path.GetFileName(_workingFilePath)),
                    AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveCommand();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            DialogResult res = _op.ShowDialog();

            if (res == DialogResult.OK && _op.FileName != string.Empty)
            {
                string sText = File.ReadAllText(_op.FileName);
                JObject t = JsonConvert.DeserializeObject<JObject>(sText);

                // Can't determine the type - give up.
                if (!t.ContainsKey("type"))
                {
                    MessageBox.Show("The selected file is not a valid Warspite Engine JSON", AssemblyAccessors.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Warspite Engine JSON not supported by this version", AssemblyAccessors.AssemblyTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show(string.Format("Something went wrong while loading the JSON - please verify the validity of the JSON.{0}Error:{0}{1}", Environment.NewLine, e.Message), AssemblyAccessors.AssemblyTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateButtons();
        }

        private void SaveEngineJson(string savePath)
        {
            try
            {
                string json = "";
                switch (_state)
                {
                    case MainWindowState.StateStatePage:
                        json = JsonConvert.SerializeObject(_ws, Formatting.Indented);
                        File.WriteAllText(savePath, json);
                        _Ows = JsonConvert.DeserializeObject<WarspiteStateFile>(json);
                        break;
                    case MainWindowState.StateFontPage:
                        json = JsonConvert.SerializeObject(_ff, Formatting.Indented); 
                        File.WriteAllText(savePath, json);
                        _Off = JsonConvert.DeserializeObject<FontFile>(json);
                        break;
                    default:
                        MessageBox.Show(string.Format("No supported save method for type \"{0}\"", _state.ToString()), 
                            AssemblyAccessors.AssemblyTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                ChangeTitle();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error while saving file.{0}Error:{0}{1}", Environment.NewLine, e.Message), 
                    AssemblyAccessors.AssemblyTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CheckForChanges();
            UpdateButtons();
        }

        private void SaveCommand()
        {
            if (_workingFilePath == string.Empty || newFile)
            {
                _sd.FileName = "untitled.json";

                // Don't try to save if OK was not pressed
                if (_sd.ShowDialog() != DialogResult.OK) return;
                _workingFilePath = _sd.FileName;
                newFile = false;
            }
            SaveEngineJson(_workingFilePath);
        }

        private void SaveAsCommand()
        {
            _sd.FileName = Path.GetFileName(_workingFilePath);

            // Don't try to save if OK was not pressed
            if (_sd.ShowDialog() != DialogResult.OK) return;
            _workingFilePath = _sd.FileName;

            SaveEngineJson(_workingFilePath);
        }

        private void StateFormSetup(string json)
        {
            stateViewer.SelectedObject = null;

            _Ows = _deserialiseStateJSON(json);
            _ws = _deserialiseStateJSON(json);

            RefreshStateTree();

            _state = MainWindowState.StateStatePage;

            SetupEditForm();
        }

        private void FontFormSetup(string json)
        {
            _Off = JsonConvert.DeserializeObject<FontFile>(json);
            _ff = JsonConvert.DeserializeObject<FontFile>(json);

            dataViewer.SelectedObject = _ff;

            _state = MainWindowState.StateFontPage;

            SetupEditForm();
        }

        private void SetupEditForm()
        {
            Text = string.Format("[{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle);
            MainControl.SelectedTab = MainControl.TabPages[GetEditorPage()];

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
        }

        private void LaunchEngine()
        {
            string _debugger = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "WarspiteGame.AuthoringTools.Debugger.exe");

            if (File.Exists(_debugger) && File.Exists(Properties.Settings.Default.GameExecutable))
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                
                p.StartInfo.WorkingDirectory = Path.GetFullPath(_debugger).Replace(
                    Path.GetFileName(_debugger), "");
                p.StartInfo.FileName = _debugger;
                p.StartInfo.Arguments = Properties.Settings.Default.GameExecutable;

                p.Start();
            }
            else if (System.IO.File.Exists(Properties.Settings.Default.GameExecutable))
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.WorkingDirectory = Path.GetFullPath(Properties.Settings.Default.GameExecutable).Replace(
                    Path.GetFileName(Properties.Settings.Default.GameExecutable), "");
                p.StartInfo.FileName = Properties.Settings.Default.GameExecutable;

                p.Start();
            }
        }

        private bool CheckForChanges()
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
                case MainWindowState.StateDialoguePage:
                    bChanged = !_df.Equals(_Odf);
                    break;
            }

            return bChanged;
        }

        private void stateView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != _root)
            {
                stateViewer.SelectedObject = _ws.states[e.Node.Index];
                deleteStateBtn.Enabled = true;
            }
            else
            {
                stateViewer.SelectedObject = null;
                deleteStateBtn.Enabled = false;
            }

            bool bChanged = CheckForChanges();
            Text = bChanged ? string.Format("[*{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle)
                : string.Format("[{0}] - {1}", Path.GetFileName(_workingFilePath), _baseTitle);
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

            startPageVersionDesc.Text = string.Format("Version: {4}{2}Build: ({0}/{1}){2}Tree: {3}", 
                ToolMetadata.BuildNumber, ToolMetadata.HeadDesc, Environment.NewLine, 
                ToolMetadata.HeadShaShort, AssemblyAccessors.AssemblyVersion);
            
            UpdateButtons();
            CheckLaunchParams();

            if (Properties.Settings.Default.AssetsPath == string.Empty
                || Properties.Settings.Default.GameExecutable == string.Empty)
            {
                MessageBox.Show("One or more paths are not set.\nPlease check your paths.", AssemblyAccessors.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ConfigWindow cw = new ConfigWindow();
                cw.ShowDialog();
            }    
            else if (!System.IO.Directory.Exists(Properties.Settings.Default.AssetsPath) 
                || !System.IO.File.Exists(Properties.Settings.Default.GameExecutable))
            {
                MessageBox.Show("One or more paths are invalid.\nPlease check your paths.", AssemblyAccessors.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ConfigWindow cw = new ConfigWindow();
                cw.ShowDialog();
            }
        }

        private void startPageOpenBtn_Click(object sender, EventArgs e)
        {
            OpenEngineJson();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCommand();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsCommand();
        }

        private void PropGrids_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            ChangeTitle();

            if ((PropertyGrid) s == stateViewer)
            {
                RefreshStateTree();
            }
        }

        private void startPageNewBtn_Click(object sender, EventArgs e)
        {
            NewEngineJson();
        }

        private void ExitPrompt()
        {
            DialogResult dr = MessageBox.Show(String.Format("Do you want to save changes to \"{0}\"?", 
                    Path.GetFileName(_workingFilePath)),
                AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.Yes:
                    SaveCommand();
                    break;
                case DialogResult.No:
                    Environment.Exit(0);
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool bChanged = CheckForChanges();

            if (bChanged)
            {
                e.Cancel = true;
                ExitPrompt();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStateBtn_Click(object sender, EventArgs e)
        {
            WarspiteState ws = new WarspiteState();

            ws.id = string.Format(_baseNewState, "");
            ws = checkForDuplicateState(ws, _ws.states);

            _ws.states.Add(ws);
            RefreshStateTree();

            ChangeTitle();
        }

        // Old code I dug up
        private WarspiteState checkForDuplicateState(WarspiteState newState, List<WarspiteState> states,
            List<WarspiteState> working = null, int iter = 0)
        {
            bool flag = false;

            if (working == null)
                working = new List<WarspiteState>(states);

            if (_ws.states != null)
            {
                foreach (WarspiteState i in working)
                {
                    if (i.id == newState.id)
                    {
                        // If we have found a duplicate, increment our name by one.
                        newState.id = String.Format(_baseNewState, string.Format("({0})", iter + 1));

                        // increment our counter remove the item checked from the list.
                        iter++;
                        working.Remove(i);
                        flag = true;
                    }

                    if (flag)
                    {
                        // Check again.
                        return checkForDuplicateState(newState, states, working, iter);
                    }
                }
            }
            return newState;
        }

        private void deleteStateBtn_Click(object sender, EventArgs e)
        {
            if (stateViewer.SelectedObject != null)
            {
                WarspiteState delObj = (WarspiteState)stateViewer.SelectedObject;

                if (delObj == null) return;

                stateViewer.SelectedObject = null;
                _ws.states.Remove(delObj);

                deleteStateBtn.Enabled = false;
                RefreshStateTree();

                ChangeTitle();
            }
        }

        private void RefreshStateTree()
        {
            stateView.Nodes.Clear();
            _root = stateView.Nodes.Add(string.Format("States ({0})", _ws.states.Count));

            for (int i = 0; i < _ws.states.Count; i++)
            {
                _root.Nodes.Add(_ws.states[i].id);
            }

            _root.Expand();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                NewEngineJson();
            }

            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                OpenEngineJson();
            }

            if (_state != MainWindowState.StateStartPage || _state != MainWindowState.StateNone)
            {
                if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                {
                    SaveCommand();
                }

                if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control &&
                    e.Modifiers == Keys.Shift)
                {
                    SaveAsCommand();
                }
            }

            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Alt)
            {
                AboutBox ab = new AboutBox();

                ab.ShowDialog();
            }

            if(e.KeyCode == Keys.F5)
            {
                LaunchEngine();
            }

            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.O)
            {
                ConfigWindow cw = new ConfigWindow();
                cw.ShowDialog();
            }
        }

        private void NewtoolButton_Click(object sender, EventArgs e)
        {
            NewEngineJson();
        }

        private void OpentoolButton_Click(object sender, EventArgs e)
        {
            OpenEngineJson();
        }

        private void SavetoolButton_Click(object sender, EventArgs e)
        {
            SaveCommand();
        }

        private void SaveAstoolButton_Click(object sender, EventArgs e)
        {
            SaveAsCommand();
        }

        private void setAssetsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigWindow cw = new ConfigWindow();

            cw.loadedFromApp = true;
            cw.ShowDialog();
        }

        private void launchEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchEngine();
        }

        private void launchEngineToolBtn_Click(object sender, EventArgs e)
        {
            LaunchEngine();
        }

        private WarspiteStateFile _deserialiseStateJSON(string sText)
        {
            WarspiteStateFile file = new WarspiteStateFile();

            JObject wState = JObject.Parse(sText);
            IList<JToken> results = wState["states"].Children().ToList();

            IList<WarspiteState> states = new List<WarspiteState>();
            foreach (JToken result in results)
            {
                WarspiteState wS = new WarspiteState();

                wS.id = result["id"].ToString();
                wS.textures = result["textures"].ToObject<AssetContainer[]>();
                wS.scripts = result["scripts"].ToObject<AssetContainer[]>();

                IList<JToken> objects = result["objects"].Children().ToList();

                List<ObjectContainer> _obj = new List<ObjectContainer>();

                foreach (JToken obj in objects)
                {
                    ObjectContainer cObj = new ObjectContainer();

                    cObj.name = obj["name"].ToString();
                    cObj.type = obj["type"].ToString();
                    cObj.x = int.Parse(obj["x"].ToString());
                    cObj.y = int.Parse(obj["y"].ToString());

                    IList<JToken> properties = obj["properties"].Children().ToList();
                    List<ObjectProperty> pr = new List<ObjectProperty>();

                    foreach (JToken prop in properties)
                    {
                        ObjectProperty objProp = new ObjectProperty();

                        objProp.name = prop["name"].ToString();
                        objProp.type = prop["type"].ToString();
                        objProp.value = prop["value"].ToObject<object>();

                        pr.Add(objProp);
                    }

                    cObj.properties = pr.ToArray();
                    _obj.Add(cObj);
                }

                wS.objects = _obj.ToArray();
                states.Add(wS);
            }

            file.states = states.ToList();

            return file;
        }
    }
}
