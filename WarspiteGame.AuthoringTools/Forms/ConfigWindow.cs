using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace WarspiteGame.AuthoringTools.Forms
{
    public partial class ConfigWindow : Form
    {
        public bool loadedFromApp = false;

        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog vfbd = new VistaFolderBrowserDialog();
            
            if (System.IO.Directory.Exists(pathBox.Text)) vfbd.SelectedPath = pathBox.Text;

            if (vfbd.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = vfbd.SelectedPath;
            }
        }

        private void ConfigWindow_Load(object sender, EventArgs e)
        {
            quitBtn.Visible = !loadedFromApp;

            pathBox.Text = Properties.Settings.Default.AssetsPath;
            gameBox.Text = Properties.Settings.Default.GameExecutable;
        }

        private void ConfigWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.IO.Directory.Exists(pathBox.Text))
                Properties.Settings.Default.AssetsPath = pathBox.Text;
            else
            {
                MessageBox.Show("Invalid path specified, please check the assets folder path.", "Warspite Authoring Tools", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }

            if (System.IO.File.Exists(gameBox.Text))
                Properties.Settings.Default.GameExecutable = gameBox.Text;
            else
            {
                MessageBox.Show("Invalid path specified, please check the executable path.", "Warspite Authoring Tools", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }

            Properties.Settings.Default.Save();
        }

        private void browseExecutable_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (System.IO.Directory.Exists(gameBox.Text)) ofd.FileName = gameBox.Text; else ofd.FileName = "";
            ofd.Filter = "Executable File|*.exe|All Files|*.*";
            ofd.Title = "Open";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gameBox.Text = ofd.FileName;
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
