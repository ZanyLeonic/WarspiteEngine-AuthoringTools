using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarspiteGame.AuthoringTools.Debugger.Forms
{
    public partial class Options : Form
    {
        private PropertiesWrapper _pw = new PropertiesWrapper();

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            _pw.Load();
            OptionsEditor.SelectedObject = _pw;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            _pw.Save();
        }
    }
}
