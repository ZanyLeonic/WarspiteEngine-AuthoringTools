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
        StateNone          = -1,
        StateStartPage     =  0,
        StateStatePage     =  1,
        StateFontPage      =  2,
        StateDialoguePage  =  3
    }

    public enum EngineJsonType
    {
        None  = 0,
        State = 1,
        Font  = 2,
        Dialogue = 3
    }

    public enum SpeechNodeType
    {
        None = 0,
        Speech = 1,
        End = 2
    }

    public enum EditorType
    {
        None = 0,
        Objects = 1,
        Nodes = 2
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

        public static SpeechNodeType GetNodeEnum(string value)
        {
            switch (value)
            {
                case "speech":
                    return SpeechNodeType.Speech;
                case "end":
                    return SpeechNodeType.End;
                default:
                    return SpeechNodeType.None;
            }
        }

        public static string GetEnumNode(SpeechNodeType value)
        {
            switch (value)
            {
                case SpeechNodeType.Speech:
                    return "speech";
                case SpeechNodeType.End:
                    return "end";
                default:
                    return "none";
            }
        }
    }

    public static class ToolUtil
    {
        public static string GetWorkingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        }

        public static T[] ShiftElement<T>(this T[] array, int oldIndex, int newIndex)
        {
            // TODO: Argument validation
            if (oldIndex == newIndex)
            {
                return array; // No-op
            }
            T tmp = array[oldIndex];
            if (newIndex < oldIndex)
            {
                // Need to move part of the array "up" to make room
                Array.Copy(array, newIndex, array, newIndex + 1, oldIndex - newIndex);
            }
            else
            {
                // Need to move part of the array "down" to fill the gap
                Array.Copy(array, oldIndex + 1, array, oldIndex, newIndex - oldIndex);
            }
            array[newIndex] = tmp;

            return array;
        }
    }
}