using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms
{
    public partial class NewFileSelector : Form
    {
        public EngineJsonType ChosenType { get; set; }

        public NewFileSelector()
        {
            InitializeComponent();
        }

        private void NewFileSelector_Load(object sender, EventArgs e)
        {
            TypeSelector.Items.Clear();

            var types = EnumTools.GetValues<EngineJsonType>();

            foreach (var i in types)
            {
                if (i != EngineJsonType.None)
                    TypeSelector.Items.Add(i.ToString());
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (TypeSelector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type", AssemblyAccessors.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChosenType = (EngineJsonType)TypeSelector.SelectedIndex + 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NewFileSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TypeSelector.SelectedIndex == -1) DialogResult = DialogResult.Cancel;
        }

        private void TypeSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChosenType = (EngineJsonType)TypeSelector.SelectedIndex + 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
