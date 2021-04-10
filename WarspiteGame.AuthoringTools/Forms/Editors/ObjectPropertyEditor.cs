using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WarspiteGame.AuthoringTools.Formats;

namespace WarspiteGame.AuthoringTools.Forms.Editors
{
    public class ObjectPropertyEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            ObjectProperty[] prop = value as ObjectProperty[];

            ObjectPropertyEditorForm opef = new ObjectPropertyEditorForm();
            opef.CurrentProperties = prop.ToList();

            if (svc != null && prop != null)
            {
                if (svc.ShowDialog(opef) == DialogResult.OK)
                {
                    return opef.CurrentProperties.ToArray();
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}
