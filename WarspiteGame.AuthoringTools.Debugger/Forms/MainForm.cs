using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarspiteGame.AuthoringTools.Debugger.Forms
{
    public partial class MainForm : Form
    {
        private string _baseTitle = String.Format("Warspite Debugger ({0}/{1})", ToolMetadata.BuildNumber,
                                                    ToolMetadata.HeadDesc);
        private OpenFileDialog _ofd;

        Process _p;
        StreamWriter _sw;

        public MainForm()
        {
            InitializeComponent();

            _ofd = new OpenFileDialog();

            _ofd.FileName = "";
            _ofd.Title = "Open";
            _ofd.Filter = "Executables|*.exe|All Files |*.*";

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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_ofd.ShowDialog() == DialogResult.OK)
            {
                _p.StartInfo.FileName = _ofd.FileName;

                richTextBox1.Clear();

                _p.Start();

                _p.BeginOutputReadLine();
                _p.BeginErrorReadLine();

                _p.StartInfo.WorkingDirectory = new FileInfo(_ofd.FileName).Directory.FullName;
                _sw = _p.StandardInput;

                killProcessToolStripMenuItem.Visible = true;
                openToolStripMenuItem.Enabled = false;
                stdinPanel.Enabled = true;
            }
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
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(String.Format("Process \"{0}\" is still running! Kill it?",
                    Path.GetFileName(_ofd.FileName)),
                AssemblyAccessors.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitPrompt();
        }

        private void RedirOutput(object sender, DataReceivedEventArgs args)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate {
                    richTextBox1.ForeColor = Color.White;
                    richTextBox1.Text += args.Data; 
                    richTextBox1.Text += Environment.NewLine; 
                }));
            }
        }

        private void RedirError(object sender, DataReceivedEventArgs args)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate {
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.Text += args.Data; 
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }));
            }
        }

        private void StdinInput(string input)
        {
            if (_sw != null)
            {
                _sw.WriteLine(input);
            }
        }

        private void ProcessExited(object sender, EventArgs args)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { 
                    openToolStripMenuItem.Enabled = true; 
                    stdinPanel.Enabled = false; 
                    killProcessToolStripMenuItem.Visible = false;
                }));
                _p.CancelOutputRead();
                _p.CancelErrorRead();
            }
        }

        private void ExitPrompt()
        {
            DialogResult dr = MessageBox.Show(String.Format("Process \"{0}\" is still running! Kill it?",
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
    }
}
