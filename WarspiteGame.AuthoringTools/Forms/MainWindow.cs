using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools
{
    public partial class MainWindow : Form
    {
        TreeNode root;
        WarspiteStateFile ws;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Open a Warspite JSON...";
            op.FileName = "";
            op.Filter = "JSON File|*.json|All Files |*.*";

            DialogResult res = op.ShowDialog();

            if (res == DialogResult.OK && op.FileName != String.Empty)
            {
                string sText = File.ReadAllText(op.FileName);
                ws = JsonConvert.DeserializeObject<WarspiteStateFile>(sText);

                treeView1.Nodes.Clear();
                root = treeView1.Nodes.Add("States");

                for (int i = 0; i < ws.States.Length; i++)
                {
                    root.Nodes.Add(ws.States[i].ID);
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != root)
            {
                propertyGrid1.SelectedObject = ws.States[e.Node.Index];
            }
        }
    }
}
