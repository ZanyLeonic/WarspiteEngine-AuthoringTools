using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using WarspiteGame.AuthoringTools.Forms.Editors;

namespace WarspiteGame.AuthoringTools.Formats
{
    public class DialogueFile
    {
        [Category("Dialogue Metadata")]
        [DisplayName("ID")]
        [Description("The unique identifier of the dialogue file")]
        public string id { get; set; } = "";

        [Category("Dialogue Data")]
        [DisplayName("Start Node")]
        [Description("The speech node the dialogue starts when intiated")]
        public int startnode { get; set; } = 0;

        [Category("Dialogue Data")]
        [DisplayName("Nodes")]
        [Description("The speech nodes contained within the dialogue")]
        [TypeConverter(typeof(SpeechNodesArrayTypeConverter))]
        [Editor(typeof(DialogueEditor), typeof(UITypeEditor))]
        public SpeechNode[] nodes { get; set; } = new List<SpeechNode>().ToArray();

        [Category("Dialogue Data")]
        [DisplayName("Variables")]
        [Description("The variable names and types stored within the dialouge to keep track of events inside the dialogue tree.")]
        [TypeConverter(typeof(ObjectPropertyArrayTypeConverter))]
        [Editor(typeof(ObjectPropertyEditor), typeof(UITypeEditor))]
        public ObjectProperty[] variables { get; set; } = new List<ObjectProperty>().ToArray();

        [Browsable(false)]
        public string type { get; set; } = "Dialogue";
    }

    public class SpeechNode
    {
        [Category("Dialogue Data")]
        [DisplayName("Text")]
        [Description("The text for node.")]
        public string text { get; set; } = "";

        [Category("Dialogue Data")]
        [DisplayName("Type")]
        [Description("The type of the node")]
        public string type { get; set; } = "speech";

        [Category("Dialogue Data")]
        [DisplayName("Next node")]
        [Description("The next node")]
        public int nextnode { get; set; } = -1;
    }

    public class SpeechNodesArrayTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is SpeechNode[] && destinationType == typeof(string))
            {
                SpeechNode[] data = (SpeechNode[])value;

                return (data.Length <= 0) ? "No nodes defined" : string.Format("Nodes defined ({0})", data.Length.ToString());
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}