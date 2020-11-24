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
    public class ObjectContainerEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            ObjectContainer[] objects = value as ObjectContainer[];

            ObjectContainerEditorForm ocef = new ObjectContainerEditorForm();
            ocef.CurrentObject = objects.ToList();

            if (svc != null && objects != null)
            {
                if (svc.ShowDialog(ocef) == DialogResult.OK)
                {
                    return ocef.CurrentObject.ToArray();
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}
