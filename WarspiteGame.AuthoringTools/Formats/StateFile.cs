using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using WarspiteGame.AuthoringTools.Converters;
using WarspiteGame.AuthoringTools.Forms.Editors;

namespace WarspiteGame.AuthoringTools.Formats
{
    [JsonConverter(typeof(NoTypeConverterJsonConverter<WarspiteStateFile>))]
    public class WarspiteStateFile
    {
        public WarspiteStateFile()
        {

        }

        public WarspiteStateFile(WarspiteStateFile wsf)
        {
            states = wsf.states;
            type = wsf.type;
        }

        [Browsable(false)]
        public List<WarspiteState> states { get; set; } = new List<WarspiteState>();

        [Browsable(false)] 
        public string type { get; set; } = "StateFile";

        public override bool Equals(object obj)
        {
            var o = obj as WarspiteStateFile;

            if (o == null)
                return false;

            if (!states.SequenceEqual(o.states))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return states.GetHashCode() * type.GetHashCode() * 21;
        }
    }

    public class WarspiteState
    {
        [Category("State Metadata")]
        [DisplayName("Identifier")]
        [Description("The identifier used to load the state.")]
        public string id { get; set; }

        [Category("State Data")]
        [DisplayName("Textures")]
        [Description("A list of textures that will be loaded when the Engine loads the state.")]
        [TypeConverter(typeof(AssetContainerArrayTypeConverter))]
        public AssetContainer[] textures { get; set; } = { };

        [Category("State Data")]
        [DisplayName("Scripts")]
        [Description("A list of scripts that will be loaded when the Engine loads the state.")]
        [TypeConverter(typeof(AssetContainerArrayTypeConverter))]
        public AssetContainer[] scripts { get; set; } = { };

        [Category("State Data")]
        [DisplayName("Objects")]
        [Description("A list of objects that will be created when the Engine loads the state.")]
        [TypeConverter(typeof(ObjectContainerArrayTypeConverter))]
        [Editor(typeof(ObjectContainerEditor), typeof(UITypeEditor))]
        public ObjectContainer[] objects { get; set; } = { };

        public override bool Equals(object obj)
        {
            var o = obj as WarspiteState;

            if (o == null)
                return false;

            if (id != o.id || !textures.SequenceEqual(o.textures) || !scripts.SequenceEqual(o.scripts) || !objects.SequenceEqual(o.objects))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode() * textures.GetHashCode() * scripts.GetHashCode() * objects.GetHashCode() * 21;
        }
    }

    [TypeConverter(typeof(AssetContainerTypeConverter))]
    [JsonConverter(typeof(NoTypeConverterJsonConverter<AssetContainer>))]
    public class AssetContainer
    {
        [Category("Asset Information")]
        [DisplayName("Identifier")]
        [Description("The identifier used to reference the asset within the state.")]
        public string id { get; set; } = "";

        [Category("Asset Information")]
        [DisplayName("Path")]
        [Description("The path to load the asset - relative to the folder of the type of asset. (e.g. Textures will be loaded from \"assets/textures\")")]
        [Editor(typeof(Editors.AssetPathEditor), typeof(UITypeEditor))]
        public string path { get; set; } = "";

        public override bool Equals(object obj)
        {
            var o = obj as AssetContainer;

            if (o == null)
                return false;

            if (id != o.id || path != o.path)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode() * path.GetHashCode() * 21;
        }
    }

    [TypeConverter(typeof(ObjectPropertyTypeConverter))]
    [JsonConverter(typeof(NoTypeConverterJsonConverter<ObjectContainer>))]
    public class ObjectContainer
    {
        [Category("Object Information")]
        [DisplayName("Name")]
        [Description("The name of this instance of the object that will be created.")]
        public string name { get; set; } = "";

        [Category("Object Information")]
        [DisplayName("Type")]
        [Description("The type of the object that will be created.")]
        public string type { get; set; } = "";

        [Category("Object Position")]
        [DisplayName("X")]
        [Description("The X position of the object on the screen.")]
        public int x { get; set; } = 0;

        [Category("Object Position")]
        [DisplayName("Y")]
        [Description("The Y position of the object on the screen.")]
        public int y { get; set; } = 0;

        [Category("Object Information")]
        [DisplayName("Custom Properties")]
        [Description("Custom properties that define the behaviour of the object")]
        [TypeConverter(typeof(ObjectPropertyArrayTypeConverter))]
        [Editor(typeof(ObjectPropertyEditor), typeof(UITypeEditor))]
        public ObjectProperty[] properties { get; set; }

        public override bool Equals(object obj)
        {
            var o = obj as ObjectContainer;

            if (o == null)
                return false;

            if (name != o.name || type != o.type || x != o.x || y != o.y)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() * type.GetHashCode()
                   * x.GetHashCode() * y.GetHashCode() *  21;
        }
    }

    [TypeConverter(typeof(ObjectPropertyTypeConverter))]
    [JsonConverter(typeof(NoTypeConverterJsonConverter<ObjectProperty>))]
    public class ObjectProperty
    {
        [Category("Custom Properties")]
        [DisplayName("Name")]
        [Description("The name of the property")]
        public string name { get; set; } = "";

        [Category("Custom Properties")]
        [DisplayName("Type")]
        [Description("The type of the property")]
        public string type { get; set; } = "";

        [Category("Custom Properties")]
        [DisplayName("Value")]
        [Description("The value of the property")]
        [Browsable(false)]
        public object value { get; set; }
    }

    #region Type Converters
    public class AssetContainerTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is AssetContainer && destinationType == typeof(string))
            {
                return ((AssetContainer)value).id == "" ? "(Unnamed)" : ((AssetContainer)value).id;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string s = value.ToString();
                //s = s.Replace("\\", "");
                AssetContainer f = JsonConvert.DeserializeObject<AssetContainer>(s);
                return f;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }

    public class AssetContainerArrayTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is AssetContainer[] && destinationType == typeof(string))
            {
                AssetContainer[] data = (AssetContainer[])value;

                return (data.Length <= 0 ) ? "No assets defined" : string.Format("Assets defined: {0}", ((AssetContainer[])value).Length);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class ObjectPropertyTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is ObjectProperty && destinationType == typeof(string))
            {
                return string.Format("{0} ({1})", ((ObjectProperty)value).name, ((ObjectProperty)value).type);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string s = value.ToString();
                //s = s.Replace("\\", "");
                ObjectProperty f = JsonConvert.DeserializeObject<ObjectProperty>(s);
                return f;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }

    public class ObjectContainerArrayTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is ObjectContainer[] && destinationType == typeof(string))
            {
                ObjectContainer[] data = (ObjectContainer[])value;

                return (data.Length <= 0) ? "No objects defined" : string.Format("Objects defined: {0}", ((ObjectContainer[])value).Length);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class ObjectPropertyArrayTypeConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is ObjectProperty[] && destinationType == typeof(string))
            {
                ObjectProperty[] data = (ObjectProperty[])value;

                return (data.Length <= 0) ? "No properties defined" : string.Format("Properties defined: {0}", ((ObjectProperty[])value).Length);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
    #endregion
}
