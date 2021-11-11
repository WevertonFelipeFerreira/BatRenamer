using System.IO;

namespace BatRenamer.Entities
{
    public class NameInfo
    {
        public string OriginalName { get; private set; }
        public string ToRename { get; private set; }

        public NameInfo(string originalName, string toRename)
        {
            OriginalName = originalName;
            ToRename = toRename;
        }
        public string GetLine() 
        {
            return $"ren {OriginalName} {ToRename}";
        }
    }

}
