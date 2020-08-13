using System;
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
    }
}
