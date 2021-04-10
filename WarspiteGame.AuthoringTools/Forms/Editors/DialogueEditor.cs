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
    public class DialogueEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            object objects = value;
            DialogueEditorForm def = new DialogueEditorForm();
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            def.CurrentNodes = ((SpeechNode[])objects).ToList();

            if (svc != null && objects != null)
            {
                if (svc.ShowDialog(def) == DialogResult.OK)
                {
                    return def.CurrentNodes.ToArray();
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}
