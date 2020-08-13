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

    public static class EnumTools
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues((typeof(T))).Cast<T>();
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
