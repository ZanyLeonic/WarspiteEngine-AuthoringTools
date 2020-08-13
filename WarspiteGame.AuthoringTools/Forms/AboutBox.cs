using System;
using System.Reflection;
using System.Windows.Forms;
using WarspiteGame.AuthoringTools;

namespace WarspiteGame.AuthoringTools.Forms
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            DateTimeOffset dTO = DateTimeOffset.FromUnixTimeSeconds((long)ToolMetadata.BuildTime);

            this.Text = String.Format("About {0}", AssemblyAccessors.AssemblyTitle);
            this.labelProductName.Text = AssemblyAccessors.AssemblyTitle;
            this.labelVersion.Text = String.Format("Version {0} ({1}/{2})", AssemblyAccessors.AssemblyVersion, ToolMetadata.BuildNumber, ToolMetadata.HeadDesc);
            this.labelCopyright.Text = AssemblyAccessors.AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyAccessors.AssemblyCompany;
            this.textBoxDescription.Text = String.Format("{0}"+ Environment.NewLine + Environment.NewLine + "Build date: {1}" + Environment.NewLine + "Commit: {2}",
                AssemblyAccessors.AssemblyDescription, dTO.ToString(), ToolMetadata.HeadSha1);
        }

        #region Assembly Attribute Accessors

        
        #endregion
    }
}
