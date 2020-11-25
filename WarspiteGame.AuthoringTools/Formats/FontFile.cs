using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;

namespace WarspiteGame.AuthoringTools.Formats
{
    public class FontFile
    {
        [Category("Font Metadata")]
        [DisplayName("Base font name")]
        [Description("The family of the font name (e.g. Roboto)")]
        public string name { get; set; } = "";

        [Category("Font Metadata")]
        [DisplayName("Font types")]
        [Description(
            "Informs the Engine of the different types of the font is available. In format \"baseName-Variation\"")]
        [TypeConverter(typeof(FontVariationsArrayTypeConverter))]
        public string[] types { get; set; } = { };

        [Browsable(false)] 
        public string type { get; set; } = "FontFile";

        public override bool Equals(object obj)
        {
            var o = obj as FontFile;

            if (o == null)
                return false;

            if (name != o.name || !types.SequenceEqual(o.types))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() * types.GetHashCode() * type.GetHashCode() * 21;
        }
    }

    public class FontVariationsArrayTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is string[] && destinationType == typeof(string))
            {
                string[] data = (string[])value;

                string desc = "";

                for (int i = 0; i < data.Length; i++)
                {
                    desc += data[i];
                    if (i < data.Length - 1) desc += ", ";
                }

                return (data.Length <= 0) ? "No variations defined" : string.Format(desc);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
