using System;
using System.CodeDom;
using System.ComponentModel;

namespace WarspiteGame.AuthoringTools.Formats
{
    public class FontFile
    {
        [Category("Font Metadata")]
        [DisplayName("Font name")]
        [Description("The base identifier the Engine will use to load the font with.")]
        public string name { get; set; }

        [Category("Font Metadata")]
        [DisplayName("Font types")]
        [Description("Informs the Engine of the different types of the font is available. In format \"fontName-TypeName\"")]
        public string[] types { get; set; }

        [Browsable(false)]
        public string type { get; set; }

        public static bool operator ==(FontFile f1, FontFile f2)
        {
            return (f1.name == f2.name) && (f1.types == f2.types) && (f1.type == f2.type);
        }

        public static bool operator !=(FontFile f1, FontFile f2)
        {
            return (f1.name != f2.name) && (f1.types != f2.types) && (f1.type != f2.type);
        }
    }
}
