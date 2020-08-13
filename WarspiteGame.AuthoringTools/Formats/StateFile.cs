using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarspiteGame.AuthoringTools.Formats
{
    public class WarspiteStateFile
    {
        public WarspiteState[] States { get; set; }
    }

    public class WarspiteState
    {
        public string ID { get; set; }
        public AssetContainer[] Textures { get; set; }
        public AssetContainer[] Scripts { get; set; }

        public ObjectContainer[] Objects { get; set; }
    }

    public class AssetContainer
    {
        public string ID { get; set; }
        public string Path { get; set; }
    }

    public class ObjectContainer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Textureid { get; set; }
        public string Script { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int NumFrames { get; set; }
        public int AnimSpeed { get; set; }

        public int OnClickId { get; set; }
        public int OnEnterId { get; set; }
        public int OnLeaveId { get; set; }
    }
}
