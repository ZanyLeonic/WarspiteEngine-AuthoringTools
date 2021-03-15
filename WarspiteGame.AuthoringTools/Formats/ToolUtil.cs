using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarspiteGame.AuthoringTools.Formats
{
    public enum MainWindowState
    {
        StateNone      = -1,
        StateStartPage =  0,
        StateStatePage =  1,
        StateFontPage  =  2
    }

    public enum EngineJsonType
    {
        None  = 0,
        State = 1,
        Font  = 2
    }

    public enum PropertyType
    {
        String = 0,
        Object = 1,
        Int = 2,
        File = 3,
        Float = 4,
        Color = 5,
        Bool = 6
    }

    public static class EnumTools
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues((typeof(T))).Cast<T>();
        }

        public static PropertyType GetPropEnum(string value)
        {
            switch(value)
            {
                case "string":
                    return PropertyType.String;
                case "object":
                    return PropertyType.Object;
                case "int":
                    return PropertyType.Int;
                case "file":
                    return PropertyType.File;
                case "float":
                    return PropertyType.Float;
                case "color":
                    return PropertyType.Color;
                case "bool":
                    return PropertyType.Bool;
                default:
                    return PropertyType.String;
            }
        }

        public static string GetEnumProp(PropertyType value)
        {
            switch (value)
            {
                case PropertyType.String:
                    return "string";
                case PropertyType.Object:
                    return "object";
                case PropertyType.Int:
                    return "int";
                case PropertyType.File:
                    return "file";
                case PropertyType.Float:
                    return "float";
                case PropertyType.Color:
                    return "color";
                case PropertyType.Bool:
                    return "bool";
                default:
                    return "string";
            }
        }
    }

    public static class ToolUtil
    {
        public static string GetWorkingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        }
    }
}