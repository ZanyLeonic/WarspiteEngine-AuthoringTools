using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Text;

namespace WarspiteGame.AuthoringTools.Debugger
{
    public class PropertiesWrapper
    {
        [Category("Configuration")]
        [DisplayName("Draw on top")]
        [Description("Whether the main window should draw on top of other windows.")]
        public bool DrawOnTop { get; set; }

        [Category("Configuration")]
        [DisplayName("Launch arguments")]
        [Description("The parameters the debugger should use when launching the program.")]
        [TypeConverter(typeof(StringCollectionTypeConverter))]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public StringCollection LaunchArguments { get; set; }

        public void Load()
        {
            Properties.Settings.Default.Reload();

            DrawOnTop = Properties.Settings.Default.DrawOnTop;
            LaunchArguments = Properties.Settings.Default.LaunchArguments;
        }

        public void Save()
        {
            Properties.Settings.Default.DrawOnTop = DrawOnTop;
            Properties.Settings.Default.LaunchArguments = LaunchArguments;

            Properties.Settings.Default.Save();
        }
    }

    public class StringCollectionTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is StringCollection && destinationType == typeof(string))
            {
                StringCollection data = (StringCollection)value;

                string desc = "";

                for (int i = 0; i < data.Count; i++)
                {
                    desc += data[i];
                    if (i < data.Count - 1) desc += ", ";
                }

                return (data.Count <= 0) ? "No launch arguments specified" : string.Format(desc);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
