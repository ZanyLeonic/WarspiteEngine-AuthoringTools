using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WarspiteGame.AuthoringTools.Formats.Editors
{
    public class AssetPathEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            string path = value as string;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open...";
            ofd.InitialDirectory = Properties.Settings.Default.AssetsPath;
            ofd.FileName = "";

            if (svc != null && path != null)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Create a relative path to the asset chosen
                    Uri nPath = new Uri(ofd.FileName);
                    Uri baseFolder = new Uri(Properties.Settings.Default.AssetsPath);
                    Uri relPath = baseFolder.MakeRelativeUri(nPath);

                    string[] sPath = relPath.ToString().Split('/');
                    string nrelPath = "";

                    for (int i = 2; i < sPath.Length; i++)
                    {
                        nrelPath += sPath[i];
                    }
                   
                    return Uri.UnescapeDataString(nrelPath);
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}
