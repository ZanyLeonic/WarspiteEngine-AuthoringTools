using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
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
            _op.Title = "Open a Warspite JSON...";
            _op.FileName = "";
            _op.Filter = "JSON File|*.json|All Files |*.*";

            DialogResult res = _op.ShowDialog();

            if (res == DialogResult.OK && _op.FileName != String.Empty)
            {
                string sText = File.ReadAllText(_op.FileName);
                _ws = JsonConvert.DeserializeObject<WarspiteStateFile>(sText);

                stateView.Nodes.Clear();
                _root = stateView.Nodes.Add("States");

                for (int i = 0; i < _ws.States.Length; i++)
                {
                    _root.Nodes.Add(_ws.States[i].ID);
                }
            }
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
    }
}
