using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WarspiteGame.AuthoringTools
{
    public partial class MainWindow : Form
    {
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
                WarspiteStateFile ws = JsonConvert.DeserializeObject<WarspiteStateFile>(sText);

                propertyGrid1.SelectedObject = ws;
            }
        }
    }

    public class AssetContainer
    {
        public string id { get; set; }
        public string path { get; set; }
    }

    public class ObjectContainer
    {
        public string name { get; set; }
        public string type { get; set; }
        public string textureid { get; set; }
        public string script { get; set; }

        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public int numFrames { get; set; }
        public int animSpeed { get; set; }

        public int onClickId { get; set; }
        public int onEnterId { get; set; }
        public int onLeaveId { get; set; }
    }

    public class WarspiteState
    {
        public string id { get; set; }
        public AssetContainer[] textures { get; set; }
        public AssetContainer[] scripts { get; set; }

        public ObjectContainer[] objects { get; set; }
    }

    public class WarspiteStateFile
    {
        public WarspiteState[] states { get; set; }
    }
}
