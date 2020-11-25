using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WarspiteGame.AuthoringTools.Debugger.Forms
{
    public partial class MainForm : Form
    {
        private Color _debugColour = Color.FromArgb(51, 150, 221);
        private string _baseTitle = string.Format("Warspite Debugger ({0}/{1})", ToolMetadata.BuildNumber,
                                                    ToolMetadata.HeadDesc);
        private const string _drawOnTop = "Draw Ontop ({0})";
        
        private OpenFileDialog _ofd;
        private SaveFileDialog _sfd;

        Process _p;
        StreamWriter _sw;

        private void UpdateMenuStrip()
        {
            drawOnTopButton.Text = TopMost ? string.Format(_drawOnTop, "Enabled") : string.Format(_drawOnTop, "Disabled");

            saveOutputToolStripMenuItem.Enabled = stdOutput.TextLength > 0;
            SaveLogButton.Enabled = stdOutput.TextLength > 0;
        }

        private void OpenExecutable()
        {
            if (_ofd.ShowDialog() == DialogResult.OK)
            {
                // Better way to do this, however this needs to be pumped out NOW!
                string args = "";
                StringCollection data = Properties.Settings.Default.LaunchArguments;

                for (int i = 0; i < data.Count; i++)
                {
                    args += data[i];
                    if (i < data.Count - 1) args += " ";
                }

                _p.StartInfo.FileName = _ofd.FileName;
                _p.StartInfo.Arguments = args;
                _p.StartInfo.WorkingDirectory = new FileInfo(_ofd.FileName).Directory.FullName;

                stdOutput.Clear();

                _p.Start();

                _p.BeginOutputReadLine();
                _p.BeginErrorReadLine();

                _sw = _p.StandardInput;

                killProcessButton.Enabled = true;
                openToolStripMenuItem.Enabled = false;
                OpenToolButton.Enabled = false;
                stdinPanel.Enabled = true;

                UpdateMenuStrip();
            }
        }

        private void SaveLog()
        {
            if (_sfd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(_sfd.FileName);

                if (fi.Extension == ".rtf")
                {
                    stdOutput.SaveFile(_sfd.FileName);
                }
                else
                {
                    File.WriteAllText(_sfd.FileName, stdOutput.Text);
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            TopMost = Properties.Settings.Default.DrawOnTop;
            UpdateMenuStrip();

            _ofd = new OpenFileDialog();

            _ofd.FileName = "";
            _ofd.Title = "Open";
            _ofd.Filter = "Executable Files|*.exe|All Files |*.*";

            _sfd = new SaveFileDialog();

            _sfd.FileName = "";
            _sfd.Title = "Save";
            _sfd.Filter = "Rich Text files|*.rtf|Text files|*.txt|All Files |*.*";

            _p = new Process();

            _p.StartInfo.UseShellExecute = false;
            _p.StartInfo.CreateNoWindow = true;
            _p.StartInfo.RedirectStandardOutput = true;
            _p.StartInfo.RedirectStandardError = true;
            _p.StartInfo.RedirectStandardInput = true;
            _p.EnableRaisingEvents = true;
            _p.Exited += ProcessExited;

            _p.OutputDataReceived += RedirOutput;
            _p.ErrorDataReceived += RedirError;   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = _baseTitle;
            stdOutput.BackColor = Color.Black;
            UpdateMenuStrip();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExecutable();
        }

        private void stdinBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StdinInput(stdinBox.Text);
            }
        }

        private void stdinEnter_Click(object sender, EventArgs e)
        {
            StdinInput(stdinBox.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_p.IsRunning())
            {
                e.Cancel = true;
                ExitPrompt();
            }

            Properties.Settings.Default.DrawOnTop = TopMost;
            Properties.Settings.Default.Save();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitPrompt();
        }

        private void RedirOutput(object sender, DataReceivedEventArgs args)
        {
            if (stdOutput.InvokeRequired && args.Data != null)
            {
                stdOutput.Invoke(new MethodInvoker(delegate {

                    if (args.Data.Contains("[engine/debug]")) stdOutput.AppendText(args.Data, _debugColour);
                    else if (args.Data.Contains("[engine/warn]")) stdOutput.AppendText(args.Data, Color.Yellow);
                    else if (args.Data.Contains("[engine/error]")) stdOutput.AppendText(args.Data, Color.Red);
                    else stdOutput.AppendText(args.Data, Color.White);

                    stdOutput.AppendText(Environment.NewLine);
                    stdOutput.ScrollToCaret();
                }));
            }
        }

        private void RedirError(object sender, DataReceivedEventArgs args)
        {
            if (stdOutput.InvokeRequired && args.Data != null)
            {
                stdOutput.Invoke(new MethodInvoker(delegate {
                    stdOutput.AppendText(args.Data, Color.Red);
                    stdOutput.AppendText(Environment.NewLine);
                    stdOutput.Select(stdOutput.TextLength - 1, 0);
                    stdOutput.ScrollToCaret();
                }));
            }
        }

        private void StdinInput(string input)
        {
            if (_sw != null)
            {
                _sw.WriteLine(input);
            }
            stdinBox.Text = "";
        }

        private void ProcessExited(object sender, EventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { 
                    openToolStripMenuItem.Enabled = true;
                    OpenToolButton.Enabled = true;
                    stdinPanel.Enabled = false; 
                    killProcessButton.Enabled = false;
                }));
                _p.CancelOutputRead();
                _p.CancelErrorRead();
            }
        }

        private void ExitPrompt()
        {
            if (!_p.IsRunning()) Environment.Exit(0);

            DialogResult dr = MessageBox.Show(string.Format("Process \"{0}\" is still running! Kill it?",
                Path.GetFileName(_ofd.FileName)),
            AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.Yes:
                    if (!_p.HasExited)
                    {
                        _p.Kill();
                        _p.CancelOutputRead();
                        _p.CancelErrorRead();
                    }
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();

            ab.ShowDialog();
        }

        private void drawOntopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            UpdateMenuStrip();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                OpenExecutable();
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                SaveLog();
            }

            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                AboutBox ab = new AboutBox();

                ab.ShowDialog();
            }
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLog();
        }

        private void mainStrip_Click(object sender, EventArgs e)
        {
            UpdateMenuStrip();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options o = new Options();

            o.TopMost = true;
            o.ShowDialog();
        }

        private void drawOnTopButton_Click(object sender, EventArgs e)
        {
            if (TopMost)
                TopMost = false;
            else if (!TopMost)
                TopMost = true;

            UpdateMenuStrip();
        }

        private void killProcessButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Process \"{0}\" is still running! Kill it?",
                                              Path.GetFileName(_ofd.FileName)), AssemblyAccessors.AssemblyTitle, 
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    if (!_p.HasExited)
                        _p.Kill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void OpenToolButton_Click(object sender, EventArgs e)
        {
            OpenExecutable();
        }

        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            SaveLog();
        }
    }
}
