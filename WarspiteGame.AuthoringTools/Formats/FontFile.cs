using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

        public override bool Equals(object obj)
        {
            var o = obj as FontFile;

            if (o == null)
                return false;

            if (name != o.name || !types.SequenceEqual(o.types))
                return false;

            return true;
        }
    }
}
