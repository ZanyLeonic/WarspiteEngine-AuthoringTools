using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools.Debugger;
using WarspiteGame.AuthoringTools.Debugger.Properties;

namespace WarspiteGame.AuthoringTools.Debugger.Forms
{
    partial class AboutBox : Form
    {
        private List<Bitmap> _aboutBitmaps = new List<Bitmap>();

        public AboutBox()
        {
            InitializeComponent();

            var res = new ResourceManager(typeof(AboutBox));

            _aboutBitmaps.Add((Bitmap)res.GetObject("logoPictureBox.Image"));
            _aboutBitmaps.Add(new Bitmap(Resources.logoPictureBox_Image_one));
            _aboutBitmaps.Add(new Bitmap(Resources.logoPictureBox_Image_two));

            DateTimeOffset dTO = DateTimeOffset.FromUnixTimeSeconds((long)ToolMetadata.BuildTime);

            this.Text = String.Format("About {0}", AssemblyAccessors.AssemblyTitle);
            this.labelProductName.Text = AssemblyAccessors.AssemblyTitle;
            this.labelVersion.Text = String.Format("Version {0} ({1}/{2})", AssemblyAccessors.AssemblyVersion, ToolMetadata.BuildNumber, ToolMetadata.HeadDesc);
            this.labelCopyright.Text = AssemblyAccessors.AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyAccessors.AssemblyCompany;
            this.textBoxDescription.Text = String.Format("{0}{3}{3}Build date:{3}{1}{3}Commit:{3}{2}{3}{3}Made in C# in a day lol.",
                AssemblyAccessors.AssemblyDescription, dTO.ToString(), ToolMetadata.HeadSha1, Environment.NewLine);

            Random rn = new Random();

            this.logoPictureBox.Image = _aboutBitmaps[rn.Next(0, 3)];
        }

        #region Assembly Attribute Accessors

        
        #endregion
    }
}
